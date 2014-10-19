using System;
using System.Collections.Generic;
using System.Globalization;
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
                string[] strWhere = TạoWHERE();
                if (string.IsNullOrEmpty(strWhere[0]) == true)
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
                    rp.RP_STATUS = "Đang xử lý";
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

        private string[] TạoWHERE()
        {
            //string strSQL = "SELECT * FROM MVIEW1_TOKHAIMD WHERE {0}";
            //string strSQL = "SELECT * FROM A501A WHERE {0}";
            string[] strSQL = new string[2];
            if (string.IsNullOrEmpty(SOTK.Text.Trim()) == false)
            {
                return new string[2]{
                    string.Format("N1.N501A_SIKNO='{0}' ", SOTK.Text),
                    string.Format("N2.N502A_SIKNO='{0}' ", SOTK.Text)};
            }
            
            //THỜI GIAN ĐANG CHẠY RẤT CHẬP VÌ NGÀY ĐK TỜ KHAI ĐANG ĐỂ DẠNG TEXT TRONG ĐB

            //if (string.IsNullOrEmpty(NGAYDK_FROM.Text) == false)
            //{
            //    DateTime dFrom = new DateTime();
            //    bool bP = DateTime.TryParseExact(NGAYDK_FROM.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out dFrom);
            //    if (bP == true)
            //    { 
            //        strSQL = new string[2]{
            //        string.Format("N501A_SINKD>='{0:yyyyMMdd}' ", dFrom),
            //        string.Format("N502A_SINKD>='{0:yyyyMMdd}' ", dFrom)};
            //    }
            //}
            //if (string.IsNullOrEmpty(NGAYDK_TO.Text) == false)
            //{
            //    DateTime dTO = new DateTime();
            //    bool bP = DateTime.TryParseExact(NGAYDK_TO.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out dTO);
            //    if (bP == true)
            //    {
            //        if (string.IsNullOrEmpty(strSQL[0]) == false)
            //        {
            //            strSQL[0] += " AND "; strSQL[1] += " AND ";
            //        }

            //       strSQL[0] += string.Format("N501A_SINKD<='{0:yyyyMMdd}' ", dTO);
            //       strSQL[1] += string.Format("N502A_SINKD<='{0:yyyyMMdd}' ", dTO);
            //    }
            //}

            if (string.IsNullOrEmpty(MA_LH.Text) == false)
            {
                if (string.IsNullOrEmpty(strSQL[0]) == false)
                {
                    strSQL[0] += " AND "; strSQL[1] += " AND ";
                }

                strSQL[0] += string.Format("N1.N501A_SINKS='{0}' ", MA_LH.Text);
                strSQL[1] += string.Format("N2.N502A_SINKS='{0}' ", MA_LH.Text);
            }

            if (string.IsNullOrEmpty(MA_CC.Text) == false)
            {
                if (string.IsNullOrEmpty(strSQL[0]) == false)
                {
                    strSQL[0] += " AND "; strSQL[1] += " AND ";
                }

                strSQL[0] += string.Format("N1.N501A_SHIKS='{0}' ", MA_CC.Text);
                strSQL[1] += string.Format("N2.N502A_SHIKS='{0}' ", MA_CC.Text);
            }
            else
            {
                if (string.IsNullOrEmpty(MA_CUCHQ.Text) == false)
                {
                    if (string.IsNullOrEmpty(strSQL[0]) == false)
                    {
                        strSQL[0] += " AND "; strSQL[1] += " AND ";
                    }

                    strSQL[0] += string.Format("SUBSTR(N1.N501A_SHIKS,0,2)='{0}' ", MA_CUCHQ.Text);
                    strSQL[1] += string.Format("SUBSTR(N2.N502A_SHIKS,0,2)='{0}' ", MA_CUCHQ.Text);
                } 
            }

            if (string.IsNullOrEmpty(MA_DONVI.Text) == false)
            {
                if (string.IsNullOrEmpty(strSQL[0]) == false)
                {
                    strSQL[0] += " AND "; strSQL[1] += " AND ";
                }

                strSQL[0] += string.Format("N1.N501A_YUNYC='{0}' ", MA_DONVI.Text);
                strSQL[1] += string.Format("N2.N502A_YUNYC='{0}' ", MA_DONVI.Text);
            }

            if (string.IsNullOrEmpty(TEN_DOITAC.Text) == false)
            {
                if (string.IsNullOrEmpty(strSQL[0]) == false)
                {
                    strSQL[0] += " AND "; strSQL[1] += " AND ";
                }

                strSQL[0] += string.Format("N1.N501A_YUNN2 LIKE '%{0}%' ", TEN_DOITAC.Text);
                strSQL[1] += string.Format("N2.N502A_YUNN2 LIKE '%{0}%' ", TEN_DOITAC.Text);
            }

            //Nước xuất nhập khẩu (chung trường YUSYK)
            if (string.IsNullOrEmpty(MA_NUOCXK.Text) == false)
            {
                if (string.IsNullOrEmpty(strSQL[0]) == false)
                {
                    strSQL[0] += " AND "; strSQL[1] += " AND ";
                }

                strSQL[0] += string.Format("N1.N501A_YUSYK='{0}' ", MA_NUOCXK.Text);
                strSQL[1] += string.Format("N2.N502A_YUSYK='{0}' ", MA_NUOCXK.Text);
            }

            //nước xuất xứ chưa tìm thấy trường nào
            return strSQL;
        }

        private string TạoTruyVấn(string[] strWhere)
        {
            //string strSQL = "SELECT V1.* FROM (" + t.Properties.Resources.MVIEW1_TOKHAIMD + ") V1 WHERE {0}";
            //string strSQL = "SELECT * FROM A501A WHERE {0}";
            string strSQL = t.Properties.Resources.MVIEW1_TOKHAIMD2;
            return string.Format(strSQL, strWhere[0], strWhere[1]);
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

        protected void MA_NUOCXK_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MA_NUOCXK.Text.Trim()) == true)
            {
                TEN_NUOCXK.SelectedIndex = 0;
                return;
            }
            try
            {
                TEN_NUOCXK.SelectedValue = MA_NUOCXK.Text.Trim().ToUpper();
                MA_NUOCXK.Text = MA_NUOCXK.Text.Trim().ToUpper();
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                MA_NUOCXK.Text = string.Empty;
                TEN_NUOCXK.SelectedIndex = 0;
            }
        }

        protected void TEN_NUOCXK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TEN_NUOCXK.SelectedValue == null)
            {
                TEN_NUOCXK.SelectedIndex = 0;
                MA_NUOCXK.Text = string.Empty;
                return;
            }
            if (string.IsNullOrEmpty(TEN_NUOCXK.SelectedValue.ToString()) == true)
            {
                TEN_NUOCXK.SelectedIndex = 0;
                MA_NUOCXK.Text = string.Empty;
                return;
            }
            MA_NUOCXK.Text = TEN_NUOCXK.SelectedValue.ToString().ToUpper();
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
                TEN_DONVI.Text = string.Empty;
                return;
            }
            try
            {                
                MA_DONVI.Text = MA_DONVI.Text.Replace("'","").Trim().ToUpper();
                using (tDBContext mainDB = new tDBContext())
                {
                    SDONVI dv = mainDB.SDONVIs.GetObject(string.Format("MA_DONVI=N'{0}'", MA_DONVI.Text));
                    if (dv == null)
                    {
                        MA_DONVI.Text = string.Empty;
                        TEN_DONVI.Text = string.Empty;
                    }
                    TEN_DONVI.Text = dv.TEN_DONVI;
                }
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                MA_DONVI.Text = string.Empty;
                TEN_DONVI.Text = string.Empty;
            }
        }

        protected void TEN_DONVI_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (TEN_DONVI.SelectedValue == null)
            //{
            //    TEN_DONVI.SelectedIndex = 0;
            //    MA_DONVI.Text = string.Empty;
            //    return;
            //}
            //if (string.IsNullOrEmpty(TEN_DONVI.SelectedValue.ToString()) == true)
            //{
            //    TEN_DONVI.SelectedIndex = 0;
            //    MA_DONVI.Text = string.Empty;
            //    return;
            //}
            //MA_DONVI.Text = TEN_DONVI.SelectedValue.ToString().ToUpper();
        }

        protected void TEN_DOITAC_TextChanged(object sender, EventArgs e)
        {
            TEN_DOITAC.Text = TEN_DOITAC.Text.Trim().ToUpper().Replace("'", "");
        }
    }
}