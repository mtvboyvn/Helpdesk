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
            pro.Interval = 9000;
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
                    DataTable rr = mainDB.SREPORTs.GetList("TOP 50 * ", string.Format("RP_FILEPATH IS NULL AND RP_STATUS=N'Đang xử lý'"));
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
                    
                    foreach (DataRow r in rr.Rows)
                    {
                        #region Xử lý mật khẩu, nếu ko có mật khẩu thì bỏ qua không xử lý lệnh này
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
                        #endregion

                        // xu ly don nhiem
                        //XU_LY_LENH_TRA_CUU(r, strPass);

                        //xu ly da nhiem
                        object[] p = new object[2];
                        p[0] = r;
                        p[1] = strPass;
                        BackgroundWorker tThread = new BackgroundWorker();
                        tThread.DoWork += tThread_DoWork;
                        tThread.RunWorkerAsync(p);
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

        void tThread_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] p=e.Argument as object[];
            DataRow r=p[0] as DataRow;
            string strPass=p[1] as string;
            XU_LY_LENH_TRA_CUU(r, strPass);
        }

        private void XU_LY_LENH_TRA_CUU(DataRow r, string strPass)
        {
            #region Cập nhật trạng thái thành "Đang xử lý..."
            using (t.tDBContext mainDB = new t.tDBContext())
            {
                mainDB.SREPORTs.UpdateOnSubmit("RP_STATUS=N'Đang xử lý...'", string.Format("RP_ID={0}", r["RP_ID"]));
                mainDB.SubmitAllChange();
            }
            #endregion

            string strExtractor = Path.Combine(Application.StartupPath, "compress.config");
            #region Khởi tạo đường dẫn
            string strReportDir = Path.Combine(strReportRootPath, r["RP_USERNAME"].ToString());
            if (Directory.Exists(strReportDir) == false) Directory.CreateDirectory(strReportDir);
            string tmpFileXSL = Path.Combine(Application.StartupPath, "tempExcel2007.xlsx");
            string strReportFileName = string.Format("TOKHAIMD_{0}.xlsx", r["RP_ID"].ToString());
            string strReportFileNameRAR = string.Format("TOKHAIMD_{0}.rar", r["RP_ID"].ToString());
            string strReportFilePath = Path.Combine(strReportDir, strReportFileName);
            string strReportFilePathRAR = Path.Combine(strReportDir, strReportFileNameRAR);
            string strDuongDanTuongDoi = string.Format("~/Reports/{0}/{1}", r["RP_USERNAME"].ToString(), strReportFileNameRAR);
            #endregion

            try
            {
                #region Xử lý count trước
                string[] strQuery = r["RP_QUERY"].ToString().Split(';');
                //string[] strSelect_501_502 = strQuery[0].Split(new string[] { "UNION ALL" }, StringSplitOptions.RemoveEmptyEntries);
                //string strQueryCount501 = string.Format("SELECT COUNT(*) {0}", strSelect_501_502[0].Substring(strSelect_501_502[0].IndexOf("FROM")));
                //string strQueryCount502 = string.Format("SELECT COUNT(*) {0}", strSelect_501_502[1].Substring(strSelect_501_502[1].IndexOf("FROM")));
                //DataSet dsCount501 = t.clsDalORACLE.GetDataSet(strQueryCount501);
                //DataSet dsCount502 = t.clsDalORACLE.GetDataSet(strQueryCount502);

                //int intCount1 = 0;
                //if (dsCount501 != null)
                //{
                //    if (dsCount501.Tables.Count > 0)
                //    {
                //        if (dsCount501.Tables[0].Rows.Count > 0)
                //        {
                //            intCount1 = (int)(decimal)dsCount501.Tables[0].Rows[0][0];
                //        }
                //    }

                //}

                //int intCount2 = 0;
                //if (dsCount502 != null)
                //{
                //    if (dsCount502.Tables.Count > 0)
                //    {
                //        if (dsCount502.Tables[0].Rows.Count > 0)
                //        {
                //            intCount2 = (int)(decimal)dsCount502.Tables[0].Rows[0][0];
                //        }
                //    }
                //}

                //if (intCount1 + intCount2 > 3000)
                //{
                //    throw new Exception(string.Format("Tổng số tờ khai tìm thấy là {0} tờ khai, vượt quá số lượng trích xuất cho phép của hệ thống là 3000 tờ khai. Vui lòng bổ sung thêm điều kiện tìm kiếm để giảm số lượng tờ khai xuống.", intCount1 + intCount2));
                //}

                string strQueryCount = string.Format("SELECT COUNT(*) {0}", strQuery[0].Substring(strQuery[0].IndexOf("FROM")));
                DataSet dsCount = t.clsDalORACLE.GetDataSet(strQueryCount);
                int intCount = 0;
                if (dsCount != null)
                {
                    if (dsCount.Tables.Count > 0)
                    {
                        if (dsCount.Tables[0].Rows.Count > 0)
                        {                            
                            try
                            {
                                intCount = Convert.ToInt32(dsCount.Tables[0].Rows[0][0]);
                            }
                            catch
                            {
                                try
                                {
                                    intCount =Convert.ToInt32(Convert.ToDecimal(dsCount.Tables[0].Rows[0][0]));
                                }
                                catch
                                {
                                    intCount =(int)(decimal)dsCount.Tables[0].Rows[0][0];
                                }
                            }
                        }
                    }

                }
                if (intCount > 3000)
                {
                    throw new Exception(string.Format("Tổng số tờ khai tìm thấy là {0} tờ khai, vượt quá số lượng trích xuất cho phép của hệ thống là 3000 tờ khai. Vui lòng bổ sung thêm điều kiện tìm kiếm để giảm số lượng tờ khai xuống.", intCount));
                }
                #endregion

                File.Copy(tmpFileXSL, strReportFilePath, true);

                #region Truy vấn tờ khai
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
                #endregion

                #region Truy vấn hàng
                DataSet dsHANG = t.clsDalORACLE.GetDataSet(strQuery[1]);
                object[,] objData = t.clsAll.DataTable2ArrayObjects(dsTK.Tables[0]);
                #endregion

                #region Khởi tạo excel
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
                #endregion

                #region In ra tờ khai
                Excel.Worksheet wsTOKHAIMD = (Excel.Worksheet)wb.Worksheets[1];
                wsTOKHAIMD.Range[string.Format("A2:AW{0}", dsTK.Tables[0].Rows.Count + 1)].Value = objData;
                //603=WE
                #endregion

                #region ẩn cột tờ khai
                if (r["RP_TOKHAI_SHOW_FIELDS"] != null)
                {
                    string strF = string.Format("{0}", r["RP_TOKHAI_SHOW_FIELDS"]);
                    if (string.IsNullOrEmpty(strF) == false)
                    {
                        foreach (string f in strF.Split(','))
                        {
                            string f1 = f.Trim().Replace(",", "");
                            try
                            {
                                wsTOKHAIMD.get_Range(f1, f1).EntireColumn.Hidden = true;
                            }
                            catch { }
                        }
                    }
                }
                #endregion

                #region In ra dòng hàng
                Excel.Worksheet wsHANGMD = (Excel.Worksheet)wb.Worksheets[2];
                object[,] objDataHANG = t.clsAll.DataTable2ArrayObjects(dsHANG.Tables[0]);
                wsHANGMD.Range[string.Format("A2:AE{0}", dsHANG.Tables[0].Rows.Count + 1)].Value = objDataHANG;
                #endregion

                #region Ẩn cột dòng hàng
                if (r["RP_HANG_SHOW_FIELDS"] != null)
                {
                    string strF = string.Format("{0}", r["RP_HANG_SHOW_FIELDS"]);
                    if (string.IsNullOrEmpty(strF) == false)
                    {
                        foreach (string f in strF.Split(','))
                        {
                            string f1 = f.Trim().Replace(",", "");
                            try
                            {
                                wsHANGMD.get_Range(f1, f1).EntireColumn.Hidden = true;
                            }
                            catch { }
                        }
                    }
                }
                #endregion

                #region Thoát excel
                objExcel.Visible = false;
                // objExcel.SaveWorkspace(Missing.Value);
                try
                {
                    objExcel.Save(strReportFilePath + "x");//để nó khỏi hỏi có lưu hay không lưu
                }
                catch { }
                objExcel.Workbooks.Close();
                objExcel.Quit();
                try
                {
                    objExcel.Application.Quit();
                    objExcel = null;
                }
                catch { }
                #endregion

                #region Cập nhật trạng thái
                //t.SREPORT a = new t.SREPORT();a.RP_EXPORTDATE
                r["RP_STATUS"] = "Thành công";
                r["RP_FILEPATH"] = strDuongDanTuongDoi;
                r["RP_FILENAME"] = strReportFileNameRAR;
                r["RP_EXPORTDATE"] = DateTime.Now;
                #endregion

                #region Nén file excel
                string strZIP = string.Format("{0} a -p{3} -o+ -ep \"{1}\" \"{2}\"", strExtractor, strReportFilePathRAR, strReportFilePath, strPass);
                Interaction.Shell(strZIP, AppWinStyle.Hide, true, 100000);
                #endregion

                #region Xóa dữ liệu tạm
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
                #endregion

                #region Comit data
                t.SREPORT objUpdate = new t.SREPORT();
                t.clsAll.DataRow2Object(r, objUpdate);
                objUpdate.DataStatus = t.DBStatus.Updated;
                using (t.tDBContext mainDB = new t.tDBContext())
                {
                    mainDB.SREPORTs.UpdateOnSubmit(objUpdate);
                    mainDB.SubmitAllChange();
                }
                #endregion
            }
            catch (Exception ex)
            {
                #region Xử lý lỗi
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
                using (t.tDBContext mainDB = new t.tDBContext())
                {
                    mainDB.SREPORTs.UpdateOnSubmit(objUpdate);
                    mainDB.SubmitAllChange();
                }
                #endregion
            }
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
            //trong ung dung nay, luon luon tao moi excel de khong xung dot excel
            Excel.Application objExcel = null;

            //try
            //{
            //    //Tìm instance Excel đang chạy.
            //    objExcel = (Excel.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application");
            //}
            //catch
            //{
                //Không có instance nào của Excel đang chạy.
                try
                {
                    objExcel = new Excel.Application();
                }
                catch
                {
                   
                }
            //}

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
