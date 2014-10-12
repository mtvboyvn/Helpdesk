Imports System
Imports System.Collections.Generic
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<System.Web.Script.Services.ScriptService> _
Public Class AutoComplete
    Inherits System.Web.Services.WebService

    Public Sub New()

    End Sub


    <WebMethod()> _
    Public Function GetCompletionList(ByVal prefixText As String, ByVal count As Integer) As String()
        If count = 0 Then
            count = 10
        End If
        If String.IsNullOrEmpty(prefixText) = True Then
            Dim a(0) As String
            Return a
        End If
        If String.IsNullOrEmpty(prefixText.Trim()) = True Then
            Dim a(0) As String
            Return a
        End If
        If prefixText.Equals("xyz") Then
            Dim a(0) As String
            Return a
        End If

        'Dim random As New Random
        'Dim items As New List(Of String)(count)
        'For i As Integer = 0 To count
        '    Dim c1 As Char = Microsoft.VisualBasic.ChrW(random.Next(65, 90))
        '    Dim c2 As Char = Microsoft.VisualBasic.ChrW(random.Next(97, 122))
        '    Dim c3 As Char = Microsoft.VisualBasic.ChrW(random.Next(97, 122))

        '    items.Add(prefixText + c1 + c2 + c3)
        'Next

        'Return items.ToArray()

        Return SearchNay(prefixText)
    End Function


    Private Function SearchNay(ByVal strSearch As String) As String()

        Try
            Dim sb As New StringBuilder
            sb.Append("SELECT TOP 10 A.[KEY], A.[RANK] , B.CH_CAUHOI_NOIDUNGCAUHOI  ")
            sb.AppendFormat("FROM FREETEXTTABLE([CAUHOI],[CH_FULLTEXT_SEARCH],'{0}') AS A ", strSearch.Replace("'", ""))
            sb.Append("INNER JOIN [CAUHOI] AS B ON B.[CH_ID]=A.[KEY] ")
            sb.Append("ORDER BY A.[RANK] DESC")

            Dim ds As DataSet = t.clsDAL.GetDataSet(sb.ToString())
            If ds Is Nothing Then
                Dim a(0) As String
                Return a
            End If
            If ds.Tables.Count < 1 Then
                Dim a(0) As String
                Return a
            End If
            If ds.Tables(0).Rows.Count < 1 Then
                Dim a(0) As String
                Return a
            End If

            Dim items As New List(Of String)
            For Each r As DataRow In ds.Tables(0).Rows
                If r("CH_CAUHOI_NOIDUNGCAUHOI") Is Nothing Then Continue For
                Dim noidung As String = Convert.ToString(r("CH_CAUHOI_NOIDUNGCAUHOI"))
                If String.IsNullOrEmpty(noidung) = True Then Continue For
                Dim cut As Integer = noidung.Length
                If cut > 100 Then cut = 100
                items.Add(noidung.Substring(0, cut))
            Next

            Return items.ToArray()
        Catch ex As Exception
            Dim a(0) As String
            Return a
        End Try
    End Function
   
End Class