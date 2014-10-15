Imports System.Threading

Public Class ServicesMonitoring
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Thread.Sleep(2000)
        lblUpdate.Text = String.Format("Refresh at: {0}", DateTime.Now)
        Using mainDB As New t.tDBContext(t.st.sqlSTRINGADO_MONITORING)
            Dim d As DataTable = mainDB.V1_SERVICES_MONITORINGs.GetList("")
            GridView1.DataSource = d
            GridView1.DataBind()
        End Using

    End Sub
End Class