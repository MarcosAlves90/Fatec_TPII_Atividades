Module shortcuts
    Public Sub OpenApp(app As String)
        Try
            System.Diagnostics.Process.Start(app & ".exe")
        Catch ex As Exception
            MessageBox.Show("Não foi possível abrir o programa '" & app & "'. Erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SearchOnGoogle(search_term As String)
        If String.IsNullOrWhiteSpace(search_term) Then
            MessageBox.Show("A consulta de pesquisa não pode estar vazia :/", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim googleSearchUrl As String = $"https://www.google.com/search?q={Uri.EscapeDataString(search_term)}"
        Try
            Process.Start(New ProcessStartInfo("cmd", $"/c start {googleSearchUrl}") With {.CreateNoWindow = True})
        Catch ex As Exception
            MessageBox.Show("Não foi possível abrir o navegador :(", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Module
