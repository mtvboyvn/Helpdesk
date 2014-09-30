Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types
Imports Oracle.DataAccess
Public NotInheritable Class ConnectionHelper
    ''Demo Oracle Home
    Public Shared Function OpenConnectionToMHS_HOME() As OracleConnection
        Dim cnn As New OracleConnection(Config.ConnectionStringMHS_HOME) 'Config.ConnectionStringMHS)
        Try
            cnn.Open()
            'AuditHelper.PrepareAuditInfo(cnn)
        Catch ex As Exception
            Throw New COMMON.AppException(ex)
        End Try
        Return cnn
    End Function

    Public Shared Function OpenConnectionToMHS() As OracleConnection
        Dim cnn As New OracleConnection(Config.ConnectionStringMHS) 'Config.ConnectionStringMHS)
        Try
            cnn.Open()
            'AuditHelper.PrepareAuditInfo(cnn)
        Catch ex As Exception
            Throw New COMMON.AppException(ex)
        End Try
        Return cnn
    End Function

    ''Them phuong thuc lay ProviderName
    Public Shared Function ProviderName() As String
        Return Config.ProviderName
    End Function


    Public Shared Function OpenConnectionToNghiepVu() As OracleConnection
        Dim cnn As New OracleConnection(Config.ConnectionStringNghiepVu)
        Try
            cnn.Open()
            'AuditHelper.PrepareAuditInfo(cnn)
        Catch ex As Exception
            Throw New COMMON.AppException(ex)
        End Try
        Return cnn
    End Function

    Public Shared Function OpenConnectionToTraCuu() As OracleConnection
        Dim cnn As New OracleConnection(Config.ConnectionStringTraCuu)
        Try
            cnn.Open()
        Catch ex As Exception
            Throw New COMMON.AppException(ex)
        End Try
        Return cnn
    End Function

    Public Shared Function OpenConnectionToLog() As OracleConnection
        Dim cnn As New OracleConnection(Config.ConnectionStringLog)
        Try
            cnn.Open()
        Catch ex As Exception
            Throw New COMMON.AppException(ex)
        End Try
        Return cnn
    End Function

    Public Shared Function OpenConnectionToQuanTri() As OracleConnection
        Dim cnn As New OracleConnection(Config.ConnectionStringQuanTri)
        Try
            cnn.Open()
            'AuditHelper.PrepareAuditInfo(cnn)
        Catch ex As Exception
            Throw New COMMON.AppException(ex)
        End Try
        Return cnn
    End Function
End Class
