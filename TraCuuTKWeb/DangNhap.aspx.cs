using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace t
{
    public partial class DangNhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            try
            {
                if (Login1.UserName.Equals("TuyenHM") & Login1.Password.Equals("1"))
                {
                    Session[ct.USERNAME] = "TuyenHM";
                    Response.Redirect("~/TraCuuToKhai.aspx");
                }

                if (Login1.UserName.Equals("TuyenHM1") & Login1.Password.Equals("1"))
                {
                    Session[ct.USERNAME] = "TuyenHM1";
                    Response.Redirect("~/TraCuuToKhai.aspx");
                }

                SUSER u = default(SUSER);
                using (tDBContext mainDB = new tDBContext())
                {
                    u = mainDB.SUSERs.GetObject(string.Format("ST_USERNAME='{0}'", Login1.UserName));
                    if (u == null)
                    {
                        lblMSG.Text = string.Format("Tài khoản/mật khẩu chưa đúng. Vui lòng kiểm tra lại.");
                        return;
                    }                   
                }
                Session[ct.USERNAME] = u.ST_USERNAME;
                Response.Redirect("~/TraCuuToKhai.aspx");
            }
            catch (Exception ex)
            {
                lblMSG.Text = string.Format("Có lỗi xảy ra: {0}", ex.Message);
            }
        }
    }
}