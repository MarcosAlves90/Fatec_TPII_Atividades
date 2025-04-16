Imports Npgsql

Module data_grid_view_1

    Public Sub FillDataGridView1()
        Try
            Using conexao As NpgsqlConnection = DatabaseConnection.GetConnection(),
              cmd As New NpgsqlCommand("
                SELECT 
                    b.id AS ID,
                    b.title AS Título,
                    a.name AS Autor,
                    g.description AS Gênero,
                    b.release_year AS Lançamento,
                    CASE 
                        WHEN als.book_id IS NULL THEN 'Disponível'
                        ELSE 'Indisponível'
                    END AS Disponibilidade,
                    CASE 
                        WHEN als.book_id IS NULL THEN 'N/A'
                        WHEN CURRENT_DATE <= als.return_date THEN 'Em dia'
                        WHEN CURRENT_DATE > als.return_date THEN 'Atrasado'
                        ELSE 'N/A'
                    END AS Status
                FROM books b
                JOIN authors a ON b.author_id = a.id
                LEFT JOIN genres g ON b.genre_id = g.id
                LEFT JOIN LATERAL (
                    SELECT * 
                    FROM allocation_status 
                    WHERE book_id = b.id 
                    ORDER BY allocation_date DESC 
                    LIMIT 1
                ) als ON true
                ORDER BY b.title;", conexao),
              adapter As New NpgsqlDataAdapter(cmd)

                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                With Menu.DataGridView1
                    .AutoGenerateColumns = False

                    ' Adiciona a coluna ID (oculta)
                    If Not .Columns.Contains("ID") Then
                        Dim idColumn As New DataGridViewTextBoxColumn()
                        idColumn.Name = "ID"
                        idColumn.DataPropertyName = "ID"
                        idColumn.Visible = False ' Torna a coluna oculta
                        .Columns.Add(idColumn)
                    End If

                    ' Configura as outras colunas
                    .Columns("Título").DataPropertyName = "Título"
                    .Columns("Autor").DataPropertyName = "Autor"
                    .Columns("Gênero").DataPropertyName = "Gênero"
                    .Columns("Lançamento").DataPropertyName = "Lançamento"
                    .Columns("Disponibilidade").DataPropertyName = "Disponibilidade"
                    .Columns("Status").DataPropertyName = "Status"
                    .DataSource = dataTable
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show($"Erro ao carregar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub DataGridView1_CellContentClick(e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            If Menu.DataGridView1.Columns(e.ColumnIndex).Name = "Editar" Then
                Dim bookId As Integer = Convert.ToInt32(Menu.DataGridView1.Rows(e.RowIndex).Cells("ID").Value)
                Dim livroForm As New Livro()
                livroForm.LoadBookData(bookId)
                livroForm.Show()
            End If
        End If
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Verifica se a coluna é a coluna "Excluir"
            If Menu.DataGridView1.Columns(e.ColumnIndex).Name = "Excluir" Then
                Dim bookId As Integer = Convert.ToInt32(Menu.DataGridView1.Rows(e.RowIndex).Cells("ID").Value)

                ' Confirmação antes de excluir
                Dim confirmResult As DialogResult = MessageBox.Show("Tem certeza de que deseja excluir este livro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirmResult = DialogResult.Yes Then
                    Try
                        Using conexao As NpgsqlConnection = DatabaseConnection.GetConnection()
                            Using transacao As NpgsqlTransaction = conexao.BeginTransaction()
                                Try
                                    ' Exclui as informações de alocação relacionadas ao livro
                                    Using cmd As New NpgsqlCommand("
                                    DELETE FROM allocation_status 
                                    WHERE book_id = @book_id;", conexao, transacao)
                                        cmd.Parameters.AddWithValue("@book_id", bookId)
                                        cmd.ExecuteNonQuery()
                                    End Using

                                    ' Exclui o livro
                                    Using cmd As New NpgsqlCommand("
                                    DELETE FROM books 
                                    WHERE id = @book_id;", conexao, transacao)
                                        cmd.Parameters.AddWithValue("@book_id", bookId)
                                        cmd.ExecuteNonQuery()
                                    End Using

                                    transacao.Commit()
                                    MessageBox.Show("Livro excluído com sucesso! :)", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                    ' Atualiza o DataGridView1
                                    FillDataGridView1()
                                Catch ex As Exception
                                    transacao.Rollback()
                                    MessageBox.Show($"Erro ao excluir o livro :(", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End Try
                            End Using
                        End Using
                    Catch ex As Exception
                        MessageBox.Show($"Erro ao conectar ao banco de dados :(", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        End If
    End Sub
End Module
