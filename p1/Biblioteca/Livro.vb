Imports System.IO

Public Class Livro

    ' ------------- DECLARAÇÃO DE VARIÁVEIS LOCAIS -------------

    Private isFullScreen As Boolean = False
    Private bookId As Integer = -1
    Private bookCoverModified As Boolean = False

    ' ------------- CONFIGURAÇÃO DA INICIALIZAÇÃO DO LIVRO.VB -------------

    Private Sub Livro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        mod_global.AddBookGenres(book_genres_combobox)

        book_year_numeric.Maximum = DateTime.Now.Year
        book_allocation_date.Enabled = Not book_availability_checkbox.Checked
        book_return_date.Enabled = Not book_availability_checkbox.Checked

        If book_return_date.Value.Date = book_allocation_date.Value.Date Then
            book_return_date.Value = book_allocation_date.Value.AddDays(1)
        End If

        If book_year_numeric.Value < 0 Then
            book_year_numeric.Value = DateTime.Now.Year
        End If

        UpdateStatusLabel()
    End Sub

    Private Sub Livro_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' "Ctrl + G" Pesquisar livro no google
        If e.Control AndAlso e.KeyCode = Keys.G Then
            search_on_google()
        End If
        ' "Ctrl + H" Trazer menu para o topo
        If e.Control AndAlso e.KeyCode = Keys.H Then
            bring_menu_to_top()
        End If
    End Sub

    ' ------------- CONFIGURAÇÃO PARA CARREGAMENTO DOS LIVROS -------------

    Public Sub LoadBookData(bookId As Integer)
        Me.bookId = bookId
        Try
            Using reader = load_book.GetBookData(bookId)
                If Not reader.Read() Then Return

                load_book.FillFormFields(reader, Me)

                load_book.LoadCoverImage(reader, Me)
            End Using

            save_button.Text = "Editar"
        Catch ex As Exception
            MessageBox.Show($"Erro ao carregar os dados do livro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ------------- FUNÇÃO PARA ATUALIZAÇÃO DA LABEL DE STATUS -------------

    Private Sub UpdateStatusLabel()
        If book_availability_checkbox.Checked Then
            status_label.Text = "Disponível"
            status_label.ForeColor = Color.Green
            Return
        End If

        Dim today As Date = DateTime.Now.Date
        Dim allocationDate As Date = book_allocation_date.Value.Date
        Dim returnDate As Date = book_return_date.Value.Date

        If today < allocationDate Then
            status_label.Text = "Agendado"
            status_label.ForeColor = Color.Orange
        ElseIf today > returnDate Then
            status_label.Text = "Atrasado"
            status_label.ForeColor = Color.Red
        Else
            status_label.Text = "Indisponível"
            status_label.ForeColor = Color.Gold
        End If
    End Sub

    ' ------------- CONFIGURAÇÃO DA SELEÇÃO DE IMAGEM DA CAPA DO LIVRO -------------

    Private Sub book_image_Click(sender As Object, e As EventArgs) Handles book_image_picturebox.Click
        Dim oldImage As Image = book_image_picturebox.Image
        book_image_selection.HandleBookImageClick(book_image_picturebox, OpenFileDialog1)
        Dim newImage As Image = book_image_picturebox.Image
        If newImage IsNot Nothing AndAlso Not Object.ReferenceEquals(newImage, oldImage) Then
            bookCoverModified = True
        End If
    End Sub

    ' ------------- FUNÇÕES COMUNS PARA OS INPUTS DO LIVRO.VB -------------

    Private Sub availability_checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles book_availability_checkbox.CheckedChanged
        If book_availability_checkbox.Checked Then
            book_allocation_date.Enabled = False
            book_return_date.Enabled = False
        Else
            book_allocation_date.Enabled = True
            book_return_date.Enabled = True
        End If
        UpdateStatusLabel()
    End Sub

    Private Sub cpf_text_DoubleClick(sender As Object, e As EventArgs) Handles allocator_cpf_texbox.DoubleClick
        allocator_cpf_texbox.Clear()
        allocator_cpf_texbox.Focus()
    End Sub

    Private Sub cellphone_text_DoubleClick(sender As Object, e As EventArgs) Handles allocator_cellphone_textbox.DoubleClick
        allocator_cellphone_textbox.Clear()
        allocator_cellphone_textbox.Focus()
    End Sub

    Private Sub allocation_date_ValueChanged(sender As Object, e As EventArgs) Handles book_allocation_date.ValueChanged
        If book_allocation_date.Value.Date > book_return_date.Value.Date Then
            MessageBox.Show("A data de alocação não pode ser maior que a de devolução.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            book_allocation_date.Value = book_return_date.Value.AddDays(-1)
        End If
        UpdateStatusLabel()
    End Sub

    Private Sub return_date_ValueChanged(sender As Object, e As EventArgs) Handles book_return_date.ValueChanged
        If book_return_date.Value.Date <= book_allocation_date.Value.Date Then
            MessageBox.Show("A data de devolução não pode ser menor ou igual a de alocação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            book_return_date.Value = book_allocation_date.Value.AddDays(1)
        End If
        UpdateStatusLabel()
    End Sub

    ' ------------- CONFIGURAÇÃO DA BARRA DO MENU -------------

    Private Sub Menu_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        mod_global.AdjustFormControls(Me, gui_bar, exit_button, window_control_button, minimize_button, ToolStrip1)
        ToolStrip1.Width = Me.ClientSize.Width
    End Sub

    Private Sub ToggleWindowState()
        mod_global.ToggleWindowState(Me, isFullScreen, 716, 292)
    End Sub

    Private Sub window_control_button_Click(sender As Object, e As EventArgs) Handles window_control_button.Click
        ToggleWindowState()
    End Sub

    Private Sub minimize_button_Click(sender As Object, e As EventArgs) Handles minimize_button.Click
        mod_global.MinimizeForm(Me)
    End Sub

    Private Sub exit_button_Click(sender As Object, e As EventArgs) Handles exit_button.Click
        mod_global.CloseWindow(Me)
    End Sub

    Private Sub gui_bar_MouseDown(sender As Object, e As MouseEventArgs) Handles gui_bar.MouseDown
        mod_global.HandleGuiBarMouseDown(Me, e)
    End Sub

    Private Sub exit_to_menu_button_Click(sender As Object, e As EventArgs) Handles exit_to_menu_button.Click
        bring_menu_to_top()
    End Sub

    Private Sub bring_menu_to_top()
        For Each form As Form In Application.OpenForms
            If TypeOf form Is Menu Then
                If form.WindowState = FormWindowState.Minimized Then
                    form.WindowState = FormWindowState.Normal
                End If
                form.BringToFront()
                Return
            End If
        Next
    End Sub

    Private Sub search_on_google_button_Click(sender As Object, e As EventArgs) Handles search_on_google_button.Click
        search_on_google()
    End Sub

    Private Sub search_on_google()
        Dim bookTitle As String = book_name_textbox.Text.Trim()
        Dim bookAuthor As String = book_author_textbox.Text.Trim()
        Dim searchTerm As String = ""

        If Not String.IsNullOrWhiteSpace(bookTitle) AndAlso Not String.IsNullOrWhiteSpace(bookAuthor) Then
            searchTerm = $"{bookTitle} {bookAuthor}"
        ElseIf Not String.IsNullOrWhiteSpace(bookTitle) Then
            searchTerm = bookTitle
        ElseIf Not String.IsNullOrWhiteSpace(bookAuthor) Then
            searchTerm = bookAuthor
        Else
            MessageBox.Show("Insira um título ou autor para realizar a pesquisa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        shortcuts.SearchOnGoogle(searchTerm)
    End Sub

    ' ------------- CONFIGURAÇÃO DO ENVIO DO LIVRO -------------

    Private Sub save_button_Click(sender As Object, e As EventArgs) Handles save_button.Click
        Dim bookTitle = book_name_textbox.Text
        Dim bookYear = book_year_numeric.Value
        Dim bookAuthor = book_author_textbox.Text
        Dim bookGenre = book_genres_combobox.Text
        Dim allocatorName = allocator_name_textbox.Text
        Dim allocatorCpf = New String(allocator_cpf_texbox.Text.Where(AddressOf Char.IsDigit).ToArray())
        Dim allocatorCellphone = New String(allocator_cellphone_textbox.Text.Where(AddressOf Char.IsDigit).ToArray())
        Dim bookAllocationDate = book_allocation_date.Value
        Dim bookReturnDate = book_return_date.Value
        Dim bookAvailability = book_availability_checkbox.Checked

        Dim bookCover As Byte() = Nothing
        If book_image_picturebox.Image IsNot Nothing AndAlso bookCoverModified Then
            Using ms As New MemoryStream()
                Using bitmap As New Bitmap(book_image_picturebox.Image)
                    bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                End Using
                bookCover = ms.ToArray()
            End Using
        End If

        If String.IsNullOrWhiteSpace(bookTitle) OrElse String.IsNullOrWhiteSpace(bookAuthor) OrElse String.IsNullOrWhiteSpace(bookGenre) Then
            MessageBox.Show("Título, Autor e Gênero são obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not bookAvailability AndAlso (String.IsNullOrWhiteSpace(allocatorName) OrElse String.IsNullOrWhiteSpace(allocatorCpf)) Then
            MessageBox.Show("O livro está indisponível. Nome e CPF do locatário são obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        send_book_to_database.SaveBook(
            bookId,
            bookTitle,
            bookYear,
            bookAuthor,
            bookGenre,
            allocatorName,
            allocatorCpf,
            allocatorCellphone,
            bookAllocationDate,
            bookReturnDate,
            bookAvailability,
            bookCover
        )

        CloseWindow(Me)
    End Sub

End Class
