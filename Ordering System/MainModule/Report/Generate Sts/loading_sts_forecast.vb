Imports System.ComponentModel

Public Class loading_sts_forecast
    Dim qdate As Date
    Dim progress, last As Integer
    Private Sub loading_sts_forecast_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        progress = 0
        last = 0
        qdate = Mainmenu.Reporting_forecast1.DateTimePicker1.Value
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        progress = 0
        last = 0
        BackgroundWorker1.ReportProgress(0)
        Dim data As DataTable = New DataTable
        Dim data2 As DataTable = New DataTable
        Dim stsid = qdate.Year & Integer.Parse(qdate.Month).ToString("D2") & Integer.Parse(qdate.Day).ToString("D2")
        Dim sqlstring_branchs As String = "select * from source_branch where able = 1"
        Dim sqlstring_tempforecast As String = "select * from report_forecast_sts"
        Dim sqlstring_getproducts As String = "select source_product.name, source_product.id from source_product where name in (SELECT prod FROM `trans_sts` WHERE stsid like '%" & stsid & "%' GROUP by prod)"
        Dim drop As String = "drop "
        ''drop column
        'check
        connn.sql_customSQLCOMMAND("TRUNCATE `mangtinapay`.`report_forecast_sts`")
        data = connn.sql_customSQLCOMMAND_select(sqlstring_getproducts)
        data2 = connn.sql_customSQLCOMMAND_select(sqlstring_branchs)
        last = data2.Rows.Count + data.Rows.Count
        For i As Integer = 0 To data.Rows.Count - 1
            connn.sql_customSQLCOMMAND("INSERT INTO `report_forecast_sts`(`prod`) VALUES ('" & data.Rows(i)(0) & "')")

            For j As Integer = 0 To data2.Rows.Count - 1
                Dim vald As String = connn.sql_dataItemget("COALESCE(sum(qty),0)", "trans_sts", "id and stsid like '%" & stsid & "%' and branch = " & data2.Rows(j)(0) & " and prod = '" & data.Rows(i)(0) & "'")
                If vald = "" Then
                    vald = "0"
                End If
                If connn.sql_customSQLCOMMAND("update report_forecast_sts set `" & data2.Rows(j)(1) & "` = " & vald & "  where prod like '" & data.Rows(i)(0) & "'") Then

                End If
                progress += 1
                BackgroundWorker1.ReportProgress((progress / last) * 100)
            Next

            connn.sql_customSQLCOMMAND("update report_forecast_sts set category = '" & connn.sql_dataItemget("category", "source_product", " id and name like '" & data.Rows(i)(0) & "'") & "' where  prod like '" & data.Rows(i)(0) & "'")
            progress += 1
            BackgroundWorker1.ReportProgress((progress / last) * 100)

        Next
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Try
            ProgressBar1.Value = e.ProgressPercentage
        Catch ex As Exception
            Dim i As String = last.tostring
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        report_generate_check.ShowDialog()
    End Sub

    Private Sub Loading_sts_forecast_Close(sender As Object, e As CancelEventArgs) Handles Me.Closed
        If BackgroundWorker1.IsBusy Then
        Else
            BackgroundWorker1.CancelAsync()
        End If

    End Sub
End Class