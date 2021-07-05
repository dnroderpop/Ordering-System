<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mr_panel
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
        Me.crv_branch = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.crv_product = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.crv_content = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.crv_pp = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'crv_branch
        '
        Me.crv_branch.ActiveViewIndex = -1
        Me.crv_branch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_branch.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_branch.DisplayStatusBar = False
        Me.crv_branch.DisplayToolbar = False
        Me.crv_branch.EnableToolTips = False
        Me.crv_branch.Location = New System.Drawing.Point(26, 91)
        Me.crv_branch.MinimumSize = New System.Drawing.Size(646, 200)
        Me.crv_branch.Name = "crv_branch"
        Me.crv_branch.ShowCloseButton = False
        Me.crv_branch.Size = New System.Drawing.Size(646, 391)
        Me.crv_branch.TabIndex = 0
        Me.crv_branch.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'crv_product
        '
        Me.crv_product.ActiveViewIndex = -1
        Me.crv_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_product.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_product.DisplayStatusBar = False
        Me.crv_product.DisplayToolbar = False
        Me.crv_product.EnableToolTips = False
        Me.crv_product.Location = New System.Drawing.Point(678, 91)
        Me.crv_product.MinimumSize = New System.Drawing.Size(646, 200)
        Me.crv_product.Name = "crv_product"
        Me.crv_product.ShowCloseButton = False
        Me.crv_product.Size = New System.Drawing.Size(646, 391)
        Me.crv_product.TabIndex = 1
        Me.crv_product.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'crv_content
        '
        Me.crv_content.ActiveViewIndex = -1
        Me.crv_content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_content.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_content.Location = New System.Drawing.Point(25, 488)
        Me.crv_content.MinimumSize = New System.Drawing.Size(1298, 700)
        Me.crv_content.Name = "crv_content"
        Me.crv_content.Size = New System.Drawing.Size(1299, 700)
        Me.crv_content.TabIndex = 2
        Me.crv_content.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1298, 78)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tools"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Khaki
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(1136, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 39)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Export "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(964, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 39)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Query"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(531, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Date to :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Date From :"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(640, 39)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(283, 22)
        Me.DateTimePicker2.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(196, 39)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(283, 22)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.crv_pp)
        Me.Panel1.Controls.Add(Me.crv_content)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.crv_branch)
        Me.Panel1.Controls.Add(Me.crv_product)
        Me.Panel1.Location = New System.Drawing.Point(2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(18)
        Me.Panel1.Size = New System.Drawing.Size(1361, 529)
        Me.Panel1.TabIndex = 4
        '
        'crv_pp
        '
        Me.crv_pp.ActiveViewIndex = -1
        Me.crv_pp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_pp.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_pp.Location = New System.Drawing.Point(25, 1194)
        Me.crv_pp.Name = "crv_pp"
        Me.crv_pp.Size = New System.Drawing.Size(1298, 475)
        Me.crv_pp.TabIndex = 4
        Me.crv_pp.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.crv_pp.Visible = False
        '
        'mr_panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "mr_panel"
        Me.Size = New System.Drawing.Size(1366, 535)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crv_branch As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crv_product As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crv_content As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents crv_pp As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button2 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
