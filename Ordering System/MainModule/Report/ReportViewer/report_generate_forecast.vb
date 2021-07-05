Imports CrystalDecisions.CrystalReports.Engine

Public Class report_generate_forecast
    Dim data, data2, data3 As DataTable
    Dim branch As String
    Dim user As Integer = 0
    Private Sub report_generate_forecast_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user = 0
        loadtab()
    End Sub

    Sub loadtab()
        connn.sql_customSQLCOMMAND("TRUNCATE `mangtinapay`.`forecast_details`")
        data = connn.sql_customSQLCOMMAND_select("select * from forecast_details")
        If data.Rows.Count = 0 Then
            user = 1
            branch = Mainmenu.Reporting_forecast1.ComboBox1.Text
            Dim branchid As Integer
            Try
                branchid = Integer.Parse(connn.sql_dataItemget("id", "source_branch", "id and name = '" & branch & "'"))
            Catch ex As Exception
                branchid = 0
            End Try

            Dim stsid As String = connn.stsnum(branchid, connn.datetoquery(Mainmenu.Reporting_forecast1.DateTimePicker1.Value.AddDays(1).ToShortDateString), "First Delivery")

            If branch = "All" Then
                data = connn.sql_customSQLCOMMAND_select("Select prod,sum(qty) from trans_order where date = '" & connn.datetoquery(Mainmenu.Reporting_forecast1.DateTimePicker1.Value.ToShortDateString) & "' group by prod order by prod asc")
                stsid = Mainmenu.Reporting_forecast1.DateTimePicker1.Value.AddDays(1).Year & Integer.Parse(Mainmenu.Reporting_forecast1.DateTimePicker1.Value.AddDays(1).Month).ToString("D2") & Integer.Parse(Mainmenu.Reporting_forecast1.DateTimePicker1.Value.AddDays(1).Day).ToString("D2") & "-01"
                data2 = connn.sql_customSQLCOMMAND_select("Select prod,sum(qty) from trans_sts where time = 'First Delivery' and stsid like '%" & stsid & "%' group by prod ORDER BY prod ASC")
                stsid = Mainmenu.Reporting_forecast1.DateTimePicker1.Value.AddDays(1).Year & Integer.Parse(Mainmenu.Reporting_forecast1.DateTimePicker1.Value.AddDays(1).Month).ToString("D2") & Integer.Parse(Mainmenu.Reporting_forecast1.DateTimePicker1.Value.AddDays(1).Day).ToString("D2") & "-02"
                data3 = connn.sql_customSQLCOMMAND_select("Select prod,sum(qty) from trans_sts where time = 'First Delivery' and stsid like '%" & stsid & "%' group by prod ORDER BY prod ASC")
            Else

                data = connn.sql_customSQLCOMMAND_select("Select prod,sum(qty)  from trans_order where branch = " & branchid & " and date = '" & connn.datetoquery(Mainmenu.Reporting_forecast1.DateTimePicker1.Value.ToShortDateString) & "' group by prod ORDER BY prod ASC")
                data2 = connn.sql_customSQLCOMMAND_select("Select prod,sum(qty)  from trans_sts where branch = " & branchid & " and stsid = '" & stsid & "' group by prod ORDER BY prod ASC")
                stsid = connn.stsnum(branchid, connn.datetoquery(Mainmenu.Reporting_forecast1.DateTimePicker1.Value.AddDays(1).ToShortDateString), "Second Delivery")
                data3 = connn.sql_customSQLCOMMAND_select("Select prod,sum(qty)  from trans_sts where branch = " & branchid & " and stsid = '" & stsid & "' group by prod ORDER BY prod ASC")
            End If
            Dim d, s As String
            s = ""
            For i As Integer = 0 To data.Rows.Count - 1

                d = connn.sql_dataItemget("name", "source_product", data.Rows(i)(0).ToString)
                s = data.Rows(i)(1).ToString
                connn.sql_customSQLCOMMAND("INSERT INTO `forecast_details`(`product`, `total`) VALUES ('" & d & "'," & s & ")")
            Next


            For i As Integer = 0 To data2.Rows.Count - 1
                Dim name, actual, second, remarks As String
                name = data2.Rows(i)(0)
                actual = data2.Rows(i)(1)
                Dim table As DataTable = connn.sql_customSQLCOMMAND_select("select * from forecast_details where product like '" & name & "'")
                If table.Rows.Count = 0 Then
                    Dim err As Boolean = True
                    While err = True
                        table = connn.sql_customSQLCOMMAND_select("select * from source_product where name like '%" & name & "%'")
                        If Not table.Rows.Count = 0 Then
                            remarks = "No STS"
                            connn.sql_customSQLCOMMAND("INSERT INTO `forecast_details`(`product`, `total`) VALUES ('" & name & "',0)")
                            table = connn.sql_customSQLCOMMAND_select("select * from forecast_details where product like '" & name & "'")
                            err = False
                        Else
                            Dim tname = InputBox("We detected A changed of Name of " & name & " before it was committed, Please Input the Name of Product Registered", "MT")
                            table = connn.sql_customSQLCOMMAND_select("select * from forecast_details where product like '%" & tname & "%'")
                            If table.Rows.Count = 0 Then
                                connn.msgboxc("Error Finding the name of product " & tname, 2)
                            ElseIf table.Rows.Count > 1 Then
                                connn.msgboxc("Whoops! Theres too many product are much alike from your input. Please elaborate more", 2)
                            Else
                                err = False
                                table = connn.sql_customSQLCOMMAND_select("select * from forecast_details where product like '" & tname & "'")
                            End If
                        End If

                    End While
                End If
                second = 0
                For x As Integer = 0 To data3.Rows.Count - 1
                    Dim tname As String = ""
                    Dim table2 As DataTable

                    If data3.Rows(x)(0) = name Then
                        second = data3.Rows(x)(1)
                        x = data3.Rows.Count - 1
                    ElseIf x = data3.Rows.Count - 1 Then
                        table2 = connn.sql_customSQLCOMMAND_select("select * from forecast_details where product like '" & name & "'")


                        If table2.Rows.Count = 0 Then
                            Dim err As Boolean = True
                            While err = True
                                table2 = connn.sql_customSQLCOMMAND_select("select * from source_product where name like '%" & name & "%'")
                                If Not table2.Rows.Count = 0 Then
                                    connn.sql_customSQLCOMMAND("INSERT INTO `forecast_details`(`product`, `total`) VALUES ('" & name & "',0)")
                                    remarks = "No STS"
                                    table2 = connn.sql_customSQLCOMMAND_select("select * from forecast_details where product like '" & name & "'")
                                    err = False
                                Else
                                    tname = InputBox("We detected A changed of Name of " & name & " before it was committed, Please Input the Name of Product Registered", "MT")
                                    table2 = connn.sql_customSQLCOMMAND_select("select * from forecast_details where product like '%" & tname & "%'")
                                    If table2.Rows.Count = 0 Then
                                        connn.msgboxc("Error Finding the name of product " & tname, 2)
                                    ElseIf table2.Rows.Count > 1 Then
                                        connn.msgboxc("Whoops! Theres too many product are much alike from your input. Please elaborate more", 2)
                                    Else
                                        err = False
                                        table2 = connn.sql_customSQLCOMMAND_select("select * from forecast_details where product like '" & tname & "'")
                                    End If
                                End If

                            End While
                        End If


                    End If

                Next

                Try

                    If Integer.Parse(second) + Integer.Parse(actual) = Integer.Parse(table.Rows(0)(2).ToString) Then
                        remarks = "Good"
                    Else
                        remarks = "Variance"
                    End If
                Catch ex As Exception
                    remarks = "Variance"
                End Try

                connn.sql_customSQLCOMMAND("Update forecast_details set Actual = " & Integer.Parse(actual) & ", Second_del = " & Integer.Parse(second) & ", Remarks = '" & remarks & "' Where id = " & table.Rows(0)(0))

            Next

            Dim datax As DataTable = connn.sql_customSQLCOMMAND_select("select * from forecast_details")
            connn.sql_customSQLCOMMAND("TRUNCATE `mangtinapay`.`forecast_details`")

            Dim filelocation As String = "report\creport_forecast.rpt"
            Dim CR As New ReportDocument
            CR.Load(filelocation)

            CrystalReportViewer1.ReportSource = CR
            CR.SetDataSource(datax)
            Dim text As TextObject = CR.ReportDefinition.ReportObjects.Item("t_branch")
            Dim dataforwelcome = connn.sql_dataItemget("nickname", "user_accounts", My.Settings.myuserid)
            Dim text2 As TextObject = CR.ReportDefinition.ReportObjects.Item("t_name")
            text2.Text = connn.sql_dataItemget("nickname", "user_accounts", My.Settings.myuserid)
            text.Text = "Forecast for " & Mainmenu.Reporting_forecast1.DateTimePicker1.Value.ToLongDateString & "    Branch: " & branch


            Dim crystalexport As New crystalexport
            crystalexport.crystalexport(CR, "sum", Mainmenu.Reporting_forecast1.DateTimePicker1.Value.ToLongDateString & " Branch " & branch)


            CrystalReportViewer1.RefreshReport()
        Else
            If MessageBox.Show("Looks like someone is still using the Forecast Report. Ask or Wait for him/her to finish up before you can access the report, Do you want to retry?", "MT", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                loadtab()
            Else
                Me.Dispose()
            End If
        End If
    End Sub

    Private Sub report_generate_forecast_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If user = 0 Then
        Else
            connn.sql_customSQLCOMMAND("TRUNCATE `mangtinapay`.`forecast_details`")
        End If
    End Sub
End Class