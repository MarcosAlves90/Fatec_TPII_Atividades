<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Livro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Livro))
        Me.book_image_picturebox = New System.Windows.Forms.PictureBox()
        Me.book_author_textbox = New System.Windows.Forms.TextBox()
        Me.book_allocation_date = New System.Windows.Forms.DateTimePicker()
        Me.book_genres_combobox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.book_availability_checkbox = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.book_return_date = New System.Windows.Forms.DateTimePicker()
        Me.book_name_textbox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.status_label = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.book_year_numeric = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.allocator_name_textbox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.allocator_cpf_texbox = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.allocator_cellphone_textbox = New System.Windows.Forms.MaskedTextBox()
        Me.save_button = New System.Windows.Forms.Button()
        Me.gui_bar = New System.Windows.Forms.Panel()
        Me.app_title = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.minimize_button = New System.Windows.Forms.Button()
        Me.window_control_button = New System.Windows.Forms.Button()
        Me.exit_button = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.exit_to_menu_button = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.search_on_google_button = New System.Windows.Forms.ToolStripButton()
        CType(Me.book_image_picturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.book_year_numeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gui_bar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'book_image_picturebox
        '
        Me.book_image_picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.book_image_picturebox.Image = Global.Biblioteca.My.Resources.Resources.default_book_cover
        Me.book_image_picturebox.Location = New System.Drawing.Point(553, 69)
        Me.book_image_picturebox.Name = "book_image_picturebox"
        Me.book_image_picturebox.Size = New System.Drawing.Size(148, 205)
        Me.book_image_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.book_image_picturebox.TabIndex = 0
        Me.book_image_picturebox.TabStop = False
        '
        'book_author_textbox
        '
        Me.book_author_textbox.Location = New System.Drawing.Point(13, 142)
        Me.book_author_textbox.Name = "book_author_textbox"
        Me.book_author_textbox.Size = New System.Drawing.Size(157, 20)
        Me.book_author_textbox.TabIndex = 2
        '
        'book_allocation_date
        '
        Me.book_allocation_date.Enabled = False
        Me.book_allocation_date.Location = New System.Drawing.Point(210, 143)
        Me.book_allocation_date.Name = "book_allocation_date"
        Me.book_allocation_date.Size = New System.Drawing.Size(154, 20)
        Me.book_allocation_date.TabIndex = 3
        '
        'book_genres_combobox
        '
        Me.book_genres_combobox.FormattingEnabled = True
        Me.book_genres_combobox.Location = New System.Drawing.Point(13, 193)
        Me.book_genres_combobox.Name = "book_genres_combobox"
        Me.book_genres_combobox.Size = New System.Drawing.Size(157, 21)
        Me.book_genres_combobox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nome do livro:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Autor do livro:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Gênero do livro:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Ano de publicação:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(207, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Data de alocação:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(207, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Disponibilidade:"
        '
        'book_availability_checkbox
        '
        Me.book_availability_checkbox.AutoSize = True
        Me.book_availability_checkbox.Checked = True
        Me.book_availability_checkbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.book_availability_checkbox.Location = New System.Drawing.Point(210, 90)
        Me.book_availability_checkbox.Name = "book_availability_checkbox"
        Me.book_availability_checkbox.Size = New System.Drawing.Size(77, 17)
        Me.book_availability_checkbox.TabIndex = 13
        Me.book_availability_checkbox.Text = "Disponível"
        Me.book_availability_checkbox.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(207, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Data de devolução:"
        '
        'book_return_date
        '
        Me.book_return_date.Enabled = False
        Me.book_return_date.Location = New System.Drawing.Point(210, 194)
        Me.book_return_date.Name = "book_return_date"
        Me.book_return_date.Size = New System.Drawing.Size(154, 20)
        Me.book_return_date.TabIndex = 14
        '
        'book_name_textbox
        '
        Me.book_name_textbox.Location = New System.Drawing.Point(13, 87)
        Me.book_name_textbox.Name = "book_name_textbox"
        Me.book_name_textbox.Size = New System.Drawing.Size(157, 20)
        Me.book_name_textbox.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(207, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Status do livro:"
        '
        'status_label
        '
        Me.status_label.AutoSize = True
        Me.status_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status_label.Location = New System.Drawing.Point(207, 250)
        Me.status_label.Name = "status_label"
        Me.status_label.Size = New System.Drawing.Size(81, 16)
        Me.status_label.TabIndex = 18
        Me.status_label.Text = "Disponível"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'book_year_numeric
        '
        Me.book_year_numeric.Location = New System.Drawing.Point(13, 249)
        Me.book_year_numeric.Maximum = New Decimal(New Integer() {2025, 0, 0, 0})
        Me.book_year_numeric.Minimum = New Decimal(New Integer() {2000, 0, 0, -2147483648})
        Me.book_year_numeric.Name = "book_year_numeric"
        Me.book_year_numeric.Size = New System.Drawing.Size(157, 20)
        Me.book_year_numeric.TabIndex = 20
        Me.book_year_numeric.Value = New Decimal(New Integer() {1, 0, 0, -2147483648})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(396, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 16)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Dados do locatário:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(396, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 16)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Nome Completo:"
        '
        'allocator_name_textbox
        '
        Me.allocator_name_textbox.Location = New System.Drawing.Point(399, 117)
        Me.allocator_name_textbox.Name = "allocator_name_textbox"
        Me.allocator_name_textbox.Size = New System.Drawing.Size(132, 20)
        Me.allocator_name_textbox.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(396, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 16)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "CPF:"
        '
        'allocator_cpf_texbox
        '
        Me.allocator_cpf_texbox.Location = New System.Drawing.Point(399, 163)
        Me.allocator_cpf_texbox.Mask = "999.999.999-99"
        Me.allocator_cpf_texbox.Name = "allocator_cpf_texbox"
        Me.allocator_cpf_texbox.Size = New System.Drawing.Size(132, 20)
        Me.allocator_cpf_texbox.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(396, 192)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 16)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Celular:"
        '
        'allocator_cellphone_textbox
        '
        Me.allocator_cellphone_textbox.Location = New System.Drawing.Point(399, 211)
        Me.allocator_cellphone_textbox.Mask = "(99) 99999-9999"
        Me.allocator_cellphone_textbox.Name = "allocator_cellphone_textbox"
        Me.allocator_cellphone_textbox.Size = New System.Drawing.Size(132, 20)
        Me.allocator_cellphone_textbox.TabIndex = 27
        '
        'save_button
        '
        Me.save_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.save_button.FlatAppearance.BorderSize = 0
        Me.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_button.ForeColor = System.Drawing.Color.White
        Me.save_button.Location = New System.Drawing.Point(399, 244)
        Me.save_button.Name = "save_button"
        Me.save_button.Size = New System.Drawing.Size(132, 24)
        Me.save_button.TabIndex = 28
        Me.save_button.Text = "Salvar"
        Me.save_button.UseVisualStyleBackColor = False
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
        Me.gui_bar.Size = New System.Drawing.Size(716, 28)
        Me.gui_bar.TabIndex = 29
        '
        'app_title
        '
        Me.app_title.AutoSize = True
        Me.app_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.app_title.ForeColor = System.Drawing.Color.White
        Me.app_title.Location = New System.Drawing.Point(34, 6)
        Me.app_title.Name = "app_title"
        Me.app_title.Size = New System.Drawing.Size(137, 17)
        Me.app_title.TabIndex = 4
        Me.app_title.Text = "Bookscrow - Livro"
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
        Me.minimize_button.Location = New System.Drawing.Point(590, 0)
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
        Me.window_control_button.Location = New System.Drawing.Point(632, 0)
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
        Me.exit_button.Location = New System.Drawing.Point(674, 0)
        Me.exit_button.Name = "exit_button"
        Me.exit_button.Size = New System.Drawing.Size(42, 28)
        Me.exit_button.TabIndex = 0
        Me.exit_button.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exit_to_menu_button, Me.ToolStripSeparator1, Me.search_on_google_button})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(716, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'exit_to_menu_button
        '
        Me.exit_to_menu_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.exit_to_menu_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.exit_to_menu_button.Image = CType(resources.GetObject("exit_to_menu_button.Image"), System.Drawing.Image)
        Me.exit_to_menu_button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.exit_to_menu_button.Name = "exit_to_menu_button"
        Me.exit_to_menu_button.Size = New System.Drawing.Size(23, 22)
        Me.exit_to_menu_button.Text = "ToolStripButton1"
        Me.exit_to_menu_button.ToolTipText = "Abrir menu"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'search_on_google_button
        '
        Me.search_on_google_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.search_on_google_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.search_on_google_button.Image = Global.Biblioteca.My.Resources.Resources.google_icon
        Me.search_on_google_button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.search_on_google_button.Name = "search_on_google_button"
        Me.search_on_google_button.Size = New System.Drawing.Size(23, 22)
        Me.search_on_google_button.Text = "ToolStripButton1"
        Me.search_on_google_button.ToolTipText = "Pesquisar livro no Google"
        '
        'Livro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(716, 292)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.gui_bar)
        Me.Controls.Add(Me.save_button)
        Me.Controls.Add(Me.allocator_cellphone_textbox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.allocator_cpf_texbox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.allocator_name_textbox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.book_year_numeric)
        Me.Controls.Add(Me.status_label)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.book_name_textbox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.book_return_date)
        Me.Controls.Add(Me.book_availability_checkbox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.book_genres_combobox)
        Me.Controls.Add(Me.book_allocation_date)
        Me.Controls.Add(Me.book_author_textbox)
        Me.Controls.Add(Me.book_image_picturebox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Livro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bookscrow | Livro"
        CType(Me.book_image_picturebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.book_year_numeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gui_bar.ResumeLayout(False)
        Me.gui_bar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents book_image_picturebox As PictureBox
    Friend WithEvents book_author_textbox As TextBox
    Friend WithEvents book_allocation_date As DateTimePicker
    Friend WithEvents book_genres_combobox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents book_availability_checkbox As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents book_return_date As DateTimePicker
    Friend WithEvents book_name_textbox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents status_label As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents book_year_numeric As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents allocator_name_textbox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents allocator_cpf_texbox As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents allocator_cellphone_textbox As MaskedTextBox
    Friend WithEvents save_button As Button
    Friend WithEvents gui_bar As Panel
    Friend WithEvents app_title As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents minimize_button As Button
    Friend WithEvents window_control_button As Button
    Friend WithEvents exit_button As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents exit_to_menu_button As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents search_on_google_button As ToolStripButton
End Class
