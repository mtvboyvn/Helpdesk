Imports System
Imports System.Data
Imports System.Data.OleDb
Imports Oracle.DataAccess
Imports Oracle.DataAccess.Client
Public Class Oracle
    Public Shared Function SOSANH_MAHAIDONVI_V2(ByVal conect As String, ByVal query As String) As DataTable
        Dim conn As New OracleConnection(conect)
        Dim cmd As New OracleCommand(query, conn)
        cmd.CommandType = CommandType.Text
        Dim adapter As New OracleDataAdapter(cmd)
        conn.Open()
        Dim resultDS As New DataSet()
        Try
            adapter.Fill(resultDS)
        Catch
            conn.Close()
            Return Nothing
        Finally
            conn.Close()
        End Try
        Return resultDS.Tables(0)
    End Function
    Public Shared Function LayDuLieu(ByVal conect As String, ByVal query As String) As DataTable
        Dim conn As New OracleConnection(conect)
        Dim cmd As New OracleCommand(query, conn)
        cmd.CommandType = CommandType.Text
        Dim adapter As New OracleDataAdapter(cmd)
        conn.Open()
        cmd.Transaction = cmd.Connection.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim resultDS As New DataSet()
        Try
            adapter.Fill(resultDS)
            cmd.Transaction.Commit()
        Catch
            conn.Close()
            Return Nothing
        Finally
            conn.Close()
        End Try
        Return resultDS.Tables(0)
    End Function

End Class
