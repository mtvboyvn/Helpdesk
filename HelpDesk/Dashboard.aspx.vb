Public Class Dashboard
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(sender As Object, e As EventArgs) Handles Me.Init
        Dim txt As TextBox = Me.Master.FindControl("txtTimKiem")
        If txt IsNot Nothing Then
            'txt.Text = Me.Request.QueryString("Q")
            Page.SetFocus(txt)
            txt.Focus()
        End If

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If IsPostBack = True Then
            Return
        End If

        Dim txt As TextBox = Me.Master.FindControl("txtTimKiem")
        If txt IsNot Nothing Then
            txt.Text = Me.Request.QueryString("Q")
            'ScriptManager.RegisterClientScriptBlock(Me, Me.GetType(), "txtTimKiem", "$get('" + txt.ClientID + "').focus();$get('" + txt.ClientID + "').select();", True)
            'Page.SetFocus(txt)
        End If
        SearchNay()

    End Sub
    Private Sub SearchNay()

        Using mainDB As New t.tDBContext
            Dim l As List(Of t.CAUHOI) = mainDB.CAUHOIs.GetListObject("")
            For Each i In l
                Dim c As SearchItem = Me.LoadControl("~/Controls/SearchItem.ascx")
                c.CauHoi = i.CH_CAUHOI_NOIDUNGCAUHOI
                divSearch.Controls.Add(c)
            Next
        End Using
    End Sub

End Class