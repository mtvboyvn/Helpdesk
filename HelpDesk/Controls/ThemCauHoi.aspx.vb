Imports System
Imports System.Data
Imports System.Web


Partial Public Class ThemCauHoi
    Inherits System.Web.UI.Page
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If Request.IsAuthenticated = False Then
        '    Response.Redirect("~/Default.aspx")
        'End If

        If IsPostBack = False Then
            t.clsAll.ClearDesignData(tblCauHoi, New t.CAUHOI)
        End If

        If IsPostBack = False Then
            Dim strCH_ID As String = Me.Request.QueryString("CH_ID")
            Dim intCH_ID As Integer = -1
            Integer.TryParse(strCH_ID, intCH_ID)
            If intCH_ID > 0 Then 'update data
                Using mainDB As New t.tDBContext
                    Dim ch As t.CAUHOI = mainDB.CAUHOIs.GetObject(String.Format("CH_ID={0}", intCH_ID))
                    If ch IsNot Nothing Then
                        t.clsAll.BindData(ch, tblCauHoi)
                        Me.BindData(ch, tblCauHoi)
                        CH_ID.Value = intCH_ID
                    End If
                End Using
            Else 'insert data

            End If
        End If

    End Sub

    Protected Sub RadButton1_Click(sender As Object, e As EventArgs) Handles btnGhiDuLieu.Click, RadButton1.Click
        Try
            Dim a As New t.CAUHOI
            t.clsAll.CopyData(tblCauHoi, a)
            Me.CopyData(tblCauHoi, a)
            If String.IsNullOrEmpty(a.CH_CAUHOI_NOIDUNGTRALOI) = False Then
                a.CH_CAUHOI_NGAYTRALOI = Date.Now
            End If
            Dim strFull As String = t.clsAll.CombineProperty(a)
            a.CH_FULLTEXT_SEARCH = strFull + " " + t.clsAll.LoaiBoDau(strFull)
            Using mainDB As New t.tDBContext
                If a.CH_ID > 0 Then 'update data
                    'Cần xử lý thêm xem có thay đổi câu hỏi với DB hay ko nữa thì sẽ set lại ngày trả lời
                    mainDB.CAUHOIs.UpdateOnSubmit(a)
                Else 'insert data
                    Dim strMaxID As String = mainDB.CAUHOIs.Max("CH_ID")
                    If String.IsNullOrEmpty(strMaxID) = True Then strMaxID = "0"
                    Dim intMaxID As Integer = Convert.ToInt32(strMaxID) + 1
                    a.CH_ID = intMaxID
                    CH_ID.Value = a.CH_ID
                    a.CH_CAUHOI_NGAYHOI = Date.Now
                    mainDB.CAUHOIs.InsertOnSubmit(a)
                End If
                mainDB.SubmitAllChange()
            End Using

            Dim s As String = String.Format("&nbsp;Ghi thành công lúc: {0:ss-mm-HH dd/MM/yyyy}&nbsp;", Date.Now)
            lblMSG1.Text = s
            lblMSG2.Text = s
        Catch ex As Exception
            lblMSG1.Text = String.Format("&nbsp;Có lỗi khi ghi dữ liệu. Nội dung lỗi {0}&nbsp;", ex.Message)
        End Try

    End Sub

    Protected Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click, btnNhapMoi.Click
        t.clsAll.ClearDesignData(tblCauHoi, New t.CAUHOI)
    End Sub

    'Copy data riêng cho một số trường hợp đặc biệt
    Private Sub CopyData(ByVal tblCauHoi As HtmlTable, ByRef ch As t.CAUHOI)

        'Đối tượng hỏi
        ch.CH_DOITUONGHOI = CH_DOITUONGHOI1.Text
        If CH_DOITUONGHOI2.Checked = True Then
            ch.CH_DOITUONGHOI = CH_DOITUONGHOI2.Text
        End If

        'Phân loại câu hỏi
        ch.CH_CAUHOI_PHANLOAI = CH_CAUHOI_PHANLOAI1.Text
        If CH_CAUHOI_PHANLOAI2.Checked = True Then
            ch.CH_CAUHOI_PHANLOAI = CH_CAUHOI_PHANLOAI2.Text
        End If
        If CH_CAUHOI_PHANLOAI3.Checked = True Then
            ch.CH_CAUHOI_PHANLOAI = CH_CAUHOI_PHANLOAI3.Text
        End If
        If CH_CAUHOI_PHANLOAI4.Checked = True Then
            ch.CH_CAUHOI_PHANLOAI = CH_CAUHOI_PHANLOAI4.Text
        End If
        If CH_CAUHOI_PHANLOAI5.Checked = True Then
            ch.CH_CAUHOI_PHANLOAI = CH_CAUHOI_PHANLOAI5.Text
        End If
        If CH_CAUHOI_PHANLOAI6.Checked = True Then
            ch.CH_CAUHOI_PHANLOAI = CH_CAUHOI_PHANLOAI6.Text
        End If
        If CH_CAUHOI_PHANLOAI7.Checked = True Then
            ch.CH_CAUHOI_PHANLOAI = CH_CAUHOI_PHANLOAI7.Text
        End If

        'Tạo trường dữ liệu để search

    End Sub

    'Bind data riêng cho một số trường hợp đặc biệt
    Private Sub BindData(ByVal ch As t.CAUHOI, ByVal tblCauHoi As HtmlTable)

        'Đối tượng hỏi
        CH_DOITUONGHOI1.Checked = True
        If CH_DOITUONGHOI2.Text.Equals(ch.CH_DOITUONGHOI) = True Then
            CH_DOITUONGHOI2.Checked = True
        End If

        'Phân loại câu hỏi
        CH_CAUHOI_PHANLOAI1.Checked = True
        If CH_CAUHOI_PHANLOAI2.Text.Equals(ch.CH_CAUHOI_PHANLOAI) = True Then
            CH_CAUHOI_PHANLOAI2.Checked = True
        End If
        If CH_CAUHOI_PHANLOAI3.Text.Equals(ch.CH_CAUHOI_PHANLOAI) = True Then
            CH_CAUHOI_PHANLOAI3.Checked = True
        End If
        If CH_CAUHOI_PHANLOAI4.Text.Equals(ch.CH_CAUHOI_PHANLOAI) = True Then
            CH_CAUHOI_PHANLOAI4.Checked = True
        End If
        If CH_CAUHOI_PHANLOAI5.Text.Equals(ch.CH_CAUHOI_PHANLOAI) = True Then
            CH_CAUHOI_PHANLOAI5.Checked = True
        End If
        If CH_CAUHOI_PHANLOAI6.Text.Equals(ch.CH_CAUHOI_PHANLOAI) = True Then
            CH_CAUHOI_PHANLOAI6.Checked = True
        End If
        If CH_CAUHOI_PHANLOAI7.Text.Equals(ch.CH_CAUHOI_PHANLOAI) = True Then
            CH_CAUHOI_PHANLOAI7.Checked = True
        End If
    End Sub
End Class
