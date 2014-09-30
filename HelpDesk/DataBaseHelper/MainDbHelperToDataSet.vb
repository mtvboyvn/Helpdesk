Imports System.Data.SqlClient

Public Class MainDbHelperToDataSet
    Implements IDisposable

    Private connection As IDbConnection = Nothing

    Private Sub InitConnection()
        connection = New SqlConnection()
        connection.ConnectionString = GetConnectionString()
        connection.Open()
    End Sub

    Public Function ExecuteStoreToDataSet(ByVal sqlText As String) As DataSet
        Return ExecuteStoreToDataSet(sqlText, New String() {}, New Object() {})
    End Function

    Public Function ExecuteStoreToDataSet(ByVal sqlText As String, ByVal names As String(), ByVal values As Object()) As DataSet
        Dim cmd As IDbCommand = Me.CreateCommand(sqlText, CommandType.StoredProcedure, names, values)
        ' SqlDataAdapter dap = new SqlDataAdapter(cmd);
        Dim dap As New SqlDataAdapter()
        dap.SelectCommand = TryCast(cmd, SqlCommand)
        Dim ds As New DataSet()
        dap.Fill(ds)
        Return ds
    End Function

    Public Function ExecuteSqlToDataSet(ByVal sqlText As String) As DataSet
        Return ExecuteSqlToDataSet(sqlText, New String() {}, New Object() {})
    End Function

    Public Function ExecuteSqlToDataSet(ByVal sqlText As String, ByVal names As String(), ByVal values As Object()) As DataSet
        Dim cmd As IDbCommand = Me.CreateCommand(sqlText, CommandType.Text, names, values)
        Dim dap As New SqlDataAdapter(TryCast(cmd, SqlCommand))
        Dim ds As New DataSet()
        dap.Fill(ds)
        Return ds
    End Function

    Public Function ExecuteStoreNoneQuery(ByVal sqlText As String) As Integer
        Return ExecuteStoreNoneQuery(sqlText, New String() {}, New Object() {})
    End Function

    Public Function ExecuteStoreNoneQuery(ByVal sqlText As String, ByVal names As String(), ByVal values As Object()) As Integer
        Dim cmd As IDbCommand = Me.CreateCommand(sqlText, CommandType.StoredProcedure, names, values)
        Return cmd.ExecuteNonQuery()
    End Function

    Public Function ExecuteSqlNoneQuery(ByVal sqlText As String) As Integer
        Return ExecuteSqlNoneQuery(sqlText, New String() {}, New Object() {})
    End Function

    Public Function ExecuteSqlNoneQuery(ByVal sqlText As String, ByVal names As String(), ByVal values As Object()) As Integer
        Dim cmd As IDbCommand = Me.CreateCommand(sqlText, CommandType.Text, names, values)
        Return cmd.ExecuteNonQuery()
    End Function

    Private Function CreateCommand(ByVal sqlText As String, ByVal type As CommandType, ByVal names As String(), ByVal values As Object()) As IDbCommand
        Dim cmd As IDbCommand = connection.CreateCommand()
        cmd.CommandText = sqlText
        cmd.CommandType = type

        Dim para As IDataParameter = Nothing

        For i As Integer = 0 To names.Length - 1
            para = cmd.CreateParameter()
            para.ParameterName = names(i)
            para.Value = values(i)
            cmd.Parameters.Add(para)
        Next

        Return cmd
    End Function
    Public Sub New()
        InitConnection()
    End Sub

    Protected Overridable Function GetConnectionString() As String
        Return String.Empty
    End Function

    Public Sub IDispose()
        If connection IsNot Nothing Then
            connection.Close()
        End If
    End Sub
#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
