<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporting_sts_onday
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_branch = New System.Windows.Forms.ComboBox()
        Me.dtp_date = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_generate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(337, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 21)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Branch"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 21)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Date"
        '
        'cb_branch
        '
        Me.cb_branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_branch.FormattingEnabled = True
        Me.cb_branch.Location = New System.Drawing.Point(341, 51)
        Me.cb_branch.Name = "cb_branch"
        Me.cb_branch.Size = New System.Drawing.Size(186, 29)
        Me.cb_branch.TabIndex = 17
        '
        'dtp_date
        '
        Me.dtp_date.Location = New System.Drawing.Point(39, 54)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(296, 26)
        Me.dtp_date.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 21)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "SELECT STS FOR PAHABOL!"
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
        Me.btn_generate.Location = New System.Drawing.Point(662, 45)
        Me.btn_generate.Name = "btn_generate"
        Me.btn_generate.Size = New System.Drawing.Size(100, 38)
        Me.btn_generate.TabIndex = 14
        Me.btn_generate.Text = "Generate"
        Me.btn_generate.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(549, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 21)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Batch"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(553, 52)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(81, 26)
        Me.NumericUpDown1.TabIndex = 21
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'reporting_sts_onday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(770, 94)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cb_branch)
        Me.Controls.Add(Me.dtp_date)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_generate)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "reporting_sts_onday"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "reporting_sts_onday"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_branch As ComboBox
    Friend WithEvents dtp_date As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_generate As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
End Class
