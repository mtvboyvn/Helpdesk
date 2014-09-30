Imports System.Data.Common

Public Class MainDBBase
    Implements IDisposable
    ''' <summary>
    ''' Connection
    ''' </summary>
    Private connection As DbConnection = Nothing
    ''' <summary>
    ''' Factory để tạo provider
    ''' </summary>
    Private m_factory As DbProviderFactory = Nothing
    ''' <summary>
    ''' Transaction
    ''' </summary>
    Private transaction As DbTransaction = Nothing
    ''' <summary>
    ''' Cờ để check lỗi
    ''' </summary>
    Private isError As Boolean = False
    ''' <summary>
    ''' Phương thức để bắt đầu transaction
    ''' </summary>
    Public Sub BeginTransaction()
        transaction = connection.BeginTransaction()
    End Sub
    ''' <summary>
    ''' Phương thức để bắt đầu transacion
    ''' </summary>
    ''' <param name="ill"></param>
    Public Sub BeginTransaction(ByVal ill As IsolationLevel)
        transaction = connection.BeginTransaction(ill)
    End Sub
    ''' <summary>
    ''' Contructor khởi tạo đối tượng kết nối cơ sở dữ liệu
    ''' </summary>
    Public Sub New()
        ' Dùng factory để tạo connection
        connection = Factory.CreateConnection()
        ' truyền vào connection string
        connection.ConnectionString = Me.ConnectionString

        Try
            ' Mở conneciton
            connection.Open()
        Catch
            ' Nếu kết nối cơ sở dữ liệu không được thì hiển thị ra thông báo lỗi
            isError = True
            Throw New Exception("Kết nối cơ sở dữ liệu thất bại")
        End Try
    End Sub
#Region "Các phương thức thao tác với cơ sở dữ liệu"
    ''' <summary>
    ''' Thực hiện một câu lệnh sql none query
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <param name="param"></param>
    ''' <returns></returns>
    Public Function ExecuteSqlNoneQuery(ByVal sql As String, ByVal ParNames As String(), ByVal parValues As Object()) As Integer
        Return ExecuteNoneQuery(CommandType.Text, sql, ParNames, parValues)
    End Function
    ''' <summary>
    ''' Thực hiện một thủ tục none query
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <param name="param"></param>
    ''' <returns></returns>
    Public Function ExecuteStoreNoneQuery(ByVal sql As String, ByVal ParNames As String(), ByVal parValues As Object()) As Integer
        Return ExecuteNoneQuery(CommandType.StoredProcedure, sql, ParNames, parValues)
    End Function
    ''' <summary>
    ''' Thực hiện một command none query
    ''' </summary>
    ''' <param name="type"></param>
    ''' <param name="sql"></param>
    ''' <param name="paramInputs"></param>
    ''' <returns></returns>
    Private Function ExecuteNoneQuery(ByVal type As CommandType, ByVal sql As String, ByVal ParNames As String(), ByVal parValues As Object()) As Integer
        Dim cmd As IDbCommand = Me.CreateCommand(type, sql, ParNames, parValues)
        Dim rowEffected As Integer = -1
        Try
            rowEffected = cmd.ExecuteNonQuery()
        Catch ex As Exception
            isError = True
            Throw ex
        End Try

        Return rowEffected
    End Function
    ''' <summary>
    ''' Thực hiện một câu lệnh sql trả ra DataTable
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <param name="param"></param>
    ''' <returns></returns>
    Public Function ExecuteSqlToTable(ByVal sql As String) As DataTable
        Return ExecuteSql(sql).Tables(0)
    End Function
    ''' <summary>
    ''' Thực hiện một thủ tục trả ra DataTable
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <param name="param"></param>
    ''' <returns></returns>
    Public Function ExecuteStoreToTable(ByVal sql As String, ByVal parNames As String(), ByVal parValues As Object()) As DataTable
        Return ExecuteStore(sql, parNames, parValues).Tables(0)
    End Function
    ''' <summary>
    ''' Thực hiện một câu lệnh sql trả ra DataSet
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <param name="param"></param>
    ''' <returns></returns>
    Public Function ExecuteSql(ByVal sql As String) As DataSet
        Return Execute(CommandType.Text, sql, New String() {}, New Object() {})
    End Function
    ''' <summary>
    ''' Thực hiện một thủ tục trả ra DataSet
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <param name="param"></param>
    ''' <returns></returns>
    Public Function ExecuteStore(ByVal sql As String, ByVal parNames As String(), ByVal parValues As Object()) As DataSet
        Return Execute(CommandType.StoredProcedure, sql, parNames, parValues)
    End Function
    ''' <summary>
    ''' Thực hiện một câu lệnh Command trả tra DataSet
    ''' </summary>
    ''' <param name="type"></param>
    ''' <param name="sql"></param>
    ''' <param name="paramInputs"></param>
    ''' <returns></returns>
    Private Function Execute(ByVal type As CommandType, ByVal sql As String, ByVal parNames As String(), ByVal parValues As Object()) As DataSet
        Dim dap As IDbDataAdapter = Factory.CreateDataAdapter()
        dap.SelectCommand = Me.CreateCommand(type, sql, parNames, parValues)
        Dim ds As New DataSet()
        Try
            dap.Fill(ds)
        Catch ex As Exception
            isError = True
            Throw ex
        End Try
        Return ds
    End Function
#End Region

    ''' <summary>
    ''' Tạo Command 
    ''' </summary>
    ''' <param name="type"></param>
    ''' <param name="sql"></param>
    ''' <param name="names"></param>
    ''' <param name="values"></param>
    ''' <returns></returns>
    Private Function CreateCommand(ByVal type As CommandType, ByVal sql As String, ByVal parNames As String(), ByVal parValues As Object()) As DbCommand
        ' Khởi tạo commander
        Dim cmd As DbCommand = connection.CreateCommand()
        If Me.transaction IsNot Nothing Then
            cmd.Transaction = transaction
        End If

        cmd.CommandType = type
        cmd.CommandText = sql
        ' Khởi tạo các tham số để thực hiện truy vấn
        Dim pa As DbParameter = Nothing

        ' Thực hiện Tạo Parameter
        If parNames IsNot Nothing AndAlso parValues IsNot Nothing Then
            For i As Integer = 0 To parNames.Length - 1
                pa = cmd.CreateParameter()
                pa.ParameterName = parNames(i)
                pa.Value = If(parValues(i) Is Nothing, DBNull.Value, parValues(i))
                cmd.Parameters.Add(pa)

            Next
        End If

        Return cmd
    End Function

    ''' <summary>
    ''' Factory
    ''' </summary>
    Private ReadOnly Property Factory() As DbProviderFactory
        Get
            If m_factory Is Nothing Then
                m_factory = DbProviderFactories.GetFactory(Me.ProviderName)
            End If
            Return m_factory
        End Get
    End Property

    ''' <summary>
    ''' Phương thức dùng để lớp con kế thừa cung cấp connection string
    ''' </summary>
    ''' <returns></returns>
    Protected Overridable ReadOnly Property ConnectionString() As String
        Get
            Return String.Empty
        End Get
    End Property
    ''' <summary>
    ''' Phương thức dùng để lớp con kế thừa cung cấp provider
    ''' </summary>
    ''' <returns></returns>
    Protected Overridable ReadOnly Property ProviderName() As String
        Get
            Return String.Empty
        End Get
    End Property
    ''' <summary>
    ''' Phương thức Dispose
    ''' </summary>
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Kết thức transaction 
        If transaction IsNot Nothing Then
            If isError Then
                transaction.Rollback()
            Else
                transaction.Commit()
            End If
        End If
        ' Đóng connection
        If connection IsNot Nothing Then
            connection.Close()
            connection.Dispose()
        End If
    End Sub

    ''' <summary>
    ''' Thực hiện Cập nhật một số lượng bản ghi lớn
    ''' </summary>
    ''' <param name="table"></param>
    ''' <param name="storeInsert"></param>
    ''' <param name="storeUpdate"></param>
    ''' <param name="storeDelete"></param>
    ''' <param name="keys"></param>
    Public Function BathUpdate(ByVal table As DataTable, ByVal storeSave As String, ByVal params As String()) As Integer
        ' Tạo DataAdapter
        Dim dap As DbDataAdapter = Factory.CreateDataAdapter()

        ' Tạo Command Insert, Update
        Dim cmdInsert = connection.CreateCommand()
        Dim cmdUpdate = connection.CreateCommand()

        ' Parameter
        Dim pa As IDbDataParameter = Nothing

        ' Tạo Parameter
        params.[Select](Function(p)
                            pa = cmdInsert.CreateParameter()
                            pa.SourceColumn = InlineAssignHelper(pa.ParameterName, p)
                            cmdInsert.Parameters.Add(pa)
                            pa = cmdUpdate.CreateParameter()
                            pa.SourceColumn = InlineAssignHelper(pa.ParameterName, p)
                            cmdUpdate.Parameters.Add(pa)
                            Return p

                        End Function).ToArray()

        dap.UpdateCommand = cmdUpdate
        dap.UpdateCommand.CommandText = storeSave
        dap.UpdateCommand.UpdatedRowSource = UpdateRowSource.None
        dap.UpdateCommand.CommandType = CommandType.StoredProcedure

        dap.InsertCommand = cmdInsert
        dap.InsertCommand.CommandText = storeSave
        dap.InsertCommand.UpdatedRowSource = UpdateRowSource.None
        dap.InsertCommand.CommandType = CommandType.StoredProcedure

        dap.MissingMappingAction = MissingMappingAction.Passthrough
        dap.MissingSchemaAction = MissingSchemaAction.Ignore

        ' dap.UpdateBatchSize = 3000;
        Return dap.Update(table)
    End Function
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function
End Class