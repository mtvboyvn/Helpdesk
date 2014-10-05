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
            If String.IsNullOrEmpty(txt.Text) = False Then
                SearchNay(txt.Text)
            End If

        End If


    End Sub
    Private Sub SearchNay(ByVal strSearch As String)
        Dim sb As New StringBuilder
        sb.Append("SELECT A.[KEY], A.[RANK] , B.*  ")
        sb.AppendFormat("FROM FREETEXTTABLE([CAUHOI],[CH_FULLTEXT_SEARCH],'{0}') AS A ", strSearch.Replace("'", ""))
        sb.Append("INNER JOIN [CAUHOI] AS B ON B.[CH_ID]=A.[KEY] ")
        sb.Append("ORDER BY A.[RANK] DESC")

        Dim ds As DataSet = t.clsDAL.GetDataSet(sb.ToString())
        Dim i As Integer = ds.Tables.Count

        'Using mainDB As New t.tDBContext
        '    Dim l As List(Of t.CAUHOI) = mainDB.CAUHOIs.GetListObject("")

        '    For Each i In l
        '        Dim c As SearchItem = Me.LoadControl("~/Controls/SearchItem.ascx")
        '        c.CauHoi = i.CH_CAUHOI_NOIDUNGCAUHOI
        '        divSearch.Controls.Add(c)
        '    Next
        'End Using
    End Sub

End Class