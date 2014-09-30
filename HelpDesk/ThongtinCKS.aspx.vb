Imports System
Imports System.Data
Imports System.Data.OleDb
Imports Oracle.DataAccess
Imports Oracle.DataAccess.Client
Partial Public Class ThongtinCKS
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim connect As String = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.224.133.100)(PORT=1521))(CONNECT_DATA=(SERVER=dedicated)(SERVICE_NAME=VNACCSORA_EX)));User ID=ECUSTOMS_COREDB;Password=ECUSTOMS_COREDB; Persist Security Info=True"
        Dim conn As New OracleConnection(connect)
        conn.Open()
        Dim ds2 As New DataSet
        Dim sql1 As String = ("SELECT * From VNACCS_URR_CORE.A017A  WHERE VNACCS_URR_CORE.A017A.A017A_YUSNYU_CD = '" & Me.TextBox1.Text.Trim.ToString & "'")
        If (OracleHelper.ExecuteDataset(connect, 1, sql1).Tables.Item(0).Rows.Count = 0) Then
            Me.PMsgBox("Kh" & (244) & "ng c" & (243) & " th" & (244) & "ng tin " & (273) & (417) & "n v" & (7883) & " n" & (224) & "y trong C" & (417) & " s" & (7903) & " d" & (361) & " li" & (7879) & "u")
        ElseIf (Me.Danhsach.Tables.Item(0).Rows.Count = 0) Then
            Me.PMsgBox((272) & (417) & "n v" & (7883) & " n" & (224) & "y m" & (7899) & "i " & (273) & (259) & "ng k" & (253) & " t" & (224) & "i kho" & (7843) & "n qu" & (7843) & "n tr" & (7883) & ", ch" & (432) & "a " & (273) & (259) & "ng k" & (253) & " CKS")
        Else
            Dim ds As New DataSet
            Dim sql As String = "select A001A.A001A_YUSNYUZ_CD as Ma_DV,A017A.A017A_YUSNYU_NM as Ten_DV,A061A.A061A_CANM as Ten_Nha_Cung_Cap,A061A.A061A_SIRINO as Serial,VNACCS_URR_CORE.A042A.A042A_TRMID as TerminalID FROM  VNACCS_URR_CORE.A001A"
            sql = (((sql & " INNER join  VNACCS_URR_CORE.A061A on VNACCS_URR_CORE.A001A.A001A_RIYOU_CD=VNACCS_URR_CORE.A061A.A061A_RIYOU_CD" & " INNER join  VNACCS_URR_CORE.A017A on TRIM(VNACCS_URR_CORE.A001A.A001A_YUSNYUZ_CD)=TRIM(VNACCS_URR_CORE.A017A.A017A_YUSNYU_CD)") & " INNER join  VNACCS_URR_CORE.A004A on TRIM(VNACCS_URR_CORE.A001A.A001A_RIYOU_CD)=TRIM(VNACCS_URR_CORE.A004A.A004A_VN_RIYOU_CD)" & " INNER join  VNACCS_URR_CORE.A042A on TRIM(VNACCS_URR_CORE.A004A.A004A_TANNM)=TRIM(VNACCS_URR_CORE.A042A.A042A_TRMID)") & " WHERE A001A_YUSNYUZ_CD='" & Me.TextBox1.Text.Trim.ToString & "'")
            ds = OracleHelper.ExecuteSql(conn, sql)
            Me.GridView1.DataSource = ds
            Me.GridView1.DataBind()
        End If
    End Sub

    Public Function Danhsach() As DataSet
        Dim connect As String = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.224.133.100)(PORT=1521))(CONNECT_DATA=(SERVER=dedicated)(SERVICE_NAME=VNACCSORA_EX)));User ID=ECUSTOMS_COREDB;Password=ECUSTOMS_COREDB; Persist Security Info=True"
        Dim conn As New OracleConnection(connect)
        conn.Open()
        Dim sql As String = "select * FROM  VNACCS_URR_CORE.DN_ACCOUNT"
        'sql = ((sql & " INNER join  VNACCS_URR_CORE.A061A on VNACCS_URR_CORE.A001A.A001A_RIYOU_CD=VNACCS_URR_CORE.A061A.A061A_RIYOU_CD") & " WHERE A001A_YUSNYUZ_CD='" & Me.TextBox1.Text.Trim.ToString & "'")
        Dim ds As New DataSet
        Return OracleHelper.ExecuteSql(conn, sql)
    End Function

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Public Sub PMsgBox(ByVal Message As String)
        HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=""JavaScript"">" & (13) & (10))
        HttpContext.Current.Response.Write(("alert(""" & Message & """)" & (13) & (10)))
        HttpContext.Current.Response.Write("</SCRIPT>")
    End Sub
End Class