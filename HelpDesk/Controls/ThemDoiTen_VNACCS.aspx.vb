Imports System
Imports System.Web
Imports System.Data
Imports System.Data.OleDb
Imports Oracle.DataAccess
Imports Oracle.DataAccess.Client
Imports Microsoft.VisualBasic
Partial Public Class ThemDoiTen_VNACCS
    Inherits System.Web.UI.Page
    Public t2c As String = ""
    Public connect As String = ""
    Public Urrcore As String = ""

    Public ConnectSql As String = ""

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox1.TextChanged
        'oracle
        'Dim dt As DataTable
        'Dim sql2 As String = "select norm_name FROM  ttc_payer where tin='" + TextBox1.Text.Trim + "'"
        'dt = Oracle.LayDuLieu(t2c, sql2)
        'Dim convert As ConvertFont = New ConvertFont()
        'Label1.Text = (dt.Rows(0).Item(0).ToString)
        'convert.Convert(Label1.Text, FontIndex.iUTF, FontIndex.iUNI)

        'Sql
        Dim ten_dv As String
        Dim dia_chi As String
        Dim sql As String = "select ten_dv,diachi FROM  hq_sdonvi where ma_dv='" + TextBox1.Text.Trim + "'"
        'Dim obj As New Object
        'obj = SqlHelper.ExecuteScalar(ConnectSql, CommandType.Text, sql)
        'If obj Is Nothing Then
        '    Label1.Text = "Không có mã số thuế này"
        'Else
        '    ten_dv = obj.ToString
        '    Label1.Text = TcvntoUnicode(ten_dv)
        '    TextBox1.Enabled = False
        'End If

        Dim ds As New DataSet
        ds = SqlHelper.ExecuteDataset(ConnectSql, CommandType.Text, sql)
        If ds.Tables(0).Rows.Count = 0 Then
            Label1.Text = "Không có mã số thuế này"
        Else
            ten_dv = ds.Tables(0).Rows(0).Item(0).ToString
            dia_chi = ds.Tables(0).Rows(0).Item(1).ToString
            Label1.Text = TcvntoUnicode(ten_dv)
            Label4.Text = TcvntoUnicode(dia_chi)
            TextBox1.Enabled = False
        End If




        'oracle
        Dim conn As New OracleConnection(Urrcore)
        conn.Open()
        Dim ds1 As New DataSet
        Dim sql1 As String = "select A017A_YUSNYU_NM,A017A_YUSNYU_ADDR FROM  a017a where A017A_YUSNYU_CD='" + TextBox1.Text.Trim + "'"
        ds1 = OracleHelper.ExecuteSql(conn, sql1)
        If ds1.Tables(0).Rows.Count > 0 Then
            Label6.Text = ds1.Tables(0).Rows(0).Item(0).ToString
            Label8.Text = ds1.Tables(0).Rows(0).Item(1).ToString
        End If
        ''

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim ds As New DataSet
        'ds = Danhsach()
        If Label1.Text <> "Không có mã số thuế này" Then
            'Update lai de sang vnaccs
            Update_Tendv()
        Else
            PMsgBox("Không có thông tin mã số thuế này, yêu cầu dungnq kiểm tra")
        End If
    End Sub
    Public Sub Update_Tendv()
        'Dim conn As New OracleConnection(Urrcore)
        'conn.Open()
        'Dim sql As String = "update a017a set A017A_YUSNYU_NM='" + Label1.Text.Trim + "',a017A_vn_da_truyen=0,a017A_vn_is_dong_bo_vnaccs=1 where A017a_Yusnyu_Cd = '" + TextBox1.Text.Trim + "'"
        ''OracleHelper.ExecuteNonQuery(t2c, CommandType.StoredProcedure, _
        ''                    "CCK_TTVandon_UpdateNhap", _
        ''                      OracleHelper.CreateParameter("@Id_ct", SqlDbType.VarChar, IIf(Id_ct.Trim = "", DBNull.Value, Id_ct)), _
        ''                      OracleHelper.CreateParameter("@Stt", SqlDbType.VarChar, Stt))
        'OracleHelper.ExecuteNonQuery(conn, CommandType.Text, sql)
        'PMsgBox("Cập nhật thành công")


        Dim conn As New OracleConnection(Urrcore)
        conn.Open()
        Dim sql As String = "update a017a set A017A_YUSNYU_NM='" + Label1.Text.Trim + "',a017A_vn_da_truyen=0,a017A_vn_is_dong_bo_vnaccs=1 where A017a_Yusnyu_Cd = '" + TextBox1.Text.Trim + "'"
        OracleHelper.ExecuteNonQuery(conn, CommandType.Text, sql)
        PMsgBox("Cập nhật thành công")
    End Sub
    Public Sub Update_Diachi()
        Dim conn As New OracleConnection(Urrcore)
        conn.Open()
        Dim sql As String = "update a017a set A017A_YUSNYU_ADDR='" + Label4.Text.Trim + "',a017A_vn_da_truyen=0,a017A_vn_is_dong_bo_vnaccs=1 where A017a_Yusnyu_Cd = '" + TextBox1.Text.Trim + "'"
        OracleHelper.ExecuteNonQuery(conn, CommandType.Text, sql)
        PMsgBox("Cập nhật thành công")
    End Sub
    'Public Function Danhsach() As DataSet
    '    Dim conn As New OracleConnection(t2c)
    '    conn.Open()
    '    Dim sql As String = "select norm_name FROM  ttc_payer where tin='" + TextBox1.Text.Trim + "'"
    '    'Return OracleHelper.ExecuteSql(conn, sql)
    '    Return
    'End Function
    Public Sub PMsgBox(ByVal Message As String)
        HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=""JavaScript"">" & (13) & (10))
        HttpContext.Current.Response.Write(("alert(""" & Message & """)" & (13) & (10)))
        HttpContext.Current.Response.Write("</SCRIPT>")
    End Sub



    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Dim ds As New DataSet
        'ds = Danhsach()
        If Label1.Text <> "Không có mã số thuế này" Then
            'Update lai de sang vnaccs
            Update_Diachi()
        Else
            PMsgBox("Không có thông tin mã số thuế này, yêu cầu dungnq kiểm tra")
        End If
    End Sub

    Protected Sub LinkButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton3.Click
        Response.Redirect("./default.aspx")
    End Sub
    Public Shared Function TcvntoUnicode(ByVal strTCVN As String) As String
        Dim strManp As New StringBuilder(strTCVN)

        Dim TCVN_char As Char() = New Char() {"ü"c, "û"c, "þ"c, "ú"c, "ù"c, "÷"c, _
        "ö"c, "õ"c, "ø"c, "ñ"c, "ô"c, "î"c, _
        "ì"c, "ë"c, "ê"c, "í"c, "é"c, "ç"c, _
        "æ"c, "å"c, "è"c, "á"c, "ä"c, "Þ"c, _
        "Ø"c, "Ö"c, "Ô"c, "Ó"c, "Ò"c, "Õ"c, _
        "Ï"c, "Î"c, "Ñ"c, "Æ"c, "½"c, "¼"c, _
        "«"c, "¾"c, "Ë"c, "É"c, "È"c, "Ç"c, _
        "Ê"c, "¶"c, "¹"c, "­"c, "¦"c, "¬"c, _
        "¥"c, "ò"c, "Ü"c, "®"c, "¨"c, "¡"c, _
        "ó"c, "ï"c, "â"c, "»"c, "ã"c, "ß"c, _
        "Ý"c, "×"c, "ª"c, "Ð"c, "Ì"c, "·"c, _
        "©"c, "¸"c, "µ"c, "¤"c, "§"c, "£"c, _
        "¢"c}
        Dim Unicode_char As Char() = New Char() {"ỹ"c, "ỷ"c, "ỵ"c, "ỳ"c, "ự"c, "ữ"c, _
        "ử"c, "ừ"c, "ứ"c, "ủ"c, "ụ"c, "ợ"c, _
        "ỡ"c, "ở"c, "ờ"c, "ớ"c, "ộ"c, "ỗ"c, _
        "ổ"c, "ồ"c, "ố"c, "ỏ"c, "ọ"c, "ị"c, _
        "ỉ"c, "ệ"c, "ễ"c, "ể"c, "ề"c, "ế"c, _
        "ẽ"c, "ẻ"c, "ẹ"c, "ặ"c, "ẵ"c, "ẳ"c, _
        "ô"c, "ắ"c, "ậ"c, "ẫ"c, "ẩ"c, "ầ"c, _
        "ấ"c, "ả"c, "ạ"c, "ư"c, "Ư"c, "ơ"c, _
        "Ơ"c, "ũ"c, "ĩ"c, "đ"c, "ă"c, "Ă"c, _
        "ú"c, "ù"c, "õ"c, "ằ"c, "ó"c, "ò"c, _
        "í"c, "ì"c, "ê"c, "é"c, "è"c, "ã"c, _
        "â"c, "á"c, "à"c, "Ô"c, "Đ"c, "Ê"c, _
        "Â"c}

        For i As Integer = 0 To TCVN_char.Length - 1
            strManp = strManp.Replace(TCVN_char(i), Unicode_char(i))
        Next

        Dim TCVN_cap As String() = New String() {"Aà", "Aả", "Aã", "Aá", "Aạ", "Eè", _
        "Eẻ", "Eẽ", "Eé", "Eẹ", "Iì", "Iỉ", _
        "Iĩ", "Ií", "Iị", "Oò", "Oỏ", "Oõ", _
        "Oó", "Oọ", "Uù", "Uủ", "Uũ", "Uú", _
        "Uụ", "Yỳ", "Yỷ", "Yỹ", "Yý", "Yỵ", _
        "Ăằ", "Ăẳ", "Ăẵ", "Ăắ", "Ăặ", "Âầ", _
        "Âẩ", "Âẫ", "Âấ", "Âậ", "Êề", "Êể", _
        "Êễ", "Êế", "Êệ", "Ôồ", "Ôổ", "Ôỗ", _
        "Ôố", "Ôộ", "Ơờ", "Ơở", "Ơỡ", "Ơớ", _
        "Ơợ", "Ưừ", "Ưử", "Ưữ", "Ưứ", "Ưự"}
        Dim Unicode_cap As String() = New String() {"À", "Ả", "Ã", "Á", "Ạ", "È", _
        "Ẻ", "Ẽ", "É", "Ẹ", "Ì", "Ỉ", _
        "Ĩ", "Í", "Ị", "Ò", "Ỏ", "Õ", _
        "Ó", "Ọ", "Ù", "Ủ", "Ũ", "Ú", _
        "Ụ", "Ỳ", "Ỷ", "Ỹ", "Ý", "Ỵ", _
        "Ằ", "Ẳ", "Ẵ", "Ắ", "Ặ", "Ầ", _
        "Ẩ", "Ẫ", "Ấ", "Ậ", "Ề", "Ể", _
        "Ễ", "Ế", "Ệ", "Ồ", "Ổ", "Ỗ", _
        "Ố", "Ộ", "Ờ", "Ở", "Ỡ", "Ớ", _
        "Ợ", "Ừ", "Ử", "Ữ", "Ứ", "Ự"}

        For i As Integer = 0 To TCVN_cap.Length - 1
            strManp = strManp.Replace(TCVN_cap(i), Unicode_cap(i))
        Next

        'return "No Data"; 
        Return strManp.ToString()
    End Function
End Class

