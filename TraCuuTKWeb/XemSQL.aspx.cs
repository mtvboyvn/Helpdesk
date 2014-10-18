using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace t
{
    public partial class XemSQL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[ct.USERNAME] == null) Response.Write("BẠN KHÔNG CÓ QUYỀN TRUY CẬP TRANG NÀY");
            if (Session[ct.USERNAME].ToString().Equals("TuyenHM")==false) Response.Write("BẠN KHÔNG CÓ QUYỀN TRUY CẬP TRANG NÀY");
            string strRP_ID = this.Page.Request.QueryString["RP_ID"];
            if (string.IsNullOrEmpty(strRP_ID) == true) Response.Write("BẠN KHÔNG CÓ QUYỀN TRUY CẬP TRANG NÀY");
            int RP_ID = -1;
            bool bP = int.TryParse(strRP_ID, out RP_ID);
            if (bP == false) Response.Write("BẠN KHÔNG CÓ QUYỀN TRUY CẬP TRANG NÀY");

            try
            {
                using (t.tDBContext mainDB = new tDBContext())
                {
                    t.SREPORT r = mainDB.SREPORTs.GetObject(string.Format("RP_ID={0}", RP_ID));
                    if (r == null)
                    {
                        Response.Write("BẠN KHÔNG CÓ QUYỀN TRUY CẬP TRANG NÀY");
                    }
                    Response.Write(r.RP_QUERY);
                }
            }
            catch (Exception ex)
            {
                Response.Write("BẠN KHÔNG CÓ QUYỀN TRUY CẬP TRANG NÀY. " + ex.Message);
            }
        }
    }
}