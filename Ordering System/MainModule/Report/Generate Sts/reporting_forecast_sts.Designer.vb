<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporting_forecast_sts
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.table_second = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.table_list = New System.Windows.Forms.DataGridView()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.table_first = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cb_del = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_branch = New System.Windows.Forms.ComboBox()
        Me.dtp_date = New System.Windows.Forms.DateTimePicker()
        Me.btn_generate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.num_num = New System.Windows.Forms.NumericUpDown()
        Me.lb_prod = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dtp_qdate = New System.Windows.Forms.DateTimePicker()
        Me.lbSTSNUM = New System.Windows.Forms.Label()
        Me.lbSTSNUM_2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.table_second, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.table_first, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_num, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(245, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 21)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Delivery"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 21)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Unallocated Production"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.table_second)
        Me.GroupBox2.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(882, 82)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(481, 462)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Second Delivery"
        '
        'table_second
        '
        Me.table_second.AllowUserToAddRows = False
        Me.table_second.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.table_second.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.table_second.BackgroundColor = System.Drawing.Color.Azure
        Me.table_second.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.table_second.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.table_second.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.table_second.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.table_second.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.table_second.DefaultCellStyle = DataGridViewCellStyle3
        Me.table_second.EnableHeadersVisualStyles = False
        Me.table_second.GridColor = System.Drawing.Color.Azure
        Me.table_second.Location = New System.Drawing.Point(6, 25)
        Me.table_second.MultiSelect = False
        Me.table_second.Name = "table_second"
        Me.table_second.ReadOnly = True
        Me.table_second.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.table_second.RowHeadersVisible = False
        Me.table_second.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.table_second.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.table_second.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.table_second.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.table_second.Size = New System.Drawing.Size(469, 431)
        Me.table_second.TabIndex = 44
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 5
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.DataGridViewTextBoxColumn5.HeaderText = "Unit Price"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 5
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.DataGridViewTextBoxColumn6.HeaderText = "Total Amount"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 5
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.DataGridViewTextBoxColumn7.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 5
        '
        'table_list
        '
        Me.table_list.AllowUserToAddRows = False
        Me.table_list.AllowUserToDeleteRows = False
        Me.table_list.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.table_list.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.table_list.BackgroundColor = System.Drawing.Color.Azure
        Me.table_list.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.table_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.table_list.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.table_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.table_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column10, Me.column1, Me.column2})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.table_list.DefaultCellStyle = DataGridViewCellStyle7
        Me.table_list.EnableHeadersVisualStyles = False
        Me.table_list.GridColor = System.Drawing.Color.Azure
        Me.table_list.Location = New System.Drawing.Point(22, 37)
        Me.table_list.MultiSelect = False
        Me.table_list.Name = "table_list"
        Me.table_list.ReadOnly = True
        Me.table_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.table_list.RowHeadersVisible = False
        Me.table_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.table_list.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.table_list.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.table_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.table_list.Size = New System.Drawing.Size(217, 507)
        Me.table_list.TabIndex = 50
        '
        'Column10
        '
        Me.Column10.HeaderText = "id"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Visible = False
        '
        'column1
        '
        Me.column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.column1.FillWeight = 80.0!
        Me.column1.HeaderText = "Name"
        Me.column1.Name = "column1"
        Me.column1.ReadOnly = True
        '
        'column2
        '
        Me.column2.HeaderText = "Qty"
        Me.column2.Name = "column2"
        Me.column2.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.table_first)
        Me.GroupBox1.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(381, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(481, 462)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "First Delivery"
        '
        'table_first
        '
        Me.table_first.AllowUserToAddRows = False
        Me.table_first.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        Me.table_first.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.table_first.BackgroundColor = System.Drawing.Color.Azure
        Me.table_first.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.table_first.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.table_first.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.table_first.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.table_first.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.table_first.DefaultCellStyle = DataGridViewCellStyle11
        Me.table_first.EnableHeadersVisualStyles = False
        Me.table_first.GridColor = System.Drawing.Color.Azure
        Me.table_first.Location = New System.Drawing.Point(6, 25)
        Me.table_first.MultiSelect = False
        Me.table_first.Name = "table_first"
        Me.table_first.ReadOnly = True
        Me.table_first.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.table_first.RowHeadersVisible = False
        Me.table_first.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.table_first.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.table_first.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.table_first.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.table_first.Size = New System.Drawing.Size(469, 431)
        Me.table_first.TabIndex = 44
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.Column4.HeaderText = "Quantity"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 5
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.Column5.HeaderText = "Unit Price"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 5
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.Column6.HeaderText = "Total Amount"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 5
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.Column7.HeaderText = "Category"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 5
        '
        'cb_del
        '
        Me.cb_del.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_del.FormattingEnabled = True
        Me.cb_del.Items.AddRange(New Object() {"First Delivery", "Second Delivery"})
        Me.cb_del.Location = New System.Drawing.Point(249, 254)
        Me.cb_del.Name = "cb_del"
        Me.cb_del.Size = New System.Drawing.Size(130, 29)
        Me.cb_del.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(585, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 21)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Branch"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(266, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 21)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Date"
        '
        'cb_branch
        '
        Me.cb_branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_branch.FormattingEnabled = True
        Me.cb_branch.Location = New System.Drawing.Point(607, 34)
        Me.cb_branch.Name = "cb_branch"
        Me.cb_branch.Size = New System.Drawing.Size(186, 29)
        Me.cb_branch.TabIndex = 57
        '
        'dtp_date
        '
        Me.dtp_date.Location = New System.Drawing.Point(281, 37)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(296, 26)
        Me.dtp_date.TabIndex = 56
        '
        'btn_generate
        '
        Me.btn_generate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_generate.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btn_generate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_generate.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen
        Me.btn_generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_generate.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_generate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btn_generate.Location = New System.Drawing.Point(1229, 23)
        Me.btn_generate.Name = "btn_generate"
        Me.btn_generate.Size = New System.Drawing.Size(128, 48)
        Me.btn_generate.TabIndex = 55
        Me.btn_generate.Text = "Submit"
        Me.btn_generate.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(245, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 21)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Quantity"
        '
        'num_num
        '
        Me.num_num.Location = New System.Drawing.Point(253, 338)
        Me.num_num.Name = "num_num"
        Me.num_num.Size = New System.Drawing.Size(126, 26)
        Me.num_num.TabIndex = 62
        Me.num_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lb_prod
        '
        Me.lb_prod.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lb_prod.Location = New System.Drawing.Point(245, 168)
        Me.lb_prod.Name = "lb_prod"
        Me.lb_prod.Size = New System.Drawing.Size(130, 53)
        Me.lb_prod.TabIndex = 64
        Me.lb_prod.Text = "Product Name"
        Me.lb_prod.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(813, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 38)
        Me.Button2.TabIndex = 65
        Me.Button2.Text = "Load"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'dtp_qdate
        '
        Me.dtp_qdate.Location = New System.Drawing.Point(927, 32)
        Me.dtp_qdate.Name = "dtp_qdate"
        Me.dtp_qdate.Size = New System.Drawing.Size(296, 26)
        Me.dtp_qdate.TabIndex = 66
        Me.dtp_qdate.Visible = False
        '
        'lbSTSNUM
        '
        Me.lbSTSNUM.Location = New System.Drawing.Point(493, 80)
        Me.lbSTSNUM.Name = "lbSTSNUM"
        Me.lbSTSNUM.Size = New System.Drawing.Size(259, 21)
        Me.lbSTSNUM.TabIndex = 67
        Me.lbSTSNUM.Text = """"""
        '
        'lbSTSNUM_2
        '
        Me.lbSTSNUM_2.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSTSNUM_2.Location = New System.Drawing.Point(1007, 80)
        Me.lbSTSNUM_2.Name = "lbSTSNUM_2"
        Me.lbSTSNUM_2.Size = New System.Drawing.Size(259, 21)
        Me.lbSTSNUM_2.TabIndex = 68
        Me.lbSTSNUM_2.Text = """"""
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(241, 96)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(53, 21)
        Me.LinkLabel1.TabIndex = 70
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Export"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Enabled = False
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Button3.Image = Global.Ordering_System.My.Resources.Resources.icons8_trash_filled_24
        Me.Button3.Location = New System.Drawing.Point(245, 394)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(46, 34)
        Me.Button3.TabIndex = 69
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Button1.Image = Global.Ordering_System.My.Resources.Resources.icons8_share_3_30__1_
        Me.Button1.Location = New System.Drawing.Point(329, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 44)
        Me.Button1.TabIndex = 63
        Me.Button1.UseVisualStyleBackColor = False
        '
        'reporting_forecast_sts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lbSTSNUM_2)
        Me.Controls.Add(Me.lbSTSNUM)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lb_prod)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.num_num)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_del)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cb_branch)
        Me.Controls.Add(Me.dtp_date)
        Me.Controls.Add(Me.btn_generate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.table_list)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtp_qdate)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "reporting_forecast_sts"
        Me.Size = New System.Drawing.Size(1366, 547)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.table_second, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.table_first, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_num, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents table_second As DataGridView
    Friend WithEvents table_list As DataGridView
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents column1 As DataGridViewTextBoxColumn
    Friend WithEvents column2 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents table_first As DataGridView
    Friend WithEvents cb_del As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_branch As ComboBox
    Friend WithEvents dtp_date As DateTimePicker
    Friend WithEvents btn_generate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents num_num As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents lb_prod As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents dtp_qdate As DateTimePicker
    Friend WithEvents lbSTSNUM As Label
    Friend WithEvents lbSTSNUM_2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
