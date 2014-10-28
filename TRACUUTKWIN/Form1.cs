using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace TRACUUTKWIN
{
    public partial class Form1 : Form
    {
        System.Timers.Timer pro = new System.Timers.Timer();
        public Form1()
        {
            InitializeComponent();            
            pro.Interval = 3000;
            pro.Enabled = false;
            pro.Stop();
            pro.Elapsed += pro_Elapsed;
            strReportRootPath = File.ReadAllText(Path.Combine(Application.StartupPath, "REPORT_ROOT_PATH.txt"));
        }

        string strReportRootPath = @"E:\PROJECTS\Helpdesk\TraCuuTKWeb\Reports";

        public void pro_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Application.CurrentCulture = Program.CulUS;
            pro.Enabled = false;
            pro.Stop();
            try
            {
                using (t.tDBContext mainDB = new t.tDBContext())
                {
                    DataTable rr = mainDB.SREPORTs.GetList("TOP 50 * ", string.Format("RP_FILEPATH IS NULL"));
                    if (rr == null)
                    {
                        pro.Enabled = true;
                        pro.Start();
                        return;
                    }
                    if (rr.Rows.Count < 1)
                    {
                        pro.Enabled = true;
                        pro.Start();
                        return;
                    }
                    string strExtractor = Path.Combine(Application.StartupPath, "compress.config");
                    foreach (DataRow r in rr.Rows)
                    {
                        string strPass = "";

                        try
                        {
                            using (t.tDBContext dbU = new t.tDBContext(t.st.sqlSTRINGADO_USER))
                            {
                                t.APP_Users u = dbU.APP_Userss.GetObject(string.Format("USER_ID='{0}'", r["RP_USERNAME"]));
                                strPass = clsABC.Decrypt(u.User_Password);
                            }

                            if (string.IsNullOrEmpty(strPass) == true) continue;
                        }
                        catch
                        {
                            continue;
                        }

                        string strReportDir = Path.Combine(strReportRootPath, r["RP_USERNAME"].ToString());
                        if (Directory.Exists(strReportDir) == false) Directory.CreateDirectory(strReportDir);
                        string tmpFileXSL = Path.Combine(Application.StartupPath, "tempExcel2007.xlsx");
                        string strReportFileName = string.Format("TOKHAIMD_{0}.xlsx", r["RP_ID"].ToString());
                        string strReportFileNameRAR = string.Format("TOKHAIMD_{0}.rar", r["RP_ID"].ToString());
                        string strReportFilePath = Path.Combine(strReportDir, strReportFileName);
                        string strReportFilePathRAR = Path.Combine(strReportDir, strReportFileNameRAR);
                        string strDuongDanTuongDoi = string.Format("~/Reports/{0}/{1}", r["RP_USERNAME"].ToString(), strReportFileNameRAR);

                        try
                        {
                            File.Copy(tmpFileXSL, strReportFilePath, true);

                            string[] strQuery = r["RP_QUERY"].ToString().Split(';');
                            DataSet dsTK = t.clsDalORACLE.GetDataSet(strQuery[0]);

                            if (dsTK == null)//ko ra ket qua
                            {
                                throw new Exception("Không tìm thấy tờ khai nào!");
                            }
                            if (dsTK.Tables.Count < 1)//ko ra ket qua
                            {
                                throw new Exception("Không tìm thấy tờ khai nào!");
                            }
                            if (dsTK.Tables[0].Rows.Count < 1)//ko ra ket qua
                            {
                                throw new Exception("Không tìm thấy tờ khai nào!");
                            }

                            DataSet dsHANG = t.clsDalORACLE.GetDataSet(strQuery[1]);

                            object[,] objData = t.clsAll.DataTable2ArrayObjects(dsTK.Tables[0]);

                            Excel.Application objExcel = this.GetExcelApp();
                            objExcel.Visible = false;
                            objExcel.Application.Visible = false;
                            Excel.Workbook wb = default(Excel.Workbook);
                            try
                            {
                                wb = objExcel.Workbooks.Open(strReportFilePath);
                            }
                            catch
                            {
                                throw new Exception(" Excel.Workbook wb = objExcel.Workbooks.Open(strReportFilePath);");
                            }
                            objExcel.Visible = false;
                            Excel.Worksheet wsTOKHAIMD = (Excel.Worksheet)wb.Worksheets[1];
                            wsTOKHAIMD.Range[string.Format("A2:AS{0}", dsTK.Tables[0].Rows.Count + 1)].Value = objData;
                            //603=WE

                            Excel.Worksheet wsHANGMD = (Excel.Worksheet)wb.Worksheets[2];
                            object[,] objDataHANG = t.clsAll.DataTable2ArrayObjects(dsHANG.Tables[0]);
                            wsHANGMD.Range[string.Format("A2:AE{0}", dsHANG.Tables[0].Rows.Count + 1)].Value = objDataHANG;

                            objExcel.Visible = false;
                            // objExcel.SaveWorkspace(Missing.Value);

                            try
                            {
                                objExcel.Save(strReportFilePath + "x");//để nó khỏi hỏi có lưu hay không lưu
                            }
                            catch { }
                            objExcel.Workbooks.Close();
                            objExcel.Quit();
                            //t.SREPORT a = new t.SREPORT();a.RP_EXPORTDATE
                            r["RP_STATUS"] = "Thành công";
                            r["RP_FILEPATH"] = strDuongDanTuongDoi;
                            r["RP_FILENAME"] = strReportFileNameRAR;
                            r["RP_EXPORTDATE"] = DateTime.Now;

                            //nen du lieu 
                            string strZIP = string.Format("{0} a -p{3} -o+ -ep \"{1}\" \"{2}\"", strExtractor, strReportFilePathRAR, strReportFilePath, strPass);
                            Interaction.Shell(strZIP, AppWinStyle.Hide, true, 100000);

                            try
                            {
                                File.Delete(strReportFilePath + "x");
                            }
                            catch { }
                            try
                            {
                                File.Delete(strReportFilePath);
                            }
                            catch { }

                            t.SREPORT objUpdate = new t.SREPORT();
                            t.clsAll.DataRow2Object(r, objUpdate);
                            objUpdate.DataStatus = t.DBStatus.Updated;
                            mainDB.SREPORTs.UpdateOnSubmit(objUpdate);
                            mainDB.SubmitAllChange();
                        }
                        catch (Exception ex)
                        {
                            string s = ex.Message;
                            r["RP_STATUS"] = "Có lỗi";
                            string strErrorFileName = string.Format("ERROR_{0}.txt", r["RP_ID"]);
                            string strErrorVirtualPath = string.Format("~/Reports/{0}/{1}", r["RP_USERNAME"], strErrorFileName);
                            string strErrorFilePath = Path.Combine(strReportDir, strErrorFileName);
                            r["RP_FILEPATH"] = strErrorVirtualPath;
                            r["RP_FILENAME"] = strErrorFileName;
                            r["RP_EXPORTDATE"] = DateTime.Now;
                            if (Directory.Exists(strReportDir) == false) Directory.CreateDirectory(strReportDir);
                            File.WriteAllText(strErrorFilePath, s, Encoding.UTF8);
                            t.SREPORT objUpdate = new t.SREPORT();
                            t.clsAll.DataRow2Object(r, objUpdate);
                            objUpdate.DataStatus = t.DBStatus.Updated;
                            mainDB.SREPORTs.UpdateOnSubmit(objUpdate);
                            mainDB.SubmitAllChange();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
            pro.Enabled = true;
            pro.Start();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "ĐANG XỬ LÝ";
            button1.Enabled = false;
            pro.Enabled = true;
            pro.Start();
        }

        public void StopTimer()
        {
            pro.Enabled = false;
            pro.Stop();
        }

        public Excel.Application GetExcelApp()
        {
            Excel.Application objExcel = null;

            try
            {
                //Tìm instance Excel đang chạy.
                objExcel = (Excel.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application");
            }
            catch
            {
                //Không có instance nào của Excel đang chạy.
                try
                {
                    objExcel = new Excel.Application();
                }
                catch
                {
                   
                }
            }

            try
            {
                if (objExcel != null)
                {
                    objExcel.Interactive = false;
                    objExcel.Interactive = true;
                    return objExcel;
                }
            }
            catch
            {
                
            }

            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string s = "SELECT * FROM N501B WHERE N501B_HINME LIKE 'Chất thử chuẩn đoán dùng ch' AND ROWNUM<2";
            DataSet dsTK = t.clsDalORACLE.GetDataSet(textBox1.Text);

            MessageBox.Show(dsTK.Tables[0].Rows.Count.ToString());
        }

        private void NenDuLieu(string strExcelFilePath,DataRow r)
        { 
                //Copy và ghi file trong ngày
                string strExtractor = Path.Combine(Application.StartupPath, "compress.config");
                string strFileName = string.Format("{0}",r["RP_FILEPATH"]);
                string strZIP = string.Format("{0} a -p{3} -o+ -ep \"{1}\" \"{2}\"", strExtractor, strFileName, strExcelFilePath, "abc");
                Interaction.Shell(strZIP, AppWinStyle.Hide, true, 100000);
              
                //File.Delete(strFileName);
                //File.Delete(strExtractor);  
        }
    }
}
