Public Class resources_recipe
    Dim selectedid_product, selectedid_rawmat, selectedid_recipe, selectedid_list As String
    Dim proid, uom, rawid, cat As String
    Dim q, bq, bc, rc As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If connn.msgboxc("Are you really sure to clear the table?", 3) Then
            table_list.Rows.Clear()
        End If
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim sqlstring = "SELECT * FROM source_product where able = 1 and (id like '%" & cb_search.Text _
                         & "%' or name like '%" & cb_search.Text & "%') and NOT EXISTS 
                         (SELECT source_recipe.prodid FROM source_recipe where source_product.ID 
                         = source_recipe.prodid)"
        Dim Data = connn.sql_customSQLCOMMAND_select(sqlstring)

        ''''''''''''start
        table_prod.ClearSelection()
        table_prod.Rows.Clear()
        Try

            If Not Data.Rows.Count = 0 Then

                Dim i As Integer = 0
                While i < Data.Rows.Count

                    table_prod.Rows.Add({Data.Rows(i)(0).ToString, Data.Rows(i)(1).ToString, Data.Rows(i)(2).ToString, Data.Rows(i)(3), Data.Rows(i)(4), Data.Rows(i)(5), Data.Rows(i)(6)})

                    i += 1
                End While

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_search2_Click(sender As Object, e As EventArgs) Handles btn_search2.Click
        sqlstring2 = "SELECT * FROM source_rawmat where able = 1 and id like '%" & cb_search2.Text & "%' or name like '%" & cb_search2.Text & "%' "
        Dim data2 = connn.sql_customSQLCOMMAND_select(sqlstring2)

        ''''''''''''start
        table_raw.ClearSelection()
        table_raw.Rows.Clear()
        Try

            If Not data2.Rows.Count = 0 Then

                Dim i As Integer = 0
                While i < data2.Rows.Count

                    table_raw.Rows.Add({data2.Rows(i)(0).ToString, data2.Rows(i)(1).ToString, data2.Rows(i)(2).ToString, data2.Rows(i)(3), data2.Rows(i)(4), data2.Rows(i)(5), data2.Rows(i)(6)})

                    i += 1
                End While

            End If
        Catch ex As Exception
        End Try
        '''''''''''''end
    End Sub

    Private Sub btn_search3_Click(sender As Object, e As EventArgs) Handles btn_search3.Click
        sqlstring3 = "SELECT * FROM source_product where able = 1 and (id like '%" & cb_search.Text & "%' or name like '%" & cb_search.Text & "%') and EXISTS (SELECT source_recipe.prodid FROM source_recipe WHERE source_product.ID = source_recipe.prodid)"
        Dim data3 = connn.sql_customSQLCOMMAND_select(sqlstring3)

        ''''''''''''start
        table_recipe.ClearSelection()
        table_recipe.Rows.Clear()
        Try

            If Not data3.Rows.Count = 0 Then

                Dim i As Integer = 0
                While i < data3.Rows.Count

                    table_recipe.Rows.Add({data3.Rows(i)(0).ToString, data3.Rows(i)(1).ToString, data3.Rows(i)(2).ToString, data3.Rows(i)(3), data3.Rows(i)(4), data3.Rows(i)(5), data3.Rows(i)(6)})

                    i += 1
                End While

            End If
        Catch ex As Exception
        End Try
        '''''''''''''end
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If lb_id.Text = "" Or lb_yield.Text = "" Or tb_q.Value = 0 Then
            connn.msgboxc("Please identify proper protocol", 2)
        Else
            q = tb_q.Value
            uom = lb_uom.Text
            rawid = lb_id.Text
            bq = lb_bq.Text
            bc = lb_bc.Text
            rc = (q * bc) / bq
            rc = Decimal.Round(rc, 2, MidpointRounding.AwayFromZero)

            table_list.Rows.Add(table_list.Rows.Count + 1 * -1, q, uom, rawid, bq, bc, rc, tb_cat.Text)

            tb_q.Value = 0

            cb_search2.Select()

        End If
    End Sub

    Function getrc(quantity As String, idraw As String) As Double
        Dim src, sbc, sbq As Double
        src = 0
        Try
            sbq = connn.sql_dataItemget("vol", "source_rawmat", "'" & idraw & "'")
            sbc = connn.sql_dataItemget("amt_unit", "source_rawmat", "'" & idraw & "'")
            src = (Double.Parse(quantity) * sbc) / sbq
            src = Decimal.Round(src, 2, MidpointRounding.AwayFromZero)
        Catch ex As Exception
            connn.msgboxc(ex.Message, 2)
            src = 0
        End Try
        Return src
    End Function

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        If connn.msgboxc("Are you sure?", 3) Then
            For i As Integer = 0 To table_list.RowCount - 1
                If table_list.Rows(i).Cells(0).Value.ToString = selectedid_list Then
                    i = table_list.RowCount - 1
                    table_list.Rows.Remove(table_list.SelectedRows(0))
                    connn.msgboxc("Removed!", 1)
                    btn_remove.Enabled = False
                End If
            Next
        End If
    End Sub

    Private Sub btn_commit_Click(sender As Object, e As EventArgs) Handles btn_commit.Click
        Dim status = False
        If lb_product.Text = "Product" Or table_list.Rows.Count = 0 Then
            connn.msgboxc("Please identify proper protocol", 2)
        ElseIf connn.msgboxc("Are you sure to create recipe for " & lb_product.Text & "?", 3) Then
            Dim prodidq, ingidq, catq, qq, rcq As String
            For i As Integer = 0 To table_list.RowCount - 1
                prodidq = selectedid_product
                ingidq = table_list.Rows(i).Cells(3).Value
                catq = table_list.Rows(i).Cells(7).Value
                qq = table_list.Rows(i).Cells(1).Value
                rcq = table_list.Rows(i).Cells(6).Value

                Dim value As String = "[value-1],'[value-2]','[value-3]',[value-4],[value-5]"
                value = value.Replace("[value-1]", prodidq)
                value = value.Replace("[value-2]", ingidq)
                value = value.Replace("[value-3]", catq)
                value = value.Replace("[value-4]", qq)
                value = value.Replace("[value-5]", rcq)

                If (connn.sql_insertdatatotable("source_recipe", "`prodid`, `ing_id`, `category`, `rec_qty`, `recipecost`", value)) Then
                    status = True
                Else
                    i = table_list.RowCount - 1
                    status = False
                End If
            Next
            If status = True Then
                table_list.Rows.Clear()
                function_reset()
                loadtable()
                connn.msgboxc("Success", 1)
            End If
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim status = False
        If lb_recipe.Text = "Product" Or table_list.Rows.Count = 0 Then
            connn.msgboxc("Please identify proper protocol", 2)
        ElseIf connn.msgboxc("Are you sure to create recipe for " & lb_product.Text & "?", 3) Then
            ''delete data
            Dim sqlstring = "DELETE FROM `source_recipe` WHERE prodid = " & selectedid_recipe
            If (connn.sql_customSQLCOMMAND(sqlstring)) Then

                ''add data again
                Dim prodidq, ingidq, catq, qq, rcq As String
                For i As Integer = 0 To table_list.RowCount - 1
                    prodidq = selectedid_recipe
                    ingidq = table_list.Rows(i).Cells(3).Value
                    catq = table_list.Rows(i).Cells(7).Value
                    qq = table_list.Rows(i).Cells(1).Value
                    rcq = table_list.Rows(i).Cells(6).Value

                    Dim value As String = "[value-1],'[value-2]','[value-3]',[value-4],[value-5]"
                    value = value.Replace("[value-1]", prodidq)
                    value = value.Replace("[value-2]", ingidq)
                    value = value.Replace("[value-3]", catq)
                    value = value.Replace("[value-4]", qq)
                    value = value.Replace("[value-5]", rcq)

                    If (connn.sql_insertdatatotable("source_recipe", "`prodid`, `ing_id`, `category`, `rec_qty`, `recipecost`", value)) Then
                        status = True
                    Else
                        i = table_list.RowCount - 1
                        status = False
                    End If
                Next
                If status = True Then
                    table_list.Rows.Clear()
                    function_reset()
                    connn.msgboxc("Success", 1)
                End If
            Else

            End If
        End If
    End Sub

    Private Sub cb_search2_KeyUp(sender As Object, e As KeyEventArgs) Handles cb_search2.KeyUp
        cb_search2.Refresh()
        btn_search2_Click(e, e)
        If e.KeyCode = Keys.Enter Then
            Try
                table_raw_CellClick(sender, New DataGridViewCellEventArgs(0, table_raw.Rows.IndexOf(table_raw.SelectedRows(0))))
            Catch ex As Exception
            End Try
        End If

    End Sub

    Private Sub tb_q_Click(sender As Object, e As EventArgs) Handles tb_q.Click
        tb_q.Text = ""
    End Sub

    Private Sub tb_q_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_q.KeyUp
        If e.KeyCode = Keys.Enter Then
            btn_add_Click(e, e)
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If lb_recipe.Text = "Product" Then
            connn.msgboxc("Please identify proper protocol", 2)
        ElseIf connn.msgboxc("Are you sure to create recipe for " & lb_product.Text & "?", 3) Then
            ''delete data
            Dim sqlstring = "DELETE FROM `source_recipe` WHERE prodid = " & selectedid_recipe
            If (connn.sql_customSQLCOMMAND(sqlstring)) Then
                function_reset()
                loadtable()
            End If
        End If

    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        loadtable()
        function_reset()
    End Sub

    Private Sub resources_recipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_search.AutoCompleteMode = AutoCompleteMode.Append
        cb_search3.AutoCompleteMode = AutoCompleteMode.Append
        tb_cat.AutoCompleteMode = AutoCompleteMode.Append
        cb_search.AutoCompleteSource = AutoCompleteSource.ListItems
        cb_search3.AutoCompleteSource = AutoCompleteSource.ListItems
        tb_cat.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub


    Sub loadtable()
        Dim sqlstring, sqlstring2, sqlstring3 As String
        Dim data, data2, data3 As DataTable
        ''''''''''''''''''''''''LOAD TABLE PRODUCT
        sqlstring = "SELECT * FROM source_product where able = 1 and NOT EXISTS (SELECT source_recipe.prodid FROM source_recipe WHERE source_product.ID = source_recipe.prodid)"
        data = connn.sql_customSQLCOMMAND_select(sqlstring)

        ''''''''''''start
        table_prod.ClearSelection()
        table_prod.Rows.Clear()
        cb_search.Items.Clear()
        cb_search.Text = ""
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
        '''''''''''''end


        ''''''''''''''''''''''''LOAD TABLE raw
        sqlstring2 = "SELECT * FROM source_rawmat where able = 1 "
        data2 = connn.sql_customSQLCOMMAND_select(sqlstring2)

        ''''''''''''start
        table_raw.ClearSelection()
        table_raw.Rows.Clear()
        cb_search2.Items.Clear()
        cb_search2.Text = ""
        Try

            If Not data2.Rows.Count = 0 Then

                Dim i As Integer = 0
                While i < data2.Rows.Count

                    table_raw.Rows.Add({data2.Rows(i)(0).ToString, data2.Rows(i)(1).ToString, data2.Rows(i)(2).ToString, data2.Rows(i)(3), data2.Rows(i)(4), data2.Rows(i)(5), data2.Rows(i)(6)})
                    cb_search2.Items.Add(data2.Rows(i)(0).ToString)
                    cb_search2.Items.Add(data2.Rows(i)(1).ToString)
                    i += 1
                End While

            End If
        Catch ex As Exception
        End Try
        '''''''''''''end


        ''''''''''''''''''''''''LOAD TABLE raw
        sqlstring3 = "SELECT * FROM source_product where able = 1 and EXISTS (SELECT source_recipe.prodid FROM source_recipe WHERE source_product.ID = source_recipe.prodid)"
        data3 = connn.sql_customSQLCOMMAND_select(sqlstring3)

        ''''''''''''start
        table_recipe.ClearSelection()
        table_recipe.Rows.Clear()
        cb_search3.Items.Clear()
        cb_search3.Text = ""
        Try

            If Not data3.Rows.Count = 0 Then

                Dim i As Integer = 0
                While i < data3.Rows.Count

                    table_recipe.Rows.Add({data3.Rows(i)(0).ToString, data3.Rows(i)(1).ToString, data3.Rows(i)(2).ToString, data3.Rows(i)(3), data3.Rows(i)(4), data3.Rows(i)(5), data3.Rows(i)(6)})
                    cb_search3.Items.Add(data3.Rows(i)(0).ToString)
                    cb_search3.Items.Add(data3.Rows(i)(1).ToString)
                    i += 1
                End While

            End If
        Catch ex As Exception
        End Try
        '''''''''''''end
        table_recipe.ClearSelection()
        table_raw.ClearSelection()
        table_prod.ClearSelection()
    End Sub

    Private Sub table_list_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles table_list.CellClick
        Dim i As Integer
        Try
            i = table_list.CurrentRow.Index
            If (i >= 0) Then
                selectedid_list = table_list.Item(0, i).Value
                btn_remove.Enabled = True

                table_list.CurrentRow.Selected = True
            Else
                table_list.ClearSelection()
                table_list.Rows.Clear()
            End If
        Catch ex As Exception
            table_list.ClearSelection()
            table_list.Rows.Clear()
        End Try
    End Sub

    Private Sub table_prod_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles table_prod.CellClick
        Dim i As Integer
        Try
            i = table_prod.CurrentRow.Index
            If (i >= 0) Then
                lb_product.Text = table_prod.Item(1, i).Value
                selectedid_product = table_prod.Item(0, i).Value
                lb_yield.Text = table_prod.Item(6, i).Value

                table_prod.CurrentRow.Selected = True
            Else
                table_prod.ClearSelection()
                table_prod.Rows.Clear()
            End If
        Catch ex As Exception
            table_prod.ClearSelection()
            table_prod.Rows.Clear()
        End Try
    End Sub

    Private Sub table_raw_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles table_raw.CellClick
        Dim i As Integer
        Try
            i = table_raw.CurrentRow.Index
            If (i >= 0) Then
                lb_rawmat.Text = table_raw.Item(1, i).Value
                selectedid_rawmat = table_raw.Item(0, i).Value
                lb_id.Text = selectedid_rawmat
                lb_uom.Text = table_raw.Item(4, i).Value
                lb_bq.Text = table_raw.Item(2, i).Value
                lb_bc.Text = table_raw.Item(5, i).Value

                table_raw.CurrentRow.Selected = True

                tb_q.Select()
                tb_q.Text = ""
            Else
                table_raw.ClearSelection()
                table_raw.Rows.Clear()
            End If
        Catch ex As Exception
            table_raw.ClearSelection()
            table_raw.Rows.Clear()
        End Try
    End Sub

    Private Sub table_recipe_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles table_recipe.CellClick
        Dim i As Integer
        table_list.Rows.Clear()
        Dim uom, bq, bc, rcs As String
        Try
            i = table_recipe.CurrentRow.Index
            If (i >= 0) Then
                lb_recipe.Text = table_recipe.Item(1, i).Value
                selectedid_recipe = table_recipe.Item(0, i).Value
                lb_yield.Text = table_recipe.Item(6, i).Value
                Panel2.BackColor = Color.LightGoldenrodYellow
                btn_update.Visible = True
                btn_delete.Visible = True
                btn_commit.Visible = False


                Dim data As DataTable = connn.sql_selectdatafromtable("*", "source_recipe", "Where prodid = " & selectedid_recipe & "")
                For j As Integer = 0 To data.Rows.Count - 1

                    uom = connn.sql_dataItemget("gramscon", "source_rawmat", "'" & data.Rows(j)(2) & "'")
                    bq = connn.sql_dataItemget("vol", "source_rawmat", "'" & data.Rows(j)(2) & "'")
                    bc = connn.sql_dataItemget("amt_unit", "source_rawmat", "'" & data.Rows(j)(2) & "'")
                    rcs = getrc(data.Rows(j)(4), data.Rows(j)(2)) & ""

                    table_list.Rows.Add(data.Rows(j)(0), data.Rows(j)(4).ToString, uom, data.Rows(j)(2).ToString, bq, bc, rcs, data.Rows(j)(3).ToString)

                Next

                table_recipe.CurrentRow.Selected = True
            Else

            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub function_reset()
        Panel2.BackColor = Color.LightCyan
        lb_product.Text = "Product"
        lb_rawmat.Text = "Raw Material"
        lb_recipe.Text = "Update Recipe"
        lb_uom.Text = ""
        lb_yield.Text = ""
        lb_id.Text = ""
        lb_bq.Text = ""
        lb_bc.Text = ""
        tb_q.Value = 0

        btn_commit.Visible = True
        btn_update.Visible = False
        btn_delete.Visible = False
        btn_remove.Enabled = False

        table_list.ClearSelection()
        table_prod.ClearSelection()
        table_raw.ClearSelection()
        table_recipe.ClearSelection()

    End Sub
End Class
