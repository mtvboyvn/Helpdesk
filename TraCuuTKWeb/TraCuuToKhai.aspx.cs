using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using t.Properties;

namespace t
{
    public partial class TraCuuToKhai : System.Web.UI.Page
    {
        static DateTime? lastQueryTime = null;

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

            TEN_CC.DataTextField = "TEN_CC";
            TEN_CC.DataValueField = "MA_CC";
           
            if (Page.IsPostBack == false)
            {
                clsAll.ClearDesignData2(tblDieuKien);

                NGAYDK_FROM.Text = DateTime.Now.AddMonths(-1).ToString("dd/MM/yyyy");
                NGAYDK_TO.Text = DateTime.Now.ToString("dd/MM/yyyy");

                TEN_CC.DataSource = Global.dsCHICUC.Tables[0];
                TEN_CC.DataBind();

                //SOTK.Focus();
                //Page.SetFocus(SOTK);
                //Page.Form.DefaultFocus = SOTK.ClientID;
               // btnUpdate_Click(null, null);
                GridView1.Columns[1].Visible = string.Format("{0}",Session[ct.USERNAME]).Equals("TuyenHM");
                GridView1.Columns[GridView1.Columns.Count-1].Visible = GridView1.Columns[1].Visible;
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
            if (this.ValidateCondition(tblDieuKien) == false)
            {
                return;
            }

            if (this.ValidateNGAY(tblDieuKien) == false)
            {
                return;
            }

            if (lastQueryTime.HasValue==true)
            {
                if ((DateTime.Now - lastQueryTime.Value).TotalSeconds < 6)
                {
                    lblMSG.Text = "Không thể đặt lệnh ra cứu liên tiếp trong vòng 5 giây";
                    return;
                }
            }

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
                    rp.RP_DISPLAY = TaoDieuKienTimKiemText();
                    rp.RP_QUERY = TạoTruyVấn(strWhere);
                    rp.RP_STATUS = "Đang xử lý";
                    mainDB.SREPORTs.InsertOnSubmit(rp);
                    mainDB.SubmitAllChange();
                }
                lblMSG.Text = string.Format("Đặt lệnh thành công lúc {0}", DateTime.Now);
                lastQueryTime = DateTime.Now;
                btnUpdate_Click(null, null);
            }
            catch (Exception ex)
            {
                lblMSG.Text = string.Format("Đã xảy ra lỗi trong quá trình đặt lệnh, nội dung lỗi: {0}", ex.Message);
            }
          
        }

        private bool ValidateNGAY(System.Web.UI.HtmlControls.HtmlTable tblDieuKien)
        {
            SOTK.BackColor = Color.White;
            MA_LH.BackColor = Color.White;
            MA_CC.BackColor = Color.White;
            MA_DONVI.BackColor = Color.White;
            TEN_DOITAC.BackColor = Color.White;
            MA_NUOCXK.BackColor = Color.White;
            if (string.IsNullOrEmpty(SOTK.Text.Trim()) == false)//neu co so to khai
            {
                SOTK.BackColor = Color.White;
                if (SOTK.Text.Trim().Length != 12)
                {
                    lblMSG.Text = "Số tờ khai phải có 12 chữ số";
                    SOTK.BackColor = Color.Salmon;
                    return false;
                }
                Int64 intSoTK = -1;
                bool ip = Int64.TryParse(SOTK.Text,out intSoTK);
                if (ip==false)
                {
                    lblMSG.Text = "Số tờ khai chỉ được điền chữ số";
                    SOTK.BackColor = Color.Salmon;
                    return false;
                }

                return true;//nếu có số tờ khai chỉ xử lý riêng theo số tờ khai là đủ
            }

            if (string.IsNullOrEmpty(MA_HS.Text) == false)
            {
                MA_HS.BackColor = Color.White;
                if ((3 < MA_HS.Text.Trim().Length) & (MA_HS.Text.Trim().Length < 9))
                {

                }
                else
                {
                    lblMSG.Text = "Mã HS chỉ được nhập từ 4 đến 8 số";
                    MA_HS.BackColor = Color.Salmon;
                    return false;
                }
                Int64 intHS = -1;
                bool ip = Int64.TryParse(MA_HS.Text, out intHS);
                if (ip == false)
                {
                    lblMSG.Text = "Mã HS chỉ được điền chữ số";
                    MA_HS.BackColor = Color.Salmon;
                    return false;
                }
            }

            if (string.IsNullOrEmpty(TEN_DOITAC.Text) == false)
            {
                TEN_DOITAC.BackColor = Color.White;
                if (TEN_DOITAC.Text.Trim().Length <  11)
                {
                    lblMSG.Text = "Tên đối tác phải nhiều hơn 10 ký tự";
                    TEN_DOITAC.BackColor = Color.Salmon;
                    return false;
                }
            }
            if (string.IsNullOrEmpty(TEN_HANG.Text) == false)
            {
                TEN_HANG.BackColor = Color.White;
                if (TEN_HANG.Text.Trim().Length < 11)
                {
                    lblMSG.Text = "Tên hàng hóa phải nhiều hơn 10 ký tự";
                    TEN_HANG.BackColor = Color.Salmon;
                    return false;
                }
            }

            NGAYDK_FROM.BackColor = Color.White;
            NGAYDK_TO.BackColor = Color.White;
            if (string.IsNullOrEmpty(NGAYDK_FROM.Text) == true)
            {
                lblMSG.Text = "Bắt buộc phải nhập ngày bắt đầu tìm kiếm tờ khai";
                NGAYDK_FROM.BackColor = Color.Salmon;
                return false;
            }
            if (NGAYDK_FROM.Text.Trim().Equals("__/__/____") == true)
            {
                lblMSG.Text = "Bắt buộc phải nhập ngày bắt đầu tìm kiếm tờ khai";
                NGAYDK_FROM.BackColor = Color.Salmon;
                return false;
            }
            DateTime dFrom = new DateTime();
            bool bP1 = DateTime.TryParseExact(NGAYDK_FROM.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out dFrom);
            if (bP1 == false)
            {
                lblMSG.Text = "Ngày bắt đầu tìm kiếm tờ khai không đúng định dạng dd/MM/yyyy";
                NGAYDK_FROM.BackColor = Color.Salmon;
                return false;
            }

            if (string.IsNullOrEmpty(NGAYDK_TO.Text) == true)
            {
                lblMSG.Text = "Bắt buộc phải nhập ngày kết thúc tìm kiếm tờ khai";
                NGAYDK_TO.BackColor = Color.Salmon;
                return false;
            }
            if (NGAYDK_TO.Text.Trim().Equals("__/__/____") == true)
            {
                lblMSG.Text = "Bắt buộc phải nhập ngày kết thúc tìm kiếm tờ khai";
                NGAYDK_TO.BackColor = Color.Salmon;
                return false;
            }
            DateTime dTo = new DateTime();
            bool bP2 = DateTime.TryParseExact(NGAYDK_TO.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out dTo);
            if (bP2 == false)
            {
                lblMSG.Text = "Ngày kết thúc tìm kiếm tờ khai không đúng định dạng dd/MM/yyyy";
                NGAYDK_TO.BackColor = Color.Salmon;
                return false;
            }

            if (dFrom > dTo)
            {
                lblMSG.Text =string.Format( "Ngày bắt đầu tìm kiếm {0:dd/MM/yyyy} phải trước ngày kết thúc tìm kiếm {1:dd/MM/yyyy}",dFrom,dTo);
                NGAYDK_TO.BackColor = Color.Salmon;
                NGAYDK_FROM.BackColor = Color.Salmon;
                return false;
            }

            if( (dTo - dFrom).TotalDays>31)
            {
                lblMSG.Text = string.Format("Ngày bắt đầu tìm kiếm {0:dd/MM/yyyy} và ngày kết thúc tìm kiếm {1:dd/MM/yyyy} không được cách nhau quá 31 ngày", dFrom, dTo);
                NGAYDK_TO.BackColor = Color.Salmon;
                NGAYDK_FROM.BackColor = Color.Salmon;
                return false;
            }
           
            if (string.IsNullOrEmpty(SOTK.Text.Trim()) == true &
                string.IsNullOrEmpty(MA_LH.Text.Trim()) == true &
                string.IsNullOrEmpty(MA_CC.Text.Trim()) == true &
                 string.IsNullOrEmpty(MA_DONVI.Text.Trim()) == true &
                 string.IsNullOrEmpty(TEN_DOITAC.Text.Trim()) == true &
                 string.IsNullOrEmpty(MA_NUOCXK.Text.Trim()) == true)
            {
                lblMSG.Text = string.Format("Phải nhập tối thiểu 1 chỉ tiêu thông tin của tờ khai bôi màu đỏ");
                SOTK.BackColor = Color.Salmon;
                MA_LH.BackColor = Color.Salmon;
                MA_CC.BackColor = Color.Salmon;
                MA_DONVI.BackColor = Color.Salmon;
                TEN_DOITAC.BackColor = Color.Salmon;
                MA_NUOCXK.BackColor = Color.Salmon;
                return false;
            }

            return true;
        }

        private bool ValidateCondition(Control tblDieuKien)
        {
            bool re = true;

            foreach (Control c in tblDieuKien.Controls)
            {
                TextBox txt = c as TextBox;
                if (txt == null)
                {
                    re = ValidateCondition(c);
                    if(re==true) continue;
                    break;
                }
                txt.BackColor = Color.White;
                if (txt.Text.IndexOf("'") > -1 || txt.Text.IndexOf(";") > -1)
                {
                    txt.BackColor = Color.Salmon;
                    lblMSG.Text = "Điều kiện tìm kiếm có các ký tự lạ ['] và [;]";
                    re = false;
                    break;
                }
            }

            return re;
        }

        private string TaoDieuKienTimKiemText()
        {
            string strDK = "";
            if (string.IsNullOrEmpty(SOTK.Text) == false)
            {
                strDK += string.Format("Số TK: {0}<br />", SOTK.Text);
                return strDK;
            }

            if (string.IsNullOrEmpty(NGAYDK_FROM.Text) == false)
                strDK += string.Format("Ngày ĐK sau: {0}<br />", NGAYDK_FROM.Text);

            if (string.IsNullOrEmpty(NGAYDK_TO.Text) == false)
                strDK += string.Format("Ngày ĐK trước: {0}<br />", NGAYDK_TO.Text);

            if (string.IsNullOrEmpty(MA_LH.Text) == false)
                strDK += string.Format("Mã LH: {0}<br />", MA_LH.Text);

            if (string.IsNullOrEmpty(MA_CUCHQ.Text) == false)
                strDK += string.Format("Mã Cục: {0}<br />", MA_CUCHQ.Text);

            if (string.IsNullOrEmpty(MA_CC.Text) == false)
                strDK += string.Format("Mã Chi cục: {0}<br />", MA_CC.Text);

            if (string.IsNullOrEmpty(MA_DONVI.Text) == false)
                strDK += string.Format("Mã đơn vị: {0}<br />", MA_DONVI.Text);

            if (string.IsNullOrEmpty(TEN_DOITAC.Text) == false)
                strDK += string.Format("Tên đối tác: {0}<br />", TEN_DOITAC.Text);           

            if (string.IsNullOrEmpty(MA_NUOCXK.Text) == false)
                strDK += string.Format("Nước XNK: {0}<br />", MA_NUOCXK.Text);

            if (string.IsNullOrEmpty(MA_HS.Text) == false)
                strDK += string.Format("Mã HS: {0}<br />", MA_HS.Text);

            if (string.IsNullOrEmpty(TEN_HANG.Text) == false)
                strDK += string.Format("Tên hàng: {0}<br />", TEN_HANG.Text);

            if (string.IsNullOrEmpty(MA_NUOCXX.Text) == false)
                strDK += string.Format("Nước xuất xứ: {0}", MA_NUOCXX.Text);
           

            return strDK;
        }

        private string[] TạoWHERE()
        {
            //string strSQL = "SELECT * FROM MVIEW1_TOKHAIMD WHERE {0}";
            //string strSQL = "SELECT * FROM A501A WHERE {0}";
            string[] strSQL = new string[2];
            if (string.IsNullOrEmpty(MA_HS.Text.Trim()) == false||
                string.IsNullOrEmpty(TEN_HANG.Text.Trim()) == false||
                string.IsNullOrEmpty(MA_NUOCXX.Text.Trim()) == false)
            {
                strSQL = new string[4];
            }
            
            if (string.IsNullOrEmpty(SOTK.Text.Trim()) == false)
            {
                return new string[2]{
                    string.Format("N1.N501A_SIKNO='{0}' ", SOTK.Text),
                    string.Format("N2.N502A_SIKNO='{0}' ", SOTK.Text)};
            }
            
            //THỜI GIAN ĐANG CHẠY RẤT CHẬP VÌ NGÀY ĐK TỜ KHAI ĐANG ĐỂ DẠNG TEXT TRONG ĐB

            if (string.IsNullOrEmpty(NGAYDK_FROM.Text) == false)
            {
                DateTime dFrom = new DateTime();
                bool bP = DateTime.TryParseExact(NGAYDK_FROM.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out dFrom);
                if (bP == true)
                {

                    strSQL[0] += string.Format("N1.N501A_SINKD>='{0:yyyyMMdd}' ", dFrom);
                    strSQL[1] += string.Format("N2.N502A_SINKD>='{0:yyyyMMdd}' ", dFrom);
                }
            }
            if (string.IsNullOrEmpty(NGAYDK_TO.Text) == false)
            {
                DateTime dTO = new DateTime();
                bool bP = DateTime.TryParseExact(NGAYDK_TO.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out dTO);
                if (bP == true)
                {
                    if (string.IsNullOrEmpty(strSQL[0]) == false)
                    {
                        strSQL[0] += " AND "; strSQL[1] += " AND ";
                    }

                    strSQL[0] += string.Format("N1.N501A_SINKD<='{0:yyyyMMdd}' ", dTO);
                    strSQL[1] += string.Format("N2.N502A_SINKD<='{0:yyyyMMdd}' ", dTO);
                }
            }

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

            //nước xuất xứ
            if (string.IsNullOrEmpty(MA_NUOCXX.Text.Trim()) == false)
            {
                if (string.IsNullOrEmpty(strSQL[2]) == false)
                {
                    strSQL[2] += " AND "; strSQL[3] += " AND ";
                }
                strSQL[2] += string.Format("B1.N501B_ORGLC='{0}' ", MA_NUOCXX.Text.Trim());
                //strSQL[3] += string.Format("B2.N502B_ORGLC='{0}' ", MA_NUOCXX.Text.Trim());//to khai xua ko co nuoc xuat xu
                if (MA_NUOCXX.Text.Trim().Equals("VN") == true)
                {
                    //trường hợp chọn việt nam thì lấy tất tờ khai xuất
                    strSQL[3] += string.Format("B2.N502B_SIKNO IS NOT NULL ");//to khai xua ko co nuoc xuat xu, nên để tờ khai bằng AAA để không lấy ra tờ khai xuất 
                }
                else
                {
                    strSQL[3] += string.Format("ROWNUM < 0 ");//to khai xua ko co nuoc xuat xu, nên để ROWNUM <0 chạy cho nhanh
                }
            }

            //MÃ HS
            if (string.IsNullOrEmpty(MA_HS.Text.Trim()) == false)
            {
                if (string.IsNullOrEmpty(strSQL[2]) == false)
                {
                    strSQL[2] += " AND "; strSQL[3] += " AND ";
                }
                strSQL[2] += string.Format("B1.N501B_HINMC LIKE '%{0}%' ", MA_HS.Text.Trim());
                strSQL[3] += string.Format("B2.N502B_HINMC LIKE '%{0}%' ", MA_HS.Text.Trim());
            }

            //TÊN HÀNG
            if (string.IsNullOrEmpty(TEN_HANG.Text.Trim()) == false)
            {
                if (string.IsNullOrEmpty(strSQL[2]) == false)
                {
                    strSQL[2] += " AND "; strSQL[3] += " AND ";
                }
               // strSQL[2] += string.Format("B1.N501B_HINME  LIKE (N'%{0}%') ", TEN_HANG.Text.Trim());
               // strSQL[3] += string.Format("B2.N502B_HINME  LIKE (N'%{0}%') ", TEN_HANG.Text.Trim());
                //UPPER(supplier_name) LIKE UPPER('test%')
                strSQL[2] += string.Format("UPPER(B1.N501B_HINME)  LIKE UPPER('%{0}%') ", TEN_HANG.Text.Trim());
                strSQL[3] += string.Format("UPPER(B2.N502B_HINME)  LIKE UPPER('%{0}%') ", TEN_HANG.Text.Trim());
            }

            return strSQL;
        }

        private string TạoTruyVấn(string[] strWhere)
        {
            //string strSQL = "SELECT V1.* FROM (" + t.Properties.Resources.MVIEW1_TOKHAIMD + ") V1 WHERE {0}";
            //string strSQL = "SELECT * FROM A501A WHERE {0}";

            if (strWhere.Length >= 4)//where co thong tin hang
            {
                string strSQL = t.Properties.Resources.MVIEW1_TOKHAIMD2_HANG;
                return string.Format(strSQL, Resources.N501A_FIELDS, strWhere[0],
                                          Resources.N502A_FIELDS, strWhere[1],
                                            Resources.HANG_FIELDS,
                                            Resources.N501B_FIELDS,
                                            Resources.N502B_FIELDS,
                                            Resources.V1_FIELDS,
                                           strWhere[2],
                                           strWhere[3]);
               
            }
            else //where khong co thong tin hang
            {
                string strSQL = t.Properties.Resources.MVIEW1_TOKHAIMD2;
                return string.Format(strSQL, Resources.N501A_FIELDS, strWhere[0],
                                             Resources.N502A_FIELDS, strWhere[1],
                                               Resources.HANG_FIELDS,
                                               Resources.N501B_FIELDS,
                                               Resources.N502B_FIELDS);
            }
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
                MA_CC.Text = string.Empty;
                TEN_CC.DataSource = Global.dsCHICUC.Tables[0];
                TEN_CC.DataBind();
                return;
            }
            try
            {
                TEN_CUCHQ.SelectedValue = MA_CUCHQ.Text.Trim().ToUpper();
                MA_CUCHQ.Text = MA_CUCHQ.Text.Trim().ToUpper();
                MA_CC.Text = string.Empty;
                TEN_CUCHQ_SelectedIndexChanged(null, null);
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                MA_CUCHQ.Text = string.Empty;
                MA_CC.Text = string.Empty;
                TEN_CUCHQ.SelectedIndex = 0;
            }
        }

        protected void TEN_CUCHQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TEN_CUCHQ.SelectedValue == null)
            {
                TEN_CUCHQ.SelectedIndex = 0;
                MA_CUCHQ.Text = string.Empty;
                TEN_CC.DataSource = Global.dsCHICUC.Tables[0];
                TEN_CC.DataBind();
                MA_CC.Text = string.Empty;
                return;
            }
            if (string.IsNullOrEmpty(TEN_CUCHQ.SelectedValue.ToString()) == true)
            {
                TEN_CUCHQ.SelectedIndex = 0;
                MA_CUCHQ.Text = string.Empty;
                TEN_CC.DataSource = Global.dsCHICUC.Tables[0];
                TEN_CC.DataBind();
                MA_CC.Text = string.Empty;
                return;
            }
            MA_CUCHQ.Text = TEN_CUCHQ.SelectedValue.ToString().ToUpper();
            MA_CC.Text = string.Empty;
           DataRow[] dr = Global.dsCHICUC.Tables[0].Select(string.Format("MA_CUC='{0}'",MA_CUCHQ.Text));
           DataRow fRow = Global.dsCHICUC.Tables[0].NewRow();
           fRow[0] = ""; fRow[1] = ""; fRow[2] = "";
           List<DataRow> l = new List<DataRow>();
           l.Add(fRow);
           l.AddRange(dr);
           TEN_CC.DataSource = l.ToArray();
            TEN_CC.DataBind();
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
                using (tDBContext mainDB = new tDBContext(st.sqlSTRINGADO_DONVI))
                {
                    HQ_SDONVI dv = mainDB.HQ_SDONVIs.GetObject(string.Format("MA_DV='{0}'", MA_DONVI.Text));
                    if (dv == null)
                    {
                        MA_DONVI.Text = string.Empty;
                        TEN_DONVI.Text = string.Empty;
                    }
                    //TEN_DONVI.Text =   dv.TEN_DV;
                    string s=dv.TEN_DV;
                   // vnConvert a = new vnConvert();
                    ConvertDB.ConvertFont a = new ConvertDB.ConvertFont();
                    a.Convert(ref s, ConvertDB.FontIndex.iTCV, ConvertDB.FontIndex.iUNI);
                    TEN_DONVI.Text = s;
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