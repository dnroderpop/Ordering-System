<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class trans_Forcast
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lb_branch = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_search = New System.Windows.Forms.ComboBox()
        Me.table_prod = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lb_product = New System.Windows.Forms.Label()
        Me.tb_num = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lb_y = New System.Windows.Forms.Label()
        Me.lb_ord = New System.Windows.Forms.NumericUpDown()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmi = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.btn_removepick = New System.Windows.Forms.Button()
        Me.btn_addbranch = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_commit = New System.Windows.Forms.Button()
        Me.btn_clearlisttable = New System.Windows.Forms.Button()
        Me.lb_number = New System.Windows.Forms.Label()
        Me.btn_deletelisttable = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.table_list = New System.Windows.Forms.DataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totall = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.table_prod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_num, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lb_ord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 30)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Add an Order"
        '
        'dtp
        '
        Me.dtp.CalendarMonthBackground = System.Drawing.SystemColors.Control
        Me.dtp.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.dtp.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dtp.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtp.CustomFormat = "MMMM dd, yyyy"
        Me.dtp.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp.Location = New System.Drawing.Point(467, 47)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(283, 35)
        Me.dtp.TabIndex = 45
        Me.dtp.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(430, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 21)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Date of Forcast"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 21)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Branch"
        '
        'lb_branch
        '
        Me.lb_branch.Font = New System.Drawing.Font("Franklin Gothic Medium", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_branch.ForeColor = System.Drawing.Color.Red
        Me.lb_branch.Location = New System.Drawing.Point(99, 59)
        Me.lb_branch.Name = "lb_branch"
        Me.lb_branch.Size = New System.Drawing.Size(343, 45)
        Me.lb_branch.TabIndex = 51
        Me.lb_branch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 21)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Products to Order"
        '
        'cb_search
        '
        Me.cb_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cb_search.FormattingEnabled = True
        Me.cb_search.Location = New System.Drawing.Point(215, 144)
        Me.cb_search.Name = "cb_search"
        Me.cb_search.Size = New System.Drawing.Size(216, 21)
        Me.cb_search.TabIndex = 54
        '
        'table_prod
        '
        Me.table_prod.AllowUserToAddRows = False
        Me.table_prod.AllowUserToDeleteRows = False
        Me.table_prod.AllowUserToResizeRows = False
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black
        Me.table_prod.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
        Me.table_prod.BackgroundColor = System.Drawing.Color.MintCream
        Me.table_prod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.table_prod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.table_prod.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.table_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.table_prod.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column7, Me.Column6, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.table_prod.DefaultCellStyle = DataGridViewCellStyle19
        Me.table_prod.EnableHeadersVisualStyles = False
        Me.table_prod.GridColor = System.Drawing.Color.Azure
        Me.table_prod.Location = New System.Drawing.Point(27, 171)
        Me.table_prod.MultiSelect = False
        Me.table_prod.Name = "table_prod"
        Me.table_prod.ReadOnly = True
        Me.table_prod.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.table_prod.RowHeadersVisible = False
        Me.table_prod.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.table_prod.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.table_prod.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.table_prod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.table_prod.Size = New System.Drawing.Size(431, 350)
        Me.table_prod.TabIndex = 56
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 80
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 80
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 103
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
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Average Weight"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 80
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 151
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Yielding"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 80
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 99
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(148, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 21)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Search "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(556, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 21)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Selected Product"
        '
        'lb_product
        '
        Me.lb_product.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_product.ForeColor = System.Drawing.Color.OrangeRed
        Me.lb_product.Location = New System.Drawing.Point(476, 208)
        Me.lb_product.Name = "lb_product"
        Me.lb_product.Size = New System.Drawing.Size(284, 26)
        Me.lb_product.TabIndex = 64
        Me.lb_product.Text = "Product"
        Me.lb_product.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tb_num
        '
        Me.tb_num.DecimalPlaces = 2
        Me.tb_num.ForeColor = System.Drawing.Color.Green
        Me.tb_num.Location = New System.Drawing.Point(545, 260)
        Me.tb_num.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.tb_num.Name = "tb_num"
        Me.tb_num.ReadOnly = True
        Me.tb_num.Size = New System.Drawing.Size(181, 26)
        Me.tb_num.TabIndex = 66
        Me.tb_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label9.Location = New System.Drawing.Point(477, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 63)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Batch                          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        x "
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(546, 302)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 21)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Yield:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(481, 367)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(196, 24)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "Total Quantity Ordered:"
        '
        'lb_y
        '
        Me.lb_y.BackColor = System.Drawing.Color.Transparent
        Me.lb_y.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_y.ForeColor = System.Drawing.Color.Green
        Me.lb_y.Location = New System.Drawing.Point(545, 325)
        Me.lb_y.Name = "lb_y"
        Me.lb_y.Size = New System.Drawing.Size(86, 33)
        Me.lb_y.TabIndex = 75
        Me.lb_y.Text = "0"
        Me.lb_y.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lb_ord
        '
        Me.lb_ord.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ord.ForeColor = System.Drawing.Color.Green
        Me.lb_ord.Location = New System.Drawing.Point(545, 400)
        Me.lb_ord.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.lb_ord.Name = "lb_ord"
        Me.lb_ord.Size = New System.Drawing.Size(180, 35)
        Me.lb_ord.TabIndex = 78
        Me.lb_ord.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(571, 508)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 24)
        Me.Button2.TabIndex = 79
        Me.Button2.Text = "Show Forecasts"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(646, 302)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 21)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Commi Price"
        '
        'cmi
        '
        Me.cmi.BackColor = System.Drawing.Color.Transparent
        Me.cmi.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmi.ForeColor = System.Drawing.Color.DarkGreen
        Me.cmi.Location = New System.Drawing.Point(668, 325)
        Me.cmi.Name = "cmi"
        Me.cmi.Size = New System.Drawing.Size(86, 33)
        Me.cmi.TabIndex = 81
        Me.cmi.Text = "0"
        Me.cmi.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Ordering_System.My.Resources.Resources.icons8_share_3_30__1_
        Me.Button1.Location = New System.Drawing.Point(731, 403)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 32)
        Me.Button1.TabIndex = 73
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_search.BackColor = System.Drawing.Color.Transparent
        Me.btn_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown
        Me.btn_search.FlatAppearance.BorderSize = 0
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.Color.DarkGray
        Me.btn_search.Image = Global.Ordering_System.My.Resources.Resources.icons8_search_24__1_
        Me.btn_search.Location = New System.Drawing.Point(434, 146)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(24, 21)
        Me.btn_search.TabIndex = 55
        Me.btn_search.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'btn_removepick
        '
        Me.btn_removepick.FlatAppearance.BorderSize = 0
        Me.btn_removepick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_removepick.Image = Global.Ordering_System.My.Resources.Resources.icons8_delete_30__1_
        Me.btn_removepick.Location = New System.Drawing.Point(57, 71)
        Me.btn_removepick.Name = "btn_removepick"
        Me.btn_removepick.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_removepick.Size = New System.Drawing.Size(36, 33)
        Me.btn_removepick.TabIndex = 50
        Me.btn_removepick.UseVisualStyleBackColor = True
        Me.btn_removepick.Visible = False
        '
        'btn_addbranch
        '
        Me.btn_addbranch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_addbranch.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btn_addbranch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addbranch.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki
        Me.btn_addbranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addbranch.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addbranch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btn_addbranch.Location = New System.Drawing.Point(106, 66)
        Me.btn_addbranch.Name = "btn_addbranch"
        Me.btn_addbranch.Size = New System.Drawing.Size(144, 38)
        Me.btn_addbranch.TabIndex = 52
        Me.btn_addbranch.Text = "Pick Branch"
        Me.btn_addbranch.UseVisualStyleBackColor = False
        Me.btn_addbranch.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!)
        Me.Label12.Location = New System.Drawing.Point(460, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(298, 52)
        Me.Label12.TabIndex = 82
        Me.Label12.Text = "Date is Invisible"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_commit
        '
        Me.btn_commit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_commit.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btn_commit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_commit.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen
        Me.btn_commit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_commit.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_commit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btn_commit.Location = New System.Drawing.Point(487, 483)
        Me.btn_commit.Name = "btn_commit"
        Me.btn_commit.Size = New System.Drawing.Size(100, 38)
        Me.btn_commit.TabIndex = 48
        Me.btn_commit.Text = "Commit"
        Me.btn_commit.UseVisualStyleBackColor = False
        '
        'btn_clearlisttable
        '
        Me.btn_clearlisttable.FlatAppearance.BorderSize = 0
        Me.btn_clearlisttable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clearlisttable.Image = Global.Ordering_System.My.Resources.Resources.icons8_refresh_30
        Me.btn_clearlisttable.Location = New System.Drawing.Point(558, 13)
        Me.btn_clearlisttable.Name = "btn_clearlisttable"
        Me.btn_clearlisttable.Size = New System.Drawing.Size(29, 32)
        Me.btn_clearlisttable.TabIndex = 72
        Me.btn_clearlisttable.UseVisualStyleBackColor = True
        '
        'lb_number
        '
        Me.lb_number.Location = New System.Drawing.Point(189, 16)
        Me.lb_number.Name = "lb_number"
        Me.lb_number.Size = New System.Drawing.Size(273, 24)
        Me.lb_number.TabIndex = 77
        Me.lb_number.Text = "########"
        Me.lb_number.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_deletelisttable
        '
        Me.btn_deletelisttable.FlatAppearance.BorderSize = 0
        Me.btn_deletelisttable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deletelisttable.Image = Global.Ordering_System.My.Resources.Resources.icons8_trash_filled_24
        Me.btn_deletelisttable.Location = New System.Drawing.Point(523, 13)
        Me.btn_deletelisttable.Name = "btn_deletelisttable"
        Me.btn_deletelisttable.Size = New System.Drawing.Size(29, 32)
        Me.btn_deletelisttable.TabIndex = 47
        Me.btn_deletelisttable.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 21)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "List of Orders"
        '
        'table_list
        '
        Me.table_list.AllowUserToAddRows = False
        Me.table_list.AllowUserToDeleteRows = False
        Me.table_list.AllowUserToResizeRows = False
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black
        Me.table_list.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle21
        Me.table_list.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.table_list.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.table_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.table_list.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.table_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.table_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column10, Me.Column1, Me.Column2, Me.Column4, Me.Column3, Me.Column5, Me.Column8})
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.table_list.DefaultCellStyle = DataGridViewCellStyle23
        Me.table_list.EnableHeadersVisualStyles = False
        Me.table_list.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.table_list.Location = New System.Drawing.Point(14, 43)
        Me.table_list.MultiSelect = False
        Me.table_list.Name = "table_list"
        Me.table_list.ReadOnly = True
        Me.table_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.table_list.RowHeadersVisible = False
        Me.table_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.table_list.RowsDefaultCellStyle = DataGridViewCellStyle24
        Me.table_list.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.table_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.table_list.Size = New System.Drawing.Size(573, 434)
        Me.table_list.TabIndex = 43
        '
        'Column8
        '
        Me.Column8.HeaderText = "Amount"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Quantity Ordered"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Commi Price"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Branch Price"
        Me.Column4.MinimumWidth = 100
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.FillWeight = 50.0!
        Me.Column2.HeaderText = "Product Name"
        Me.Column2.MinimumWidth = 120
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Product id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column10
        '
        Me.Column10.HeaderText = "id"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Visible = False
        '
        'totall
        '
        Me.totall.Location = New System.Drawing.Point(138, 483)
        Me.totall.Name = "totall"
        Me.totall.Size = New System.Drawing.Size(242, 38)
        Me.totall.TabIndex = 73
        Me.totall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.totall)
        Me.Panel1.Controls.Add(Me.table_list)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btn_deletelisttable)
        Me.Panel1.Controls.Add(Me.lb_number)
        Me.Panel1.Controls.Add(Me.btn_clearlisttable)
        Me.Panel1.Controls.Add(Me.btn_commit)
        Me.Panel1.Location = New System.Drawing.Point(766, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(621, 535)
        Me.Panel1.TabIndex = 76
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(29, 492)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 21)
        Me.Label13.TabIndex = 78
        Me.Label13.Text = "Total Amount"
        '
        'trans_Forcast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.Controls.Add(Me.cmi)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lb_ord)
        Me.Controls.Add(Me.lb_y)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tb_num)
        Me.Controls.Add(Me.lb_product)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.table_prod)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.cb_search)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_addbranch)
        Me.Controls.Add(Me.lb_branch)
        Me.Controls.Add(Me.btn_removepick)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label12)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "trans_Forcast"
        Me.Size = New System.Drawing.Size(1366, 535)
        CType(Me.table_prod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_num, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lb_ord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_removepick As Button
    Friend WithEvents lb_branch As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_search As Button
    Friend WithEvents cb_search As ComboBox
    Friend WithEvents table_prod As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lb_product As Label
    Friend WithEvents tb_num As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lb_y As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents lb_ord As NumericUpDown
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents cmi As Label
    Friend WithEvents btn_addbranch As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_commit As Button
    Friend WithEvents btn_clearlisttable As Button
    Friend WithEvents lb_number As Label
    Friend WithEvents btn_deletelisttable As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents table_list As DataGridView
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents totall As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
End Class
