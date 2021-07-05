﻿Imports CrystalDecisions.CrystalReports.Engine
Public Class print_delivery
    Public s As DataTable
    Public sts, time, branch, qdate As String
    Private Sub print_delivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filelocation As String = "report\creport_deliveries.rpt"
        Dim CR As New ReportDocument
        CR.Load(filelocation)

        crv_form.ReportSource = CR
        CR.SetDataSource(s)
        Dim txt_name As TextObject = CR.ReportDefinition.ReportObjects.Item("txt_name")
        Dim txt_sts As TextObject = CR.ReportDefinition.ReportObjects.Item("txt_sts")
        Dim txt_branch As TextObject = CR.ReportDefinition.ReportObjects.Item("txt_branch")
        Dim txt_date As TextObject = CR.ReportDefinition.ReportObjects.Item("txt_date")


        txt_name.Text = connn.sql_dataItemget("nickname", "user_accounts", My.Settings.myuserid)
        txt_sts.Text = sts
        txt_branch.Text = branch
        txt_date.Text = qdate

        crv_form.RefreshReport()

        Dim crystalexport As New crystalexport
        crystalexport.crystalexport(CR, "sts", "Batch for " & txt_sts.Text)

    End Sub
End Class