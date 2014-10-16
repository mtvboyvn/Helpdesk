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
                
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            lblUpdate.Text = String.Format("Refresh at: {0}", DateTime.Now);
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session[ct.USERNAME] = null;
            Response.Redirect("~/DangNhap.aspx");
        }
    }
}