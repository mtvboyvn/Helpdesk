Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Configuration
Imports System.Xml
Imports System.Security.Cryptography.X509Certificates
Imports System.Globalization
Imports System.IO
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class Service1
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function WebServices() As String
        Return "OK"
    End Function

#Region "Tiếp nhận thông tin services từ các hệ thống vệ tinh"
    <WebMethod()> _
    Public Sub WS_NhanThongTin(ByVal Services_Name As String, ByVal App_Type As String)
        Dim connection As New SqlConnection(ConfigurationManager.ConnectionStrings("Local").ToString)
        connection.Open()
        Dim selectCommand As New SqlCommand
        selectCommand.Connection = connection
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.CommandText = "Monitor_Insert"
        selectCommand.Parameters.AddWithValue("@Services_Name", Services_Name)
        selectCommand.Parameters.AddWithValue("@App_Type", App_Type)
        Dim adapter As New SqlDataAdapter(selectCommand)
        Dim dataSet As New DataSet
        adapter.Fill(dataSet)
        adapter = Nothing
        selectCommand = Nothing
        connection.Close()
        connection = Nothing
    End Sub
#End Region

End Class