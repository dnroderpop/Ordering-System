Public Class resources_supplier
    Dim selectedid As Integer
    Dim names As String
    Dim data As DataTable


    Sub loadtable()
        table_prod.ClearSelection()
        table_prod.Rows.Clear()
        data = connn.sql_selectdatafromtable("*", "source_supplier", "where able = 1")
        Try

            If Not data.Rows.Count = 0 Then

                Dim i As Integer = 0
                While i < data.Rows.Count

                    table_prod.Rows.Add({data.Rows(i)(0).ToString, data.Rows(i)(1).ToString})

                    i += 1
                End While

            End If
        Catch ex As Exception
        End Try
        function_reset()
    End Sub

    Sub function_reset()
        Lmat.Text = "Selected Supplier"
        Ladd.Text = "Add a Supplier"
        Ladd.ForeColor = Color.ForestGreen
        t_n.Text = ""

        btn_add.Visible = True
        btn_update.Visible = False
        btn_delete.Enabled = False
        table_prod.ClearSelection()
    End Sub

    Private Sub table_prod_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles table_prod.CellClick
        Dim i As Integer
        Try
            function_reset()
            i = table_prod.CurrentRow.Index
            selectedid = table_prod.Item(0, i).Value
            table_prod.CurrentRow.Selected = True
            If (i >= 0) Then
                Lmat.Text = table_prod.Item(1, i).Value
                selectedid = table_prod.Item(0, i).Value
                btn_add.Visible = False
                btn_update.Visible = True
                t_n.Text = table_prod.Item(1, i).Value
                Ladd.Text = "Change a Property"
                Ladd.ForeColor = Color.DarkSlateGray
                btn_delete.Enabled = True
            Else
                table_prod.ClearSelection()
                table_prod.Rows.Clear()
            End If
        Catch ex As Exception
            table_prod.ClearSelection()
            table_prod.Rows.Clear()
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If connn.msgboxc("Are you sure to delete [" & selectedid & "] ?", 3) Then
            If connn.sql_customSQLCOMMAND("update source_supplier set able = 0 where id = " & selectedid) Then
                function_reset()
                loadtable()
            End If
        End If
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        function_reset()
        loadtable()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        names = t_n.Text

        If names = "" Then
            MessageBox.Show("If possibly dont leave any blank items.")
        Else
            Dim sqlstring As String = "UPDATE `source_supplier` SET `name`='[value-2]' where id = '" & selectedid & "'"
            sqlstring = sqlstring.Replace("[value-2]", names)
            If connn.sql_customSQLCOMMAND(sqlstring) Then
                function_reset()
                loadtable()
                connn.msgboxc("Success!", 1)
            End If
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        names = t_n.Text

        If names = "" Then
            MessageBox.Show("If possibly dont leave any blank items.")
        Else
            Dim values As String = "'[value-2]', 1"
            values = values.Replace("[value-2]", names)

            If connn.sql_insertdatatotable("source_supplier", "`name`,`able`", values) Then
                function_reset()
                loadtable()
                connn.msgboxc("Success!", 1)
            End If
        End If
    End Sub

    Private Sub resources_Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadtable()
    End Sub
End Class