<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class report_generate_sts_pa
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
        Me.crv_form = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crv_form
        '
        Me.crv_form.ActiveViewIndex = -1
        Me.crv_form.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_form.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_form.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv_form.Location = New System.Drawing.Point(0, 0)
        Me.crv_form.Name = "crv_form"
        Me.crv_form.Size = New System.Drawing.Size(800, 450)
        Me.crv_form.TabIndex = 0
        Me.crv_form.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'report_generate_sts_pa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.crv_form)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MinimizeBox = False
        Me.Name = "report_generate_sts_pa"
        Me.Text = "report_generate_sts_pa"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crv_form As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
