Imports System.IO
Imports Npgsql

Module load_book
    Public Function GetBookData(bookId As Integer) As NpgsqlDataReader
        Dim conexao = DatabaseConnection.GetConnection()
        Dim cmd = New NpgsqlCommand("
            SELECT b.title, b.release_year, a.name AS author, g.description AS genre, 
                   als.allocator_id, alloc.name AS allocator_name, alloc.phone AS allocator_phone, 
                   als.allocation_date, als.return_date, b.cover_image
            FROM books b
            JOIN authors a ON b.author_id = a.id
            LEFT JOIN genres g ON b.genre_id = g.id
            LEFT JOIN LATERAL (
                SELECT * FROM allocation_status 
                WHERE book_id = b.id 
                ORDER BY allocation_date DESC LIMIT 1
            ) als ON true
            LEFT JOIN allocators alloc ON als.allocator_id = alloc.cpf
            WHERE b.id = @id;", conexao)

        cmd.Parameters.AddWithValue("@id", bookId)
        Return cmd.ExecuteReader()
    End Function

    Public Sub FillFormFields(reader As NpgsqlDataReader, book As Livro)
        book.book_name_textbox.Text = reader("title").ToString()
        book.book_year_numeric.Value = Convert.ToInt32(reader("release_year"))
        book.book_author_textbox.Text = reader("author").ToString()
        book.book_genres_combobox.Text = reader("genre").ToString()

        Dim isAvailable = reader("allocator_id") Is DBNull.Value
        book.book_availability_checkbox.Checked = isAvailable

        If Not isAvailable Then
            book.allocator_name_textbox.Text = reader("allocator_name").ToString()
            book.allocator_cpf_texbox.Text = reader("allocator_id").ToString()
            book.allocator_cellphone_textbox.Text = reader("allocator_phone").ToString()
            book.book_allocation_date.Value = Convert.ToDateTime(reader("allocation_date"))
            book.book_return_date.Value = Convert.ToDateTime(reader("return_date"))
        End If
    End Sub

    Public Sub LoadCoverImage(reader As NpgsqlDataReader, book As Livro)
        If Not IsDBNull(reader("cover_image")) AndAlso TypeOf reader("cover_image") Is Byte() Then
            Dim coverImage = CType(reader("cover_image"), Byte())
            book.book_image_picturebox.Image = LoadImageFromBytes(coverImage)
        Else
            book.book_image_picturebox.Image = Nothing
        End If
    End Sub

    Private Function LoadImageFromBytes(imageBytes As Byte()) As Image
        Try
            Using ms As New MemoryStream(imageBytes)
                Return Image.FromStream(ms)
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading cover image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

End Module
