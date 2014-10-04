Public Class Dashboard
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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