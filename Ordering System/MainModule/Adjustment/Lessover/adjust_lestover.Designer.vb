<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adjust_lestover
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.var_ispahabol = New System.Windows.Forms.CheckBox()
        Me.var_doeshavests = New System.Windows.Forms.CheckBox()
        Me.var_date = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.var_branch = New System.Windows.Forms.ComboBox()
        Me.var_pname = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.var_pid = New System.Windows.Forms.NumericUpDown()
        Me.var_qty = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.var_reason = New System.Windows.Forms.TextBox()
        Me.btn_accepts = New System.Windows.Forms.Button()
        Me.var_firstdel = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.var_batch = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.var_pid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.var_qty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.var_batch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lest Over Items"
        '
        'var_ispahabol
        '
        Me.var_ispahabol.AutoSize = True
        Me.var_ispahabol.Checked = True
        Me.var_ispahabol.CheckState = System.Windows.Forms.CheckState.Checked
        Me.var_ispahabol.Location = New System.Drawing.Point(49, 73)
        Me.var_ispahabol.Name = "var_ispahabol"
        Me.var_ispahabol.Size = New System.Drawing.Size(146, 25)
        Me.var_ispahabol.TabIndex = 2
        Me.var_ispahabol.Text = "Is it a PAHABOL?"
        Me.var_ispahabol.UseVisualStyleBackColor = True
        '
        'var_doeshavests
        '
        Me.var_doeshavests.AutoSize = True
        Me.var_doeshavests.Location = New System.Drawing.Point(49, 42)
        Me.var_doeshavests.Name = "var_doeshavests"
        Me.var_doeshavests.Size = New System.Drawing.Size(166, 25)
        Me.var_doeshavests.TabIndex = 3
        Me.var_doeshavests.Text = "Does this have STS?"
        Me.var_doeshavests.UseVisualStyleBackColor = True
        '
        'var_date
        '
        Me.var_date.Location = New System.Drawing.Point(350, 53)
        Me.var_date.Name = "var_date"
        Me.var_date.Size = New System.Drawing.Size(279, 26)
        Me.var_date.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(323, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(323, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Branch"
        '
        'var_branch
        '
        Me.var_branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.var_branch.FormattingEnabled = True
        Me.var_branch.Location = New System.Drawing.Point(350, 106)
        Me.var_branch.Name = "var_branch"
        Me.var_branch.Size = New System.Drawing.Size(279, 29)
        Me.var_branch.TabIndex = 7
        '
        'var_pname
        '
        Me.var_pname.FormattingEnabled = True
        Me.var_pname.Location = New System.Drawing.Point(157, 162)
        Me.var_pname.Name = "var_pname"
        Me.var_pname.Size = New System.Drawing.Size(236, 29)
        Me.var_pname.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(238, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Product id               Product Name"
        '
        'var_pid
        '
        Me.var_pid.Location = New System.Drawing.Point(40, 163)
        Me.var_pid.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.var_pid.Name = "var_pid"
        Me.var_pid.Size = New System.Drawing.Size(86, 26)
        Me.var_pid.TabIndex = 10
        Me.var_pid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'var_qty
        '
        Me.var_qty.Location = New System.Drawing.Point(475, 162)
        Me.var_qty.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.var_qty.Minimum = New Decimal(New Integer() {99999, 0, 0, -2147483648})
        Me.var_qty.Name = "var_qty"
        Me.var_qty.Size = New System.Drawing.Size(134, 26)
        Me.var_qty.TabIndex = 11
        Me.var_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(434, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 21)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Set The Exact Quantity"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 21)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Reason"
        '
        'var_reason
        '
        Me.var_reason.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.var_reason.Location = New System.Drawing.Point(40, 237)
        Me.var_reason.Multiline = True
        Me.var_reason.Name = "var_reason"
        Me.var_reason.Size = New System.Drawing.Size(589, 86)
        Me.var_reason.TabIndex = 14
        '
        'btn_accepts
        '
        Me.btn_accepts.BackColor = System.Drawing.Color.GreenYellow
        Me.btn_accepts.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_accepts.Location = New System.Drawing.Point(270, 329)
        Me.btn_accepts.Name = "btn_accepts"
        Me.btn_accepts.Size = New System.Drawing.Size(86, 34)
        Me.btn_accepts.TabIndex = 15
        Me.btn_accepts.Text = "Accept"
        Me.btn_accepts.UseVisualStyleBackColor = False
        '
        'var_firstdel
        '
        Me.var_firstdel.AutoSize = True
        Me.var_firstdel.Location = New System.Drawing.Point(49, 104)
        Me.var_firstdel.Name = "var_firstdel"
        Me.var_firstdel.Size = New System.Drawing.Size(84, 25)
        Me.var_firstdel.TabIndex = 16
        Me.var_firstdel.Text = "1st Del?"
        Me.var_firstdel.UseVisualStyleBackColor = True
        Me.var_firstdel.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Aqua
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(534, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Check"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Crimson
        Me.Label7.Location = New System.Drawing.Point(346, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(252, 21)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Plus 1 day if you are refering to STS"
        '
        'var_batch
        '
        Me.var_batch.Location = New System.Drawing.Point(419, 205)
        Me.var_batch.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.var_batch.Minimum = New Decimal(New Integer() {99999, 0, 0, -2147483648})
        Me.var_batch.Name = "var_batch"
        Me.var_batch.Size = New System.Drawing.Size(61, 26)
        Me.var_batch.TabIndex = 19
        Me.var_batch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(399, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 21)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Batch"
        '
        'adjust_lestover
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(641, 369)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.var_batch)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.var_firstdel)
        Me.Controls.Add(Me.btn_accepts)
        Me.Controls.Add(Me.var_reason)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.var_qty)
        Me.Controls.Add(Me.var_pid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.var_pname)
        Me.Controls.Add(Me.var_branch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.var_date)
        Me.Controls.Add(Me.var_doeshavests)
        Me.Controls.Add(Me.var_ispahabol)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "adjust_lestover"
        Me.Text = "Less Over Items Adjustment"
        CType(Me.var_pid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.var_qty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.var_batch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents var_ispahabol As CheckBox
    Friend WithEvents var_doeshavests As CheckBox
    Friend WithEvents var_date As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents var_branch As ComboBox
    Friend WithEvents var_pname As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents var_pid As NumericUpDown
    Friend WithEvents var_qty As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents var_reason As TextBox
    Friend WithEvents btn_accepts As Button
    Friend WithEvents var_firstdel As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents var_batch As NumericUpDown
    Friend WithEvents Label8 As Label
End Class
