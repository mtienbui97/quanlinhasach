Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports MySql.Data
Imports MySql.Data.MySqlClient
    Public Class DataAccessHelper
        Public Shared ReadOnly Property ConnectionString() As String
            Get
                Return "Server=localhost;User Id=root;Password=3725141531;Database=quanlynhasach"
            End Get
        End Property
        Public Shared Function ExecuteQuery(spName As String, Optional parameters As List(Of MySqlParameter) = Nothing) As DataTable
            Dim dt = New DataTable()
            Try
                Dim connect = New MySqlConnection(ConnectionString)
                connect.Open()
                Try
                    Dim command As MySqlCommand = connect.CreateCommand()
                    command.CommandType = CommandType.StoredProcedure
                    command.CommandText = spName
                    If parameters IsNot Nothing Then
                        For Each parameter In parameters
                            command.Parameters.Add(parameter)
                        Next
                    End If
                    Dim adapter As New MySqlDataAdapter()
                    adapter.SelectCommand = command
                    adapter.Fill(dt)
                Catch ex As Exception
                    Throw ex
                Finally
                    connect.Close()
                End Try
            Catch ex As Exception
                Throw ex
            End Try
            Return dt
        End Function
        Public Shared Function ExecuteNonQuery(spName As String, Optional parameters As List(Of MySqlParameter) = Nothing) As Integer
            Dim n As Integer
            Try
                Dim connect = New MySqlConnection(ConnectionString)
                connect.Open()
                Try
                    Dim command As MySqlCommand = connect.CreateCommand()
                    command.CommandType = CommandType.StoredProcedure
                    command.CommandText = spName
                    If parameters IsNot Nothing Then
                        For Each parameter As MySqlParameter In parameters
                            command.Parameters.Add(parameter)
                        Next
                    End If
                    n = command.ExecuteNonQuery()
                Catch ex As SqlException
                    Throw ex
                Finally
                    connect.Close()
                End Try
            Catch ex As Exception
                Throw ex
            End Try
            Return n
        End Function
    End Class
