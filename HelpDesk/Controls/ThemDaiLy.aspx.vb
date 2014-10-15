Imports System
Imports System.Web
Imports System.Data
Imports System.Data.OleDb
Imports Oracle.DataAccess
Imports Oracle.DataAccess.Client
Imports Microsoft.VisualBasic
Partial Public Class ThemDaiLy
    Inherits System.Web.UI.Page
    Public t2c As String = ""
    Public connect As String = ""
    Public Urrcore As String = ""

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Request.IsAuthenticated = False Then
            Response.Redirect("~/Default.aspx")
        End If
    End Sub
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim ds As New DataSet
        ds = Danhsach()
        If ds.Tables(0).Rows.Count > 0 Then
            'Update lai de sang vnaccs
            Update()
        Else
            ' check trong t2c
            'Chua lam
            '
            PMsgBox("Không có thông tin mã số thuế này, yêu cầu dungnq kiểm tra")
        End If
    End Sub
    Public Sub KiemtraDN_T2C()

    End Sub
    Public Sub Update()
        Dim conn As New OracleConnection(Urrcore)
        conn.Open()
        Dim sql As String = "update a017a set a017A_vn_da_truyen=0,a017A_vn_is_dong_bo_vnaccs=1 where A017a_Yusnyu_Cd = '" + TextBox1.Text.Trim + "'"
        'OracleHelper.ExecuteNonQuery(t2c, CommandType.StoredProcedure, _
        '                    "CCK_TTVandon_UpdateNhap", _
        '                      OracleHelper.CreateParameter("@Id_ct", SqlDbType.VarChar, IIf(Id_ct.Trim = "", DBNull.Value, Id_ct)), _
        '                      OracleHelper.CreateParameter("@Stt", SqlDbType.VarChar, Stt))
        OracleHelper.ExecuteNonQuery(conn, CommandType.Text, sql)
        PMsgBox("Cập nhật thành công, thông báo doanh nghiệp 2 tiếng nữa khai lại nhé")
    End Sub
    Public Function Danhsach() As DataSet
        Dim conn As New OracleConnection(Urrcore)
        conn.Open()
        Dim sql As String = "select * FROM  a017a where A017A_YUSNYU_CD='" + TextBox1.Text.Trim + "'"
        'sql = ((sql & " INNER join  VNACCS_URR_CORE.A061A on VNACCS_URR_CORE.A001A.A001A_RIYOU_CD=VNACCS_URR_CORE.A061A.A061A_RIYOU_CD") & " WHERE A001A_YUSNYUZ_CD='" & Me.TextBox1.Text.Trim.ToString & "'")
        Dim ds As New DataSet
        Return OracleHelper.ExecuteSql(conn, sql)
    End Function
    Public Sub PMsgBox(ByVal Message As String)
        System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=""JavaScript"">" & vbCrLf)

        System.Web.HttpContext.Current.Response.Write("alert(""" & Message & """)" & vbCrLf)

        System.Web.HttpContext.Current.Response.Write("</SCRIPT>")
    End Sub

End Class
