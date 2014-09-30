Imports System.Data.Common

Public Class MainDbHelperToDataTable
    Implements IDisposable



    Private connection As IDbConnection

    Public Sub New()
        InitConnection()
    End Sub
    'lay data bang Store co param truyen vao
    Public Function ExecuteStore(ByVal sql As String, ByVal parNames As String(), ByVal parValues As Object()) As DataTable
        Return Execute(sql, parNames, parValues, CommandType.StoredProcedure)
    End Function
    'lay data bang store khong param truyen vao
    Public Function ExecuteStore(ByVal sql As String) As DataTable
        Return Execute(sql, New String() {}, New Object() {}, CommandType.StoredProcedure)
    End Function
    'lay data bang query sql co param truyen vao
    Public Function ExecuteSql(ByVal sql As String, ByVal parNames As String(), ByVal parValues As Object()) As DataTable
        Return Execute(sql, parNames, parValues, CommandType.Text)
    End Function
    'lay data bang query sql khong param truyen vao
    Public Function ExecuteSql(ByVal sql As String) As DataTable
        Return Execute(sql, New String() {}, New Object() {}, CommandType.Text)
    End Function
    'lay data bang cau lenh execute
    Public Function Execute(ByVal sql As String, ByVal parNames As String(), ByVal parValues As Object(), ByVal type As CommandType) As DataTable
        Dim cmd As IDbCommand = Me.CreateCommand(sql, parNames, parValues, type)

        Dim dap As IDbDataAdapter = Me.Factory.CreateDataAdapter()
        dap.SelectCommand = cmd

        Dim ds As New DataSet()
        dap.Fill(ds)

        Return ds.Tables(0)
    End Function
    'cau lenh sql none query( add, delete,update)
    Public Sub ExecuteNoneQuery(ByVal sql As String, ByVal parNames As String(), ByVal parValues As Object(), ByVal type As CommandType)
        Dim cmd As IDbCommand = Me.CreateCommand(sql, parNames, parValues, type)
        cmd.ExecuteNonQuery()
    End Sub
    'Sql nonequery vơi tham số truyền vào là một datatable
    Public Sub ExecuteNoneQuery(ByVal sql As String, ByVal tbl As DataTable)
        'tbl.TableName= paramName trong thủ tục Sql
        Me.ExecuteNoneQuery(sql, New String() {tbl.TableName}, New Object() {tbl}, CommandType.StoredProcedure)

    End Sub
    'ham tao SqlCommand
    Private Function CreateCommand(ByVal sql As String, ByVal parNames As String(), ByVal parValues As Object(), ByVal type As CommandType) As IDbCommand
        Dim cmd As IDbCommand = connection.CreateCommand()
        cmd.CommandText = sql
        cmd.CommandType = type

        Dim param As IDbDataParameter = Nothing
        For i As Integer = 0 To parNames.Length - 1
            param = cmd.CreateParameter()
            param.ParameterName = parNames(i)
            param.Value = If(parValues(i) Is Nothing, DBNull.Value, parValues(i))
            cmd.Parameters.Add(param)
        Next

        Return cmd
    End Function
    'Ham khoi tao va open Connection
    Private Sub InitConnection()
        connection = Me.Factory.CreateConnection()
        connection.ConnectionString = GetConnectionString()
        connection.Open()
    End Sub
    'ham lay provider bat ky
    Private m_factory As DbProviderFactory = Nothing
    Public ReadOnly Property Factory() As DbProviderFactory
        Get
            If m_factory Is Nothing Then
                m_factory = DbProviderFactories.GetFactory(GetProvider())
            End If
            Return m_factory
        End Get
    End Property
    'Ham ao kay connection se duoc ke thua o lop Dabase
    Public Overridable Function GetConnectionString() As String
        Return String.Empty
    End Function
    'Ham ao dung de ke thua lay provider o lop DB
    Public Overridable Function GetProvider() As String
        Return String.Empty
    End Function
    'Ham ngat ket noi va giai phong tai nguyen.
    Public Sub IDispose()
        If connection IsNot Nothing Then
            connection.Close()
            connection.Dispose()
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
