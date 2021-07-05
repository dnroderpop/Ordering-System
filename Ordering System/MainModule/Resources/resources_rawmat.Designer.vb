<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class resources_rawmat
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.table_raw = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ladd = New System.Windows.Forms.Label()
        Me.t_c = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.t_n = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.t_u = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.t_g = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.Lmat = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.t_v = New System.Windows.Forms.NumericUpDown()
        Me.t_au = New System.Windows.Forms.NumericUpDown()
        Me.t_ag = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_search = New System.Windows.Forms.ComboBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        CType(Me.table_raw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t_v, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t_au, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t_ag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Raw Materials"
        '
        'table_raw
        '
        Me.table_raw.AllowUserToAddRows = False
        Me.table_raw.AllowUserToDeleteRows = False
        Me.table_raw.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.table_raw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.table_raw.BackgroundColor = System.Drawing.Color.Azure
        Me.table_raw.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.table_raw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.table_raw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.table_raw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.table_raw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.table_raw.DefaultCellStyle = DataGridViewCellStyle3
        Me.table_raw.EnableHeadersVisualStyles = False
        Me.table_raw.GridColor = System.Drawing.Color.Azure
        Me.table_raw.Location = New System.Drawing.Point(32, 42)
        Me.table_raw.MultiSelect = False
        Me.table_raw.Name = "table_raw"
        Me.table_raw.ReadOnly = True
        Me.table_raw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.table_raw.RowHeadersVisible = False
        Me.table_raw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.table_raw.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.table_raw.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.table_raw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.table_raw.Size = New System.Drawing.Size(881, 490)
        Me.table_raw.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "CODE"
        Me.Column1.MinimumWidth = 80
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Name"
        Me.Column2.MinimumWidth = 80
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Volume"
        Me.Column3.MinimumWidth = 80
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 96
        '
        'Column4
        '
        Me.Column4.HeaderText = "Unit of Measure"
        Me.Column4.MinimumWidth = 80
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 140
        '
        'Column5
        '
        Me.Column5.HeaderText = "Grams Conversion"
        Me.Column5.MinimumWidth = 80
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 153
        '
        'Column6
        '
        Me.Column6.HeaderText = "AMT_UNIT"
        Me.Column6.MinimumWidth = 80
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 115
        '
        'Column7
        '
        Me.Column7.HeaderText = "AMT_GRAMS"
        Me.Column7.MinimumWidth = 80
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 135
        '
        'Ladd
        '
        Me.Ladd.Font = New System.Drawing.Font("Franklin Gothic Medium", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ladd.ForeColor = System.Drawing.Color.ForestGreen
        Me.Ladd.Location = New System.Drawing.Point(930, 151)
        Me.Ladd.Name = "Ladd"
        Me.Ladd.Size = New System.Drawing.Size(433, 46)
        Me.Ladd.TabIndex = 6
        Me.Ladd.Text = "Add a raw material"
        Me.Ladd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        't_c
        '
        Me.t_c.Location = New System.Drawing.Point(1060, 215)
        Me.t_c.MaxLength = 10
        Me.t_c.Name = "t_c"
        Me.t_c.Size = New System.Drawing.Size(242, 26)
        Me.t_c.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(1012, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(1005, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Name"
        '
        't_n
        '
        Me.t_n.Location = New System.Drawing.Point(1062, 247)
        Me.t_n.Name = "t_n"
        Me.t_n.Size = New System.Drawing.Size(242, 26)
        Me.t_n.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(994, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 21)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Volume"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(1013, 314)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 21)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "UOM"
        '
        't_u
        '
        Me.t_u.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.t_u.Location = New System.Drawing.Point(1062, 311)
        Me.t_u.Name = "t_u"
        Me.t_u.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.t_u.Size = New System.Drawing.Size(242, 26)
        Me.t_u.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(964, 346)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 21)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "GConversion"
        '
        't_g
        '
        Me.t_g.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.t_g.Location = New System.Drawing.Point(1062, 343)
        Me.t_g.Name = "t_g"
        Me.t_g.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.t_g.Size = New System.Drawing.Size(242, 26)
        Me.t_g.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(975, 378)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 21)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "AMT_UNIT"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(955, 410)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 21)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "AMT_GRAMS"
        '
        'btn_add
        '
        Me.btn_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btn_add.Location = New System.Drawing.Point(1204, 439)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(100, 38)
        Me.btn_add.TabIndex = 7
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btn_update.Location = New System.Drawing.Point(1062, 439)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(100, 38)
        Me.btn_update.TabIndex = 8
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        Me.btn_update.Visible = False
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.Enabled = False
        Me.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Snow
        Me.btn_delete.Location = New System.Drawing.Point(1009, 73)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(100, 38)
        Me.btn_delete.TabIndex = 23
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.Location = New System.Drawing.Point(933, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(433, 30)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Function for selected items"
        '
        'btn_refresh
        '
        Me.btn_refresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_refresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_refresh.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.btn_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan
        Me.btn_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.ForeColor = System.Drawing.Color.Snow
        Me.btn_refresh.Location = New System.Drawing.Point(1192, 73)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(100, 38)
        Me.btn_refresh.TabIndex = 25
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'Lmat
        '
        Me.Lmat.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Lmat.Location = New System.Drawing.Point(971, 114)
        Me.Lmat.Name = "Lmat"
        Me.Lmat.Size = New System.Drawing.Size(353, 37)
        Me.Lmat.TabIndex = 27
        Me.Lmat.Text = "Selected Material"
        Me.Lmat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(1253, 408)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(61, 25)
        Me.CheckBox1.TabIndex = 28
        Me.CheckBox1.Text = "Auto"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        't_v
        '
        Me.t_v.DecimalPlaces = 2
        Me.t_v.Location = New System.Drawing.Point(1062, 279)
        Me.t_v.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.t_v.Name = "t_v"
        Me.t_v.Size = New System.Drawing.Size(242, 26)
        Me.t_v.TabIndex = 2
        Me.t_v.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        't_au
        '
        Me.t_au.DecimalPlaces = 2
        Me.t_au.Location = New System.Drawing.Point(1062, 376)
        Me.t_au.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.t_au.Name = "t_au"
        Me.t_au.Size = New System.Drawing.Size(242, 26)
        Me.t_au.TabIndex = 5
        Me.t_au.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        't_ag
        '
        Me.t_ag.DecimalPlaces = 4
        Me.t_ag.Location = New System.Drawing.Point(1062, 408)
        Me.t_ag.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.t_ag.Name = "t_ag"
        Me.t_ag.ReadOnly = True
        Me.t_ag.Size = New System.Drawing.Size(185, 26)
        Me.t_ag.TabIndex = 6
        Me.t_ag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(538, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 21)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Search "
        '
        'cb_search
        '
        Me.cb_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cb_search.FormattingEnabled = True
        Me.cb_search.Location = New System.Drawing.Point(605, 13)
        Me.cb_search.Name = "cb_search"
        Me.cb_search.Size = New System.Drawing.Size(216, 21)
        Me.cb_search.TabIndex = 33
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.BackColor = System.Drawing.Color.SandyBrown
        Me.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.Color.Snow
        Me.BtnSearch.Location = New System.Drawing.Point(827, 12)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(86, 29)
        Me.BtnSearch.TabIndex = 34
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'resources_rawmat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Azure
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.cb_search)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.t_ag)
        Me.Controls.Add(Me.t_au)
        Me.Controls.Add(Me.t_v)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Lmat)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.t_g)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.t_u)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.t_n)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.t_c)
        Me.Controls.Add(Me.Ladd)
        Me.Controls.Add(Me.table_raw)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "resources_rawmat"
        Me.Size = New System.Drawing.Size(1366, 535)
        CType(Me.table_raw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t_v, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t_au, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t_ag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents table_raw As DataGridView
    Friend WithEvents Ladd As Label
    Friend WithEvents t_c As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents t_n As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents t_u As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents t_g As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_refresh As Button
    Friend WithEvents Lmat As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents t_v As NumericUpDown
    Friend WithEvents t_au As NumericUpDown
    Friend WithEvents t_ag As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_search As ComboBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
