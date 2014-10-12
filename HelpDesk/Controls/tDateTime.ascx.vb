Public Class tDateTime
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Property DateValue As DateTime?
        Get
            If (String.IsNullOrEmpty(txtDateTimeInput.Text) = True) Then Return Nothing
            Dim returnValue As DateTime
            Dim isValid As Boolean = DateTime.TryParseExact(txtDateTimeInput.Text, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, returnValue)
            If isValid = False Then Return Nothing
            Return returnValue
        End Get
        Set(value As DateTime?)
            If value.HasValue = False Then
                txtDateTimeInput.Text = String.Empty
                Return
            End If
            txtDateTimeInput.Text = value.Value.ToString("dd/MM/yyyy")
        End Set
    End Property
End Class