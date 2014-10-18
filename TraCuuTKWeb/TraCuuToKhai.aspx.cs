using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace t
{
    public partial class TraCuuToKhai : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            //SOTK.Focus();
            //Page.SetFocus(SOTK);
            //Page.Form.DefaultFocus = SOTK.ClientID;
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            //SOTK.Focus();
            //Page.SetFocus(SOTK);
            //Page.Form.DefaultFocus = SOTK.ClientID;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[ct.USERNAME] == null)
            {
                Response.Redirect("~/DangNhap.aspx");
            }

           
            if (Page.IsPostBack == false)
            {
                clsAll.ClearDesignData2(tblDieuKien);
                //SOTK.Focus();
                //Page.SetFocus(SOTK);
                //Page.Form.DefaultFocus = SOTK.ClientID;
               // btnUpdate_Click(null, null);
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //System.Threading.Thread.Sleep(5000);
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
                string strWhere = TạoWHERE();
                if (string.IsNullOrEmpty(strWhere) == true)
                {
                    lblMSG.Text = "Vui lòng nhập điều kiện tìm kiếm!";
                    return;
                }

                //System.Threading.Thread.Sleep(5000);
                using (tDBContext mainDB = new tDBContext())
                {
                    SREPORT rp = new SREPORT();
                    string strMax = mainDB.SREPORTs.Max("RP_ID");
                    if (string.IsNullOrEmpty(strMax) == true) strMax = "0";
                    int intMax = Convert.ToInt32(strMax);
                    rp.RP_ID = ++intMax;
                    rp.RP_USERNAME = string.Format("{0}", Session[ct.USERNAME]);
                    rp.RP_CREATEDATE = DateTime.Now;
                    rp.RP_DISPLAY = string.Format("Số TK: {0}", SOTK.Text);
                    rp.RP_QUERY = TạoTruyVấn(strWhere);
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

        private string TạoWHERE()
        {
            //string strSQL = "SELECT * FROM MVIEW1_TOKHAIMD WHERE {0}";
            //string strSQL = "SELECT * FROM A501A WHERE {0}";
            if (string.IsNullOrEmpty(SOTK.Text.Trim()) == false)
            {
                return string.Format("SIKNO='{0}'", SOTK.Text);
            }
            return "";
        }

        private string TạoTruyVấn(string strWhere)
        {
            //string strSQL = "SELECT * FROM MVIEW1_TOKHAIMD WHERE {0}";
            string strSQL = "SELECT * FROM A501A WHERE {0}";
            return string.Format(strSQL, strWhere);
        }

        protected void MA_LH_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(MA_LH.Text.Trim()) == true)
            {
                TEN_LH.SelectedIndex = 0;
                return;
            }
            try
            {
                TEN_LH.SelectedValue = MA_LH.Text.Trim().ToUpper();
                MA_LH.Text = MA_LH.Text.Trim().ToUpper();                
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                MA_LH.Text = string.Empty;
                TEN_LH.SelectedIndex = 0;
            }
        }

        protected void TEN_LH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TEN_LH.SelectedValue == null)
            {
                TEN_LH.SelectedIndex = 0;
                MA_LH.Text = string.Empty;
                return;
            }
            if (string.IsNullOrEmpty(TEN_LH.SelectedValue.ToString())==true)
            {
                TEN_LH.SelectedIndex = 0;
                MA_LH.Text = string.Empty;
                return;
            }
            MA_LH.Text = TEN_LH.SelectedValue.ToString().ToUpper();
        }

        protected void MA_NUOCXNK_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MA_NUOCXNK.Text.Trim()) == true)
            {
                TEN_NUOCXNK.SelectedIndex = 0;
                return;
            }
            try
            {
                TEN_NUOCXNK.SelectedValue = MA_NUOCXNK.Text.Trim().ToUpper();
                MA_NUOCXNK.Text = MA_NUOCXNK.Text.Trim().ToUpper();
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                MA_NUOCXNK.Text = string.Empty;
                TEN_NUOCXNK.SelectedIndex = 0;
            }
        }

        protected void TEN_NUOCXNK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TEN_NUOCXNK.SelectedValue == null)
            {
                TEN_NUOCXNK.SelectedIndex = 0;
                MA_NUOCXNK.Text = string.Empty;
                return;
            }
            if (string.IsNullOrEmpty(TEN_NUOCXNK.SelectedValue.ToString()) == true)
            {
                TEN_NUOCXNK.SelectedIndex = 0;
                MA_NUOCXNK.Text = string.Empty;
                return;
            }
            MA_NUOCXNK.Text = TEN_NUOCXNK.SelectedValue.ToString().ToUpper();
        }

        protected void MA_NUOCXX_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MA_NUOCXX.Text.Trim()) == true)
            {
                TEN_NUOCXX.SelectedIndex = 0;
                return;
            }
            try
            {
                TEN_NUOCXX.SelectedValue = MA_NUOCXX.Text.Trim().ToUpper();
                MA_NUOCXX.Text = MA_NUOCXX.Text.Trim().ToUpper();
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                MA_NUOCXX.Text = string.Empty;
                TEN_NUOCXX.SelectedIndex = 0;
            }
        }

        protected void TEN_NUOCXX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TEN_NUOCXX.SelectedValue == null)
            {
                TEN_NUOCXX.SelectedIndex = 0;
                MA_NUOCXX.Text = string.Empty;
                return;
            }
            if (string.IsNullOrEmpty(TEN_NUOCXX.SelectedValue.ToString()) == true)
            {
                TEN_NUOCXX.SelectedIndex = 0;
                MA_NUOCXX.Text = string.Empty;
                return;
            }
            MA_NUOCXX.Text = TEN_NUOCXX.SelectedValue.ToString().ToUpper();
        }

        protected void MA_CUCHQ_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MA_CUCHQ.Text.Trim()) == true)
            {
                TEN_CUCHQ.SelectedIndex = 0;
                return;
            }
            try
            {
                TEN_CUCHQ.SelectedValue = MA_CUCHQ.Text.Trim().ToUpper();
                MA_CUCHQ.Text = MA_CUCHQ.Text.Trim().ToUpper();
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                MA_CUCHQ.Text = string.Empty;
                TEN_CUCHQ.SelectedIndex = 0;
            }
        }

        protected void TEN_CUCHQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TEN_CUCHQ.SelectedValue == null)
            {
                TEN_CUCHQ.SelectedIndex = 0;
                MA_CUCHQ.Text = string.Empty;
                return;
            }
            if (string.IsNullOrEmpty(TEN_CUCHQ.SelectedValue.ToString()) == true)
            {
                TEN_CUCHQ.SelectedIndex = 0;
                MA_CUCHQ.Text = string.Empty;
                return;
            }
            MA_CUCHQ.Text = TEN_CUCHQ.SelectedValue.ToString().ToUpper();
        }

        protected void MA_CC_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MA_CC.Text.Trim()) == true)
            {
                TEN_CC.SelectedIndex = 0;
                return;
            }
            try
            {
                TEN_CC.SelectedValue = MA_CC.Text.Trim().ToUpper();
                MA_CC.Text = MA_CC.Text.Trim().ToUpper();
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                MA_CC.Text = string.Empty;
                TEN_CC.SelectedIndex = 0;
            }
        }

        protected void TEN_CC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TEN_CC.SelectedValue == null)
            {
                TEN_CC.SelectedIndex = 0;
                MA_CC.Text = string.Empty;
                return;
            }
            if (string.IsNullOrEmpty(TEN_CC.SelectedValue.ToString()) == true)
            {
                TEN_CC.SelectedIndex = 0;
                MA_CC.Text = string.Empty;
                return;
            }
            MA_CC.Text = TEN_CC.SelectedValue.ToString().ToUpper();
        }

        protected void MA_DONVI_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MA_DONVI.Text.Trim()) == true)
            {
                TEN_DONVI.SelectedIndex = 0;
                return;
            }
            try
            {
                TEN_DONVI.SelectedValue = MA_DONVI.Text.Trim().ToUpper();
                MA_DONVI.Text = MA_DONVI.Text.Trim().ToUpper();
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                MA_DONVI.Text = string.Empty;
                TEN_DONVI.SelectedIndex = 0;
            }
        }

        protected void TEN_DONVI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TEN_DONVI.SelectedValue == null)
            {
                TEN_DONVI.SelectedIndex = 0;
                MA_DONVI.Text = string.Empty;
                return;
            }
            if (string.IsNullOrEmpty(TEN_DONVI.SelectedValue.ToString()) == true)
            {
                TEN_DONVI.SelectedIndex = 0;
                MA_DONVI.Text = string.Empty;
                return;
            }
            MA_DONVI.Text = TEN_DONVI.SelectedValue.ToString().ToUpper();
        }
    }
}