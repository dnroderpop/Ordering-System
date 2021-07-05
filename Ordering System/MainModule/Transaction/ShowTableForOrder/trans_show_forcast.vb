
Public Class trans_show_forcast
    Public qdate As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If BackgroundWorker1.IsBusy Then
            connn.msgboxc("Please wait for your table to load", 1)
        Else
            qdate = connn.datetoquery(DateTimePicker1.Value)
            loadtable()
        End If
    End Sub

    Sub loadtable()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub trans_show_forcast_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadtable()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        qdate = connn.datetoquery(DateTimePicker1.Value)
        BackgroundWorker1.ReportProgress(0)
        Dim data As DataTable = New DataTable
        Dim data2 As DataTable = New DataTable
        Dim sqlstring_branchs As String = "select * from source_branch where able = 1"
        Dim sqlstring_tempforecast As String = "select * from temp_forecast"
        Dim sqlstring_getproducts As String = "select source_product.name, source_product.id from source_product where id in (SELECT prod FROM `trans_order` WHERE date = '" & qdate & "' GROUP by prod)"
        Dim drop As String = "drop "
        ''drop column
        BackgroundWorker1.ReportProgress(5)
        'check
        data = connn.sql_customSQLCOMMAND_select(sqlstring_tempforecast)
        If data.Columns.Count > 1 Then
            connn.sql_customSQLCOMMAND("DROP TABLE `mangtinapay`.`temp_forecast`")
            connn.sql_customSQLCOMMAND("CREATE TABLE `mangtinapay`.`temp_forecast` ( `prod` VARCHAR(255) NOT NULL , PRIMARY KEY (`prod`)) ENGINE = InnoDB;")
        End If
        BackgroundWorker1.ReportProgress(30)
        ''''''make the table
        data = connn.sql_customSQLCOMMAND_select(sqlstring_branchs)
        For i As Integer = 0 To data.Rows.Count - 1
            connn.sql_customSQLCOMMAND("alter table `temp_forecast` add `" & data.Rows(i)(1) & "` INT not null")
        Next
        connn.sql_customSQLCOMMAND("alter table `temp_forecast` add `Total Batch per Yielding` varchar(255) not null")
        ''''''''fill table
        BackgroundWorker1.ReportProgress(50)
        data = connn.sql_customSQLCOMMAND_select(sqlstring_getproducts)
        data2 = connn.sql_customSQLCOMMAND_select(sqlstring_branchs)
        For i As Integer = 0 To data.Rows.Count - 1
            connn.sql_customSQLCOMMAND("INSERT INTO `temp_forecast`(`prod`) VALUES ('" & data.Rows(i)(0) & "')")
            For j As Integer = 0 To data2.Rows.Count - 1
                Dim vald As String = connn.sql_dataItemget("COALESCE(sum(qty),0)", "trans_order", "id and date = '" & qdate & "' and branch = " & data2.Rows(j)(0) & " and prod = " & data.Rows(i)(1) & " group by prod")
                If vald = "" Then
                    vald = "0"
                End If
                If connn.sql_customSQLCOMMAND("update temp_forecast set `" & data2.Rows(j)(1) & "` = " & vald & "  where prod like '" & data.Rows(i)(0) & "'") Then

                End If
            Next
        Next
        BackgroundWorker1.ReportProgress(90)
        '''''load table
        BackgroundWorker1.ReportProgress(100)
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        If e.ProgressPercentage = 90 Then

            Dim dat As DataSet = New DataSet
            dat = connn.sql_customSQLCOMMAND_select("select * from temp_forecast", dat, "dat")
            '
            Try
                table_q.DataSource = New DataTable
                table_q.Rows.Clear()
            Catch ex As Exception
            End Try

            For row As Integer = 0 To dat.Tables("dat").Rows.Count - 1
                Dim total As Double = 0
                For i As Integer = 1 To dat.Tables("dat").Columns.Count - 2
                    total = total + Double.Parse(dat.Tables("dat").Rows(row)(i))
                Next
                dat.Tables("dat").Rows(row)(dat.Tables("dat").Columns.Count - 1) = total & " / " & Double.Parse(connn.sql_dataItemget("yielding", "source_product", "id and name = '" & dat.Tables("dat").Rows(row)(0) & "'")) & " = " & (total / Double.Parse(connn.sql_dataItemget("yielding", "source_product", "id and name = '" & dat.Tables("dat").Rows(row)(0) & "'")))
            Next

            table_q.DataSource = dat.Tables("dat")
            table_q.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

            ProgressBar1.Visible = False
        ElseIf e.ProgressPercentage = 0 Then
            ProgressBar1.Visible = True
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

    End Sub

    Private Sub trans_show_forcast_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private bitmap As Bitmap
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim data As New dataset_delivery
        Dim d As DataTable = data.DataTable2
        For Each rows In table_q.Rows
            d.Rows.Add(rows.Cells(0).value, rows.Cells(1).value, rows.Cells(2).value, rows.Cells(3).value, rows.Cells(4).value, rows.Cells(5).value, rows.Cells(6).value, rows.Cells(7).value, rows.Cells(8).value, rows.Cells(9).value, rows.Cells(10).value, rows.Cells(11).value, rows.Cells(12).value, rows.Cells(13).value, "", rows.Cells(14).value)
        Next

        Dim report As New report_generate_check
        report.data = d
        report.dat = DateTimePicker1.Value.ToLongDateString
        report.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        PrintDocument1.DefaultPageSettings.Landscape = True
        e.PageSettings.Landscape = True
        Dim drawFont As Font = New Font("Arial", 16)
        Dim drawbrush As SolidBrush = New SolidBrush(Color.Black)
        e.Graphics.DrawString("Forecast for " & DateTimePicker1.Value.ToLongDateString, drawFont, drawbrush, New Point(30, 10))
        e.Graphics.DrawImage(bitmap, 30, 50)
        Dim recPrint As RectangleF = e.PageSettings.PrintableArea
        If Me.table_q.Height - recPrint.Height > 0 Then e.HasMorePages = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        Me.Close()

    End Sub
End Class