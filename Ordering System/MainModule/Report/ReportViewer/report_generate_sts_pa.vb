Imports CrystalDecisions.CrystalReports.Engine
Public Class report_generate_sts_pa
    Public sts, time, branch, qdate, batch As String
    Public data As DataTable
    Private Sub report_generate_sts_pa_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filelocation As String = "report\creport_sts_pahabol.rpt"
        Dim CR As New ReportDocument
        CR.Load(filelocation)

        crv_form.ReportSource = CR
        CR.SetDataSource(data)
        Dim txt_name As TextObject = CR.ReportDefinition.ReportObjects.Item("txt_name")
        Dim txt_time As TextObject = CR.ReportDefinition.ReportObjects.Item("txt_time")
        Dim txt_sts As TextObject = CR.ReportDefinition.ReportObjects.Item("txt_sts")
        Dim txt_branch As TextObject = CR.ReportDefinition.ReportObjects.Item("txt_branch")
        Dim txt_date As TextObject = CR.ReportDefinition.ReportObjects.Item("txt_date")


        txt_name.Text = connn.sql_dataItemget("nickname", "user_accounts", My.Settings.myuserid)
        txt_sts.Text = sts
        txt_time.Text = time
        txt_branch.Text = branch
        txt_date.Text = qdate

        crv_form.RefreshReport()

        Dim crystalexport As New crystalexport
        crystalexport.crystalexport(CR, "sts", txt_sts.Text)

    End Sub
End Class
