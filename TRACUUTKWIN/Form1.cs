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
            pro.Elapsed += pro_Elapsed;
            pro.Interval = 3000;
            pro.Enabled = false;
            pro.Stop();
        }

        string strReportRootPath = @"E:\PROJECTS\Helpdesk\TraCuuTKWeb\Reports";

        void pro_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            pro.Enabled = false;
            pro.Stop();
            try
            {
                using (t.tDBContext mainDB = new t.tDBContext())
                {                    
                  DataTable rr=  mainDB.SREPORTs.GetList("TOP 50 * ",string.Format("RP_FILEPATH IS NULL"));
                  if (rr == null)
                  {
                      pro.Enabled = true;
                      pro.Start();
                      return;
                  }
                  if (rr.Rows.Count<1)
                  {
                      pro.Enabled = true;
                      pro.Start();
                      return;
                  }
                  foreach (DataRow r in rr.Rows)
                  {
                      string strReportDir = Path.Combine(strReportRootPath, r["RP_USERNAME"].ToString());
                      if (Directory.Exists(strReportDir) == false) Directory.CreateDirectory(strReportDir);
                      string tmpFileXSL = Path.Combine(Application.StartupPath, "tempExcel.xls");
                      string strReportFileName = string.Format("TOKHAIMD_{0}.xls", r["RP_ID"].ToString());
                      string strReportFilePath = Path.Combine(strReportDir, strReportFileName);
                      string strDuongDanTuongDoi = string.Format("~/Reports/{0}/{1}", r["RP_USERNAME"].ToString(), strReportFileName);
                      try
                      {                         
                          File.Copy(tmpFileXSL, strReportFilePath, true);

                          string[] strQuery = r["RP_QUERY"].ToString().Split(';');
                          DataSet dsTK = t.clsDalORACLE.GetDataSet(strQuery[0]);
                          DataSet dsHANG = t.clsDalORACLE.GetDataSet(strQuery[1]);

                          if (dsTK == null)//ko ra ket qua
                          { 
                          
                          }
                          if (dsTK.Tables.Count < 1)//ko ra ket qua
                          {

                          }

                          object[,] objData = t.clsAll.DataTable2ArrayObjects(dsTK.Tables[0]);

                          Excel.Application objExcel = this.GetExcelApp();                         
                          objExcel.Visible = false;
                          objExcel.Application.Visible = false; 
                          Excel.Workbook wb = objExcel.Workbooks.Open(strReportFilePath);
                          objExcel.Visible = false;
                          Excel.Worksheet wsTOKHAIMD = (Excel.Worksheet)wb.Worksheets[1];
                          wsTOKHAIMD.Range[string.Format("A1:IV{0}", dsTK.Tables[0].Rows.Count)].Value = objData;

                          Excel.Worksheet wsHANGMD = (Excel.Worksheet)wb.Worksheets[2];
                          object[,] objDataHANG = t.clsAll.DataTable2ArrayObjects(dsHANG.Tables[0]);
                          wsHANGMD.Range[string.Format("A1:IV{0}", dsHANG.Tables[0].Rows.Count)].Value = objDataHANG;

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
                          r["RP_FILENAME"] = strReportFileName;
                          r["RP_EXPORTDATE"]=DateTime.Now;
                          t.SREPORT objUpdate=new t.SREPORT();
                          t.clsAll.DataRow2Object(r, objUpdate);
                          objUpdate.DataStatus = t.DBStatus.Updated;
                          mainDB.SREPORTs.UpdateOnSubmit(objUpdate);
                          mainDB.SubmitAllChange();
                      }
                      catch (Exception ex)
                      {
                          string s = ex.Message;
                          r["RP_STATUS"] = "Có lỗi";
                          r["RP_FILEPATH"] = string.Format("~/ERROR_{0}.txt",r["RP_ID"]);
                          t.SREPORT objUpdate=new t.SREPORT();
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

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "ĐANG XỬ LÝ";
            button1.Enabled = false;
            pro.Enabled = true;
            pro.Start();
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
    }
}
