Public Class adjust_lestover
    Dim func As functions_adjustment = New functions_adjustment
    Private Sub adjust_lestover_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        var_pname.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        var_pname.AutoCompleteSource = AutoCompleteSource.ListItems

        loadall()
    End Sub
    Sub loadall()
        var_branch.Items.Clear()
        Dim data As DataTable = connn.sql_customSQLCOMMAND_select("select * from source_branch where able = 1")
        For i As Integer = 0 To data.Rows.Count - 1

            var_branch.Items.Add(data.Rows(i)(1))

        Next

        var_pname.Items.Clear()
        Dim data2 As DataTable = connn.sql_customSQLCOMMAND_select("select * from source_product")
        For i As Integer = 0 To data2.Rows.Count - 1

            var_pname.Items.Add(data2.Rows(i)(1))

        Next

    End Sub

    Private Sub btn_accepts_Click(sender As Object, e As EventArgs) Handles btn_accepts.Click
        If connn.msgboxc("Are you sure you want to adjust Transactions and stock?", 3) And Not var_reason.Text.Trim = "" Then
            Dim branchid As Integer = connn.sql_dataItemget("id", "source_branch", "id and name like '%" & var_branch.Text & "%'")
            Dim result As Integer = func.checkForItemsInGivenDetails(var_firstdel.Checked, var_ispahabol.Checked, var_doeshavests.Checked, var_date.Value, branchid, var_pid.Value, var_batch.Value)

            Select Case result
                Case 1 ' no result
                    connn.msgboxc("You're inputs didn't correspond to any data at the database", 2)
                Case 2 ' both are available
                    func.removefromorder(var_ispahabol.Checked, var_pid.Value, var_qty.Value, branchid, var_date.Value, "less over", var_reason.Text)
                    func.removefromsts(var_firstdel.Checked, var_ispahabol.Checked, var_pid.Value, var_qty.Value, branchid, var_date.Value, "less over", var_reason.Text, var_batch.Value)
                Case 3 ' only STS is available
                    func.removefromsts(var_firstdel.Checked, var_ispahabol.Checked, var_pid.Value, var_qty.Value, branchid, var_date.Value, "less over", var_reason.Text, var_batch.Value)
                Case 4 ' only the forecast is available
                    func.removefromorder(var_ispahabol.Checked, var_pid.Value, var_qty.Value, branchid, var_date.Value, "less over", var_reason.Text)
            End Select
        ElseIf var_reason.Text.Trim = "" Then
            connn.msgboxc("Please state a Reason for the adjustment", 2)
        End If
    End Sub

    Private Sub var_ispahabol_CheckedChanged(sender As Object, e As EventArgs) Handles var_ispahabol.CheckedChanged
        If var_ispahabol.Checked = False Then
            var_batch.Visible = False
            Label8.Visible = False
            var_firstdel.Visible = True
        Else
            var_firstdel.Visible = False
            Label8.Visible = True
            var_batch.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim clause As String = ""
        Dim message As String = "Do mean this specific data?" & vbCrLf & vbCrLf
        Dim branchid As Integer = connn.sql_dataItemget("id", "source_branch", "id and name like '%" & var_branch.Text & "%'")
        Dim result As Integer = func.checkForItemsInGivenDetails(var_firstdel.Checked, var_ispahabol.Checked, var_doeshavests.Checked, var_date.Value, branchid, var_pid.Value, var_batch.Value)
        Dim table As String = "trans_order"
        Dim stsdel = "pa"
        If var_firstdel.Checked And var_ispahabol.Checked = False Then

            stsdel = "01"

        ElseIf var_firstdel.Checked = False And var_ispahabol.Checked = False Then

            stsdel = "Second Delivery"

        End If
        Dim curdates As Date = var_date.Value
        If stsdel = "pa" Then
            clause = " and batch = " & var_batch.Value
            curdates = var_date.Value
        Else
            clause = ""
            curdates = DateAdd(DateInterval.Day, 1, var_date.Value)
        End If
        Dim stsid As String = connn.stsnum(branchid, curdates, stsdel)
        Dim product As String = connn.sql_dataItemget("name", "source_product", var_pid.Value)

        If var_ispahabol.Checked Then

            table = "trans_pahabol_on"

        End If

        If result = 2 Then
            Dim data As DataTable = connn.sql_customSQLCOMMAND_select("SELECT `branch`, `prod`, `qty`, `date` FROM `" & table & "` where date = '" & connn.datetoquery(var_date.Value) & "' and branch = " & branchid & " and prod = " & var_pid.Value)
            message += table & vbCrLf
            For j As Integer = 0 To data.Rows.Count - 1
                message += " █ " & connn.sql_dataItemget("name", "source_branch", data.Rows(j)(0)) & " █ " & connn.sql_dataItemget("name", "source_product", data.Rows(j)(1)) & " █ " & data.Rows(j)(2) & " █ " & data.Rows(j)(3) & vbCrLf
            Next
            var_qty.Value = data.Rows(0)(2)
            message += vbCrLf & "STS" & vbCrLf
            Dim data2 As DataTable = connn.sql_customSQLCOMMAND_select("SELECT `stsid`,`branch`, `prod`, `qty`, `unt`, `tamt` FROM `trans_sts` where stsid = '" & stsid & "' and prod like '" & var_pname.Text & "' " & clause & " limit 1")
            message += " █ " & data2.Rows(0)(0) & " █ " & connn.sql_dataItemget("name", "source_branch", data2.Rows(0)(1)) & " █ " & data2.Rows(0)(2) & " █ pcs = " & data2.Rows(0)(3) & " █ unt = " & data2.Rows(0)(4) & " █ total = " & data2.Rows(0)(5)
        ElseIf result = 3 Then
            message += "STS" & vbCrLf
            Dim data2 As DataTable = connn.sql_customSQLCOMMAND_select("SELECT `stsid`,`branch`, `prod`, `qty`, `unt`, `tamt` FROM `trans_sts` where stsid = '" & stsid & "' and prod like '" & var_pname.Text & "'  " & clause & " limit 1")
            message += " █ " & data2.Rows(0)(0) & " █ " & connn.sql_dataItemget("name", "source_branch", data2.Rows(0)(1)) & " █ " & data2.Rows(0)(2) & " █ pcs = " & data2.Rows(0)(3) & " █ unt = " & data2.Rows(0)(4) & " █ total = " & data2.Rows(0)(5)
            var_qty.Value = data2.Rows(0)(3)
        ElseIf result = 4 Then
            Dim data As DataTable = connn.sql_customSQLCOMMAND_select("SELECT `branch`, `prod`, `qty`, `date` FROM `" & table & "` where date = '" & connn.datetoquery(var_date.Value) & "' and branch = " & branchid & " and prod = " & var_pid.Value)
            message += table & vbCrLf
            For j As Integer = 0 To data.Rows.Count - 1
                message += " █ " & connn.sql_dataItemget("name", "source_branch", data.Rows(j)(0)) & " █ " & connn.sql_dataItemget("name", "source_product", data.Rows(j)(1)) & " █ " & data.Rows(j)(2) & " █ " & data.Rows(j)(3) & vbCrLf
            Next
            var_qty.Value = data.Rows(0)(2)
        Else
            message += "NO DATA FOUND"
        End If
        connn.msgboxc(message, 1)
    End Sub

    Private Sub var_pname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles var_pname.SelectedIndexChanged
        var_pid.Value = Integer.Parse(connn.sql_dataItemget("id", "source_product", "id and name like '" & var_pname.Text & "'"))
    End Sub

    Private Sub var_pid_ValueChanged(sender As Object, e As EventArgs) Handles var_pid.ValueChanged
        var_pname.Text = connn.sql_dataItemget("name", "source_product", var_pid.Value)
    End Sub
End Class