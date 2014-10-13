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
        Try
            MyBase.OnStart(args)

            mTimer = New System.Timers.Timer
            ' mTimer.Interval = Utilities.AppSettings.TimerInterval
            mTimer.Interval = CInt(ConfigurationManager.AppSettings("TTDL.Service.TimerInterval").ToString())
            ' mTimer.Interval = 6000
            mTimer.Enabled = True
            ' mTimer.Start()


            ' Goi WS cua ve tinh
            Dim Wc As New Web_SV.Service1
            Dim CHUOI As String = Wc.WebServices("1", "A")
            If CHUOI = "OK" Then
                ' Ghi vao DB
                Dim Wc2 As New Web_SV.Service1
                Wc.WS_NhanThongTin("1", "A")
            End If
            '
        Catch ex As Exception
            ex.ToString()
        End Try

    End Sub

    Protected Overrides Sub OnStop()
        ' Add code here to perform any tear-down necessary to stop your service.

    End Sub

End Class
