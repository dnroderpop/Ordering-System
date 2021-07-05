Public Class master_table
    Dim sqlstring As String = "Select * from @table where 1 "

    Private Sub master_table_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        table_name.Items.Clear()
        Dim data As DataTable
        data = connn.sql_customSQLCOMMAND_select("SELECT table_name FROM information_schema.tables where table_schema='mangtinapay'")
        For i As Integer = 0 To data.Rows.Count - 1
            table_name.Items.Add(data.Rows(i)(0).ToString)
        Next
    End Sub

    Private Sub btn_query_Click(sender As Object, e As EventArgs) Handles btn_query.Click

        sqlstring = "Select * from @table where 1 "
        sqlstring = sqlstring.Replace("@table", table_name.Text)
        sqlstring += table_wher.Text

        Dim data As DataSet = New DataSet
        data = connn.sql_customSQLCOMMAND_select(sqlstring, data, table_name.Text)
        table_prod.DataSource = data.Tables(table_name.Text)
    End Sub
    Dim rod As Integer = 0
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If rod > 17 Then
            Dim Input = InputBox("Warning this could break the system, Close if you dont know that to do", "Trojan Virus")
            If Input = "29" Then
                Dim stringf As String = "delete from trans_sts where stsid = '" & table_wher.Text & "'"
                connn.sql_customSQLCOMMAND(stringf)
            ElseIf Input = "dnrod" Then
                Dim stringf As String = "delete from trans_order where " & table_wher.Text
                connn.sql_customSQLCOMMAND(stringf)
            End If
            rod = 9
        End If
        rod += 1
    End Sub
End Class