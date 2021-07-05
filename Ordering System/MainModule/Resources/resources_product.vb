
Public Class resources_product
    Dim data As DataTable
    Dim id, names, cat, srpc, srpb, avew, yiel As String
    Dim selectedid As String

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        function_reset()
        loadtable()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        function_getitems()
        If names = "" Or cat = "" Or srpc = "0" Or srpb = "0" Or avew = "0" Or yiel = "0" Then
            MessageBox.Show("If possibly dont leave any blank items.")
        Else
            Dim values As String = "'[value-2]','[value-3]',[value-4],[value-5],[value-6],[value-7],1"
            values = values.Replace("[value-2]", names)
            values = values.Replace("[value-3]", cat)
            values = values.Replace("[value-4]", srpc)
            values = values.Replace("[value-5]", srpb)
            values = values.Replace("[value-6]", avew)
            values = values.Replace("[value-7]", yiel)

            If connn.sql_insertdatatotable("source_product", "`name`, `category`, `srpc`, `srpb`, `avew`, `yielding`,`able`", values) Then
                function_reset()
                loadtable()

                t_n.Select()
                connn.msgboxc("Success!", 1)
            End If
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        table_prod.ClearSelection()
        table_prod.Rows.Clear()
        data = connn.sql_selectdatafromtable("*", "source_product", "Where able = 1 and (id like '" & cb_search.Text & "' or  name like '%" & cb_search.Text & "%'  or  category like '%" & cb_search.Text & "%')")
        Try

            If Not data.Rows.Count = 0 Then

                Dim i As Integer = 0
                While i < data.Rows.Count
                    table_prod.Rows.Add({data.Rows(i)(0).ToString, data.Rows(i)(1).ToString, data.Rows(i)(2).ToString, data.Rows(i)(3).ToString, data.Rows(i)(4).ToString, data.Rows(i)(5).ToString, data.Rows(i)(6).ToString})
                    i += 1
                End While

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub t_y_KeyUp(sender As Object, e As KeyEventArgs) Handles t_y.KeyUp
        If e.KeyCode = Keys.Enter Then
            btn_add_Click(e, e)
        End If
    End Sub

    Private Sub t_aw_KeyUp(sender As Object, e As KeyEventArgs) Handles t_aw.KeyUp
        If e.KeyCode = Keys.Enter Then
            btn_add_Click(e, e)
        End If
    End Sub

    Private Sub t_srpb_KeyUp(sender As Object, e As KeyEventArgs) Handles t_srpb.KeyUp
        If e.KeyCode = Keys.Enter Then
            btn_add_Click(e, e)
        End If
    End Sub

    Private Sub t_srpc_KeyUp(sender As Object, e As KeyEventArgs) Handles t_srpc.KeyUp
        If e.KeyCode = Keys.Enter Then
            btn_add_Click(e, e)
        End If
    End Sub

    Private Sub t_n_KeyUp(sender As Object, e As KeyEventArgs) Handles t_n.KeyUp
        If e.KeyCode = Keys.Enter Then
            btn_add_Click(e, e)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        report_generate_products.ShowDialog()
    End Sub

    Private Sub cb_search_KeyUp(sender As Object, e As KeyEventArgs) Handles cb_search.KeyUp
        BtnSearch_Click(e, e)
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        function_getitems()

        If id = "" Or names = "" Or cat = "" Or srpc = "0" Or srpb = "0" Or avew = "0" Or yiel = "0" Then
            MessageBox.Show("If possibly dont leave any blank items.")
        Else
            Dim sqlstring As String = "UPDATE `source_product` SET `id`=[value-1],`name`='[value-2]',`category`='[value-3]',`srpc`=[value-4],`srpb`=[value-5],`avew`=[value-6],`yielding`=[value-7] where id = '" & selectedid & "'"
            sqlstring = sqlstring.Replace("[value-1]", id)
            sqlstring = sqlstring.Replace("[value-2]", names)
            sqlstring = sqlstring.Replace("[value-3]", cat)
            sqlstring = sqlstring.Replace("[value-4]", srpc)
            sqlstring = sqlstring.Replace("[value-5]", srpb)
            sqlstring = sqlstring.Replace("[value-6]", avew)
            sqlstring = sqlstring.Replace("[value-7]", yiel)
            t_id.Visible = True
            lid.Visible = True
            If connn.sql_customSQLCOMMAND(sqlstring) Then
                function_reset()
                loadtable()
                connn.msgboxc("Success!", 1)
            End If
        End If
    End Sub
    Sub function_getitems()
        id = t_id.Text
        names = t_n.Text
        cat = t_c.Text
        srpc = t_srpc.Value
        srpb = t_srpb.Value
        avew = t_aw.Value
        yiel = t_y.Value
    End Sub


    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If connn.msgboxc("Are you sure to delete [" & selectedid & "] ?", 3) Then
            If connn.sql_customSQLCOMMAND("update source_product set able = 0 where id = " & selectedid) Then
                function_reset()
                loadtable()
            End If
        End If
    End Sub


    Sub loadtable()
        table_prod.Rows.Clear()
        cb_search.Items.Clear()
        cb_search.Text = ""
        data = connn.sql_selectdatafromtable("*", "source_product", "where able = 1")
        Try

            If Not data.Rows.Count = 0 Then

                Dim i As Integer = 0
                While i < data.Rows.Count

                    table_prod.Rows.Add({data.Rows(i)(0).ToString, data.Rows(i)(1).ToString, data.Rows(i)(2).ToString, data.Rows(i)(3), data.Rows(i)(4), data.Rows(i)(5), data.Rows(i)(6)})
                    cb_search.Items.Add(data.Rows(i)(0).ToString)
                    cb_search.Items.Add(data.Rows(i)(1).ToString)
                    cb_search.Items.Add(data.Rows(i)(2).ToString)
                    i += 1
                End While

            End If
        Catch ex As Exception
        End Try
        function_reset()
    End Sub

    Sub function_reset()
        t_id.Visible = False
        lid.Visible = False
        t_id.Text = ""
        t_n.Text = ""
        t_c.SelectedIndex = -1
        t_c.ResetText()
        t_aw.Value = 0
        t_y.Value = 0
        t_srpb.Value = "0"
        t_srpc.Value = "0"
        Lmat.Text = "Selected Product"
        Ladd.Text = "Add a Product"
        Ladd.ForeColor = Color.ForestGreen

        btn_add.Visible = True
        btn_update.Visible = False
        btn_delete.Enabled = False
        table_prod.ClearSelection()

        id = ""
        names = ""
        cat = ""
        srpc = ""
        srpb = ""
        avew = ""
        yiel = ""
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
                t_id.Text = table_prod.Item(0, i).Value
                t_n.Text = table_prod.Item(1, i).Value
                t_c.Text = table_prod.Item(2, i).Value
                t_srpc.Text = table_prod.Item(3, i).Value
                t_srpb.Text = table_prod.Item(4, i).Value
                t_aw.Text = table_prod.Item(5, i).Value
                t_y.Text = table_prod.Item(6, i).Value
                Ladd.Text = "Change a Property"
                Ladd.ForeColor = Color.DarkSlateGray
                btn_delete.Enabled = True
                lid.Visible = True
                t_id.Visible = True
            Else
                table_prod.ClearSelection()
                table_prod.Rows.Clear()
            End If
        Catch ex As Exception
            table_prod.ClearSelection()
            table_prod.Rows.Clear()
        End Try
    End Sub
End Class
