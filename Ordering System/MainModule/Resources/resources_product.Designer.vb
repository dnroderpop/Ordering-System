<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class resources_product
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.t_srpb = New System.Windows.Forms.NumericUpDown()
        Me.t_srpc = New System.Windows.Forms.NumericUpDown()
        Me.Lmat = New System.Windows.Forms.Label()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.t_n = New System.Windows.Forms.TextBox()
        Me.lid = New System.Windows.Forms.Label()
        Me.t_id = New System.Windows.Forms.TextBox()
        Me.Ladd = New System.Windows.Forms.Label()
        Me.table_prod = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.cb_search = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.t_y = New System.Windows.Forms.NumericUpDown()
        Me.t_aw = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.t_c = New System.Windows.Forms.ComboBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.t_srpb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t_srpc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table_prod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t_y, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t_aw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        't_srpb
        '
        Me.t_srpb.DecimalPlaces = 2
        Me.t_srpb.Location = New System.Drawing.Point(1047, 329)
        Me.t_srpb.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.t_srpb.Name = "t_srpb"
        Me.t_srpb.Size = New System.Drawing.Size(242, 26)
        Me.t_srpb.TabIndex = 4
        Me.t_srpb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        't_srpc
        '
        Me.t_srpc.DecimalPlaces = 2
        Me.t_srpc.Location = New System.Drawing.Point(1047, 297)
        Me.t_srpc.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.t_srpc.Name = "t_srpc"
        Me.t_srpc.Size = New System.Drawing.Size(242, 26)
        Me.t_srpc.TabIndex = 3
        Me.t_srpc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lmat
        '
        Me.Lmat.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Lmat.Location = New System.Drawing.Point(973, 114)
        Me.Lmat.Name = "Lmat"
        Me.Lmat.Size = New System.Drawing.Size(353, 37)
        Me.Lmat.TabIndex = 50
        Me.Lmat.Text = "Selected Product"
        Me.Lmat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btn_refresh.Location = New System.Drawing.Point(1194, 73)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(100, 38)
        Me.btn_refresh.TabIndex = 49
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.Location = New System.Drawing.Point(917, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(433, 30)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Function for selected items"
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
        Me.btn_delete.Location = New System.Drawing.Point(1011, 73)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(100, 38)
        Me.btn_delete.TabIndex = 47
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(938, 331)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 21)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "SRP Branch"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(924, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 17)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "SRP Commissarry"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(961, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 21)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(979, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 21)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Name"
        '
        't_n
        '
        Me.t_n.Location = New System.Drawing.Point(1047, 232)
        Me.t_n.Name = "t_n"
        Me.t_n.Size = New System.Drawing.Size(242, 26)
        Me.t_n.TabIndex = 1
        '
        'lid
        '
        Me.lid.AutoSize = True
        Me.lid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.lid.Location = New System.Drawing.Point(1006, 203)
        Me.lid.Name = "lid"
        Me.lid.Size = New System.Drawing.Size(24, 21)
        Me.lid.TabIndex = 35
        Me.lid.Text = "ID"
        Me.lid.Visible = False
        '
        't_id
        '
        Me.t_id.Location = New System.Drawing.Point(1047, 200)
        Me.t_id.MaxLength = 10
        Me.t_id.Name = "t_id"
        Me.t_id.Size = New System.Drawing.Size(242, 26)
        Me.t_id.TabIndex = 0
        Me.t_id.Visible = False
        '
        'Ladd
        '
        Me.Ladd.Font = New System.Drawing.Font("Franklin Gothic Medium", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ladd.ForeColor = System.Drawing.Color.ForestGreen
        Me.Ladd.Location = New System.Drawing.Point(921, 151)
        Me.Ladd.Name = "Ladd"
        Me.Ladd.Size = New System.Drawing.Size(433, 46)
        Me.Ladd.TabIndex = 33
        Me.Ladd.Text = "Add a Product"
        Me.Ladd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'table_prod
        '
        Me.table_prod.AllowUserToAddRows = False
        Me.table_prod.AllowUserToDeleteRows = False
        Me.table_prod.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.table_prod.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.table_prod.BackgroundColor = System.Drawing.Color.Azure
        Me.table_prod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.table_prod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.table_prod.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.table_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.table_prod.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column7, Me.Column6, Me.Column4, Me.Column5})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.table_prod.DefaultCellStyle = DataGridViewCellStyle7
        Me.table_prod.EnableHeadersVisualStyles = False
        Me.table_prod.GridColor = System.Drawing.Color.Azure
        Me.table_prod.Location = New System.Drawing.Point(16, 44)
        Me.table_prod.MultiSelect = False
        Me.table_prod.Name = "table_prod"
        Me.table_prod.ReadOnly = True
        Me.table_prod.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.table_prod.RowHeadersVisible = False
        Me.table_prod.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.table_prod.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.table_prod.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.table_prod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.table_prod.Size = New System.Drawing.Size(881, 488)
        Me.table_prod.TabIndex = 32
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 80
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Category"
        Me.Column3.MinimumWidth = 80
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 103
        '
        'Column7
        '
        Me.Column7.HeaderText = "Srp (c)"
        Me.Column7.MinimumWidth = 80
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Srp (b)"
        Me.Column6.MinimumWidth = 80
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Average Weight"
        Me.Column4.MinimumWidth = 80
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 151
        '
        'Column5
        '
        Me.Column5.HeaderText = "Yielding"
        Me.Column5.MinimumWidth = 80
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 99
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
        Me.btn_update.Location = New System.Drawing.Point(1047, 425)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(100, 38)
        Me.btn_update.TabIndex = 8
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        Me.btn_update.Visible = False
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
        Me.btn_add.Location = New System.Drawing.Point(1189, 425)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(100, 38)
        Me.btn_add.TabIndex = 7
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = False
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
        Me.BtnSearch.Location = New System.Drawing.Point(808, 14)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(86, 29)
        Me.BtnSearch.TabIndex = 11
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'cb_search
        '
        Me.cb_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cb_search.FormattingEnabled = True
        Me.cb_search.Location = New System.Drawing.Point(586, 15)
        Me.cb_search.Name = "cb_search"
        Me.cb_search.Size = New System.Drawing.Size(216, 21)
        Me.cb_search.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(519, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 21)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Search "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 30)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Manage Products"
        '
        't_y
        '
        Me.t_y.DecimalPlaces = 1
        Me.t_y.Location = New System.Drawing.Point(1047, 393)
        Me.t_y.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.t_y.Name = "t_y"
        Me.t_y.Size = New System.Drawing.Size(242, 26)
        Me.t_y.TabIndex = 6
        Me.t_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        't_aw
        '
        Me.t_aw.DecimalPlaces = 2
        Me.t_aw.Location = New System.Drawing.Point(1047, 361)
        Me.t_aw.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.t_aw.Name = "t_aw"
        Me.t_aw.Size = New System.Drawing.Size(242, 26)
        Me.t_aw.TabIndex = 5
        Me.t_aw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(923, 395)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 21)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Yielding (PCS)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(920, 363)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 21)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "AWU (GRAMS)"
        '
        't_c
        '
        Me.t_c.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.t_c.FormattingEnabled = True
        Me.t_c.Items.AddRange(New Object() {"BREAD SHOP", "SWEETS", "SNACK SHOP RAW", "SNACK SHOP TRADE", "JANITORIAL"})
        Me.t_c.Location = New System.Drawing.Point(1047, 264)
        Me.t_c.Name = "t_c"
        Me.t_c.Size = New System.Drawing.Size(242, 29)
        Me.t_c.TabIndex = 2
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(342, 18)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(107, 21)
        Me.LinkLabel1.TabIndex = 62
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Print Products"
        '
        'resources_product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.t_c)
        Me.Controls.Add(Me.t_y)
        Me.Controls.Add(Me.t_aw)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.cb_search)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.t_srpb)
        Me.Controls.Add(Me.t_srpc)
        Me.Controls.Add(Me.Lmat)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.t_n)
        Me.Controls.Add(Me.lid)
        Me.Controls.Add(Me.t_id)
        Me.Controls.Add(Me.Ladd)
        Me.Controls.Add(Me.table_prod)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "resources_product"
        Me.Size = New System.Drawing.Size(1366, 535)
        CType(Me.t_srpb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t_srpc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table_prod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t_y, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t_aw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents t_srpb As NumericUpDown
    Friend WithEvents t_srpc As NumericUpDown
    Friend WithEvents Lmat As Label
    Friend WithEvents btn_refresh As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents t_n As TextBox
    Friend WithEvents lid As Label
    Friend WithEvents t_id As TextBox
    Friend WithEvents Ladd As Label
    Friend WithEvents table_prod As DataGridView
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents cb_search As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents t_y As NumericUpDown
    Friend WithEvents t_aw As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents t_c As ComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
