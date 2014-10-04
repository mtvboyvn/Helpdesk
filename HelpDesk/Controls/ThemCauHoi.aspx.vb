Imports System
Imports System.Data
Imports System.Web


Partial Public Class ThemCauHoi
    Inherits System.Web.UI.Page
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If Request.IsAuthenticated = False Then
        '    Response.Redirect("~/Default.aspx")
        'End If
        t.clsAll.ClearDesignData(tblCauHoi, New t.CAUHOI)
    End Sub
    
    'Public Sub PMsgBox(ByVal Message As String)
    '    HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=""JavaScript"">" & (13) & (10))
    '    HttpContext.Current.Response.Write(("alert(""" & Message & """)" & (13) & (10)))
    '    HttpContext.Current.Response.Write("</SCRIPT>")
    'End Sub

    Protected Sub RadButton1_Click(sender As Object, e As EventArgs) Handles btnGhiDuLieu.Click

        Try
            Dim a As New t.CAUHOI
            t.clsAll.CopyData(tblCauHoi, a)
            Using mainDB As New t.tDBContext
                If a.CH_ID > 0 Then 'update data
                    mainDB.CAUHOIs.UpdateOnSubmit(a)
                Else 'insert data
                    Dim strMaxID As String = mainDB.CAUHOIs.Max("CH_ID")
                    If String.IsNullOrEmpty(strMaxID) = True Then strMaxID = "0"
                    Dim intMaxID As Integer = Convert.ToInt32(strMaxID) + 1
                    a.CH_ID = intMaxID
                    mainDB.CAUHOIs.InsertOnSubmit(a)
                End If
                mainDB.SubmitAllChange()
            End Using

            Dim s As String = String.Format("&nbsp;Ghi thành công lúc: {0:ss-mm-HH dd/MM/yyyy}&nbsp;", Date.Now)
            lblMSG1.Text = s
            lblMSG2.Text = s
        Catch ex As Exception
            lblMSG1.Text = String.Format("&nbsp;Có lỗi khi ghi dữ liệu. Nội dung lỗi {0}&nbsp;", ex.Message)
        End Try

    End Sub
End Class
