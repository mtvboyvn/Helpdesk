Imports System
Imports System.Data
Imports System.Data.OleDb
Imports Oracle.DataAccess
Imports Oracle.DataAccess.Client
Imports Microsoft.VisualBasic
Partial Public Class _Default
    Inherits System.Web.UI.Page
    Public t2c As String = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.224.176.10)(PORT=1521))(CONNECT_DATA=(SERVER=dedicated)(SERVICE_NAME=thqdn)));User ID=thq;Password=cgetvnrcntndnt; Persist Security Info=True"
    Public connect As String = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.224.133.100)(PORT=1521))(CONNECT_DATA=(SERVER=dedicated)(SERVICE_NAME=VNACCSORA_EX)));User ID=ECUSTOMS_COREDB;Password=ECUSTOMS_COREDB; Persist Security Info=True"
    Public Urrcore As String = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=tchq-scan.tongcuc.haiquan.vn)(PORT=1521))(CONNECT_DATA=(SERVER=dedicated)(SERVICE_NAME=VNACCSORA_EX)));User ID=VNACCS_URR_Core;Password=VNACCS_URR_Core; Persist Security Info=True"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim ds As New DataSet
        ds = Danhsach()
        Dim thongbao As String = ds.Tables(0).Rows(0).Item(0).ToString
        PMsgBox("Còn " + thongbao + " bản ghi chưa đẩy sang VNACCS")
    End Sub
    Public Function Danhsach() As DataSet
        Dim conn As New OracleConnection(Urrcore)
        conn.Open()
        Dim sql As String = "select count(*) from a017a  where a017A_vn_da_truyen=0 and a017A_vn_is_dong_bo_vnaccs=1"
        Return OracleHelper.ExecuteSql(conn, sql)
    End Function
    Public Sub PMsgBox(ByVal Message As String)
        System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=""JavaScript"">" & vbCrLf)
        System.Web.HttpContext.Current.Response.Write("alert(""" & Message & """)" & vbCrLf)
        System.Web.HttpContext.Current.Response.Write("</SCRIPT>")
    End Sub
End Class