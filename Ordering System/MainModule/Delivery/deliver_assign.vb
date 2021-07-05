
Public Class deliver_assign
    Public Dataset_delivery1 As dataset_delivery = New dataset_delivery
    Private Sub deliver_assign_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        loadcb()
    End Sub

    Sub loadcb()
        cb_branch.Items.Clear()
        Dim data As DataTable = connn.sql_selectdatafromtable("*", "source_branch", "Where able = 1")
        For i As Integer = 0 To data.Rows.Count - 1
            cb_branch.Items.Add(data.Rows(i)(1))
        Next
    End Sub

    Sub enable(cases As String)
        Select Case cases
            Case "add"
                btn_add.Enabled = True
            Case "print"
                btn_print.Enabled = True
            Case "remove"
                btn_remove.Enabled = True
        End Select
    End Sub
    Sub enable_Not(cases As String)
        Select Case cases
            Case "add"
                btn_add.Enabled = False
            Case "print"
                btn_print.Enabled = False
            Case "remove"
                btn_remove.Enabled = False
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If cb_branch.Text = "" Or cb_del.Text = "" Then
        Else
            NumericUpDown1.Value = 1
            loadtable()
        End If
    End Sub

    Sub loadtable()
        Dim stsid As String = connn.stsnum(connn.sql_dataItemget("id", "source_branch", "id and name = '" & cb_branch.Text & "'"), dtp_date.Value, cb_del.Text)

        Dim data As DataTable = connn.sql_customSQLCOMMAND_select("select * from trans_sts where stsid = '" & stsid & "'")

        Dim data0 As DataTable = connn.sql_customSQLCOMMAND_select("select * from trans_sts where batch = 0  AND stsid = '" & stsid & "'  ORDER BY `trans_sts`.`stsid` DESC")

        Dim data1 As DataTable = connn.sql_customSQLCOMMAND_select("select * from trans_sts where stsid = '" & stsid & "' and batch = " & NumericUpDown1.Value)
        table_first.Rows.Clear()

        For Each rows In data0.Rows
            table_first.Rows.Add(rows.item(0), rows.item(2), rows.item(3), rows.item(4), rows.item(5))
        Next
        table_second.Rows.Clear()

        For Each rows In data1.Rows
            table_second.Rows.Add(rows.item(0), rows.item(2), rows.item(3), rows.item(4), rows.item(5))
        Next

        enable("print")

        Dataset_delivery1.DataTable1.Rows.Clear()
        For Each rows In data.Rows
            Dataset_delivery1.DataTable1.Rows.Add(rows.item(0), rows.item(1), rows.item(2), rows.item(3), rows.item(4), rows.item(5), rows.item(6), rows.item(7), rows.item(8), rows.item(9), rows.item(10))
        Next


    End Sub
    Dim selectedid As Integer
    Private Sub table_first_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles table_first.CellClick
        Dim i As Integer
        Try
            i = table_first.CurrentRow.Index
            table_first.CurrentRow.Selected = True
            If (i >= 0) Then
                selectedid = table_first.Item(0, i).Value
                enable("add")
            Else
                enable_Not("add")
            End If
        Catch ex As Exception
            enable_Not("add")
        End Try
    End Sub

    Private Sub table_second_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles table_second.CellClick
        Dim i As Integer
        Try
            i = table_second.CurrentRow.Index
            table_second.CurrentRow.Selected = True
            If (i >= 0) Then
                selectedid = table_second.Item(0, i).Value
                enable("remove")
            Else
                enable_Not("remove")
            End If
        Catch ex As Exception
            enable_Not("remove")
        End Try
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If cb_branch.Text = "" Or cb_del.Text = "" Then
        Else
            loadtable()
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        connn.sql_changeValueRowtableByID("trans_sts", "Batch = " & NumericUpDown1.Value, selectedid)
        enable_Not("add")
        loadtable()
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        connn.sql_changeValueRowtableByID("trans_sts", "Batch = 0", selectedid)
        enable_Not("remove")
        loadtable()
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Dim report As print_delivery = New print_delivery
        report.sts = connn.stsnum(connn.sql_dataItemget("id", "source_branch", "id and name = '" & cb_branch.Text & "'"), dtp_date.Value, cb_del.Text)
        report.time = cb_del.Text
        report.branch = cb_branch.Text
        report.qdate = dtp_date.Value.ToLongDateString
        report.s = Dataset_delivery1.DataTable1
        report.ShowDialog()
    End Sub
End Class
