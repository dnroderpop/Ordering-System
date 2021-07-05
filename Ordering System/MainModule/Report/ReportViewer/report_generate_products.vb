Imports CrystalDecisions.CrystalReports.Engine
Public Class report_generate_products
    Private Sub report_generate_products_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cv As ReportDocument = New ReportDocument
        cv.Load("report/creport_products.rpt")
        CrystalReportViewer1.ReportSource = cv

    End Sub
End Class