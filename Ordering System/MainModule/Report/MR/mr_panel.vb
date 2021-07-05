Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class mr_panel
    Dim save As SaveFileDialog = SaveFileDialog1
    Dim dataset_delivery As New dataset_delivery
    Dim transsts As DataTable = dataset_delivery.mrtable
    Dim date1, date2 As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        transsts.Rows.Clear()
        date1 = connn.datetoquery(DateTimePicker1.Value.ToShortDateString)
        date2 = connn.datetoquery(DateTimePicker2.Value.ToShortDateString)
        Dim data As DataTable = connn.sql_customSQLCOMMAND_select("select * from trans_sts where date between '" & date1 & "' and '" & date2 & "'")
        If data.Rows.Count = 0 Then
            connn.msgboxc("no data between these dates", 2)
        Else

            For i As Integer = 0 To data.Rows.Count - 1
                Dim id, stsid, prod, cat, branch As String
                Dim qty, unt, tamt As Double
                id = data.Rows(i)(0)
                stsid = data.Rows(i)(1)
                prod = data.Rows(i)(2)
                qty = data.Rows(i)(3)
                unt = data.Rows(i)(4)
                tamt = data.Rows(i)(5)
                cat = data.Rows(i)(6)
                branch = connn.sql_dataItemget("name", "source_branch", data.Rows(i)(8))

                transsts.Rows.Add(id, stsid, prod, qty, unt, tamt, cat, branch)
            Next
        End If

        crvb_load()
        crvp_load()
        crvc_load()
        crvpp_load()
    End Sub
    Sub crvb_load()
        Dim filelocation As String = "report\creport_mr_graph_branch.rpt"
        Dim CR As New ReportDocument
        CR.Load(filelocation)
        crv_branch.ReportSource = CR
        CR.SetDataSource(transsts)

        Dim txtbox As TextObject = CR.ReportDefinition.ReportObjects.Item("Text2")
        txtbox.Text = "From " & DateTimePicker1.Value.ToLongDateString & " to " & DateTimePicker2.Value.ToLongDateString
        crv_branch.RefreshReport()
        crv_branch.Zoom(1)
    End Sub
    Sub crvp_load()
        Dim filelocation As String = "report\creport_mr_graph_product.rpt"
        Dim CR As New ReportDocument
        CR.Load(filelocation)
        crv_product.ReportSource = CR
        CR.SetDataSource(transsts)
        Dim txtbox As TextObject = CR.ReportDefinition.ReportObjects.Item("Text2")
        txtbox.Text = "From " & DateTimePicker1.Value.ToLongDateString & " to " & DateTimePicker2.Value.ToLongDateString
        crv_product.RefreshReport()
        crv_product.Zoom(2)
    End Sub
    Sub crvc_load()
        Dim filelocation As String = "report\creports_mr.rpt"
        Dim CR As New ReportDocument
        CR.Load(filelocation)
        crv_content.ReportSource = CR
        CR.SetDataSource(transsts)
        Dim txtbox As TextObject = CR.ReportDefinition.ReportObjects.Item("Text2")
        txtbox.Text = "From " & DateTimePicker1.Value.ToLongDateString & " to " & DateTimePicker2.Value.ToLongDateString
        crv_content.RefreshReport()
        crv_content.Zoom(1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If transsts.Rows.Count > 0 Then
            Dim cr As ReportDocument
            cr = crv_pp.ReportSource
            Dim save As New SaveFileDialog
            save.Filter = "Excel Files|*.xls"
            save.Title = "Export Report to Excel"
            If save.ShowDialog() = DialogResult.OK Then

                If Not save.FileName = "" Then
                    Dim CrExportOptions As ExportOptions
                    Dim CrDiskFileDestinationOptions As DiskFileDestinationOptions = New DiskFileDestinationOptions()
                    Dim CrFormatTypeOptions As PdfRtfWordFormatOptions = New PdfRtfWordFormatOptions()
                    connn.msgboxc(save.FileName, 1)
                    CrDiskFileDestinationOptions.DiskFileName = save.FileName
                    CrExportOptions = cr.ExportOptions

                    CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile
                    CrExportOptions.ExportFormatType = ExportFormatType.ExcelWorkbook
                    CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions
                    CrExportOptions.FormatOptions = CrFormatTypeOptions

                    cr.Export()

                    If connn.msgboxc("Do you want to open your file?", 3) Then
                        Try
                            Process.Start(save.FileName)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
                Else
                    connn.msgboxc("File Not Save", 2)
                End If
            End If
        Else
            connn.msgboxc("No data to export", 2)
        End If
    End Sub

    Sub crvpp_load()
        Dim filelocation As String = "report\creport_mr_prod.rpt"
        Dim CR As New ReportDocument
        CR.Load(filelocation)
        crv_pp.ReportSource = CR
        CR.SetDataSource(transsts)
        Dim txtbox As TextObject = CR.ReportDefinition.ReportObjects.Item("Text2")
        txtbox.Text = "From " & DateTimePicker1.Value.ToLongDateString & " to " & DateTimePicker2.Value.ToLongDateString
        crv_pp.RefreshReport()
        crv_pp.Zoom(2)
    End Sub
End Class
