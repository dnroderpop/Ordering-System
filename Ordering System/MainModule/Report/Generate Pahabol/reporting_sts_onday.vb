Public Class reporting_sts_onday
    Dim sts_date As String
    Dim branch, branchid As String
    Dim time, qdate As String
    Dim stsid As String = ""
    Dim batch As Integer = 0
    Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click
        branch = cb_branch.Text
        sts_date = connn.datetoquery(dtp_date.Value)
        branchid = connn.sql_dataItemget("id", "source_branch", "id and name = '" & cb_branch.Text & "'")
        stsid = connn.stsnum(branchid, dtp_date.Value, "pa")
        loadpahabol()
        Dim sont As Integer = 0
        Try
            sont = Integer.Parse(connn.sql_dataItemget("batch", "trans_sts", "id and stsid like '%" & connn.stsnum(cb_branch.SelectedIndex + 1, dtp_date.Value, "pa") & "%' group by batch desc"))
            If connn.msgboxc("Do you want to switch to the new PAHABOL? The Latest Number is " & sont, 3) Then
                NumericUpDown1.Value = Integer.Parse(sont)
            End If
        Catch ex As Exception
        End Try

        Dim act As Boolean = False
        Dim act2 As Boolean = False
        Do While act = False
            If Not connn.sql_customSQLCOMMAND_select("select * from report_sts_pa").Rows.Count = 0 Then
                If connn.msgboxc("Someone is still generating a report, want to wait and retry?", 4) Then
                    act = False
                Else
                    act = True
                End If
            Else
                act = True
                act2 = True
            End If
        Loop
        If act2 = True Then
            Dim data As DataTable = connn.sql_customSQLCOMMAND_select("SELECT * FROM `trans_sts` WHERE `stsid` = '" & stsid & "' and batch = " & NumericUpDown1.Value)
            If connn.msgboxc("Do you want to open [" & stsid & "] batch " & NumericUpDown1.Value & "?", 3) And Not data.Rows.Count = 0 Then

                connn.sql_customSQLCOMMAND("TRUNCATE `mangtinapay`.`report_sts_pa`")


                ''query for display
                For i As Integer = 0 To data.Rows.Count - 1
                    Dim col As String = "`Product`, `Quantity`, `Unit_Price`, `Total_Amount`, `category`,`batch`"
                    Dim val As String = "'[value-1]',[value-2],[value-3],[value-4],'[value-5]','[value-6]'"
                    val = val.Replace("[value-1]", data.Rows(i)(2))
                    val = val.Replace("[value-2]", data.Rows(i)(3))
                    val = val.Replace("[value-3]", data.Rows(i)(4))
                    val = val.Replace("[value-4]", data.Rows(i)(5))
                    val = val.Replace("[value-5]", data.Rows(i)(6))
                    val = val.Replace("[value-6]", data.Rows(i)(10))
                    connn.sql_insertdatatotable("report_sts_pa", col, val)
                Next

                Dim report As report_generate_sts_pa = New report_generate_sts_pa
                Dim datta As DataTable = connn.sql_customSQLCOMMAND_select("select * from report_sts_pa")
                report.time = data.Rows(0)(7)
                report.qdate = dtp_date.Value.ToShortDateString
                report.sts = stsid
                report.branch = branch
                report.batch = NumericUpDown1.Value
                report.Data = datta
                connn.sql_customSQLCOMMAND("TRUNCATE `mangtinapay`.`report_sts_pa`")
                report.ShowDialog()
            ElseIf data.Rows.Count = 0 Then
                connn.msgboxc("No data as of this " & stsid, 2)

            End If
        End If
    End Sub

    Sub loadc()
        cb_branch.Items.Clear()
        Dim data As DataTable = connn.sql_selectdatafromtable("*", "source_branch", "Where able = 1")
        For i As Integer = 0 To data.Rows.Count - 1
            cb_branch.Items.Add(data.Rows(i)(1))
        Next
    End Sub

    Private Sub cb_branch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_branch.SelectedIndexChanged
        Try
            NumericUpDown1.Value = Integer.Parse(connn.sql_dataItemget("batch", "trans_sts", "id and stsid like '%" & connn.stsnum(cb_branch.SelectedIndex + 1, dtp_date.Value, "pa") & "%' group by batch desc"))
            batch = NumericUpDown1.Value + 1
        Catch ex As Exception
            NumericUpDown1.Value = 0
            batch = 0
        End Try

    End Sub

    Private Sub dtp_date_ValueChanged(sender As Object, e As EventArgs) Handles dtp_date.ValueChanged
        Try
            NumericUpDown1.Value = Integer.Parse(connn.sql_dataItemget("batch", "trans_sts", "id and stsid like '%" & connn.stsnum(cb_branch.SelectedIndex + 1, dtp_date.Value, "pa") & "%' group by batch desc"))
        Catch ex As Exception
            NumericUpDown1.Value = 0
            batch = 0
        End Try
    End Sub

    Private Sub reporting_sts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadc()
        cb_branch.SelectedIndex() = 0
        cb_branch.Text = cb_branch.SelectedText

    End Sub

    Sub loadpahabol()

        Dim data As DataTable = connn.sql_customSQLCOMMAND_select("SELECT `id`, `branch`, `prod`, sum(`qty`) FROM `trans_pahabol_on` where branch = " & branchid & " and date = '" & connn.datetoquery(dtp_date.Value) & "' and able = 0 group by prod")
        If connn.sql_customSQLCOMMAND_select("select * from trans_sts where stsid = '" & stsid & "'").Rows.Count > 0 Then
            Dim bool As Boolean = False
            batch = 0
            While bool = False
                If connn.sql_dataItemget("id", "trans_sts", "id and stsid = '" & stsid & "' and batch = " & batch) = "" Then
                    bool = True
                Else
                    batch += 1
                End If
            End While

        End If

        For i As Integer = 0 To data.Rows.Count - 1
            Dim prod, qty, unit, tamt, cat, time, branch As String
            prod = connn.sql_dataItemget("name", "source_product", data.Rows(i)(2))
            qty = data.Rows(i)(3)
            unit = connn.sql_dataItemget("srpc", "source_product", data.Rows(i)(2))
            tamt = Double.Parse(qty) * Double.Parse(unit)
            cat = connn.sql_dataItemget("category", "source_product", data.Rows(i)(2))
            time = "PAHABOL"
            branch = data.Rows(i)(1)
            connn.sql_customSQLCOMMAND("update trans_pahabol_on set able = 1 where id = " & data.Rows(i)(0))

            Dim val As String = "'[value-1]','[value-2]',[value-3],[value-4],[value-5],'[value-6]','[value-7]',[value-8],'" & connn.datetoquery(dtp_date.Value) & "'," & batch
            Dim col As String = "`stsid`, `prod`, `qty`, `unt`, `tamt`, `cat`, `time`, `branch`,`Date`,batch"
            val = val.Replace("[value-1]", stsid)
            val = val.Replace("[value-2]", prod)
            val = val.Replace("[value-3]", qty)
            val = val.Replace("[value-4]", unit)
            val = val.Replace("[value-5]", tamt)
            val = val.Replace("[value-6]", cat)
            val = val.Replace("[value-7]", time)
            val = val.Replace("[value-8]", branch)
            connn.sql_insertdatatotable("trans_sts", col, val)
        Next

    End Sub
End Class