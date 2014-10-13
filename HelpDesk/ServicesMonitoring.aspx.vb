Imports System.Threading

Public Class ServicesMonitoring
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Thread.Sleep(2000)
        lblUpdate.Text = DateTime.Now.ToString()
    End Sub
End Class