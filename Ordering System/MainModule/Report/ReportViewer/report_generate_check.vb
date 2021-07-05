Imports CrystalDecisions.CrystalReports.Engine
Public Class report_generate_check
    Public data As DataTable
    Public dat As String
    Private Sub report_generate_mr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filelocation As String = "report\creport_checksum.rpt"
        Dim CR As New ReportDocument
        CR.Load(filelocation)
        CrystalReportViewer1.ReportSource = CR
        CR.SetDataSource(data)
        CrystalReportViewer1.RefreshReport()

        Dim crystalexport As New crystalexport
        crystalexport.crystalexport(CR, "sum", dat)

    End Sub
End Class