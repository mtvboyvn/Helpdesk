Imports System
Imports System.Data
Imports System.Web


Partial Public Class ThemCauHoi
    Inherits System.Web.UI.Page
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If Request.IsAuthenticated = False Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub
    
    'Public Sub PMsgBox(ByVal Message As String)
    '    HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=""JavaScript"">" & (13) & (10))
    '    HttpContext.Current.Response.Write(("alert(""" & Message & """)" & (13) & (10)))
    '    HttpContext.Current.Response.Write("</SCRIPT>")
    'End Sub

    Protected Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Dim a As New t.CAUHOI
        a.CH_ID = 2
        Using mainDB As New t.tDBContext
            mainDB.CAUHOIs.InsertOnSubmit(a)
            mainDB.SubmitAllChange()
        End Using
    End Sub
End Class
