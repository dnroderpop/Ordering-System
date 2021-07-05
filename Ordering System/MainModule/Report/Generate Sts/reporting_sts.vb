
Public Class reporting_sts
    Dim sts_date As String
    Dim branch As String
    Dim time, qdate As String
    Dim stsid As String
    Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click
        sts_date = connn.datetoquery(dtp_date.Value)
        branch = cb_branch.Text
        branchid = connn.sql_dataItemget("id", "source_branch", "id and name = '" & cb_branch.Text & "'")
        stsid = connn.stsnum(branchid, dtp_date.Value, cb_del.Text)
        Dim data As DataTable = connn.sql_customSQLCOMMAND_select("SELECT * FROM `trans_sts` WHERE `stsid` = '" & stsid & "'")
        If connn.msgboxc("Do you want to open [" & stsid & "] ?", 3) And Not data.Rows.Count = 0 Then
            Dim act As Boolean = False
            Dim act2 As Boolean = False
            Do While act = False
                If Not connn.sql_customSQLCOMMAND_select("select * from report_sts").Rows.Count = 0 Then
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

                connn.sql_customSQLCOMMAND("TRUNCATE `mangtinapay`.`report_sts`")

                ''query for display
                For i As Integer = 0 To data.Rows.Count - 1
                    Dim col As String = "`Product`, `Quantity`, `Unit_Price`, `Total_Amount`, `category`,`Batch`"
                    Dim val As String = "'[value-1]',[value-2],[value-3],[value-4],'[value-5]',[value-6]"
                    val = val.Replace("[value-1]", data.Rows(i)(2))
                    val = val.Replace("[value-2]", data.Rows(i)(3))
                    val = val.Replace("[value-3]", data.Rows(i)(4))
                    val = val.Replace("[value-4]", data.Rows(i)(5))
                    val = val.Replace("[value-5]", data.Rows(i)(6))
                    val = val.Replace("[value-6]", data.Rows(i)(10))
                    connn.sql_insertdatatotable("report_sts", col, val)
                Next

                Dim report As report_generate_sts = New report_generate_sts

                report.time = data.Rows(0)(7)
                report.qdate = dtp_date.Value.ToShortDateString
                report.sts = stsid
                report.branch = branch
                report.data = connn.sql_customSQLCOMMAND_select("select * from report_sts")
                connn.sql_customSQLCOMMAND("TRUNCATE `mangtinapay`.`report_sts`")

                report.ShowDialog()

                act = True
            End If


        ElseIf data.Rows.Count = 0 Then
            connn.msgboxc("There's no data as of this " & stsid, 2)
        End If
    End Sub



    Sub loadc()
        cb_branch.Items.Clear()
        Dim data As DataTable = connn.sql_selectdatafromtable("*", "source_branch", "Where able = 1")
        For i As Integer = 0 To data.Rows.Count - 1
            cb_branch.Items.Add(data.Rows(i)(1))
        Next
    End Sub


    Private Sub reporting_sts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadc()
        cb_branch.SelectedIndex() = 0
        cb_branch.Text = cb_branch.SelectedText
        cb_del.SelectedIndex() = 0
        cb_del.Text = cb_del.SelectedText
    End Sub

End Class