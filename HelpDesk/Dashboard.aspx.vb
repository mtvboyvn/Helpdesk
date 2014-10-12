Public Class Dashboard
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(sender As Object, e As EventArgs) Handles Me.Init
        Dim txt As TextBox = Me.Master.FindControl("myTextBox")
        If txt IsNot Nothing Then
            'txt.Text = Me.Request.QueryString("Q")
            Page.SetFocus(txt)
            txt.Focus()
        End If

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'For Each c In divSearch.Controls
        '    divSearch.Controls.Remove(c)
        'Next
        'divSearch.Controls.Clear()
        If IsPostBack = True Then
            Return
        End If

        Dim txt As TextBox = Me.Master.FindControl("myTextBox")
        If txt IsNot Nothing Then
            txt.Text = Me.Request.QueryString("Q")
            'ScriptManager.RegisterClientScriptBlock(Me, Me.GetType(), "txtTimKiem", "$get('" + txt.ClientID + "').focus();$get('" + txt.ClientID + "').select();", True)
            'Page.SetFocus(txt)
            If String.IsNullOrEmpty(txt.Text) = False Then
                SearchNay(txt.Text)
                Return
            End If
            SelectTop100()
        End If


    End Sub
    Private Sub SearchNay(ByVal strSearch As String)
        Dim sb As New StringBuilder
        sb.Append("SELECT A.[KEY], A.[RANK] , B.*  ")
        sb.AppendFormat("FROM FREETEXTTABLE([CAUHOI],[CH_FULLTEXT_SEARCH],'{0}') AS A ", strSearch.Replace("'", ""))
        sb.Append("INNER JOIN [CAUHOI] AS B ON B.[CH_ID]=A.[KEY] ")
        sb.Append("ORDER BY A.[RANK] DESC")

        Dim ds As DataSet = t.clsDAL.GetDataSet(sb.ToString())
        If ds Is Nothing Then
            ListView1.DataSource = Nothing
            ListView1.DataBind()
            Return
        End If
        If ds.Tables.Count < 1 Then
            ListView1.DataSource = Nothing
            ListView1.DataBind()
            Return
        End If
        If ds.Tables(0).Rows.Count < 1 Then
            ListView1.DataSource = Nothing
            ListView1.DataBind()
            Return
        End If
     
        ListView1.DataSource = ds.Tables(0)
        ListView1.DataBind()
        lblMSG.Text = String.Format("{0} kết quả trong vòng 0.0000000000268 giây", ds.Tables(0).Rows.Count)
    End Sub

    Private Sub SelectTop100()
        Try
            Using mainDB As New t.tDBContext
                'Dim l As New List(Of t.CAUHOI)                
                Dim dt100 As DataTable = mainDB.CAUHOIs.GetList("TOP 100 *", "", "CH_CAUHOI_NGAYHOI DESC")
                ' l = t.clsAll.DataTable2ListObjects(Of t.CAUHOI)(dt100)           
                ListView1.DataSource = dt100
                ListView1.DataBind()
            End Using
            lblMSG.Text = "100 câu hỏi mới nhất"
            lblError.Visible = False
            lblError.Text = ""
        Catch ex As Exception
            lblMSG.Text = "Máy chủ dữ liệu tạm ngừng phục vụ"
            lblError.Text = String.Format("{0}", ex.Message)
            lblError.Visible = True
        End Try
    End Sub

End Class