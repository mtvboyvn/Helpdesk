
Imports System
Imports System.Data
Imports System.Data.OleDb
Imports Oracle.DataAccess
Imports Oracle.DataAccess.Client

Partial Public Class TaiKhoanquantri
    Inherits System.Web.UI.UserControl
    Public t2c As String = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.224.176.10)(PORT=1521))(CONNECT_DATA=(SERVER=dedicated)(SERVICE_NAME=thqdn)));User ID=thq;Password=cgetvnrcntndnt; Persist Security Info=True"
    Public connect As String = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.224.133.100)(PORT=1521))(CONNECT_DATA=(SERVER=dedicated)(SERVICE_NAME=VNACCSORA_EX)));User ID=ECUSTOMS_COREDB;Password=ECUSTOMS_COREDB; Persist Security Info=True"
    Public Urrcore As String = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=tchq-scan.tongcuc.haiquan.vn)(PORT=1521))(CONNECT_DATA=(SERVER=dedicated)(SERVICE_NAME=VNACCSORA_EX)));User ID=VNACCS_URR_Core;Password=VNACCS_URR_Core; Persist Security Info=True"


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim ds As New DataSet
        Dim ds1 As New DataSet
        ds = Danhsach()
        ds1 = Danhsach1()
        If ds.Tables(0).Rows.Count > 0 Then
            'Kiem tra xem co trong vnaccs_ttc_payer
            If ds1.Tables(0).Rows.Count = 0 Then
                'Insert
                Insert()
            Else
                'update lai
                Update()
            End If
        Else
            PMsgBox("Không có thông tin mã số thuế này bên tổng cục thuế")
        End If
    End Sub
    Public Sub Insert()
        Dim conn As New OracleConnection(t2c)
        conn.Open()
        Dim sql As String = "insert into VNACCS_TTC_PAYER (tin,trackingid,lastdate) values('" + TextBox1.Text.Trim + "', VNACCS_TTC_PAYER_SEQ.nextval,sysdate);"
        OracleHelper.ExecuteNonQuery(conn, CommandType.Text, sql)
    End Sub
    Public Sub Update()
        Dim conn As New OracleConnection(t2c)
        conn.Open()
        Dim sql As String = "update VNACCS_TTC_PAYER set trackingid = VNACCS_TTC_PAYER_SEQ.nextval,lastdate = sysdate where tin = '" + TextBox1.Text.Trim + "'"
        'OracleHelper.ExecuteNonQuery(t2c, CommandType.StoredProcedure, _
        '                    "CCK_TTVandon_UpdateNhap", _
        '                      OracleHelper.CreateParameter("@Id_ct", SqlDbType.VarChar, IIf(Id_ct.Trim = "", DBNull.Value, Id_ct)), _
        '                      OracleHelper.CreateParameter("@Stt", SqlDbType.VarChar, Stt))
        OracleHelper.ExecuteNonQuery(conn, CommandType.Text, sql)
        PMsgBox("Cập nhật thành công, thông báo doanh nghiệp 2 tiếng nữa đăng ký tài khoản lại nhé")
    End Sub
    Public Function Danhsach() As DataSet
        Dim conn As New OracleConnection(t2c)
        conn.Open()
        Dim sql As String = "select * FROM  ttc_payer where tin='" + TextBox1.Text.Trim + "'"
        Dim ds As New DataSet
        Return OracleHelper.ExecuteSql(conn, sql)
    End Function
    Public Function Danhsach1() As DataSet
        Dim conn As New OracleConnection(t2c)
        conn.Open()
        Dim sql As String = "select * FROM  vnaccs_ttc_payer where tin='" + TextBox1.Text.Trim + "'"
        Dim ds As New DataSet
        Return OracleHelper.ExecuteSql(conn, sql)
    End Function
    Public Sub PMsgBox(ByVal Message As String)
        HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=""JavaScript"">" & ChrW(13) & ChrW(10))
        HttpContext.Current.Response.Write(("alert(""" & Message & """)" & ChrW(13) & ChrW(10)))
        HttpContext.Current.Response.Write("</SCRIPT>")
    End Sub
End Class