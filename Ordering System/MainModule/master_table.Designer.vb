<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class master_table
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.table_prod = New System.Windows.Forms.DataGridView()
        Me.btn_query = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.table_wher = New System.Windows.Forms.TextBox()
        Me.table_name = New System.Windows.Forms.ComboBox()
        CType(Me.table_prod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'table_prod
        '
        Me.table_prod.AllowUserToAddRows = False
        Me.table_prod.AllowUserToDeleteRows = False
        Me.table_prod.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.table_prod.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.table_prod.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.table_prod.BackgroundColor = System.Drawing.Color.Azure
        Me.table_prod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.table_prod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.table_prod.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.table_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.table_prod.DefaultCellStyle = DataGridViewCellStyle3
        Me.table_prod.EnableHeadersVisualStyles = False
        Me.table_prod.GridColor = System.Drawing.Color.Azure
        Me.table_prod.Location = New System.Drawing.Point(12, 48)
        Me.table_prod.MultiSelect = False
        Me.table_prod.Name = "table_prod"
        Me.table_prod.ReadOnly = True
        Me.table_prod.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.table_prod.RowHeadersVisible = False
        Me.table_prod.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.table_prod.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.table_prod.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.table_prod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.table_prod.Size = New System.Drawing.Size(776, 455)
        Me.table_prod.TabIndex = 57
        '
        'btn_query
        '
        Me.btn_query.BackColor = System.Drawing.Color.YellowGreen
        Me.btn_query.FlatAppearance.BorderSize = 0
        Me.btn_query.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_query.Location = New System.Drawing.Point(713, 12)
        Me.btn_query.Name = "btn_query"
        Me.btn_query.Size = New System.Drawing.Size(75, 30)
        Me.btn_query.TabIndex = 58
        Me.btn_query.Text = "Query Data"
        Me.btn_query.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Table"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(244, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Conditions"
        '
        'table_wher
        '
        Me.table_wher.Location = New System.Drawing.Point(244, 22)
        Me.table_wher.Name = "table_wher"
        Me.table_wher.Size = New System.Drawing.Size(463, 20)
        Me.table_wher.TabIndex = 61
        '
        'table_name
        '
        Me.table_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.table_name.FormattingEnabled = True
        Me.table_name.Location = New System.Drawing.Point(15, 21)
        Me.table_name.Name = "table_name"
        Me.table_name.Size = New System.Drawing.Size(223, 21)
        Me.table_name.TabIndex = 63
        '
        'master_table
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(800, 515)
        Me.Controls.Add(Me.table_name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.table_wher)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_query)
        Me.Controls.Add(Me.table_prod)
        Me.Name = "master_table"
        Me.Text = "Master Table"
        CType(Me.table_prod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents table_prod As DataGridView
    Friend WithEvents btn_query As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents table_wher As TextBox
    Friend WithEvents table_name As ComboBox
End Class
