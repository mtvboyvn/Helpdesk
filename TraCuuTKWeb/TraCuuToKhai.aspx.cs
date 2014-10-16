using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace t
{
    public partial class TraCuuToKhai : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[ct.USERNAME] == null)
            {
                Response.Redirect("~/DangNhap.aspx");
            }

            if (Page.IsPostBack == false)
            {
                btnUpdate_Click(null, null);
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                System.Threading.Thread.Sleep(5000);
                using (tDBContext mainDB = new tDBContext())
                {                   
                    GridView1.DataSource = mainDB.SREPORTs.GetList("",string.Format("RP_USERNAME='{0}'", Session[ct.USERNAME]),"RP_CREATEDATE DESC");
                    GridView1.DataBind();
                }
                lblUpdate.Text = String.Format("Cập nhật lúc: {0}", DateTime.Now);
            }
            catch (Exception ex)
            {
                lblUpdate.Text = String.Format("Có lỗi trong quá trình cập nhật dữ liệu, nội dung lỗi: {0}", ex.Message);
            }
            
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session[ct.USERNAME] = null;
            Response.Redirect("~/DangNhap.aspx");
        }

        protected void btnDatLenh_Click(object sender, EventArgs e)
        {
            try
            {
                System.Threading.Thread.Sleep(5000);
                using (tDBContext mainDB = new tDBContext())
                {
                    SREPORT rp = new SREPORT();
                    string strMax = mainDB.SREPORTs.Max("RP_ID");
                    if (string.IsNullOrEmpty(strMax) == true) strMax = "0";
                    int intMax = Convert.ToInt32(strMax);
                    rp.RP_ID = ++intMax;
                    rp.RP_USERNAME = string.Format("{0}", Session[ct.USERNAME]);
                    rp.RP_CREATEDATE = DateTime.Now;
                    rp.RP_DISPLAY = string.Format("Số TK: {0}", txtSoTK.Text);
                    rp.RP_QUERY = "SELECT * FROM B501A";
                    mainDB.SREPORTs.InsertOnSubmit(rp);
                    mainDB.SubmitAllChange();
                }
                lblMSG.Text = string.Format("Đặt lệnh thành công lúc {0}", DateTime.Now);
                btnUpdate_Click(null, null);
            }
            catch (Exception ex)
            {
                lblMSG.Text = string.Format("Đã xảy ra lỗi trong quá trình đặt lệnh, nội dung lỗi: {0}", ex.Message);
            }
          
        }
    }
}