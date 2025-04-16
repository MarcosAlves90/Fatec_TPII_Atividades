Imports System.Runtime.InteropServices

Module mod_global

    ' ------------- VARIÁVEIS GLOBAIS -------------
    Public diretorio As String ' Diretório global utilizado pelo programa

    ' ------------- EVENTOS GLOBAIS -------------
    Public Event LivroSalvo() ' Esse evento é disparado quando um livro é salvo

    ' Dispara o evento LivroSalvo
    Public Sub DispararEventoLivroSalvo()
        RaiseEvent LivroSalvo()
    End Sub

    ' ------------- FUNÇÕES PARA CONTROLE DE JANELAS -------------

    ' Minimiza o form
    Public Sub MinimizeForm(form As Form)
        form.WindowState = FormWindowState.Minimized
    End Sub

    ' Fecha o form
    Public Sub CloseWindow(form As Form)
        form.Close()
    End Sub

    ' Centraliza o form
    Public Sub CenterForm(form As Form)
        Dim screenBounds = Screen.FromControl(form).Bounds
        form.Location = New Point((screenBounds.Width - form.Width) \ 2, (screenBounds.Height - form.Height) \ 2)
    End Sub

    ' Alterna entre o modo de tela cheia e o modo normal - É usado pela função abaixo
    Public Sub ToggleFullScreen(form As Form, enable As Boolean, width As Integer, height As Integer)
        If enable Then
            form.WindowState = FormWindowState.Maximized
        Else
            form.WindowState = FormWindowState.Normal
            form.Bounds = New Rectangle(0, 0, width, height)
            CenterForm(form)
        End If
    End Sub

    ' Alterna o estado da instância do form (tela cheia ou normal) 
    Public Sub ToggleWindowState(form As Form, ByRef isFullScreen As Boolean, width As Integer, height As Integer)
        If form.WindowState = FormWindowState.Maximized Then
            isFullScreen = True
        ElseIf form.WindowState = FormWindowState.Normal Then
            isFullScreen = False
        End If

        If isFullScreen Then
            ToggleFullScreen(form, False, width, height)
        Else
            ToggleFullScreen(form, True, width, height)
        End If

        isFullScreen = Not isFullScreen
    End Sub

    ' ------------- FUNÇÕES PARA CONTROLE DO FRONT -------------

    ' Ajusta os controles do GUI de acordo com o tamanho da janela
    Public Sub AdjustFormControls(form As Form, gui_bar As Control, exit_button As Control, window_control_button As Control, minimize_button As Control, tool_strip As ToolStrip)
        gui_bar.Width = form.ClientSize.Width

        exit_button.Location = New Point(form.ClientSize.Width - exit_button.Width, exit_button.Location.Y)
        window_control_button.Location = New Point(form.ClientSize.Width - window_control_button.Width - exit_button.Width, window_control_button.Location.Y)
        minimize_button.Location = New Point(form.ClientSize.Width - minimize_button.Width - window_control_button.Width - exit_button.Width, minimize_button.Location.Y)
        tool_strip.Width = form.ClientSize.Width
    End Sub

    ' Move a janela se clicar ou arrastar o GUI
    Public Sub HandleGuiBarMouseDown(form As Form, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(form.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
        End If
    End Sub

    ' ------------- FUNÇÕES PARA POPULAR INPUTS -------------

    ' Adiciona gêneros de livros a um ComboBox
    Public Sub AddBookGenres(ByRef comboBox As ComboBox)
        Dim genres As String() = {
            "Romance", "Fantasia", "Ficção Científica", "Mistério", "Suspense",
            "Terror", "Biografia", "História", "Poesia", "Aventura", "Drama",
            "Autoajuda", "Infantil"
        }

        comboBox.Items.AddRange(genres)
    End Sub

    ' ------------- IMPORTAÇÕES -------------

    ' Importa funções da user32.dll
    <DllImport("user32.dll")>
    Private Sub ReleaseCapture()
    End Sub

    <DllImport("user32.dll")>
    Private Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As IntPtr
    End Function

    ' Variáveis constantes para movimentação da janela do form
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = 2

End Module
