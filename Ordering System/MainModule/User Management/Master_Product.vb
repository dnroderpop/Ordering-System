Public Class Master_Product
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sqlstring = "Select * from trans_sts where stsid like '%" & TextBox1.Text & "%'"
        Dim d As DataSet = connn.sql_customSQLCOMMAND_select(sqlstring, New DataSet, "sts")

        Try

            table_q.DataSource = d.Tables("sts")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If InputBox("Are you sure?") = "mangtinapay" Then
            connn.sql_customSQLCOMMAND("delete from trans_sts where stsid like '%" & TextBox1.Text & "%'")
            connn.msgboxc("successs", 1)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sqlstring = "select * from trans_order where branch = " & NumericUpDown1.Value & " and date = '" & connn.datetoquery(DateTimePicker1.Value) & "'"
        Dim d As DataSet = connn.sql_customSQLCOMMAND_select(sqlstring, New DataSet, "order")

        Try

            table_order.DataSource = d.Tables("order")
        Catch ex As Exception

        End Try
    End Sub
    Dim selectedid As String
    Private Sub table_order_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles table_order.CellClick
        Dim i As Integer
        Try
            i = table_order.CurrentRow.Index
            table_order.CurrentRow.Selected = True
            If (i >= 0) Then
                Selectedid = table_order.Item(0, i).Value
                order_1.Text = connn.sql_dataItemget("name", "source_product", table_order.Item(2, i).Value)
            Else
                order_1.Text = ""
            End If
        Catch ex As Exception
            order_1.Text = ""
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If InputBox("Are you sure?") = "mangtinapay" Then
            Dim sql As String = "update trans_order set qty = " & Order_2.Value & " where id = " & selectedid
            connn.sql_customSQLCOMMAND(sql)
            connn.msgboxc("Done", 1)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If InputBox("Are you sure?") = "mangtinapay" Then
            Dim sql As String = "delete from trans_order where id = " & selectedid
            connn.sql_customSQLCOMMAND(sql)
            connn.msgboxc("Done", 1)
        End If
    End Sub
End Class