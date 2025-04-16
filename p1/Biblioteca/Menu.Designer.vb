<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.add_book_button = New System.Windows.Forms.Button()
        Me.primary_search_box = New System.Windows.Forms.TextBox()
        Me.book_genres_combobox = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Título = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Autor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gênero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lançamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Disponibilidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Editar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.gui_bar = New System.Windows.Forms.Panel()
        Me.app_title = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.minimize_button = New System.Windows.Forms.Button()
        Me.window_control_button = New System.Windows.Forms.Button()
        Me.exit_button = New System.Windows.Forms.Button()
        Me.book_availability_combobox = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.open_notepad_button = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.open_excel_button = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.reload_table_button = New System.Windows.Forms.ToolStripButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gui_bar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'add_book_button
        '
        Me.add_book_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.add_book_button.FlatAppearance.BorderSize = 0
        Me.add_book_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_book_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_book_button.ForeColor = System.Drawing.Color.White
        Me.add_book_button.Location = New System.Drawing.Point(12, 62)
        Me.add_book_button.Name = "add_book_button"
        Me.add_book_button.Size = New System.Drawing.Size(134, 24)
        Me.add_book_button.TabIndex = 0
        Me.add_book_button.Text = "Adicionar livro"
        Me.add_book_button.UseVisualStyleBackColor = False
        '
        'primary_search_box
        '
        Me.primary_search_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.primary_search_box.Location = New System.Drawing.Point(152, 62)
        Me.primary_search_box.Name = "primary_search_box"
        Me.primary_search_box.Size = New System.Drawing.Size(286, 24)
        Me.primary_search_box.TabIndex = 2
        '
        'book_genres_combobox
        '
        Me.book_genres_combobox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.book_genres_combobox.FormattingEnabled = True
        Me.book_genres_combobox.Location = New System.Drawing.Point(444, 62)
        Me.book_genres_combobox.Name = "book_genres_combobox"
        Me.book_genres_combobox.Size = New System.Drawing.Size(120, 24)
        Me.book_genres_combobox.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Título, Me.Autor, Me.Gênero, Me.Lançamento, Me.Disponibilidade, Me.Status, Me.Editar, Me.Excluir})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 101)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(677, 256)
        Me.DataGridView1.TabIndex = 6
        '
        'Título
        '
        Me.Título.HeaderText = "Título"
        Me.Título.Name = "Título"
        Me.Título.ReadOnly = True
        Me.Título.Width = 120
        '
        'Autor
        '
        Me.Autor.HeaderText = "Autor"
        Me.Autor.Name = "Autor"
        Me.Autor.ReadOnly = True
        '
        'Gênero
        '
        Me.Gênero.HeaderText = "Gênero"
        Me.Gênero.Name = "Gênero"
        Me.Gênero.ReadOnly = True
        '
        'Lançamento
        '
        Me.Lançamento.HeaderText = "Lançamento"
        Me.Lançamento.Name = "Lançamento"
        Me.Lançamento.ReadOnly = True
        Me.Lançamento.Width = 80
        '
        'Disponibilidade
        '
        Me.Disponibilidade.HeaderText = "Disponibilidade"
        Me.Disponibilidade.Name = "Disponibilidade"
        Me.Disponibilidade.ReadOnly = True
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Width = 90
        '
        'Editar
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle5.NullValue = CType(resources.GetObject("DataGridViewCellStyle5.NullValue"), Object)
        Me.Editar.DefaultCellStyle = DataGridViewCellStyle5
        Me.Editar.HeaderText = ""
        Me.Editar.Image = Global.Biblioteca.My.Resources.Resources.edit_icon
        Me.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Editar.Name = "Editar"
        Me.Editar.ReadOnly = True
        Me.Editar.Width = 25
        '
        'Excluir
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle6.NullValue = CType(resources.GetObject("DataGridViewCellStyle6.NullValue"), Object)
        Me.Excluir.DefaultCellStyle = DataGridViewCellStyle6
        Me.Excluir.HeaderText = ""
        Me.Excluir.Image = Global.Biblioteca.My.Resources.Resources.delete_icon
        Me.Excluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Excluir.Name = "Excluir"
        Me.Excluir.ReadOnly = True
        Me.Excluir.Width = 25
        '
        'gui_bar
        '
        Me.gui_bar.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.gui_bar.Controls.Add(Me.app_title)
        Me.gui_bar.Controls.Add(Me.PictureBox1)
        Me.gui_bar.Controls.Add(Me.minimize_button)
        Me.gui_bar.Controls.Add(Me.window_control_button)
        Me.gui_bar.Controls.Add(Me.exit_button)
        Me.gui_bar.Location = New System.Drawing.Point(0, 0)
        Me.gui_bar.Name = "gui_bar"
        Me.gui_bar.Size = New System.Drawing.Size(701, 28)
        Me.gui_bar.TabIndex = 7
        '
        'app_title
        '
        Me.app_title.AutoSize = True
        Me.app_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.app_title.ForeColor = System.Drawing.Color.White
        Me.app_title.Location = New System.Drawing.Point(34, 6)
        Me.app_title.Name = "app_title"
        Me.app_title.Size = New System.Drawing.Size(140, 17)
        Me.app_title.TabIndex = 4
        Me.app_title.Text = "Bookscrow - Menu"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(6, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'minimize_button
        '
        Me.minimize_button.BackgroundImage = CType(resources.GetObject("minimize_button.BackgroundImage"), System.Drawing.Image)
        Me.minimize_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.minimize_button.FlatAppearance.BorderSize = 0
        Me.minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimize_button.Location = New System.Drawing.Point(575, 0)
        Me.minimize_button.Name = "minimize_button"
        Me.minimize_button.Size = New System.Drawing.Size(42, 28)
        Me.minimize_button.TabIndex = 2
        Me.minimize_button.UseVisualStyleBackColor = True
        '
        'window_control_button
        '
        Me.window_control_button.BackgroundImage = CType(resources.GetObject("window_control_button.BackgroundImage"), System.Drawing.Image)
        Me.window_control_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.window_control_button.FlatAppearance.BorderSize = 0
        Me.window_control_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.window_control_button.Location = New System.Drawing.Point(617, 0)
        Me.window_control_button.Name = "window_control_button"
        Me.window_control_button.Size = New System.Drawing.Size(42, 28)
        Me.window_control_button.TabIndex = 1
        Me.window_control_button.UseVisualStyleBackColor = True
        '
        'exit_button
        '
        Me.exit_button.BackgroundImage = CType(resources.GetObject("exit_button.BackgroundImage"), System.Drawing.Image)
        Me.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.exit_button.FlatAppearance.BorderSize = 0
        Me.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exit_button.Location = New System.Drawing.Point(659, 0)
        Me.exit_button.Name = "exit_button"
        Me.exit_button.Size = New System.Drawing.Size(42, 28)
        Me.exit_button.TabIndex = 0
        Me.exit_button.UseVisualStyleBackColor = True
        '
        'book_availability_combobox
        '
        Me.book_availability_combobox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.book_availability_combobox.FormattingEnabled = True
        Me.book_availability_combobox.Location = New System.Drawing.Point(570, 62)
        Me.book_availability_combobox.Name = "book_availability_combobox"
        Me.book_availability_combobox.Size = New System.Drawing.Size(120, 24)
        Me.book_availability_combobox.TabIndex = 8
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.open_notepad_button, Me.ToolStripSeparator1, Me.open_excel_button, Me.ToolStripSeparator2, Me.reload_table_button})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(701, 25)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'open_notepad_button
        '
        Me.open_notepad_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.open_notepad_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.open_notepad_button.Image = Global.Biblioteca.My.Resources.Resources.notepad_icon
        Me.open_notepad_button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.open_notepad_button.Name = "open_notepad_button"
        Me.open_notepad_button.Size = New System.Drawing.Size(23, 22)
        Me.open_notepad_button.Text = "ToolStripButton1"
        Me.open_notepad_button.ToolTipText = "Abrir notepad"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'open_excel_button
        '
        Me.open_excel_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.open_excel_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.open_excel_button.Image = Global.Biblioteca.My.Resources.Resources.excel_icon
        Me.open_excel_button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.open_excel_button.Name = "open_excel_button"
        Me.open_excel_button.Size = New System.Drawing.Size(23, 22)
        Me.open_excel_button.Text = "ToolStripButton1"
        Me.open_excel_button.ToolTipText = "Abrir excel"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'reload_table_button
        '
        Me.reload_table_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.reload_table_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.reload_table_button.Image = Global.Biblioteca.My.Resources.Resources.reload_icon
        Me.reload_table_button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.reload_table_button.Name = "reload_table_button"
        Me.reload_table_button.Size = New System.Drawing.Size(23, 22)
        Me.reload_table_button.Text = "ToolStripButton1"
        Me.reload_table_button.ToolTipText = "Recarregar tabela"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(701, 372)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.book_availability_combobox)
        Me.Controls.Add(Me.gui_bar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.book_genres_combobox)
        Me.Controls.Add(Me.primary_search_box)
        Me.Controls.Add(Me.add_book_button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bookscrow | Menu"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gui_bar.ResumeLayout(False)
        Me.gui_bar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents add_book_button As Button
    Friend WithEvents primary_search_box As TextBox
    Friend WithEvents book_genres_combobox As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents gui_bar As Panel
    Friend WithEvents exit_button As Button
    Friend WithEvents window_control_button As Button
    Friend WithEvents minimize_button As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents app_title As Label
    Friend WithEvents book_availability_combobox As ComboBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents open_notepad_button As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents open_excel_button As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents reload_table_button As ToolStripButton
    Friend WithEvents Título As DataGridViewTextBoxColumn
    Friend WithEvents Autor As DataGridViewTextBoxColumn
    Friend WithEvents Gênero As DataGridViewTextBoxColumn
    Friend WithEvents Lançamento As DataGridViewTextBoxColumn
    Friend WithEvents Disponibilidade As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Editar As DataGridViewImageColumn
    Friend WithEvents Excluir As DataGridViewImageColumn
End Class
