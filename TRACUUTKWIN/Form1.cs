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
                      try
                      {
                          string strReportDir = Path.Combine(strReportRootPath, r["RP_USERNAME"].ToString());
                          if (Directory.Exists(strReportDir) == false) Directory.CreateDirectory(strReportDir);
                          string tmpFileXSL = Path.Combine(Application.StartupPath, "tempExcel.xls");
                          string strReportFileName = string.Format("TOKHAIMD_{0}.xls", r["RP_ID"].ToString());
                          string strReportFilePath = Path.Combine(strReportDir, strReportFileName);
                          string strDuongDanTuongDoi = string.Format("~/{0}/{1}", r["RP_USERNAME"].ToString(), strReportFileName);
                          File.Copy(tmpFileXSL, strReportFilePath, true);

                          DataSet ds = t.clsDalORACLE.GetDataSet(r["RP_QUERY"].ToString());

                          if (ds == null)//ko ra ket qua
                          { 
                          
                          }
                          if (ds.Tables.Count<1)//ko ra ket qua
                          {

                          }

                          object[,] objData = t.clsAll.DataTable2ArrayObjects(ds.Tables[0]);

                          Excel.Application objExcel=new Excel.Application();                          
                          objExcel.Visible = false;
                          objExcel.Workbooks.Open(strReportFilePath);
                          objExcel.Visible = false;
                          objExcel.Range[string.Format("A1:IV{0}", ds.Tables[0].Rows.Count)].Value = objData;

                          objExcel.Visible = false;
                          objExcel.SaveWorkspace(Missing.Value);
                          objExcel.Quit();

                          r["RP_STATUS"] = "Thành công";
                          r["RP_FILEPATH"] = strDuongDanTuongDoi;
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
    }
}
