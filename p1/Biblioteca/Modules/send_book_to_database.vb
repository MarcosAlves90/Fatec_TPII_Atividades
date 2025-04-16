Imports Npgsql

Module send_book_to_database

    Public Function InsertOrGetId(connection As NpgsqlConnection, transaction As NpgsqlTransaction, table As String, column As String, value As String) As Integer
        Dim queryInsert = $"INSERT INTO {table} ({column}) VALUES (@value) ON CONFLICT ({column}) DO NOTHING RETURNING id;"
        Dim querySelect = $"SELECT id FROM {table} WHERE {column} = @value;"

        Using cmd = New NpgsqlCommand(queryInsert, connection, transaction)
            cmd.Parameters.AddWithValue("@value", value)
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then Return Convert.ToInt32(result)
        End Using

        Using cmd = New NpgsqlCommand(querySelect, connection, transaction)
            cmd.Parameters.AddWithValue("@value", value)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    Public Function InsertBook(connection As NpgsqlConnection, transaction As NpgsqlTransaction, title As String, authorId As Integer, genreId As Integer, year As Integer, cover As Byte()) As Integer
        Using cmd = New NpgsqlCommand("INSERT INTO books (title, author_id, genre_id, release_year, cover_image) VALUES (@title, @autor_id, @genero_id, @ano, @capa) RETURNING id;", connection, transaction)
            cmd.Parameters.AddWithValue("@title", title)
            cmd.Parameters.AddWithValue("@autor_id", authorId)
            cmd.Parameters.AddWithValue("@genero_id", genreId)
            cmd.Parameters.AddWithValue("@ano", year)
            cmd.Parameters.AddWithValue("@capa", If(cover IsNot Nothing, cover, DBNull.Value))
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    Public Sub InsertOrUpdateAllocator(connection As NpgsqlConnection, transaction As NpgsqlTransaction, cpf As String, name As String, phone As String)
        Using cmd = New NpgsqlCommand("INSERT INTO allocators (cpf, name, phone) VALUES (@cpf, @name, @phone) ON CONFLICT (cpf) DO UPDATE SET name = @name, phone = @phone;", connection, transaction)
            cmd.Parameters.AddWithValue("@cpf", cpf)
            cmd.Parameters.AddWithValue("@name", name)
            cmd.Parameters.AddWithValue("@phone", phone)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub InsertAllocationStatus(connection As NpgsqlConnection, transaction As NpgsqlTransaction, bookId As Integer, allocatorCpf As String, allocationDate As Date, returnDate As Date)
        Using cmd = New NpgsqlCommand("INSERT INTO allocation_status (book_id, allocator_id, allocation_date, return_date) VALUES (@book_id, @allocator_cpf, @allocation_date, @return_date);", connection, transaction)
            cmd.Parameters.AddWithValue("@book_id", bookId)
            cmd.Parameters.AddWithValue("@allocator_cpf", allocatorCpf)
            cmd.Parameters.AddWithValue("@allocation_date", allocationDate)
            cmd.Parameters.AddWithValue("@return_date", If(returnDate = Date.MinValue, DBNull.Value, returnDate))
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub SaveBook(bookId As Integer, bookTitle As String, bookYear As Integer, bookAuthor As String, bookGenre As String, allocatorName As String, allocatorCpf As String, allocatorCellphone As String, bookAllocationDate As Date, bookReturnDate As Date, bookAvailability As Boolean, bookCover As Byte())
        Using connection = DatabaseConnection.GetConnection()
            Using transaction = connection.BeginTransaction()
                Try
                    Dim authorId = InsertOrGetId(connection, transaction, "authors", "name", bookAuthor)
                    Dim genreId = InsertOrGetId(connection, transaction, "genres", "description", bookGenre)

                    If bookId = -1 Then
                        Dim newBookId = InsertBook(connection, transaction, bookTitle, authorId, genreId, bookYear, bookCover)

                        If Not bookAvailability Then
                            InsertOrUpdateAllocator(connection, transaction, allocatorCpf, allocatorName, allocatorCellphone)
                            InsertAllocationStatus(connection, transaction, newBookId, allocatorCpf, bookAllocationDate, bookReturnDate)
                        End If
                    Else
                        Using cmd = New NpgsqlCommand("
                            UPDATE books 
                            SET title = @title, 
                                author_id = @author_id, 
                                genre_id = @genre_id, 
                                release_year = @release_year, 
                                cover_image = @cover_image
                            WHERE id = @id;", connection, transaction)

                            cmd.Parameters.AddWithValue("@title", bookTitle)
                            cmd.Parameters.AddWithValue("@release_year", bookYear)
                            cmd.Parameters.AddWithValue("@id", bookId)
                            cmd.Parameters.AddWithValue("@autor_id", authorId)
                            cmd.Parameters.AddWithValue("@genero_id", genreId)
                            cmd.Parameters.AddWithValue("@cover_image", If(bookCover IsNot Nothing, bookCover, DBNull.Value))
                            cmd.ExecuteNonQuery()
                        End Using

                        If bookAvailability Then
                            Using cmd = New NpgsqlCommand("DELETE FROM allocation_status WHERE book_id = @book_id;", connection, transaction)
                                cmd.Parameters.AddWithValue("@book_id", bookId)
                                cmd.ExecuteNonQuery()
                            End Using

                            Using cmd = New NpgsqlCommand("
                                DELETE FROM allocators 
                                WHERE cpf = @cpf 
                                AND NOT EXISTS (
                                    SELECT 1 
                                    FROM allocation_status 
                                    WHERE allocator_id = @cpf);", connection, transaction)
                                cmd.Parameters.AddWithValue("@cpf", allocatorCpf)
                                cmd.ExecuteNonQuery()
                            End Using
                        Else
                            InsertOrUpdateAllocator(connection, transaction, allocatorCpf, allocatorName, allocatorCellphone)
                            InsertAllocationStatus(connection, transaction, bookId, allocatorCpf, bookAllocationDate, bookReturnDate)
                        End If
                    End If

                    transaction.Commit()
                    MessageBox.Show("Livro salvo com sucesso! :)", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mod_global.DispararEventoLivroSalvo()

                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show($"Erro ao salvar o livro :(", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

End Module