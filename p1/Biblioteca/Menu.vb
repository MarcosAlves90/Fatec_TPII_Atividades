Imports System.Runtime.InteropServices

Public Class Menu

    ' ------------- DECLARAÇÃO DE VARIÁVEIS LOCAIS -------------

    Private isFullScreen As Boolean = False

    ' ------------- CONFIGURAÇÃO DA INICIALIZAÇÃO E FECHAMENTO DO MENU.VB -------------

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        mod_global.AddBookGenres(book_genres_combobox)

        book_genres_combobox.Items.Insert(0, "Gênero")
        book_genres_combobox.SelectedIndex = 0

        book_availability_combobox.Items.Insert(0, "Disponibilidade")
        book_availability_combobox.Items.Insert(1, "Disponível")
        book_availability_combobox.Items.Insert(2, "Indisponível")
        book_availability_combobox.Items.Insert(3, "Atrasado")
        book_availability_combobox.SelectedIndex = 0

        data_grid_view_1.FillDataGridView1()

        AddHandler mod_global.LivroSalvo, AddressOf data_grid_view_1.FillDataGridView1
    End Sub

    Private Sub Menu_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' "Ctrl + N" Abrir Notepad
        If e.Control AndAlso e.KeyCode = Keys.N Then
            shortcuts.OpenApp("notepad")
        End If
        ' "Ctrl + E" Abrir Excel
        If e.Control AndAlso e.KeyCode = Keys.E Then
            shortcuts.OpenApp("excel")
        End If
        ' "Ctrl + R" Recarregar tabela
        If e.Control AndAlso e.KeyCode = Keys.R Then
            data_grid_view_1.FillDataGridView1()
        End If
    End Sub

    Private Sub Menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        RemoveHandler mod_global.LivroSalvo, AddressOf data_grid_view_1.FillDataGridView1
    End Sub

    ' ------------- CONFIGURAÇÃO DO PREENCHIMENTO DO DATAGRIDVIEW1 -------------

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If e.Value Is Nothing Then Exit Sub

        Select Case DataGridView1.Columns(e.ColumnIndex).Name
            Case "Título"
                e.CellStyle.Font = New Font(DataGridView1.Font, FontStyle.Bold)

            Case "Disponibilidade"
                Select Case e.Value.ToString()
                    Case "Disponível"
                        e.CellStyle.BackColor = Color.Green
                    Case "Indisponível"
                        e.CellStyle.BackColor = Color.Gold
                End Select
                e.CellStyle.ForeColor = Color.White
                e.CellStyle.Font = New Font(DataGridView1.Font, FontStyle.Bold)

            Case "Status"
                Select Case e.Value.ToString()
                    Case "N/A"
                        e.CellStyle.BackColor = Color.Green
                    Case "Em dia"
                        e.CellStyle.BackColor = Color.Blue
                    Case "Atrasado"
                        e.CellStyle.BackColor = Color.Red
                End Select
                e.CellStyle.ForeColor = Color.White
                e.CellStyle.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        End Select
    End Sub

    ' ------------- CONFIGURAÇÃO DA BARRA DO MENU -------------

    Private Sub Menu_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        mod_global.AdjustFormControls(Me, gui_bar, exit_button, window_control_button, minimize_button, ToolStrip1)
    End Sub

    <DllImport("user32.dll")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.dll")>
    Private Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As IntPtr
    End Function

    Private Const WM_NCLBUTTONDOWN As Integer = &HA1, HTCAPTION As Integer = 2

    Private Sub gui_bar_MouseDown(sender As Object, e As MouseEventArgs) Handles gui_bar.MouseDown
        mod_global.HandleGuiBarMouseDown(Me, e)
    End Sub

    Private Sub ToggleWindowState()
        mod_global.ToggleWindowState(Me, isFullScreen, 731, 372)
    End Sub

    Private Sub window_control_button_Click(sender As Object, e As EventArgs) Handles window_control_button.Click
        ToggleWindowState()
    End Sub

    Private Sub exit_button_Click(sender As Object, e As EventArgs) Handles exit_button.Click
        mod_global.CloseWindow(Me)
    End Sub

    Private Sub minimize_button_Click(sender As Object, e As EventArgs) Handles minimize_button.Click
        mod_global.MinimizeForm(Me)
    End Sub

    ' ------------- CONFIGURAÇÃO DA PESQUISA E FILTROS -------------

    Private Sub book_genres_combobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles book_genres_combobox.SelectedIndexChanged
        ApplyFilters()
    End Sub

    Private Sub book_availability_combobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles book_availability_combobox.SelectedIndexChanged
        ApplyFilters()
    End Sub

    Private Sub primary_search_box_TextChanged(sender As Object, e As EventArgs) Handles primary_search_box.TextChanged
        ApplyFilters()
    End Sub

    Private Sub ApplyFilters()
        Dim dataTable As DataTable = TryCast(DataGridView1.DataSource, DataTable)

        If dataTable Is Nothing Then Exit Sub

        Dim searchText As String = primary_search_box.Text.Trim().Replace("'", "''")
        Dim selectedGenre As String = book_genres_combobox.SelectedItem?.ToString()
        Dim selectedAvailability As String = book_availability_combobox.SelectedItem?.ToString()

        Dim filters As New List(Of String)

        If Not String.IsNullOrEmpty(searchText) Then
            filters.Add($"(Título LIKE '%{searchText}%' OR Autor LIKE '%{searchText}%')")
        End If

        If book_genres_combobox.SelectedIndex <> 0 Then
            filters.Add($"Gênero = '{selectedGenre.Replace("'", "''")}'")
        End If

        If book_availability_combobox.SelectedIndex <> 0 Then
            If selectedAvailability = "Atrasado" Then
                filters.Add($"Status = 'Atrasado'")
            Else
                filters.Add($"Disponibilidade = '{selectedAvailability.Replace("'", "''")}'")
            End If
        End If

        dataTable.DefaultView.RowFilter = String.Join(" AND ", filters)
    End Sub

    ' ------------- CONFIGURAÇÃO DOS BOTÕES E INPUTS DO FORM MENU.VB -------------

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        data_grid_view_1.DataGridView1_CellContentClick(e)
    End Sub

    Private Sub open_notepad_button_Click(sender As Object, e As EventArgs) Handles open_notepad_button.Click
        shortcuts.OpenApp("notepad")
    End Sub

    Private Sub open_excel_button_Click(sender As Object, e As EventArgs) Handles open_excel_button.Click
        shortcuts.OpenApp("excel")
    End Sub

    Private Sub reload_table_button_Click(sender As Object, e As EventArgs) Handles reload_table_button.Click
        data_grid_view_1.FillDataGridView1()
    End Sub

    Private Sub add_book_button_Click(sender As Object, e As EventArgs) Handles add_book_button.Click
        Dim livroForm As New Livro()
        livroForm.Show()
    End Sub

End Class
