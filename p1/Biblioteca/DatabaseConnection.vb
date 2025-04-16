Imports System.Configuration
Imports Npgsql

Public Class DatabaseConnection
    Private Shared conexao As NpgsqlConnection
    Private Shared ReadOnly connectionString As String = ConfigurationManager.ConnectionStrings("MinhaConexao")?.ConnectionString

    Shared Sub New()
        If String.IsNullOrWhiteSpace(connectionString) Then
            Throw New InvalidOperationException("A string de conexão 'MinhaConexao' não foi encontrada ou está vazia no arquivo de configuração.")
        End If
    End Sub

    Public Shared Function GetConnection() As NpgsqlConnection
        If conexao Is Nothing OrElse conexao.State <> ConnectionState.Open Then
            conexao?.Dispose()
            conexao = New NpgsqlConnection(connectionString)

            Try
                conexao.Open()
            Catch ex As Exception
                Throw New InvalidOperationException("Erro ao conectar ao banco de dados.", ex)
            End Try
        End If

        Return conexao
    End Function

    Public Shared Sub CloseConnection()
        If conexao?.State = ConnectionState.Open Then
            Try
                conexao.Close()
            Catch ex As Exception
                Throw New InvalidOperationException("Erro ao fechar a conexão com o banco de dados.", ex)
            Finally
                conexao.Dispose()
                conexao = Nothing
            End Try
        End If
    End Sub
End Class
