<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class conset
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tserver = New System.Windows.Forms.TextBox()
        Me.Tuser = New System.Windows.Forms.TextBox()
        Me.Tpass = New System.Windows.Forms.TextBox()
        Me.Tname = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(35, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "host"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(315, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Apply"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(35, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "user"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(35, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "pass"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(17, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "namedb"
        '
        'Tserver
        '
        Me.Tserver.Location = New System.Drawing.Point(68, 17)
        Me.Tserver.Name = "Tserver"
        Me.Tserver.Size = New System.Drawing.Size(323, 20)
        Me.Tserver.TabIndex = 5
        '
        'Tuser
        '
        Me.Tuser.Location = New System.Drawing.Point(68, 43)
        Me.Tuser.Name = "Tuser"
        Me.Tuser.Size = New System.Drawing.Size(323, 20)
        Me.Tuser.TabIndex = 6
        '
        'Tpass
        '
        Me.Tpass.Location = New System.Drawing.Point(68, 69)
        Me.Tpass.Name = "Tpass"
        Me.Tpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Tpass.Size = New System.Drawing.Size(323, 20)
        Me.Tpass.TabIndex = 7
        '
        'Tname
        '
        Me.Tname.Location = New System.Drawing.Point(68, 95)
        Me.Tname.Name = "Tname"
        Me.Tname.Size = New System.Drawing.Size(323, 20)
        Me.Tname.TabIndex = 8
        '
        'conset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(423, 163)
        Me.Controls.Add(Me.Tname)
        Me.Controls.Add(Me.Tpass)
        Me.Controls.Add(Me.Tuser)
        Me.Controls.Add(Me.Tserver)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "conset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "conset"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Tserver As TextBox
    Friend WithEvents Tuser As TextBox
    Friend WithEvents Tpass As TextBox
    Friend WithEvents Tname As TextBox
End Class
