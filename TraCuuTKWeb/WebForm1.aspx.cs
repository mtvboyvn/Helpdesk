using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace t
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dsLOAIHINHMD ds = new dsLOAIHINHMD();
            DataRow r = ds.Tables[0].NewRow();
            r[0] = "A11";
            r[1] = "Nhập kinh doanh tiêu dùng";
            ds.Tables[0].Rows.Add(r);

            DataRow r1 = ds.Tables[0].NewRow();
            r1[0] = "A12";
            r1[1] = "Nhập kinh doanh sản xuất";
            ds.Tables[0].Rows.Add(r1);

            ds.Tables[0].WriteXml(@"C:\SLOAIHINHMD.xml");
        }
    }
}