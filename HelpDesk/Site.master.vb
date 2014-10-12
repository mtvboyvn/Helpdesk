
Partial Class Site
    Inherits System.Web.UI.MasterPage


    Protected Sub Page_Init(sender As Object, e As EventArgs) Handles Me.Init
        'Page.SetFocus(txtTimKiem)
        'txtTimKiem.Focus()
    End Sub

    Protected Sub Page_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
        'txtTimKiem.Focus()
        'Page.SetFocus(txtTimKiem)
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        'txtTimKiem.Focus()
        'ScriptManager.RegisterClientScriptBlock(Me, Me.GetType(), "txtTimKiem", "$get('" + txtTimKiem.ClientID + "').focus();$get('" + txtTimKiem.ClientID + "').select();", True)
        'Page.SetFocus(txtTimKiem)
        btnDangNhap.Visible = Not My.User.IsAuthenticated
        lblUserName.Visible = Not btnDangNhap.Visible
    End Sub

    Protected Sub txtTimKiem_TextChanged(sender As Object, e As EventArgs) Handles myTextBox.TextChanged
        Response.Redirect(String.Format("~/Dashboard.aspx?q={0}", myTextBox.Text))
    End Sub
End Class

