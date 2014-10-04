Public Class SearchItem
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblCauHoi.Text = Me.CauHoi
    End Sub

    Private _CauHoi As String = "Empty"
    Public Property CauHoi As String
        Get
            Return _CauHoi
        End Get
        Set(ByVal value As String)
            _CauHoi = value
        End Set
    End Property
End Class