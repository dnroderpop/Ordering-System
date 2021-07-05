<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resources_supplier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.table_prod = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Lmat = New System.Windows.Forms.Label()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.t_n = New System.Windows.Forms.TextBox()
        Me.Ladd = New System.Windows.Forms.Label()
        CType(Me.table_prod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'table_prod
        '
        Me.table_prod.AllowUserToAddRows = False
        Me.table_prod.AllowUserToDeleteRows = False
        Me.table_prod.AllowUserToResizeColumns = False
        Me.table_prod.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.table_prod.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.table_prod.BackgroundColor = System.Drawing.Color.Azure
        Me.table_prod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.table_prod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.table_prod.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.table_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.table_prod.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.table_prod.DefaultCellStyle = DataGridViewCellStyle3
        Me.table_prod.EnableHeadersVisualStyles = False
        Me.table_prod.GridColor = System.Drawing.Color.Azure
        Me.table_prod.Location = New System.Drawing.Point(12, 42)
        Me.table_prod.MultiSelect = False
        Me.table_prod.Name = "table_prod"
        Me.table_prod.ReadOnly = True
        Me.table_prod.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.table_prod.RowHeadersVisible = False
        Me.table_prod.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.table_prod.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.table_prod.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.table_prod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.table_prod.Size = New System.Drawing.Size(432, 311)
        Me.table_prod.TabIndex = 34
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 30)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Manage Suppliers"
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
        Me.btn_update.Location = New System.Drawing.Point(484, 290)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(100, 38)
        Me.btn_update.TabIndex = 79
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
        Me.btn_add.Location = New System.Drawing.Point(626, 290)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(100, 38)
        Me.btn_add.TabIndex = 72
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'Lmat
        '
        Me.Lmat.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Lmat.Location = New System.Drawing.Point(453, 122)
        Me.Lmat.Name = "Lmat"
        Me.Lmat.Size = New System.Drawing.Size(272, 37)
        Me.Lmat.TabIndex = 78
        Me.Lmat.Text = "Selected Supplier"
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
        Me.btn_refresh.Location = New System.Drawing.Point(606, 75)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(100, 38)
        Me.btn_refresh.TabIndex = 77
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.Location = New System.Drawing.Point(455, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(278, 30)
        Me.Label10.TabIndex = 76
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
        Me.btn_delete.Location = New System.Drawing.Point(488, 75)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(100, 38)
        Me.btn_delete.TabIndex = 75
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(456, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 21)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Name"
        '
        't_n
        '
        Me.t_n.Location = New System.Drawing.Point(484, 250)
        Me.t_n.Name = "t_n"
        Me.t_n.Size = New System.Drawing.Size(242, 26)
        Me.t_n.TabIndex = 71
        '
        'Ladd
        '
        Me.Ladd.Font = New System.Drawing.Font("Franklin Gothic Medium", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ladd.ForeColor = System.Drawing.Color.ForestGreen
        Me.Ladd.Location = New System.Drawing.Point(450, 148)
        Me.Ladd.Name = "Ladd"
        Me.Ladd.Size = New System.Drawing.Size(283, 46)
        Me.Ladd.TabIndex = 73
        Me.Ladd.Text = "Add a Supplier"
        Me.Ladd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'resources_supplier
        '
        Me.AcceptButton = Me.btn_add
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(745, 373)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.Lmat)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.t_n)
        Me.Controls.Add(Me.Ladd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.table_prod)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "resources_supplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Suppliers | Mang Tinapay Ordering And Inventory System"
        CType(Me.table_prod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents table_prod As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents Lmat As Label
    Friend WithEvents btn_refresh As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents t_n As TextBox
    Friend WithEvents Ladd As Label
End Class
