Imports System
Imports System.Data
Imports System.Web
Imports System.IO
Imports System.Configuration
Public Class Service1
    Protected WithEvents mTimer As System.Timers.Timer
    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Add code here to start your service. This method should set things
        ' in motion so your service can do its work.
        MyBase.OnStart(args)
        abc()

    End Sub

    Public Sub abc()
        Try
            'mTimer = New System.Timers.Timer
            '' mTimer.Interval = Utilities.AppSettings.TimerInterval
            ''mTimer.Interval = CInt(ConfigurationManager.AppSettings("TTDL.Service.TimerInterval").ToString())
            'mTimer.Interval = 30
            'mTimer.Enabled = True

            mTimer_Elapsed(Nothing, Nothing)

            'mTimer.Start()
        Catch ex As Exception
            ex.ToString()
        End Try
    End Sub

    Protected Overrides Sub OnStop()
        ' Add code here to perform any tear-down necessary to stop your service.

    End Sub

    Private Sub mTimer_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles mTimer.Elapsed
        ' Goi WS cua ve tinh
        Dim Ws As New Web_SV.Service1
        Dim Ws1 As New Test_WS.Service1

        Dim i As Integer

        For i = 1 To 2
            Dim CHUOI As String

            CHUOI = Ws.WebServices("A", "1")

            If CHUOI = "OK" Then
                ' Ghi vao DB
                'Dim Wc2 As New Web_SV.Service1
                Ws.WS_NhanThongTin("A", "1")
            End If
        Next

        '
    End Sub
End Class
