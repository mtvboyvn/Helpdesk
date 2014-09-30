Public NotInheritable Class Config
    'Private Const CONST_XPATH_MHS As String = ".//GTT01/CONNECTIONSTRING/MHS"
    'Private Const CONST_XPATH_NGHIEPVU As String = ".//GTT01/CONNECTIONSTRING/NGHIEPVU"
    'Private Const CONST_XPATH_QUANTRI As String = ".//GTT01/CONNECTIONSTRING/QUANTRI"
    'Private Const CONST_XPATH_TRACUU As String = ".//GTT01/CONNECTIONSTRING/TRACUU"
    'Private Const CONST_XPATH_LOG As String = ".//GTT01/CONNECTIONSTRING/AUDIT"
    'Private Const CONST_LOCK_TIMEOUT As String = ".//LockTimeOut"
    'Private Const CONST_WEBSERVICES_GETDATAXNK_PREFIX_URL As String = ".//WEBSERVICES_URL/"
    'Private Const CONST_WEBSERVICES_GETDATAXNK_SUFFIX_URL As String = "_GETDATAXNK"
    Private Const CONST_XPATH_MHS_HOME As String = ".//THUEXNK/CONNECTIONSTRING/MHS_HOME"
    Private Const CONST_XPATH_MHS As String = ".//THUEXNK/CONNECTIONSTRING/MHS_46"
    Private Const CONST_XPATH_NGHIEPVU As String = ".//THUEXNK/CONNECTIONSTRING/NGHIEPVU"
    Private Const CONST_XPATH_QUANTRI As String = ".//THUEXNK/CONNECTIONSTRING/QUANTRI"
    Private Const CONST_XPATH_TRACUU As String = ".//THUEXNK/CONNECTIONSTRING/TRACUU"
    Private Const CONST_XPATH_LOG As String = ".//THUEXNK/CONNECTIONSTRING/AUDIT"
    Private Const CONST_LOCK_TIMEOUT As String = ".//LockTimeOut"
    Private Const CONST_WEBSERVICES_GETDATAXNK_PREFIX_URL As String = ".//WEBSERVICES_URL/"
    Private Const CONST_WEBSERVICES_GETDATAXNK_SUFFIX_URL As String = "_GETDATAXNK"

    ''Demo Oracle Home
    Private Shared _ConnectionStringMHS_HOME As String = String.Empty
    Private Shared _ConnectionStringMHS_TRACUU As String = String.Empty
    Public Shared ReadOnly Property ConnectionStringMHS_HOME() As String
        Get
            If _ConnectionStringMHS_HOME.IsNull() Then _ConnectionStringMHS_HOME = GetConnectionString(CONST_XPATH_MHS_HOME)
            Return _ConnectionStringMHS_HOME
        End Get
    End Property

    Private Shared _ConnectionStringMHS As String = String.Empty
    Public Shared ReadOnly Property ConnectionStringMHS() As String
        
        'Return "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.15.20.46)(PORT=1521))(CONNECT_DATA=(SERVER=dedicated)(SERVICE_NAME=MHS)));User ID=MHS;Password=123456; Persist Security Info=True"
        Get
            If _ConnectionStringMHS.IsNull() Then _ConnectionStringMHS = GetConnectionString(CONST_XPATH_MHS)

            Return _ConnectionStringMHS
        End Get
    End Property
    Public Shared ReadOnly Property ConnectionStringMHS_TRACUU() As String
        Get
            If _ConnectionStringMHS_TRACUU.IsNull() Then _ConnectionStringMHS_TRACUU = GetConnectionString(CONST_XPATH_TRACUU)
            Return _ConnectionStringMHS_TRACUU
            'Return "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.15.147.68)(PORT=1521))(CONNECT_DATA=(SERVER=dedicated)(SERVICE_NAME=MHSFLAT)));User ID=MHSFLAT;Password=MHSFLAT; Persist Security Info=True"
        End Get
    End Property
    Private Shared _ProviderName As String = String.Empty
    ''Lay ProviderName MHS
    Public Shared ReadOnly Property ProviderName() As String
        Get
            If _ProviderName.IsNull() Then _ProviderName = "Oracle.DataAccess.Client"

            Return _ProviderName
        End Get
    End Property
    ''' <summary>
    ''' '''
    ''' </summary>
    ''' <remarks></remarks>
    Private Shared _ConnectionStringNghiepVu As String = String.Empty
    Public Shared ReadOnly Property ConnectionStringNghiepVu() As String
        Get
            If _ConnectionStringNghiepVu.IsNull() Then _ConnectionStringNghiepVu = GetConnectionString(CONST_XPATH_NGHIEPVU)
            Return _ConnectionStringNghiepVu
        End Get
    End Property

    Private Shared _ConnectionStringTraCuu As String = String.Empty
    Public Shared ReadOnly Property ConnectionStringTraCuu() As String
        Get
            If _ConnectionStringTraCuu.IsNull() Then _ConnectionStringTraCuu = GetConnectionString(CONST_XPATH_TRACUU)
            Return _ConnectionStringTraCuu
        End Get
    End Property

    Private Shared _ConnectionStringLog As String = String.Empty
    Public Shared ReadOnly Property ConnectionStringLog() As String
        Get
            If _ConnectionStringLog.IsNull() Then _ConnectionStringLog = GetConnectionString(CONST_XPATH_LOG)
            Return _ConnectionStringLog
        End Get
    End Property

    Private Shared _ConnectionStringQuanTri As String = String.Empty
    Public Shared ReadOnly Property ConnectionStringQuanTri() As String
        Get
            If _ConnectionStringQuanTri.IsNull() Then _ConnectionStringQuanTri = GetConnectionString(CONST_XPATH_QUANTRI)
            Return _ConnectionStringQuanTri
        End Get
    End Property

    Public Shared ReadOnly Property WEBSERVICES_GETDATAXNK_URL(ByVal MA_HQ As String) As String
        Get
            Return GetConnectionString(CONST_WEBSERVICES_GETDATAXNK_PREFIX_URL & MA_HQ.Trim() & CONST_WEBSERVICES_GETDATAXNK_SUFFIX_URL).Trim
        End Get
    End Property

    Public Shared ReadOnly Property LockTimeOut() As Integer
        Get
            Return CInt(GetConnectionString(CONST_LOCK_TIMEOUT).Trim)
        End Get
    End Property

    Private Shared Function GetConnectionString(ByVal xPath As String) As String
        Dim Conn As String = String.Empty
        Conn = AppSetting.GetInnerTextNode(xPath)
        'Dim oEncrypt As New EncyptPassword
        'Conn = oEncrypt.EncryptPasswd(Conn)        
        Return Conn
    End Function
End Class