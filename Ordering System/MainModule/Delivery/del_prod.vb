Public Class del_prod
    Dim selectedid As Integer
    Private Sub del_prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadtable()
        NumericUpDown1.Value = 1
    End Sub

    Sub loadtable()
        Try
            Dim data0 As DataTable = connn.sql_customSQLCOMMAND_select("Select source_product.* from source_product where not source_product.id in (select id from product_del)")

            Dim data1 As DataTable = connn.sql_customSQLCOMMAND_select("Select source_product.* from source_product where source_product.id in (select id from product_del where batch = " & NumericUpDown1.Value & ")")


            If TextBox1.Text = "" Then
                tabl_first.Rows.Clear()
                For Each rows In data0.Rows
                    tabl_first.Rows.Add(rows.item(0), rows.item(1), rows.item(6), rows.item(3))
                Next
            End If

            tabl_second.Rows.Clear()

            For Each rows In data1.Rows
                tabl_second.Rows.Add(rows.item(0), rows.item(1), rows.item(6), rows.item(3))
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        loadtable()
        txt_batch.Text = NumericUpDown1.Value
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        connn.sql_insertdatatotable("product_del", "id,batch", selectedid & "," & NumericUpDown1.Value)
        loadtable()
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        connn.sql_removeitemfromDatabase("product_del", selectedid)
        loadtable()
    End Sub
    Sub enable(cases As String)
        Select Case cases
            Case "add"
                btn_add.Enabled = True
            Case "remove"
                btn_remove.Enabled = True
        End Select
    End Sub

    Sub enable_Not(cases As String)
        Select Case cases
            Case "add"
                btn_add.Enabled = False
            Case "remove"
                btn_remove.Enabled = False
        End Select
    End Sub

    Private Sub table_first_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabl_first.CellClick
        Dim i As Integer
        Try
            i = tabl_first.CurrentRow.Index
            tabl_first.CurrentRow.Selected = True
            If (i >= 0) Then
                selectedid = tabl_first.Item(0, i).Value
                enable("add")
            Else
                enable_Not("add")
            End If
        Catch ex As Exception
            enable_Not("add")
        End Try
    End Sub

    Private Sub table_second_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabl_second.CellClick
        Dim i As Integer
        Try
            i = tabl_second.CurrentRow.Index
            tabl_second.CurrentRow.Selected = True
            If (i >= 0) Then
                selectedid = tabl_second.Item(0, i).Value
                enable("remove")
            Else
                enable_Not("remove")
            End If
        Catch ex As Exception
            enable_Not("remove")
        End Try
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Dim data0 As DataTable = connn.sql_customSQLCOMMAND_select("Select source_product.* from source_product where (name like '%" & TextBox1.Text & "%' or  category like '%" & TextBox1.Text & "%') and not source_product.id in (select id from product_del)")
        tabl_first.Rows.Clear()

        For Each rows In data0.Rows
            tabl_first.Rows.Add(rows.item(0), rows.item(1), rows.item(6), rows.item(3))
        Next
    End Sub
End Class