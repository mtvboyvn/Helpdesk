

Imports System.Data.Common
'Imports System.Data.OracleClient
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types
Imports Oracle.DataAccess

Public NotInheritable Class OracleHelper

#Region "Parameter"
    Public Shared Function CreateParameter(ByVal parameterName As String, ByVal type As OracleDbType, ByRef value As Object) As OracleParameter
        Dim param As New OracleParameter(parameterName, type)
        param.Value = value
        param.Direction = ParameterDirection.Input
        Return param

    End Function

    Public Shared Function CreateParameter(ByVal parameterName As String, ByVal type As OracleDbType, ByRef value As Object, ByVal direction As ParameterDirection) As OracleParameter
        Dim param As New OracleParameter(parameterName, type)
        param.Value = value
        param.Direction = direction
        Return param
    End Function

    Public Shared Function CreateParameter(ByVal parameterName As String, ByVal type As OracleDbType, ByVal size As Integer, ByRef value As Object, ByVal direction As ParameterDirection) As OracleParameter
        Dim param As New OracleParameter(parameterName, type, size)
        param.Value = value
        param.Direction = direction
        Return param
    End Function
#End Region

#Region "Cac Phuong thuc thao tac voi co so du lieu "
    ''' <summary>
    ''' Connection
    ''' </summary>
    Private connection As DbConnection = Nothing
    ''' <summary>
    ''' Factory để tạo provider
    ''' </summary>
    Private Shared m_factory As DbProviderFactory = Nothing
    ''' <summary>
    ''' Transaction
    ''' </summary>
    Private transaction As DbTransaction = Nothing
    ''' <summary>
    ''' Cờ để check lỗi
    ''' </summary>
    Private Shared isError As Boolean = False
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
    ''' 

    'Public Sub New()
    '    ' Dùng factory để tạo connection
    '    connection = Factory.CreateConnection()
    '    ' truyền vào connection string
    '    connection.ConnectionString = Me.ConnectionString

    '    Try
    '        ' Mở conneciton
    '        connection.Open()
    '    Catch
    '        ' Nếu kết nối cơ sở dữ liệu không được thì hiển thị ra thông báo lỗi
    '        isError = True
    '        Throw New Exception("Kết nối cơ sở dữ liệu thất bại")
    '    End Try
    'End Sub
#Region "Các phương thức thao tác với cơ sở dữ liệu GiangTD3 =)) :)) :D"
    ''' <summary>
    ''' Thực hiện một câu lệnh sql none query
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <param name="param"></param>
    ''' <returns></returns>
    Public Shared Function ExecuteSqlNoneQuery(ByVal connection As IDbConnection, ByVal sql As String, ByVal ParNames As String(), ByVal parValues As Object()) As Integer
        Return ExecuteNoneQuery(connection, CommandType.Text, sql, ParNames, parValues)
    End Function
    ''' <summary>
    ''' Thực hiện một thủ tục none query
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <param name="param"></param>
    ''' <returns></returns>
    Public Shared Function ExecuteStoreNoneQuery(ByVal connection As IDbConnection, ByVal sql As String, ByVal ParNames As String(), ByVal parValues As Object()) As Integer
        Return ExecuteNoneQuery(connection, CommandType.StoredProcedure, sql, ParNames, parValues)
    End Function
    ''' <summary>
    ''' Thực hiện một command none query
    ''' </summary>
    ''' <param name="type"></param>
    ''' <param name="sql"></param>
    ''' <param name="paramInputs"></param>
    ''' <returns></returns>
    Private Shared Function ExecuteNoneQuery(ByVal connection As IDbConnection, ByVal type As CommandType, ByVal sql As String, ByVal ParNames As String(), ByVal parValues As Object()) As Integer
        Dim cmd As IDbCommand = CreateCommand(connection, type, sql, ParNames, parValues)
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
    Public Shared Function ExecuteSqlToTable(ByVal connection As IDbConnection, ByVal sql As String) As DataTable
        Return ExecuteSql(connection, sql).Tables(0)
    End Function
    ''' <summary>
    ''' Thực hiện một thủ tục trả ra DataTable
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <param name="param"></param>
    ''' <returns></returns>
    Public Shared Function ExecuteStoreToTable(ByVal connection As IDbConnection, ByVal sql As String, ByVal parNames As String(), ByVal parValues As Object()) As DataTable
        Return ExecuteStore(connection, sql, parNames, parValues).Tables(0)
    End Function
    ''' <summary>
    ''' Thực hiện một câu lệnh sql trả ra DataSet
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <param name="param"></param>
    ''' <returns></returns>
    Public Shared Function ExecuteSql(ByVal connection As IDbConnection, ByVal sql As String) As DataSet
        Return Execute(connection, CommandType.Text, sql, New String() {}, New Object() {})
    End Function
    ''' <summary>
    ''' Thực hiện một thủ tục trả ra DataSet
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <param name="param"></param>
    ''' <returns></returns>
    Public Shared Function ExecuteStore(ByVal connection As IDbConnection, ByVal sql As String, ByVal parNames As String(), ByVal parValues As Object()) As DataSet
        Return Execute(connection, CommandType.StoredProcedure, sql, parNames, parValues)
    End Function
    ''' <summary>
    ''' Thực hiện một câu lệnh Command trả tra DataSet
    ''' </summary>
    ''' <param name="type"></param>
    ''' <param name="sql"></param>
    ''' <param name="paramInputs"></param>
    ''' <returns></returns>
    Private Shared Function Execute(ByVal connection As IDbConnection, ByVal type As CommandType, ByVal sql As String, ByVal parNames As String(), ByVal parValues As Object()) As DataSet
        Dim dap As IDbDataAdapter = Factory.CreateDataAdapter()
        dap.SelectCommand = CreateCommand(connection, type, sql, parNames, parValues)
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
    Private Shared Function CreateCommand(ByVal connection As IDbConnection, ByVal type As CommandType, ByVal sql As String, ByVal parNames As String(), ByVal parValues As Object()) As DbCommand
        ' Khởi tạo commander
        Dim cmd As DbCommand = connection.CreateCommand()
        'If Me.transaction IsNot Nothing Then
        '    cmd.Transaction = transaction
        'End If

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
    Private Shared ReadOnly Property Factory() As DbProviderFactory
        Get
            If m_factory Is Nothing Then
                m_factory = DbProviderFactories.GetFactory(ProviderName)
            End If
            Return m_factory
        End Get
    End Property

    'GiangTD3 Add thêm 2 function để ExecuteNonQuery với function Oracle :D:D:D:D:D:
#Region "ExecuteNonQueryFunction Oracle GiangTD3 :D:D:D :) :):):):) (-_-)"

    ''ExecuteNonQueryFunction, function này phải khởi tạo từng OracleParameter  thông qua Transaction
    Public Shared Function ExecuteNonQueryFunction(ByVal tran As OracleTransaction, ByVal sqlName As String, ByVal ParamArray params() As OracleParameter) As String
        Dim command As New OracleCommand()
        command.Connection = tran.Connection
        command.CommandText = sqlName
        command.CommandType = CommandType.StoredProcedure

        Dim retVal As OracleParameter = New OracleParameter("v_result", OracleDbType.Varchar2, 4000)
        retVal.Direction = ParameterDirection.ReturnValue
        command.Parameters.Add(retVal)

        For i As Integer = 0 To params.Length - 1
            command.Parameters.Add(params(i))
        Next

        command.ExecuteNonQuery()

        Return retVal.Value.ToString()
    End Function
    ''' <summary>
    ''' '''''''''
    ''' </summary>
    ''' <param name="conn"></param>
    ''' <param name="sqlName"></param>
    ''' <param name="params"></param>
    ''' <remarks></remarks>
    ''Với Connection trực tiếp
    Public Shared Sub ExecuteNonQueryFunction1(ByVal conn As OracleConnection, ByVal sqlName As String, ByVal ParamArray params() As OracleParameter)
        Dim command As New OracleCommand()
        command.Connection = conn
        command.CommandText = sqlName
        command.CommandType = CommandType.StoredProcedure

        Dim retVal As OracleParameter = New OracleParameter("v_result", OracleDbType.Varchar2, 4000)
        retVal.Direction = ParameterDirection.ReturnValue
        command.Parameters.Add(retVal)

        For i As Integer = 0 To params.Length - 1
            command.Parameters.Add(params(i))
        Next

        command.ExecuteNonQuery()

    End Sub


    'Function này chỉ cần truyền tên OracleParameter, OracleParamValues 

    Public Shared Sub ExecuteNonQueryFunctionORA(ByVal Tran As OracleTransaction, ByVal sqlName As String, ByVal parName() As String, ByVal parValues() As Object)
        Dim command As New OracleCommand(sqlName, Tran.Connection)
        command.CommandType = CommandType.StoredProcedure
        Dim retVal As OracleParameter = New OracleParameter("v_result", OracleDbType.Varchar2, 4000)
        retVal.Direction = ParameterDirection.ReturnValue
        command.Parameters.Add(retVal)
        For i As Integer = 0 To parName.Length - 1
            Dim p As New OracleParameter(parName(i), parValues(i))
            p.Direction = ParameterDirection.Input
            command.Parameters.Add(p)
        Next
        Dim str As String
        str = command.ExecuteNonQuery()
    End Sub
#End Region
    ''' <summary>
    ''' Phương thức tao ProviderName (OracleProviderName)
    ''' </summary>
    ''' <returns></returns>
    Protected Shared ReadOnly Property ProviderName() As String
        Get
            Return "Oracle.DataAccess.Client"
        End Get
    End Property
    ''' <summary>
    ''' Phương thức dùng để lớp con kế thừa cung cấp connection string
    ''' </summary>
    ''' <returns></returns>

    Private _ConnectionString As String
    Public Property ConnectionString() As String
        Get
            Return _ConnectionString
        End Get
        Set(ByVal value As String)
            _ConnectionString = value
        End Set
    End Property

#End Region
#Region "private utility methods & constructors"

    ' Since this class provides only static methods, make the default constructor private to prevent 
    ' instances from being created with "new OracleHelper()".
    Private Sub New()
    End Sub ' New

    ' This method is used to attach array of OracleParameters to a OracleCommand.
    ' This method will assign a value of DbNull to any parameter with a direction of
    ' InputOutput and a value of null.  
    ' This behavior will prevent default values from being used, but
    ' this will be the less common case than an intended pure output parameter (derived as InputOutput)
    ' where the user provided no input value.
    ' Parameters:
    ' -command - The command to which the parameters will be added
    ' -commandParameters - an array of OracleParameters to be added to command
    Private Shared Sub AttachParameters(ByVal command As OracleCommand, ByVal commandParameters() As OracleParameter)
        If (command Is Nothing) Then Throw New ArgumentNullException("command")
        If (Not commandParameters Is Nothing) Then
            Dim p As OracleParameter
            For Each p In commandParameters
                If (Not p Is Nothing) Then
                    ' Check for derived output value with no value assigned
                    If (p.Direction = ParameterDirection.InputOutput OrElse p.Direction = ParameterDirection.Input) AndAlso p.Value Is Nothing Then
                        p.Value = DBNull.Value
                    End If
                    command.Parameters.Add(p)
                End If
            Next p
        End If
    End Sub ' AttachParameters

    ' This method assigns dataRow column values to an array of OracleParameters.
    ' Parameters:
    ' -commandParameters: Array of OracleParameters to be assigned values
    ' -dataRow: the dataRow used to hold the stored procedure' s parameter values
    Private Overloads Shared Sub AssignParameterValues(ByVal commandParameters() As OracleParameter, ByVal dataRow As DataRow)

        If commandParameters Is Nothing OrElse dataRow Is Nothing Then
            ' Do nothing if we get no data    
            Exit Sub
        End If

        ' Set the parameters values
        Dim commandParameter As OracleParameter
        Dim i As Integer
        For Each commandParameter In commandParameters
            ' Check the parameter name
            If (commandParameter.ParameterName Is Nothing OrElse commandParameter.ParameterName.Length <= 1) Then
                Throw New Exception(String.Format("Please provide a valid parameter name on the parameter #{0}, the ParameterName property has the following value: ' {1}' .", i, commandParameter.ParameterName))
            End If
            If dataRow.Table.Columns.IndexOf(commandParameter.ParameterName.Substring(1)) <> -1 Then
                commandParameter.Value = dataRow(commandParameter.ParameterName.Substring(1))
            End If
            i = i + 1
        Next
    End Sub

    ' This method assigns an array of values to an array of OracleParameters.
    ' Parameters:
    ' -commandParameters - array of OracleParameters to be assigned values
    ' -array of objects holding the values to be assigned
    Private Overloads Shared Sub AssignParameterValues(ByVal commandParameters() As OracleParameter, ByVal parameterValues() As Object)

        Dim i As Integer
        Dim j As Integer

        If (commandParameters Is Nothing) AndAlso (parameterValues Is Nothing) Then
            ' Do nothing if we get no data
            Return
        End If

        ' We must have the same number of values as we pave parameters to put them in
        If commandParameters.Length <> parameterValues.Length Then
            Throw New ArgumentException("Parameter count does not match Parameter Value count.")
        End If

        ' Value array
        j = commandParameters.Length - 1
        For i = 0 To j
            ' If the current array value derives from IDbDataParameter, then assign its Value property
            If TypeOf parameterValues(i) Is IDbDataParameter Then
                Dim paramInstance As IDbDataParameter = CType(parameterValues(i), IDbDataParameter)
                If (paramInstance.Value Is Nothing) Then
                    commandParameters(i).Value = DBNull.Value
                Else
                    commandParameters(i).Value = paramInstance.Value
                End If
            ElseIf (parameterValues(i) Is Nothing) Then
                commandParameters(i).Value = DBNull.Value
            Else
                commandParameters(i).Value = parameterValues(i)
            End If
        Next
    End Sub ' AssignParameterValues

    ' This method opens (if necessary) and assigns a connection, transaction, command type and parameters 
    ' to the provided command.
    ' Parameters:
    ' -command - the OracleCommand to be prepared
    ' -connection - a valid OracleConnection, on which to execute this command
    ' -transaction - a valid OracleTransaction, or ' null' 
    ' -commandType - the CommandType (stored procedure, text, etc.)
    ' -commandText - the stored procedure name or T-Oracle command
    ' -commandParameters - an array of OracleParameters to be associated with the command or ' null' if no parameters are required
    Private Shared Sub PrepareCommand(ByVal command As OracleCommand, _
     ByVal connection As OracleConnection, _
     ByVal transaction As OracleTransaction, _
     ByVal commandType As CommandType, _
     ByVal commandText As String, _
     ByVal commandParameters() As OracleParameter, ByRef mustCloseConnection As Boolean)

        If (command Is Nothing) Then Throw New ArgumentNullException("command")
        If (commandText Is Nothing OrElse commandText.Length = 0) Then Throw New ArgumentNullException("commandText")

        ' If the provided connection is not open, we will open it
        If connection.State <> ConnectionState.Open Then
            connection.Open()
            mustCloseConnection = True
        Else
            mustCloseConnection = False
        End If

        ' Associate the connection with the command
        command.Connection = connection

        ' Set the command text (stored procedure name or Oracle statement)
        command.CommandText = commandText

        ' If we were provided a transaction, assign it.
        If Not (transaction Is Nothing) Then
            If transaction.Connection Is Nothing Then Throw New ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction")
            'command.Transaction = transaction
        End If

        ' Set the command type
        command.CommandType = commandType

        ' Attach the command parameters if they are provided
        If Not (commandParameters Is Nothing) Then
            AttachParameters(command, commandParameters)
        End If
        Return
    End Sub ' PrepareCommand

#End Region

#Region "ExecuteNonQuery"

    ' Execute a OracleCommand (that returns no resultset and takes no parameters) against the database specified in 
    ' the connection string. 
    ' e.g.:  
    '  Dim result As Integer =  ExecuteNonQuery(connString, CommandType.StoredProcedure, "PublishOrders")
    ' Parameters:
    ' -connectionString - a valid connection string for a OracleConnection
    ' -commandType - the CommandType (stored procedure, text, etc.)
    ' -commandText - the stored procedure name or T-Oracle command
    ' Returns: An int representing the number of rows affected by the command
    Public Overloads Shared Function ExecuteNonQuery(ByVal connectionString As String, _
      ByVal commandType As CommandType, _
      ByVal commandText As String) As Integer
        ' Pass through the call providing null for the set of OracleParameters
        Return ExecuteNonQuery(connectionString, commandType, commandText, CType(Nothing, OracleParameter()))
    End Function    ' ExecuteNonQuery

    ' Execute a OracleCommand (that returns no resultset) against the database specified in the connection string 
    ' using the provided parameters.
    ' e.g.:  
    ' Dim result As Integer = ExecuteNonQuery(connString, CommandType.StoredProcedure, "PublishOrders", new OracleParameter("@prodid", 24))
    ' Parameters:
    ' -connectionString - a valid connection string for a OracleConnection
    ' -commandType - the CommandType (stored procedure, text, etc.)
    ' -commandText - the stored procedure name or T-Oracle command
    ' -commandParameters - an array of OracleParamters used to execute the command
    ' Returns: An int representing the number of rows affected by the command
    Public Overloads Shared Function ExecuteNonQuery(ByVal connectionString As String, _
     ByVal commandType As CommandType, _
     ByVal commandText As String, _
     ByVal ParamArray commandParameters() As OracleParameter) As Integer
        If (connectionString Is Nothing OrElse connectionString.Length = 0) Then Throw New ArgumentNullException("connectionString")
        ' Create & open a OracleConnection, and dispose of it after we are done
        Dim connection As OracleConnection = Nothing
        Try
            connection = New OracleConnection(connectionString)
            connection.Open()

            ' Call the overload that takes a connection in place of the connection string
            Return ExecuteNonQuery(connection, commandType, commandText, commandParameters)
        Finally
            If Not connection Is Nothing Then connection.Dispose()
        End Try
    End Function    ' ExecuteNonQuery

    ' Execute a OracleCommand (that returns no resultset and takes no parameters) against the provided OracleConnection. 
    ' e.g.:  
    ' Dim result As Integer = ExecuteNonQuery(conn, CommandType.StoredProcedure, "PublishOrders")
    ' Parameters:
    ' -connection - a valid OracleConnection
    ' -commandType - the CommandType (stored procedure, text, etc.)
    ' -commandText - the stored procedure name or T-Oracle command 
    ' Returns: An int representing the number of rows affected by the command
    Public Overloads Shared Function ExecuteNonQuery(ByVal connection As OracleConnection, _
     ByVal commandType As CommandType, _
     ByVal commandText As String) As Integer
        ' Pass through the call providing null for the set of OracleParameters
        Return ExecuteNonQuery(connection, commandType, commandText, CType(Nothing, OracleParameter()))
    End Function ' ExecuteNonQuery

    ' Execute a OracleCommand (that returns no resultset) against the specified OracleConnection 
    ' using the provided parameters.
    ' e.g.:  
    '  Dim result As Integer = ExecuteNonQuery(conn, CommandType.StoredProcedure, "PublishOrders", new OracleParameter("@prodid", 24))
    ' Parameters:
    ' -connection - a valid OracleConnection 
    ' -commandType - the CommandType (stored procedure, text, etc.)
    ' -commandText - the stored procedure name or T-Oracle command 
    ' -commandParameters - an array of OracleParamters used to execute the command 
    ' Returns: An int representing the number of rows affected by the command 
    Public Overloads Shared Function ExecuteNonQuery(ByVal connection As OracleConnection, _
     ByVal commandType As CommandType, _
     ByVal commandText As String, _
     ByVal ParamArray commandParameters() As OracleParameter) As Integer

        If (connection Is Nothing) Then Throw New ArgumentNullException("connection")

        ' Create a command and prepare it for execution
        Dim cmd As New OracleCommand
        Dim retval As Integer
        Dim mustCloseConnection As Boolean = False

        PrepareCommand(cmd, connection, CType(Nothing, OracleTransaction), commandType, commandText, commandParameters, mustCloseConnection)

        ' Finally, execute the command
        retval = cmd.ExecuteNonQuery()

        If (mustCloseConnection) Then connection.Close()

        Return retval
    End Function ' ExecuteNonQuery

    ' Execute a OracleCommand (that returns no resultset and takes no parameters) against the provided OracleTransaction.
    ' e.g.:  
    '  Dim result As Integer = ExecuteNonQuery(trans, CommandType.StoredProcedure, "PublishOrders")
    ' Parameters:
    ' -transaction - a valid OracleTransaction associated with the connection 
    ' -commandType - the CommandType (stored procedure, text, etc.) 
    ' -commandText - the stored procedure name or T-Oracle command 
    ' Returns: An int representing the number of rows affected by the command 
    Public Overloads Shared Function ExecuteNonQuery(ByVal transaction As OracleTransaction, _
     ByVal commandType As CommandType, _
     ByVal commandText As String) As Integer
        ' Pass through the call providing null for the set of OracleParameters
        Return ExecuteNonQuery(transaction, commandType, commandText, CType(Nothing, OracleParameter()))
    End Function ' ExecuteNonQuery

    ' Execute a OracleCommand (that returns no resultset) against the specified OracleTransaction
    ' using the provided parameters.
    ' e.g.:  
    ' Dim result As Integer = ExecuteNonQuery(trans, CommandType.StoredProcedure, "GetOrders", new OracleParameter("@prodid", 24))
    ' Parameters:
    ' -transaction - a valid OracleTransaction 
    ' -commandType - the CommandType (stored procedure, text, etc.) 
    ' -commandText - the stored procedure name or T-Oracle command 
    ' -commandParameters - an array of OracleParamters used to execute the command 
    ' Returns: An int representing the number of rows affected by the command 
    Public Overloads Shared Function ExecuteNonQuery(ByVal transaction As OracleTransaction, _
     ByVal commandType As CommandType, _
     ByVal commandText As String, _
     ByVal ParamArray commandParameters() As OracleParameter) As Integer

        If (transaction Is Nothing) Then Throw New ArgumentNullException("transaction")
        If Not (transaction Is Nothing) AndAlso (transaction.Connection Is Nothing) Then Throw New ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction")

        ' Create a command and prepare it for execution
        Dim cmd As New OracleCommand
        Dim retval As Integer
        Dim mustCloseConnection As Boolean = False

        PrepareCommand(cmd, transaction.Connection, transaction, commandType, commandText, commandParameters, mustCloseConnection)

        ' Finally, execute the command
        retval = cmd.ExecuteNonQuery()

        Return retval
    End Function ' ExecuteNonQuery

    'Execute mot OracleCommand su dung OracleConnection, sau do giai phong command
    'cnn: Connection object (phải mở sẵn)
    'cmd: Command object để execute (phải tạo sẵn và map SourceColumn với dt)
    'dt: DataTable object chứa dữ liệu
    Public Overloads Shared Sub ExecuteNonQuery(ByVal connection As OracleConnection, ByVal command As OracleCommand, ByVal data As DataTable)
        If (connection Is Nothing) Then Throw New ArgumentNullException("connection")
        If (command Is Nothing) Then Throw New ArgumentNullException("command")
        If (data Is Nothing) Then Throw New ArgumentNullException("data")
        Dim dr As DataRow
        Dim param As OracleParameter
        Try
            command.Connection = connection
            For Each dr In data.Rows
                'Add gia tri cho cac parameter trong command
                For Each param In command.Parameters
                    'Là InputParameter hoặc InputOutputParameter?
                    If param.Direction = ParameterDirection.Input Or param.Direction = ParameterDirection.InputOutput Then
                        'Chua set SourceColumn?
                        If (param.SourceColumn = Nothing) OrElse (param.SourceColumn = String.Empty) Then
                            'Throw New ArgumentNullException(param.ParameterName)
                            'Do nothing!! (Cho là đã được set giá trị trước)
                        Else
                            'Add value
                            param.Value = dr.Item(param.SourceColumn)
                        End If
                    End If
                Next
                command.ExecuteNonQuery()
            Next
        Finally
            command.Dispose()
            command = Nothing
        End Try
    End Sub

#End Region

#Region "ExecuteOutputParameters"

    ' Parameters:
    ' -connection - a valid OracleConnection
    ' -commandType - the CommandType (stored procedure, text, etc.)
    ' -commandText - the stored procedure name or T-Oracle command 
    ' Returns: An hashtable of value of output parameters
    Public Overloads Shared Function ExecuteOutputParameters(ByVal connection As OracleConnection, _
     ByVal commandType As CommandType, _
     ByVal commandText As String) As Hashtable
        ' Pass through the call providing null for the set of OracleParameters
        Return ExecuteOutputParameters(connection, commandType, commandText, CType(Nothing, OracleParameter()))
    End Function ' ExecuteOutputParameters

    ' Parameters:
    ' -connection - a valid OracleConnection 
    ' -commandType - the CommandType (stored procedure, text, etc.)
    ' -commandText - the stored procedure name or T-Oracle command 
    ' -commandParameters - an array of OracleParamters used to execute the command 
    ' Returns: An hashtable of value of output parameters
    Public Overloads Shared Function ExecuteOutputParameters(ByVal connection As OracleConnection, _
     ByVal commandType As CommandType, _
     ByVal commandText As String, _
     ByVal ParamArray commandParameters() As OracleParameter) As Hashtable
        If (connection Is Nothing) Then Throw New ArgumentNullException("connection")
        ' Create a command and prepare it for execution
        Dim cmd As New OracleCommand
        Dim mustCloseConnection As Boolean = False
        PrepareCommand(cmd, connection, CType(Nothing, OracleTransaction), commandType, commandText, commandParameters, mustCloseConnection)
        ' Finally, execute the command
        cmd.ExecuteScalar()
        If (mustCloseConnection) Then connection.Close()
        'Get values
        Dim retvals As New Hashtable
        Dim p As OracleParameter
        For Each p In cmd.Parameters
            If p.Direction = ParameterDirection.InputOutput Or p.Direction = ParameterDirection.Output Then
                'retvals.Add(p.ParameterName, GetValueFromParameter(p))
            End If
        Next
        Return retvals
    End Function ' ExecuteOutputParameters

    ' Parameters:
    ' -transaction - a valid OracleTransaction associated with the connection 
    ' -commandType - the CommandType (stored procedure, text, etc.) 
    ' -commandText - the stored procedure name or T-Oracle command 
    ' Returns: An hashtable of value of output parameters
    Public Overloads Shared Function ExecuteOutputParameters(ByVal transaction As OracleTransaction, _
     ByVal commandType As CommandType, _
     ByVal commandText As String) As Hashtable
        ' Pass through the call providing null for the set of OracleParameters
        Return ExecuteOutputParameters(transaction, commandType, commandText, CType(Nothing, OracleParameter()))
    End Function ' ExecuteOutputParameters

    ' Parameters:
    ' -transaction - a valid OracleTransaction 
    ' -commandType - the CommandType (stored procedure, text, etc.) 
    ' -commandText - the stored procedure name or T-Oracle command 
    ' -commandParameters - an array of OracleParamters used to execute the command 
    ' Returns: An hashtable of value of output parameters
    Public Overloads Shared Function ExecuteOutputParameters(ByVal transaction As OracleTransaction, _
     ByVal commandType As CommandType, _
     ByVal commandText As String, _
     ByVal ParamArray commandParameters() As OracleParameter) As Hashtable
        If (transaction Is Nothing) Then Throw New ArgumentNullException("transaction")
        If Not (transaction Is Nothing) AndAlso (transaction.Connection Is Nothing) Then Throw New ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction")
        ' Create a command and prepare it for execution
        Dim cmd As New OracleCommand
        Dim mustCloseConnection As Boolean = False
        PrepareCommand(cmd, transaction.Connection, transaction, commandType, commandText, commandParameters, mustCloseConnection)
        ' Finally, execute the command
        cmd.ExecuteNonQuery()
        'Get values
        Dim retvals As New Hashtable
        Dim p As OracleParameter
        For Each p In cmd.Parameters
            If p.Direction = ParameterDirection.InputOutput Or p.Direction = ParameterDirection.Output Then
                'retvals.Add(p.ParameterName, GetValueFromParameter(p))
            End If
        Next
        Return retvals
    End Function ' ExecuteOutputParameters

    ' Parameters:
    ' -connectionString - a valid connection string for a OracleConnection 
    ' -commandType - the CommandType (stored procedure, text, etc.) 
    ' -commandText - the stored procedure name or T-Oracle command 
    ' -commandParameters - an array of OracleParamters used to execute the command 
    ' Returns: An hashtable of value of output parameters
    Public Overloads Shared Function ExecuteOutputParameters( _
      ByVal connectionString As String, _
      ByVal commandType As CommandType, _
      ByVal commandText As String, _
      ByVal ParamArray commandParameters() As OracleParameter) As Hashtable
        If (connectionString Is Nothing OrElse connectionString.Length = 0) Then Throw New ArgumentNullException("connectionString")
        ' Create & open a OracleConnection, and dispose of it after we are done.
        Dim connection As OracleConnection = Nothing
        Try
            connection = New OracleConnection(connectionString)
            connection.Open()
            ' Call the overload that takes a connection in place of the connection string
            Return ExecuteOutputParameters(connection, commandType, commandText, commandParameters)
        Finally
            If Not connection Is Nothing Then connection.Dispose()
        End Try
    End Function ' ExecuteOutputParameters

    'Private Shared Function GetValueFromParameter(ByVal param As OracleParameter) As Object
    '    If TypeOf param.Value Is System.Data.OracleClient.OracleString Then
    '        Return CType(param.Value, System.Data.OracleClient.OracleString).Value
    '    ElseIf TypeOf param.Value Is OracleClob Then
    '        Return CType(param.Value, OracleClob).Value
    '    ElseIf TypeOf param.Value Is OracleDate Then
    '        Return CType(param.Value, OracleDate).Value
    '    ElseIf TypeOf param.Value Is OracleDecimal Then
    '        Return CType(param.Value, OracleDecimal).Value
    '    ElseIf TypeOf param.Value Is OracleIntervalDS Then
    '        Return CType(param.Value, OracleIntervalDS).Value
    '    ElseIf TypeOf param.Value Is OracleIntervalYM Then
    '        Return CType(param.Value, OracleIntervalYM).Value
    '    ElseIf TypeOf param.Value Is OracleTimeStamp Then
    '        Return CType(param.Value, OracleTimeStamp).Value
    '    ElseIf TypeOf param.Value Is OracleTimeStampLTZ Then
    '        Return CType(param.Value, OracleTimeStampLTZ).Value
    '    ElseIf TypeOf param.Value Is OracleTimeStampTZ Then
    '        Return CType(param.Value, OracleTimeStampTZ).Value
    '    ElseIf TypeOf param.Value Is OracleXmlStream Then
    '        Return CType(param.Value, OracleXmlStream).Value
    '    ElseIf TypeOf param.Value Is OracleXmlType Then
    '        Return CType(param.Value, OracleXmlType).Value
    '    ElseIf TypeOf param.Value Is System.Data.OracleClient.OracleBFile Then
    '        Return CType(param.Value, System.Data.OracleClient.OracleBFile).Value
    '    ElseIf TypeOf param.Value Is System.Data.OracleClient.OracleBinary Then
    '        Return CType(param.Value, System.Data.OracleClient.OracleBinary).Value
    '    ElseIf TypeOf param.Value Is OracleBlob Then
    '        Return CType(param.Value, OracleBlob).Value
    '    Else
    '        Return Nothing
    '    End If
    'End Function

#End Region

#Region "ExecuteDataset"

    ' Execute a OracleCommand (that returns a resultset and takes no parameters) against the database specified in 
    ' the connection string. 
    ' e.g.:  
    ' Dim ds As DataSet = OracleHelper.ExecuteDataset("", commandType.StoredProcedure, "GetOrders")
    ' Parameters:
    ' -connectionString - a valid connection string for a OracleConnection
    ' -commandType - the CommandType (stored procedure, text, etc.)
    ' -commandText - the stored procedure name or T-Oracle command
    ' Returns: A dataset containing the resultset generated by the command
    Public Overloads Shared Function ExecuteDataset(ByVal connectionString As String, _
       ByVal commandType As CommandType, _
       ByVal commandText As String) As DataSet
        ' Pass through the call providing null for the set of OracleParameters
        Return ExecuteDataset(connectionString, commandType, commandText, CType(Nothing, OracleParameter()))
    End Function ' ExecuteDataset

    ' Execute a OracleCommand (that returns a resultset) against the database specified in the connection string 
    ' using the provided parameters.
    ' e.g.:  
    ' Dim ds As Dataset = ExecuteDataset(connString, CommandType.StoredProcedure, "GetOrders", new OracleParameter("@prodid", 24))
    ' Parameters:
    ' -connectionString - a valid connection string for a OracleConnection
    ' -commandType - the CommandType (stored procedure, text, etc.)
    ' -commandText - the stored procedure name or T-Oracle command
    ' -commandParameters - an array of OracleParamters used to execute the command
    ' Returns: A dataset containing the resultset generated by the command
    Public Overloads Shared Function ExecuteDataset(ByVal connectionString As String, _
       ByVal commandType As CommandType, _
       ByVal commandText As String, _
       ByVal ParamArray commandParameters() As OracleParameter) As DataSet

        If (connectionString Is Nothing OrElse connectionString.Length = 0) Then Throw New ArgumentNullException("connectionString")

        ' Create & open a OracleConnection, and dispose of it after we are done
        Dim connection As OracleConnection = Nothing
        Try
            connection = New OracleConnection(connectionString)
            connection.Open()

            ' Call the overload that takes a connection in place of the connection string
            Return ExecuteDataset(connection, commandType, commandText, commandParameters)
        Finally
            If Not connection Is Nothing Then connection.Dispose()
        End Try
    End Function ' ExecuteDataset

    ' Execute a OracleCommand (that returns a resultset and takes no parameters) against the provided OracleConnection. 
    ' e.g.:  
    ' Dim ds As Dataset = ExecuteDataset(conn, CommandType.StoredProcedure, "GetOrders")
    ' Parameters:
    ' -connection - a valid OracleConnection
    ' -commandType - the CommandType (stored procedure, text, etc.)
    ' -commandText - the stored procedure name or T-Oracle command
    ' Returns: A dataset containing the resultset generated by the command
    Public Overloads Shared Function ExecuteDataset(ByVal connection As OracleConnection, _
       ByVal commandType As CommandType, _
       ByVal commandText As String) As DataSet

        ' Pass through the call providing null for the set of OracleParameters
        Return ExecuteDataset(connection, commandType, commandText, CType(Nothing, OracleParameter()))
    End Function ' ExecuteDataset

    ' Execute a OracleCommand (that returns a resultset) against the specified OracleConnection 
    ' using the provided parameters.
    ' e.g.:  
    ' Dim ds As Dataset = ExecuteDataset(conn, CommandType.StoredProcedure, "GetOrders", new OracleParameter("@prodid", 24))
    ' Parameters:
    ' -connection - a valid OracleConnection
    ' -commandType - the CommandType (stored procedure, text, etc.)
    ' -commandText - the stored procedure name or T-Oracle command
    ' -commandParameters - an array of OracleParamters used to execute the command
    ' Returns: A dataset containing the resultset generated by the command
    Public Overloads Shared Function ExecuteDataset(ByVal connection As OracleConnection, _
       ByVal commandType As CommandType, _
       ByVal commandText As String, _
       ByVal ParamArray commandParameters() As OracleParameter) As DataSet
        If (connection Is Nothing) Then Throw New ArgumentNullException("connection")
        ' Create a command and prepare it for execution
        Dim cmd As New OracleCommand
        Dim ds As New DataSet
        Dim dataAdatpter As OracleDataAdapter = Nothing
        Dim mustCloseConnection As Boolean = False

        PrepareCommand(cmd, connection, CType(Nothing, OracleTransaction), commandType, commandText, commandParameters, mustCloseConnection)

        Try
            ' Create the DataAdapter & DataSet
            dataAdatpter = New OracleDataAdapter(cmd)

            ' Fill the DataSet using default values for DataTable names, etc
            dataAdatpter.Fill(ds)
        Finally
            If (Not dataAdatpter Is Nothing) Then dataAdatpter.Dispose()
        End Try
        If (mustCloseConnection) Then connection.Close()

        ' Return the dataset
        Return ds
    End Function ' ExecuteDataset

    ' Execute a OracleCommand (that returns a resultset and takes no parameters) against the provided OracleTransaction. 
    ' e.g.:  
    ' Dim ds As Dataset = ExecuteDataset(trans, CommandType.StoredProcedure, "GetOrders")
    ' Parameters
    ' -transaction - a valid OracleTransaction
    ' -commandType - the CommandType (stored procedure, text, etc.)
    ' -commandText - the stored procedure name or T-Oracle command
    ' Returns: A dataset containing the resultset generated by the command
    Public Overloads Shared Function ExecuteDataset(ByVal transaction As OracleTransaction, _
       ByVal commandType As CommandType, _
       ByVal commandText As String) As DataSet
        ' Pass through the call providing null for the set of OracleParameters
        Return ExecuteDataset(transaction, commandType, commandText, CType(Nothing, OracleParameter()))
    End Function ' ExecuteDataset

    ' Execute a OracleCommand (that returns a resultset) against the specified OracleTransaction
    ' using the provided parameters.
    ' e.g.:  
    ' Dim ds As Dataset = ExecuteDataset(trans, CommandType.StoredProcedure, "GetOrders", new OracleParameter("@prodid", 24))
    ' Parameters
    ' -transaction - a valid OracleTransaction 
    ' -commandType - the CommandType (stored procedure, text, etc.)
    ' -commandText - the stored procedure name or T-Oracle command
    ' -commandParameters - an array of OracleParamters used to execute the command
    ' Returns: A dataset containing the resultset generated by the command
    Public Overloads Shared Function ExecuteDataset(ByVal transaction As OracleTransaction, _
       ByVal commandType As CommandType, _
       ByVal commandText As String, _
       ByVal ParamArray commandParameters() As OracleParameter) As DataSet
        If (transaction Is Nothing) Then Throw New ArgumentNullException("transaction")
        If Not (transaction Is Nothing) AndAlso (transaction.Connection Is Nothing) Then Throw New ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction")

        ' Create a command and prepare it for execution
        Dim cmd As New OracleCommand
        Dim ds As New DataSet
        Dim dataAdatpter As OracleDataAdapter = Nothing
        Dim mustCloseConnection As Boolean = False

        PrepareCommand(cmd, transaction.Connection, transaction, commandType, commandText, commandParameters, mustCloseConnection)

        Try
            ' Create the DataAdapter & DataSet
            dataAdatpter = New OracleDataAdapter(cmd)

            ' Fill the DataSet using default values for DataTable names, etc
            dataAdatpter.Fill(ds)
        Finally
            If (Not dataAdatpter Is Nothing) Then dataAdatpter.Dispose()
        End Try

        ' Return the dataset
        Return ds

    End Function ' ExecuteDataset

#End Region

#Region "ExecuteReader"
    ' this enum is used to indicate whether the connection was provided by the caller, or created by OracleHelper, so that
    ' we can set the appropriate CommandBehavior when calling ExecuteReader()
    Private Enum OracleConnectionOwnership
        ' Connection is owned and managed by OracleHelper
        Internal
        ' Connection is owned and managed by the caller
        [External]
    End Enum ' OracleConnectionOwnership

    ' Create and prepare a OracleCommand, and call ExecuteReader with the appropriate CommandBehavior.
    ' If we created and opened the connection, we want the connection to be closed when the DataReader is closed.
    ' If the caller provided the connection, we want to leave it to them to manage.
    ' Parameters:
    ' -connection - a valid OracleConnection, on which to execute this command 
    ' -transaction - a valid OracleTransaction, or ' null' 
    ' -commandType - the CommandType (stored procedure, text, etc.) 
    ' -commandText - the stored procedure name or SQL command 
    ' -commandParameters - an array of OracleParameters to be associated with the command or ' null' if no parameters are required 
    ' -connectionOwnership - indicates whether the connection parameter was provided by the caller, or created by OracleHelper 
    ' Returns: OracleDataReader containing the results of the command 
    Private Overloads Shared Function ExecuteReader(ByVal connection As OracleConnection, _
       ByVal transaction As OracleTransaction, _
       ByVal commandType As CommandType, _
       ByVal commandText As String, _
       ByVal commandParameters() As OracleParameter, _
       ByVal connectionOwnership As OracleConnectionOwnership) As OracleDataReader

        If (connection Is Nothing) Then Throw New ArgumentNullException("connection")

        Dim mustCloseConnection As Boolean = False
        ' Create a command and prepare it for execution
        Dim cmd As New OracleCommand
        Try
            ' Create a reader
            Dim dataReader As OracleDataReader

            PrepareCommand(cmd, connection, transaction, commandType, commandText, commandParameters, mustCloseConnection)

            ' Call ExecuteReader with the appropriate CommandBehavior
            If connectionOwnership = OracleConnectionOwnership.External Then
                dataReader = cmd.ExecuteReader()
            Else
                dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            End If

            Return dataReader
        Catch ex As Exception
            If (mustCloseConnection) Then connection.Close()
            Throw ex
        End Try
    End Function ' ExecuteReader

    ' Execute a OracleCommand (that returns a resultset and takes no parameters) against the database specified in 
    ' the connection string. 
    ' e.g.:  
    ' Dim dr As OracleDataReader = ExecuteReader(connString, CommandType.StoredProcedure, "GetOrders")
    ' Parameters:
    ' -connectionString - a valid connection string for a OracleConnection 
    ' -commandType - the CommandType (stored procedure, text, etc.) 
    ' -commandText - the stored procedure name or SQL command 
    ' Returns: A OracleDataReader containing the resultset generated by the command 
    Public Overloads Shared Function ExecuteReader(ByVal connectionString As String, _
      ByVal commandType As CommandType, _
      ByVal commandText As String) As OracleDataReader
        ' Pass through the call providing null for the set of OracleParameters
        Return ExecuteReader(connectionString, commandType, commandText, CType(Nothing, OracleParameter()))
    End Function ' ExecuteReader

    ' Execute a OracleCommand (that returns a resultset) against the database specified in the connection string 
    ' using the provided parameters.
    ' e.g.:  
    ' Dim dr As OracleDataReader = ExecuteReader(connString, CommandType.StoredProcedure, "GetOrders", new OracleParameter("@prodid", 24))
    ' Parameters:
    ' -connectionString - a valid connection string for a OracleConnection 
    ' -commandType - the CommandType (stored procedure, text, etc.) 
    ' -commandText - the stored procedure name or SQL command 
    ' -commandParameters - an array of OracleParamters used to execute the command 
    ' Returns: A OracleDataReader containing the resultset generated by the command 
    Public Overloads Shared Function ExecuteReader(ByVal connectionString As String, _
      ByVal commandType As CommandType, _
      ByVal commandText As String, _
      ByVal ParamArray commandParameters() As OracleParameter) As OracleDataReader
        If (connectionString Is Nothing OrElse connectionString.Length = 0) Then Throw New ArgumentNullException("connectionString")

        ' Create & open a OracleConnection
        Dim connection As OracleConnection = Nothing
        Try
            connection = New OracleConnection(connectionString)
            connection.Open()
            ' Call the private overload that takes an internally owned connection in place of the connection string
            Return ExecuteReader(connection, CType(Nothing, OracleTransaction), commandType, commandText, commandParameters, OracleConnectionOwnership.Internal)
        Catch
            ' If we fail to return the OracleDatReader, we need to close the connection ourselves
            If Not connection Is Nothing Then connection.Dispose()
            Throw
        End Try
    End Function ' ExecuteReader

    ' Execute a OracleCommand (that returns a resultset and takes no parameters) against the provided OracleConnection. 
    ' e.g.:  
    ' Dim dr As OracleDataReader = ExecuteReader(conn, CommandType.StoredProcedure, "GetOrders")
    ' Parameters:
    ' -connection - a valid OracleConnection 
    ' -commandType - the CommandType (stored procedure, text, etc.) 
    ' -commandText - the stored procedure name or SQL command 
    ' Returns: A OracleDataReader containing the resultset generated by the command 
    Public Overloads Shared Function ExecuteReader(ByVal connection As OracleConnection, _
      ByVal commandType As CommandType, _
      ByVal commandText As String) As OracleDataReader

        Return ExecuteReader(connection, commandType, commandText, CType(Nothing, OracleParameter()))

    End Function ' ExecuteReader

    ' Execute a OracleCommand (that returns a resultset) against the specified OracleConnection 
    ' using the provided parameters.
    ' e.g.:  
    ' Dim dr As OracleDataReader = ExecuteReader(conn, CommandType.StoredProcedure, "GetOrders", new OracleParameter("@prodid", 24))
    ' Parameters:
    ' -connection - a valid OracleConnection 
    ' -commandType - the CommandType (stored procedure, text, etc.) 
    ' -commandText - the stored procedure name or SQL command 
    ' -commandParameters - an array of OracleParamters used to execute the command 
    ' Returns: A OracleDataReader containing the resultset generated by the command 
    Public Overloads Shared Function ExecuteReader(ByVal connection As OracleConnection, _
      ByVal commandType As CommandType, _
      ByVal commandText As String, _
      ByVal ParamArray commandParameters() As OracleParameter) As OracleDataReader
        ' Pass through the call to private overload using a null transaction value
        Return ExecuteReader(connection, CType(Nothing, OracleTransaction), commandType, commandText, commandParameters, OracleConnectionOwnership.External)

    End Function ' ExecuteReader

    ' Execute a OracleCommand (that returns a resultset and takes no parameters) against the provided OracleTransaction.
    ' e.g.:  
    ' Dim dr As OracleDataReader = ExecuteReader(trans, CommandType.StoredProcedure, "GetOrders")
    ' Parameters:
    ' -transaction - a valid OracleTransaction  
    ' -commandType - the CommandType (stored procedure, text, etc.) 
    ' -commandText - the stored procedure name or SQL command 
    ' Returns: A OracleDataReader containing the resultset generated by the command 
    Public Overloads Shared Function ExecuteReader(ByVal transaction As OracleTransaction, _
      ByVal commandType As CommandType, _
      ByVal commandText As String) As OracleDataReader
        ' Pass through the call providing null for the set of OracleParameters
        Return ExecuteReader(transaction, commandType, commandText, CType(Nothing, OracleParameter()))
    End Function ' ExecuteReader

    ' Execute a OracleCommand (that returns a resultset) against the specified OracleTransaction
    ' using the provided parameters.
    ' e.g.:  
    ' Dim dr As OracleDataReader = ExecuteReader(trans, CommandType.StoredProcedure, "GetOrders", new OracleParameter("@prodid", 24))
    ' Parameters:
    ' -transaction - a valid OracleTransaction 
    ' -commandType - the CommandType (stored procedure, text, etc.)
    ' -commandText - the stored procedure name or SQL command 
    ' -commandParameters - an array of OracleParamters used to execute the command 
    ' Returns: A OracleDataReader containing the resultset generated by the command 
    Public Overloads Shared Function ExecuteReader(ByVal transaction As OracleTransaction, _
      ByVal commandType As CommandType, _
      ByVal commandText As String, _
      ByVal ParamArray commandParameters() As OracleParameter) As OracleDataReader
        If (transaction Is Nothing) Then Throw New ArgumentNullException("transaction")
        If Not (transaction Is Nothing) AndAlso (transaction.Connection Is Nothing) Then Throw New ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction")
        ' Pass through to private overload, indicating that the connection is owned by the caller
        Return ExecuteReader(transaction.Connection, transaction, commandType, commandText, commandParameters, OracleConnectionOwnership.External)
    End Function ' ExecuteReader

#End Region

#Region "ExecuteScalar"

    ' Execute a OracleCommand (that returns a 1x1 resultset and takes no parameters) against the database specified in 
    ' the connection string. 
    ' e.g.:  
    ' Dim orderCount As Integer = CInt(ExecuteScalar(connString, CommandType.StoredProcedure, "GetOrderCount"))
    ' Parameters:
    ' -connectionString - a valid connection string for a OracleConnection 
    ' -commandType - the CommandType (stored procedure, text, etc.) 
    ' -commandText - the stored procedure name or T-Oracle command 
    ' Returns: An object containing the value in the 1x1 resultset generated by the command
    Public Overloads Shared Function ExecuteScalar(ByVal connectionString As String, _
      ByVal commandType As CommandType, _
      ByVal commandText As String) As Object
        ' Pass through the call providing null for the set of OracleParameters
        Return ExecuteScalar(connectionString, commandType, commandText, CType(Nothing, OracleParameter()))
    End Function ' ExecuteScalar

    ' Execute a OracleCommand (that returns a 1x1 resultset) against the database specified in the connection string 
    ' using the provided parameters.
    ' e.g.:  
    ' Dim orderCount As Integer = Cint(ExecuteScalar(connString, CommandType.StoredProcedure, "GetOrderCount", new OracleParameter("@prodid", 24)))
    ' Parameters:
    ' -connectionString - a valid connection string for a OracleConnection 
    ' -commandType - the CommandType (stored procedure, text, etc.) 
    ' -commandText - the stored procedure name or T-Oracle command 
    ' -commandParameters - an array of OracleParamters used to execute the command 
    ' Returns: An object containing the value in the 1x1 resultset generated by the command 
    Public Overloads Shared Function ExecuteScalar(ByVal connectionString As String, _
      ByVal commandType As CommandType, _
      ByVal commandText As String, _
      ByVal ParamArray commandParameters() As OracleParameter) As Object
        If (connectionString Is Nothing OrElse connectionString.Length = 0) Then Throw New ArgumentNullException("connectionString")
        ' Create & open a OracleConnection, and dispose of it after we are done.
        Dim connection As OracleConnection = Nothing
        Try
            connection = New OracleConnection(connectionString)
            connection.Open()

            ' Call the overload that takes a connection in place of the connection string
            Return ExecuteScalar(connection, commandType, commandText, commandParameters)
        Finally
            If Not connection Is Nothing Then connection.Dispose()
        End Try
    End Function ' ExecuteScalar

    ' Execute a OracleCommand (that returns a 1x1 resultset and takes no parameters) against the provided OracleConnection. 
    ' e.g.:  
    ' Dim orderCount As Integer = CInt(ExecuteScalar(conn, CommandType.StoredProcedure, "GetOrderCount"))
    ' Parameters:
    ' -connection - a valid OracleConnection 
    ' -commandType - the CommandType (stored procedure, text, etc.) 
    ' -commandText - the stored procedure name or T-Oracle command 
    ' Returns: An object containing the value in the 1x1 resultset generated by the command 
    Public Overloads Shared Function ExecuteScalar(ByVal connection As OracleConnection, _
      ByVal commandType As CommandType, _
      ByVal commandText As String) As Object
        ' Pass through the call providing null for the set of OracleParameters
        Return ExecuteScalar(connection, commandType, commandText, CType(Nothing, OracleParameter()))
    End Function ' ExecuteScalar

    ' Execute a OracleCommand (that returns a 1x1 resultset) against the specified OracleConnection 
    ' using the provided parameters.
    ' e.g.:  
    ' Dim orderCount As Integer = CInt(ExecuteScalar(conn, CommandType.StoredProcedure, "GetOrderCount", new OracleParameter("@prodid", 24)))
    ' Parameters:
    ' -connection - a valid OracleConnection 
    ' -commandType - the CommandType (stored procedure, text, etc.) 
    ' -commandText - the stored procedure name or T-Oracle command 
    ' -commandParameters - an array of OracleParamters used to execute the command 
    ' Returns: An object containing the value in the 1x1 resultset generated by the command 
    Public Overloads Shared Function ExecuteScalar(ByVal connection As OracleConnection, _
      ByVal commandType As CommandType, _
      ByVal commandText As String, _
      ByVal ParamArray commandParameters() As OracleParameter) As Object

        If (connection Is Nothing) Then Throw New ArgumentNullException("connection")

        ' Create a command and prepare it for execution
        Dim cmd As New OracleCommand
        Dim retval As Object
        Dim mustCloseConnection As Boolean = False

        PrepareCommand(cmd, connection, CType(Nothing, OracleTransaction), commandType, commandText, commandParameters, mustCloseConnection)

        ' Execute the command & return the results
        retval = cmd.ExecuteScalar()

        If (mustCloseConnection) Then connection.Close()

        Return retval

    End Function ' ExecuteScalar

    ' Execute a OracleCommand (that returns a 1x1 resultset and takes no parameters) against the provided OracleTransaction.
    ' e.g.:  
    ' Dim orderCount As Integer  = CInt(ExecuteScalar(trans, CommandType.StoredProcedure, "GetOrderCount"))
    ' Parameters:
    ' -transaction - a valid OracleTransaction 
    ' -commandType - the CommandType (stored procedure, text, etc.) 
    ' -commandText - the stored procedure name or T-Oracle command 
    ' Returns: An object containing the value in the 1x1 resultset generated by the command 
    Public Overloads Shared Function ExecuteScalar(ByVal transaction As OracleTransaction, _
      ByVal commandType As CommandType, _
      ByVal commandText As String) As Object
        ' Pass through the call providing null for the set of OracleParameters
        Return ExecuteScalar(transaction, commandType, commandText, CType(Nothing, OracleParameter()))
    End Function ' ExecuteScalar

    ' Execute a OracleCommand (that returns a 1x1 resultset) against the specified OracleTransaction
    ' using the provided parameters.
    ' e.g.:  
    ' Dim orderCount As Integer = CInt(ExecuteScalar(trans, CommandType.StoredProcedure, "GetOrderCount", new OracleParameter("@prodid", 24)))
    ' Parameters:
    ' -transaction - a valid OracleTransaction  
    ' -commandType - the CommandType (stored procedure, text, etc.) 
    ' -commandText - the stored procedure name or T-Oracle command 
    ' -commandParameters - an array of OracleParamters used to execute the command 
    ' Returns: An object containing the value in the 1x1 resultset generated by the command 
    Public Overloads Shared Function ExecuteScalar(ByVal transaction As OracleTransaction, _
      ByVal commandType As CommandType, _
      ByVal commandText As String, _
      ByVal ParamArray commandParameters() As OracleParameter) As Object
        If (transaction Is Nothing) Then Throw New ArgumentNullException("transaction")
        If Not (transaction Is Nothing) AndAlso (transaction.Connection Is Nothing) Then Throw New ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction")

        ' Create a command and prepare it for execution
        Dim cmd As New OracleCommand
        Dim retval As Object
        Dim mustCloseConnection As Boolean = False

        PrepareCommand(cmd, transaction.Connection, transaction, commandType, commandText, commandParameters, mustCloseConnection)

        ' Execute the command & return the results
        retval = cmd.ExecuteScalar()

        Return retval
    End Function ' ExecuteScalar

#End Region

#Region "FillDataset"
    ' Execute a OracleCommand (that returns a resultset and takes no parameters) against the database specified in 
    ' the connection string. 
    ' e.g.:  
    '   FillDataset (connString, CommandType.StoredProcedure, "GetOrders", ds, new String() {"orders"})
    ' Parameters:    
    ' -connectionString: A valid connection string for a OracleConnection
    ' -commandType: the CommandType (stored procedure, text, etc.)
    ' -commandText: the stored procedure name or T-Oracle command
    ' -dataSet: A dataset wich will contain the resultset generated by the command
    ' -tableNames: this array will be used to create table mappings allowing the DataTables to be referenced
    '               by a user defined name (probably the actual table name)
    Public Overloads Shared Sub FillDataset(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String, ByVal dataSet As DataSet, ByVal tableNames() As String)

        If (connectionString Is Nothing OrElse connectionString.Length = 0) Then Throw New ArgumentNullException("connectionString")
        If (dataSet Is Nothing) Then Throw New ArgumentNullException("dataSet")

        ' Create & open a OracleConnection, and dispose of it after we are done
        Dim connection As OracleConnection = Nothing
        Try
            connection = New OracleConnection(connectionString)

            connection.Open()

            ' Call the overload that takes a connection in place of the connection string
            FillDataset(connection, commandType, commandText, dataSet, tableNames)
        Finally
            If Not connection Is Nothing Then connection.Dispose()
        End Try
    End Sub

    ' Execute a OracleCommand (that returns a resultset) against the database specified in the connection string 
    ' using the provided parameters.
    ' e.g.:  
    '   FillDataset (connString, CommandType.StoredProcedure, "GetOrders", ds, new String() = {"orders"}, new OracleParameter("@prodid", 24))
    ' Parameters:    
    ' -connectionString: A valid connection string for a OracleConnection
    ' -commandType: the CommandType (stored procedure, text, etc.)
    ' -commandText: the stored procedure name or T-Oracle command
    ' -dataSet: A dataset wich will contain the resultset generated by the command
    ' -tableNames: this array will be used to create table mappings allowing the DataTables to be referenced
    '               by a user defined name (probably the actual table name)
    ' -commandParameters: An array of OracleParamters used to execute the command
    Public Overloads Shared Sub FillDataset(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String, ByVal dataSet As DataSet, _
     ByVal tableNames() As String, ByVal ParamArray commandParameters() As OracleParameter)

        If (connectionString Is Nothing OrElse connectionString.Length = 0) Then Throw New ArgumentNullException("connectionString")
        If (dataSet Is Nothing) Then Throw New ArgumentNullException("dataSet")

        ' Create & open a OracleConnection, and dispose of it after we are done
        Dim connection As OracleConnection = Nothing
        Try
            connection = New OracleConnection(connectionString)

            connection.Open()

            ' Call the overload that takes a connection in place of the connection string
            FillDataset(connection, commandType, commandText, dataSet, tableNames, commandParameters)
        Finally
            If Not connection Is Nothing Then connection.Dispose()
        End Try
    End Sub

    ' Execute a OracleCommand (that returns a resultset and takes no parameters) against the provided OracleConnection. 
    ' e.g.:  
    '   FillDataset (conn, CommandType.StoredProcedure, "GetOrders", ds, new String() {"orders"})
    ' Parameters:
    ' -connection: A valid OracleConnection
    ' -commandType: the CommandType (stored procedure, text, etc.)
    ' -commandText: the stored procedure name or T-Oracle command
    ' -dataSet: A dataset wich will contain the resultset generated by the command
    ' -tableNames: this array will be used to create table mappings allowing the DataTables to be referenced
    ' by a user defined name (probably the actual table name)
    Public Overloads Shared Sub FillDataset(ByVal connection As OracleConnection, ByVal commandType As CommandType, _
     ByVal commandText As String, ByVal dataSet As DataSet, ByVal tableNames As String())

        FillDataset(connection, commandType, commandText, dataSet, tableNames, Nothing)

    End Sub

    ' Execute a OracleCommand (that returns a resultset) against the specified OracleConnection 
    ' using the provided parameters.
    ' e.g.:  
    '   FillDataset (conn, CommandType.StoredProcedure, "GetOrders", ds, new String() {"orders"}, new OracleParameter("@prodid", 24))
    ' Parameters:
    ' -connection: A valid OracleConnection
    ' -commandType: the CommandType (stored procedure, text, etc.)
    ' -commandText: the stored procedure name or T-Oracle command
    ' -dataSet: A dataset wich will contain the resultset generated by the command
    ' -tableNames: this array will be used to create table mappings allowing the DataTables to be referenced
    ' by a user defined name (probably the actual table name)
    ' -commandParameters: An array of OracleParamters used to execute the command
    Public Overloads Shared Sub FillDataset(ByVal connection As OracleConnection, ByVal commandType As CommandType, _
    ByVal commandText As String, ByVal dataSet As DataSet, ByVal tableNames As String(), _
     ByVal ParamArray commandParameters() As OracleParameter)

        FillDataset(connection, Nothing, commandType, commandText, dataSet, tableNames, commandParameters)

    End Sub

    ' Execute a OracleCommand (that returns a resultset and takes no parameters) against the provided OracleTransaction. 
    ' e.g.:  
    '   FillDataset (trans, CommandType.StoredProcedure, "GetOrders", ds, new string() {"orders"})
    ' Parameters:
    ' -transaction: A valid OracleTransaction
    ' -commandType: the CommandType (stored procedure, text, etc.)
    ' -commandText: the stored procedure name or T-Oracle command
    ' -dataSet: A dataset wich will contain the resultset generated by the command
    ' -tableNames: this array will be used to create table mappings allowing the DataTables to be referenced
    '             by a user defined name (probably the actual table name)
    Public Overloads Shared Sub FillDataset(ByVal transaction As OracleTransaction, ByVal commandType As CommandType, _
     ByVal commandText As String, ByVal dataSet As DataSet, ByVal tableNames() As String)

        FillDataset(transaction, commandType, commandText, dataSet, tableNames, Nothing)
    End Sub

    ' Execute a OracleCommand (that returns a resultset) against the specified OracleTransaction
    ' using the provided parameters.
    ' e.g.:  
    '   FillDataset(trans, CommandType.StoredProcedure, "GetOrders", ds, new string() {"orders"}, new OracleParameter("@prodid", 24))
    ' Parameters:
    ' -transaction: A valid OracleTransaction
    ' -commandType: the CommandType (stored procedure, text, etc.)
    ' -commandText: the stored procedure name or T-Oracle command
    ' -dataSet: A dataset wich will contain the resultset generated by the command
    ' -tableNames: this array will be used to create table mappings allowing the DataTables to be referenced
    ' by a user defined name (probably the actual table name)
    ' -commandParameters: An array of OracleParamters used to execute the command
    Public Overloads Shared Sub FillDataset(ByVal transaction As OracleTransaction, ByVal commandType As CommandType, _
     ByVal commandText As String, ByVal dataSet As DataSet, ByVal tableNames() As String, _
     ByVal ParamArray commandParameters() As OracleParameter)

        If (transaction Is Nothing) Then Throw New ArgumentNullException("transaction")
        If Not (transaction Is Nothing) AndAlso (transaction.Connection Is Nothing) Then Throw New ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction")
        FillDataset(transaction.Connection, transaction, commandType, commandText, dataSet, tableNames, commandParameters)

    End Sub

    ' Private helper method that execute a OracleCommand (that returns a resultset) against the specified OracleTransaction and OracleConnection
    ' using the provided parameters.
    ' e.g.:  
    '   FillDataset(conn, trans, CommandType.StoredProcedure, "GetOrders", ds, new String() {"orders"}, new OracleParameter("@prodid", 24))
    ' Parameters:
    ' -connection: A valid OracleConnection
    ' -transaction: A valid OracleTransaction
    ' -commandType: the CommandType (stored procedure, text, etc.)
    ' -commandText: the stored procedure name or T-Oracle command
    ' -dataSet: A dataset wich will contain the resultset generated by the command
    ' -tableNames: this array will be used to create table mappings allowing the DataTables to be referenced
    '             by a user defined name (probably the actual table name)
    ' -commandParameters: An array of OracleParamters used to execute the command
    Private Overloads Shared Sub FillDataset(ByVal connection As OracleConnection, ByVal transaction As OracleTransaction, ByVal commandType As CommandType, _
     ByVal commandText As String, ByVal dataSet As DataSet, ByVal tableNames() As String, _
     ByVal ParamArray commandParameters() As OracleParameter)

        If (connection Is Nothing) Then Throw New ArgumentNullException("connection")
        If (dataSet Is Nothing) Then Throw New ArgumentNullException("dataSet")

        ' Create a command and prepare it for execution
        Dim command As New OracleCommand

        Dim mustCloseConnection As Boolean = False
        PrepareCommand(command, connection, transaction, commandType, commandText, commandParameters, mustCloseConnection)

        ' Create the DataAdapter & DataSet
        Dim dataAdapter As OracleDataAdapter = New OracleDataAdapter(command)

        Try
            ' Add the table mappings specified by the user
            If Not tableNames Is Nothing AndAlso tableNames.Length > 0 Then

                Dim tableName As String = "Table"
                Dim index As Integer

                For index = 0 To tableNames.Length - 1
                    If (tableNames(index) Is Nothing OrElse tableNames(index).Length = 0) Then Throw New ArgumentException("The tableNames parameter must contain a list of tables, a value was provided as null or empty string.", "tableNames")
                    dataAdapter.TableMappings.Add(tableName, tableNames(index))
                    tableName = "Table" & (index + 1).ToString()
                Next
            End If

            ' Fill the DataSet using default values for DataTable names, etc
            dataAdapter.Fill(dataSet)

        Finally
            If (Not dataAdapter Is Nothing) Then dataAdapter.Dispose()
        End Try

        If (mustCloseConnection) Then connection.Close()

    End Sub
#End Region

#Region "FillDatatable"
    ' Execute a OracleCommand (that returns a resultset and takes no parameters) against the database specified in 
    ' the connection string. 
    ' e.g.:  
    '   FillDatatable (connString, CommandType.StoredProcedure, "GetOrders", ds, new String() {"orders"})
    ' Parameters:    
    ' -connectionString: A valid connection string for a OracleConnection
    ' -commandType: the CommandType (stored procedure, text, etc.)
    ' -commandText: the stored procedure name or T-Oracle command
    ' -dataSet: A dataset wich will contain the resultset generated by the command
    ' -tableNames: this array will be used to create table mappings allowing the DataTables to be referenced
    '               by a user defined name (probably the actual table name)
    Public Overloads Shared Sub FillDatatable(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String, ByVal dataTable As DataTable)

        If (connectionString Is Nothing OrElse connectionString.Length = 0) Then Throw New ArgumentNullException("connectionString")
        If (dataTable Is Nothing) Then Throw New ArgumentNullException("dataTable")

        ' Create & open a OracleConnection, and dispose of it after we are done
        Dim connection As OracleConnection = Nothing
        Try
            connection = New OracleConnection(connectionString)

            connection.Open()

            ' Call the overload that takes a connection in place of the connection string
            FillDatatable(connection, commandType, commandText, dataTable)
        Finally
            If Not connection Is Nothing Then connection.Dispose()
        End Try
    End Sub

    ' Execute a OracleCommand (that returns a resultset) against the database specified in the connection string 
    ' using the provided parameters.
    ' e.g.:  
    '   FillDatatable (connString, CommandType.StoredProcedure, "GetOrders", ds, new String() = {"orders"}, new OracleParameter("@prodid", 24))
    ' Parameters:    
    ' -connectionString: A valid connection string for a OracleConnection
    ' -commandType: the CommandType (stored procedure, text, etc.)
    ' -commandText: the stored procedure name or T-Oracle command
    ' -dataSet: A dataset wich will contain the resultset generated by the command
    ' -tableNames: this array will be used to create table mappings allowing the DataTables to be referenced
    '               by a user defined name (probably the actual table name)
    ' -commandParameters: An array of OracleParamters used to execute the command
    Public Overloads Shared Sub FillDatatable(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String, ByVal dataTable As DataTable, _
     ByVal ParamArray commandParameters() As OracleParameter)

        If (connectionString Is Nothing OrElse connectionString.Length = 0) Then Throw New ArgumentNullException("connectionString")
        If (dataTable Is Nothing) Then Throw New ArgumentNullException("dataTable")

        ' Create & open a OracleConnection, and dispose of it after we are done
        Dim connection As OracleConnection = Nothing
        Try
            connection = New OracleConnection(connectionString)

            connection.Open()

            ' Call the overload that takes a connection in place of the connection string
            FillDatatable(connection, commandType, commandText, dataTable, commandParameters)
        Finally
            If Not connection Is Nothing Then connection.Dispose()
        End Try
    End Sub

    ' Execute a OracleCommand (that returns a resultset and takes no parameters) against the provided OracleConnection. 
    ' e.g.:  
    '   FillDatatable (conn, CommandType.StoredProcedure, "GetOrders", ds, new String() {"orders"})
    ' Parameters:
    ' -connection: A valid OracleConnection
    ' -commandType: the CommandType (stored procedure, text, etc.)
    ' -commandText: the stored procedure name or T-Oracle command
    ' -dataSet: A dataset wich will contain the resultset generated by the command
    ' -tableNames: this array will be used to create table mappings allowing the DataTables to be referenced
    ' by a user defined name (probably the actual table name)
    Public Overloads Shared Sub FillDatatable(ByVal connection As OracleConnection, ByVal commandType As CommandType, _
     ByVal commandText As String, ByVal dataTable As DataTable)

        FillDatatable(connection, commandType, commandText, dataTable, Nothing)

    End Sub

    ' Execute a OracleCommand (that returns a resultset) against the specified OracleConnection 
    ' using the provided parameters.
    ' e.g.:  
    '   FillDatatable (conn, CommandType.StoredProcedure, "GetOrders", ds, new String() {"orders"}, new OracleParameter("@prodid", 24))
    ' Parameters:
    ' -connection: A valid OracleConnection
    ' -commandType: the CommandType (stored procedure, text, etc.)
    ' -commandText: the stored procedure name or T-Oracle command
    ' -dataSet: A dataset wich will contain the resultset generated by the command
    ' -tableNames: this array will be used to create table mappings allowing the DataTables to be referenced
    ' by a user defined name (probably the actual table name)
    ' -commandParameters: An array of OracleParamters used to execute the command
    Public Overloads Shared Sub FillDatatable(ByVal connection As OracleConnection, ByVal commandType As CommandType, _
     ByVal commandText As String, ByVal dataTable As DataTable, _
     ByVal ParamArray commandParameters() As OracleParameter)

        FillDatatable(connection, Nothing, commandType, commandText, dataTable, commandParameters)

    End Sub

    ' Execute a OracleCommand (that returns a resultset and takes no parameters) against the provided OracleTransaction. 
    ' e.g.:  
    '   FillDatatable (trans, CommandType.StoredProcedure, "GetOrders", ds, new string() {"orders"})
    ' Parameters:
    ' -transaction: A valid OracleTransaction
    ' -commandType: the CommandType (stored procedure, text, etc.)
    ' -commandText: the stored procedure name or T-Oracle command
    ' -dataSet: A dataset wich will contain the resultset generated by the command
    ' -tableNames: this array will be used to create table mappings allowing the DataTables to be referenced
    '             by a user defined name (probably the actual table name)
    Public Overloads Shared Sub FillDatatable(ByVal transaction As OracleTransaction, ByVal commandType As CommandType, _
     ByVal commandText As String, ByVal dataTable As DataTable)

        FillDatatable(transaction, commandType, commandText, dataTable, Nothing)
    End Sub

    ' Execute a OracleCommand (that returns a resultset) against the specified OracleTransaction
    ' using the provided parameters.
    ' e.g.:  
    '   FillDatatable(trans, CommandType.StoredProcedure, "GetOrders", ds, new string() {"orders"}, new OracleParameter("@prodid", 24))
    ' Parameters:
    ' -transaction: A valid OracleTransaction
    ' -commandType: the CommandType (stored procedure, text, etc.)
    ' -commandText: the stored procedure name or T-Oracle command
    ' -dataSet: A dataset wich will contain the resultset generated by the command
    ' -tableNames: this array will be used to create table mappings allowing the DataTables to be referenced
    ' by a user defined name (probably the actual table name)
    ' -commandParameters: An array of OracleParamters used to execute the command
    Public Overloads Shared Sub FillDatatable(ByVal transaction As OracleTransaction, ByVal commandType As CommandType, _
     ByVal commandText As String, ByVal dataTable As DataTable, _
     ByVal ParamArray commandParameters() As OracleParameter)

        If (transaction Is Nothing) Then Throw New ArgumentNullException("transaction")
        If Not (transaction Is Nothing) AndAlso (transaction.Connection Is Nothing) Then Throw New ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction")
        FillDatatable(transaction.Connection, transaction, commandType, commandText, dataTable, commandParameters)

    End Sub

    ' Private helper method that execute a OracleCommand (that returns a resultset) against the specified OracleTransaction and OracleConnection
    ' using the provided parameters.
    ' e.g.:  
    '   FillDatatable(conn, trans, CommandType.StoredProcedure, "GetOrders", ds, new String() {"orders"}, new OracleParameter("@prodid", 24))
    ' Parameters:
    ' -connection: A valid OracleConnection
    ' -transaction: A valid OracleTransaction
    ' -commandType: the CommandType (stored procedure, text, etc.)
    ' -commandText: the stored procedure name or T-Oracle command
    ' -dataSet: A dataset wich will contain the resultset generated by the command
    ' -tableNames: this array will be used to create table mappings allowing the DataTables to be referenced
    '             by a user defined name (probably the actual table name)
    ' -commandParameters: An array of OracleParamters used to execute the command
    Private Overloads Shared Sub FillDatatable(ByVal connection As OracleConnection, ByVal transaction As OracleTransaction, ByVal commandType As CommandType, _
     ByVal commandText As String, ByVal dataTable As DataTable, _
     ByVal ParamArray commandParameters() As OracleParameter)

        If (connection Is Nothing) Then Throw New ArgumentNullException("connection")
        If (dataTable Is Nothing) Then Throw New ArgumentNullException("dataTable")

        ' Create a command and prepare it for execution
        Dim command As New OracleCommand

        Dim mustCloseConnection As Boolean = False
        PrepareCommand(command, connection, transaction, commandType, commandText, commandParameters, mustCloseConnection)

        ' Create the DataAdapter & DataSet
        Dim dataAdapter As OracleDataAdapter = New OracleDataAdapter(command)

        Try
            ' Fill the DataSet using default values for DataTable names, etc
            dataAdapter.Fill(dataTable)
        Finally
            If (Not dataAdapter Is Nothing) Then dataAdapter.Dispose()
        End Try

        If (mustCloseConnection) Then connection.Close()

    End Sub
#End Region

#Region "UpdateDataset"
    ' Executes the respective command for each inserted, updated, or deleted row in the DataSet.
    ' e.g.:  
    '   UpdateDataset(conn, insertCommand, deleteCommand, updateCommand, dataSet, "Order")
    ' Parameters:
    ' -insertCommand: A valid transact-Oracle statement or stored procedure to insert new records into the data source
    ' -deleteCommand: A valid transact-Oracle statement or stored procedure to delete records from the data source
    ' -updateCommand: A valid transact-Oracle statement or stored procedure used to update records in the data source
    ' -dataSet: the DataSet used to update the data source
    ' -tableName: the DataTable used to update the data source
    Public Overloads Shared Sub UpdateDataset(ByVal insertCommand As OracleCommand, ByVal deleteCommand As OracleCommand, ByVal updateCommand As OracleCommand, ByVal dataSet As DataSet, ByVal tableName As String)

        If (insertCommand Is Nothing) Then Throw New ArgumentNullException("insertCommand")
        If (deleteCommand Is Nothing) Then Throw New ArgumentNullException("deleteCommand")
        If (updateCommand Is Nothing) Then Throw New ArgumentNullException("updateCommand")
        If (dataSet Is Nothing) Then Throw New ArgumentNullException("dataSet")
        If (tableName Is Nothing OrElse tableName.Length = 0) Then Throw New ArgumentNullException("tableName")

        ' Create a OracleDataAdapter, and dispose of it after we are done
        Dim dataAdapter As New OracleDataAdapter
        Try
            ' Set the data adapter commands
            dataAdapter.UpdateCommand = updateCommand
            dataAdapter.InsertCommand = insertCommand
            dataAdapter.DeleteCommand = deleteCommand

            ' Update the dataset changes in the data source
            dataAdapter.Update(dataSet, tableName)

            ' Commit all the changes made to the DataSet
            dataSet.AcceptChanges()
        Finally
            If (Not dataAdapter Is Nothing) Then dataAdapter.Dispose()
        End Try
    End Sub
#End Region

    'Create and open a connection
    Public Shared Function OpenConnection(ByVal ConnectionString As String) As OracleConnection
        If (ConnectionString Is Nothing) OrElse (ConnectionString = String.Empty) Then
            Throw New ArgumentNullException("ConnectionString", "ConnectionString chưa được khởi tạo")
        End If
        Dim cnn As New OracleConnection
        Try
            With cnn
                .ConnectionString = ConnectionString
                .Open()
            End With
            Return cnn
        Catch ex As Exception
            cnn = Nothing
            Throw ex
        End Try
    End Function

    'Close and release a connection
    Public Shared Sub CloseConnection(ByRef Connection As OracleConnection)
        Try
            If Not Connection Is Nothing Then
                With Connection
                    If .State <> ConnectionState.Closed Then
                        .Close()
                    End If
                    .Dispose()
                End With
            End If
        Catch
        Finally
            Connection = Nothing
        End Try
    End Sub

    Public Shared Function GetCustomMessage(ByVal ex As OracleException) As String
        Dim p1 As Integer = ("ORA-" & ex.ErrorCode & ": ").Length
        Dim iLen As Integer = ex.Message.IndexOf(1)
        If iLen = -1 Then
            Return ex.Message.Substring(p1)
        Else
            Return ex.Message.Substring(p1, iLen - p1)
        End If
    End Function

End Class ' OracleHelper

' OracleHelperParameterCache provides functions to leverage a static cache of procedure parameters, and the
' ability to discover parameters for stored procedures at run-time.
Public NotInheritable Class OracleHelperParameterCache

#Region "private methods, variables, and constructors"


    ' Since this class provides only static methods, make the default constructor private to prevent 
    ' instances from being created with "new OracleHelperParameterCache()".
    Private Sub New()
    End Sub ' New 

    Private Shared paramCache As Hashtable = Hashtable.Synchronized(New Hashtable)

    ' Deep copy of cached OracleParameter array
    Private Shared Function CloneParameters(ByVal originalParameters() As OracleParameter) As OracleParameter()

        Dim iramrameter As OracleParameter()

        Dim i As Integer
        Dim j As Integer = originalParameters.Length - 1
        Dim clonedParameters(j) As OracleParameter

        For i = 0 To j
            clonedParameters(i) = CType(CType(originalParameters(i), ICloneable).Clone, OracleParameter)
        Next

        Return clonedParameters
    End Function    ' CloneParameters

#End Region

#Region "caching functions"

    ' add parameter array to the cache
    ' Parameters
    ' -connectionString - a valid connection string for a OracleConnection 
    ' -commandText - the stored procedure name or T-Oracle command 
    ' -commandParameters - an array of OracleParamters to be cached 
    Public Shared Sub CacheParameterSet(ByVal connectionString As String, _
       ByVal commandText As String, _
       ByVal ParamArray commandParameters() As OracleParameter)
        If (connectionString Is Nothing OrElse connectionString.Length = 0) Then Throw New ArgumentNullException("connectionString")
        If (commandText Is Nothing OrElse commandText.Length = 0) Then Throw New ArgumentNullException("commandText")

        Dim hashKey As String = connectionString + ":" + commandText

        paramCache(hashKey) = commandParameters
    End Sub ' CacheParameterSet

    ' retrieve a parameter array from the cache
    ' Parameters:
    ' -connectionString - a valid connection string for a OracleConnection 
    ' -commandText - the stored procedure name or T-Oracle command 
    ' Returns: An array of OracleParamters 
    Public Shared Function GetCachedParameterSet(ByVal connectionString As String, ByVal commandText As String) As OracleParameter()
        If (connectionString Is Nothing OrElse connectionString.Length = 0) Then Throw New ArgumentNullException("connectionString")
        If (commandText Is Nothing OrElse commandText.Length = 0) Then Throw New ArgumentNullException("commandText")

        Dim hashKey As String = connectionString + ":" + commandText
        Dim cachedParameters As OracleParameter() = CType(paramCache(hashKey), OracleParameter())

        If cachedParameters Is Nothing Then
            Return Nothing
        Else
            Return CloneParameters(cachedParameters)
        End If
    End Function    ' GetCachedParameterSet

#End Region
End Class