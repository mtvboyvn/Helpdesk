Imports System.Reflection
Public Class clsAll
    Public Shared Sub CopyData(tblDetail As HtmlTable, outObj As Object)
        For Each i As PropertyInfo In outObj.[GetType]().GetProperties()
            'Xử lý datetime
            If i.PropertyType.FullName.Equals(GetType(DateTime).FullName) = True Or
                i.PropertyType.FullName.Equals(GetType(DateTime?).FullName) = True Then
                Dim txt As tDateTime = TryCast(tblDetail.FindControl(i.Name), tDateTime)
                If txt Is Nothing Then
                    Continue For
                End If
                i.SetValue(outObj, txt.DateValue, Nothing)
                Continue For
            End If

            If i.PropertyType.FullName.Equals(GetType(String).FullName) = True Then
                Dim txt As TextBox = TryCast(tblDetail.FindControl(i.Name), TextBox)
                If txt Is Nothing Then
                    'thử với CodeList
                    'CodeList cl = tblDetail.FindControl(i.Name) as CodeList;
                    'if (cl == null) continue;
                    'i.SetValue(outObj, cl.CODE, null);

                    'Thử với RadEditor
                    Dim ed As TextBox = TryCast(tblDetail.FindControl(i.Name), TextBox)
                    If ed Is Nothing Then
                        'Thử với HidenField
                        Dim hd As HiddenField = TryCast(tblDetail.FindControl(i.Name), HiddenField)
                        If hd Is Nothing Then
                            Continue For
                        End If
                        i.SetValue(outObj, hd.Value, Nothing)
                        Continue For
                    Else
                        'i.SetValue(outObj, ed.GetHtml(EditorStripHtmlOptions.None), null);
                        i.SetValue(outObj, ed.Text, Nothing)
                        Continue For
                    End If
                Else
                    i.SetValue(outObj, txt.Text, Nothing)
                    Continue For
                End If
                Continue For
            End If
            If i.PropertyType.FullName.Equals(GetType(Integer).FullName) = True Then
                'Thử với HidenField
                Dim hd As HiddenField = TryCast(tblDetail.FindControl(i.Name), HiddenField)
                If hd Is Nothing Then
                    Continue For
                End If
                If hd.Value Is Nothing Then
                    Continue For
                End If
                If String.IsNullOrEmpty(hd.Value) = True Then
                    Continue For
                End If
                Dim intValue As Integer = -1
                Dim tryP As Boolean = Integer.TryParse(hd.Value, intValue)
                If tryP = False Then
                    Continue For
                End If
                i.SetValue(outObj, intValue, Nothing)
                Continue For
            End If
            If i.PropertyType.FullName.Equals(GetType(Decimal).FullName) = True Then
                Dim txt As TextBox = TryCast(tblDetail.FindControl(i.Name), TextBox)
                If txt Is Nothing Then
                    Continue For
                End If
                Dim dm As Decimal = 0
                If Decimal.TryParse(txt.Text, dm) = True Then
                    i.SetValue(outObj, dm, Nothing)
                End If
                Continue For
            End If
        Next
    End Sub

    Public Shared Sub BindData(outObj As Object, tblDetail As HtmlTable)
        For Each i As PropertyInfo In outObj.[GetType]().GetProperties()
            'Xử lý với datetime
            If i.PropertyType.FullName.Equals(GetType(DateTime).FullName) = True Or
                i.PropertyType.FullName.Equals(GetType(DateTime?).FullName) = True Then
                Dim txt As tDateTime = TryCast(tblDetail.FindControl(i.Name), tDateTime)
                If txt Is Nothing Then
                    Continue For
                End If
                txt.DateValue = i.GetValue(outObj, Nothing)
                Continue For
            End If

            If i.PropertyType.FullName.Equals(GetType(String).FullName) = True Then
                Dim txt As TextBox = TryCast(tblDetail.FindControl(i.Name), TextBox)
                If txt Is Nothing Then
                    'thử với CodeList
                    'CodeList cl = tblDetail.FindControl(i.Name) as CodeList;
                    'if (cl == null) continue;
                    'i.SetValue(outObj, cl.CODE, null);

                    'Thử với RadEditor
                    Dim ed As TextBox = TryCast(tblDetail.FindControl(i.Name), TextBox)
                    If ed Is Nothing Then
                        'Thử với HidenField
                        Dim hd As HiddenField = TryCast(tblDetail.FindControl(i.Name), HiddenField)
                        If hd Is Nothing Then
                            Continue For
                        End If
                        hd.Value = String.Format("{0}", i.GetValue(outObj, Nothing))
                        Continue For
                    End If
                    ' i.SetValue(outObj, ed.Text, null);
                    ed.Text = String.Format("{0}", i.GetValue(outObj, Nothing))
                    Continue For
                Else
                    txt.Text = String.Format("{0}", i.GetValue(outObj, Nothing))
                    Continue For
                End If
            End If
            If i.PropertyType.FullName.Equals(GetType(Integer).FullName) = True Then
                'Thử với HidenField
                Dim hd As HiddenField = TryCast(tblDetail.FindControl(i.Name), HiddenField)
                If hd Is Nothing Then
                    Continue For
                End If
                hd.Value = String.Format("{0}", i.GetValue(outObj, Nothing))
                Continue For
            End If
            If i.PropertyType.FullName.Equals(GetType(Decimal).FullName) = True Then
                Dim txt As TextBox = TryCast(tblDetail.FindControl(i.Name), TextBox)
                If txt Is Nothing Then
                    Continue For
                End If
                Dim dm As Decimal = 0
                If Decimal.TryParse(txt.Text, dm) = True Then
                    ' i.SetValue(outObj, dm, null);
                    txt.Text = String.Format("{0}", i.GetValue(outObj, Nothing))
                End If
            End If
        Next
    End Sub


    Public Shared Sub ClearDesignData(tblDetail As HtmlTable, obj As Object)
        For Each i As PropertyInfo In obj.[GetType]().GetProperties()
            If i.PropertyType.FullName.Equals(GetType(String).FullName) = True Then
                Dim txt As TextBox = TryCast(tblDetail.FindControl(i.Name), TextBox)
                If txt Is Nothing Then
                    Continue For
                End If
                txt.Text = String.Empty
                Continue For
            End If

            If i.PropertyType.FullName.Equals(GetType(DateTime).FullName) = True Or
                i.PropertyType.FullName.Equals(GetType(DateTime?).FullName) = True Then
                Dim txt As tDateTime = TryCast(tblDetail.FindControl(i.Name), tDateTime)
                If txt Is Nothing Then
                    Continue For
                End If
                txt.DateValue = Nothing
                Continue For
            End If

            If i.PropertyType.FullName.Equals(GetType(Decimal).FullName) = True Then
                Dim txt As TextBox = TryCast(tblDetail.FindControl(i.Name), TextBox)
                If txt Is Nothing Then
                    Continue For
                End If
                txt.Text = String.Empty
                Continue For
            End If
        Next
    End Sub

End Class
