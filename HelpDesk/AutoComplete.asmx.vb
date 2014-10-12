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
        If prefixText.Equals("xyz") Then
            Dim a(0) As String
            Return a
        End If

        Dim random As New Random
        Dim items As New List(Of String)(count)
        For i As Integer = 0 To count
            Dim c1 As Char = Microsoft.VisualBasic.ChrW(random.Next(65, 90))
            Dim c2 As Char = Microsoft.VisualBasic.ChrW(random.Next(97, 122))
            Dim c3 As Char = Microsoft.VisualBasic.ChrW(random.Next(97, 122))

            items.Add(prefixText + c1 + c2 + c3)
        Next

        Return items.ToArray()
    End Function

   
End Class