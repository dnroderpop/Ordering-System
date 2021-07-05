Public Class trans_Forcast
    Dim idbranch, selectedid, prodn, cp, bp, dr As String
    Dim data As DataTable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_deletelisttable.Click
        If connn.msgboxc("Are you really sure to remove the selected item below?", 3) Then
            table_list.Rows.RemoveAt(table_list.SelectedRows(0).Index)
            computetotal()
        End If
    End Sub

    Private Sub btn_addbranch_Click()

        Dim data As String
        data = frm_branch.ShowDialog()
        If Not data = 5 Then
            btn_addbranch.Visible = False
            btn_removepick.Visible = True
            idbranch = connn.sql_dataItemget("id", "source_branch", "id and name = '" & lb_branch.Text & "'")
        Else
            btn_addbranch.Visible = True
            btn_removepick.Visible = False

        End If

    End Sub

    Private Sub btn_clearlisttable_Click(sender As Object, e As EventArgs) Handles btn_clearlisttable.Click
        If connn.msgboxc("Are you sure?", 3) Then
            table_list.Rows.Clear()
            loadtable()
            btn_removepick_Click(e, e)
            dtp.Visible = False
        End If
    End Sub

    Sub on_enter()
        If dtp.Enabled = False Then dtp.Value = Now
        loadtable()
        function_reset()

    End Sub

    Private Sub btn_removepick_Click(sender As Object, e As EventArgs) Handles btn_removepick.Click
        btn_removepick.Visible = False
        lb_branch.Text = ""
    End Sub
    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        data = New DataTable
        data = connn.sql_selectdatafromtable("*", "source_product", "where able = 1 " & "and (id like '" & cb_search.Text & "' or  name like '%" & cb_search.Text & "%'  or  category like '%" & cb_search.Text & "%')")
        ' & "and" &
        '  " EXISTS (SELECT source_recipe.prodid FROM source_recipe WHERE source_product.ID = source_recipe.prodid) " &

        table_prod.Rows.Clear()
        Try

            If Not data.Rows.Count = 0 Then

                Dim i As Integer = 0
                While i < data.Rows.Count

                    table_prod.Rows.Add({data.Rows(i)(0).ToString, data.Rows(i)(1).ToString, data.Rows(i)(2).ToString, data.Rows(i)(3), data.Rows(i)(4), data.Rows(i)(5), data.Rows(i)(6)})

                    i += 1
                End While

            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btn_commit_click(sender As Object, e As EventArgs) Handles btn_commit.Click
        loadnum()

        If connn.msgboxc("Are you really sure for " & lb_branch.Text & " at " & dtp.Value.ToLongDateString & "?", 3) And Not table_list.Rows.Count = 0 Then
            Dim s As transactionRawMat = New transactionRawMat
            For i As Integer = 0 To table_list.RowCount - 1
                s.queryme(table_list.Rows(i).Cells(1).Value.ToString, table_list.Rows(i).Cells(5).Value.ToString, "order", dtp.Value.ToShortDateString, lb_number.Text)

                Dim value As String = "[value-1],[value-2],[value-3],'[value-4]'," & lb_number.Text
                value = value.Replace("[value-1]", idbranch)
                value = value.Replace("[value-2]", table_list.Rows(i).Cells(1).Value.ToString)
                value = value.Replace("[value-3]", table_list.Rows(i).Cells(5).Value.ToString)
                value = value.Replace("[value-4]", connn.datetoquery(dtp.Value.ToShortDateString))
                connn.sql_insertdatatotable("trans_order", "`branch`, `prod`, `qty`, `date`,`order_number`", value)
            Next
            function_reset()
            table_list.Rows.Clear()
            connn.msgboxc("Success!", 1)
            connn.sql_changeValueRowtableByID("settings_trans", "order_num = " & Integer.Parse(lb_number.Text) + 1, 1)
            loadnum()
            btn_removepick_Click(e, e)
            dtp.Visible = False

        End If
    End Sub
    Sub loadnum()
        Dim s As transactionRawMat = New transactionRawMat
        lb_number.Text = s.return_trans_number("order")
    End Sub

    Private Sub lb_number_Click(sender As Object, e As EventArgs) Handles lb_number.Click
        loadnum()
    End Sub

    Private Sub lb_ord_ValueChanged(sender As Object, e As EventArgs) Handles lb_ord.ValueChanged
        Dim result As Double = 0
        If lb_ord.Value = 0 Then
            tb_num.Text = 0
        Else
            result = lb_ord.Value / Double.Parse(lb_y.Text)

            If Double.IsInfinity(result) Then

                result = -9.999

            End If
        End If
        Try
            If result.ToString.Split(".")(1).Length <= 2 Then

                lb_ord.ForeColor = Color.Green
            Else

                lb_ord.ForeColor = Color.Crimson
            End If
        Catch ex As Exception
            lb_ord.ForeColor = Color.Green
        End Try
        tb_num.Text = result

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fore As trans_show_forcast = New trans_show_forcast
        fore.qdate = connn.datetoquery(dtp.Value)
        trans_show_forcast.ShowDialog()
    End Sub

    Private Sub cb_search_KeyUp(sender As Object, e As KeyEventArgs) Handles cb_search.KeyUp
        btn_search_Click(e, e)
    End Sub


    Sub loadtable()
        loadnum()
        data = New DataTable
        data = connn.sql_selectdatafromtable("*", "source_product", "where able = 1") '&" and EXISTS (SELECT source_recipe.prodid FROM source_recipe WHERE source_product.ID = source_recipe.prodid)")
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
        function_reset()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If lb_branch.ForeColor = Color.Red Then
            lb_branch.ForeColor = Color.Gold
            If dtp.Visible = True Then Label12.BackColor = Color.Gold
        Else
            lb_branch.ForeColor = Color.Red
            If dtp.Visible = True Then Label12.BackColor = Color.Red
        End If
    End Sub

    Private Sub trans_Forcast_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Timer1.Enabled = True
    End Sub

    Private Sub trans_Forcast_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        Timer1.Enabled = False
    End Sub

    Sub function_reset()
        computetotal()
        lb_product.Text = "Product"
        tb_num.Value = 0
        lb_y.Text = 0
        lb_ord.Text = 0
        lb_ord.ForeColor = Color.Green
    End Sub
    Private Sub table_prod_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles table_prod.CellClick
        Dim i As Integer
        Try
            i = table_prod.CurrentRow.Index
            table_prod.CurrentRow.Selected = True
            If (i >= 0) Then
                lb_product.Text = table_prod.Item(1, i).Value
                selectedid = table_prod.Item(0, i).Value
                lb_y.Text = table_prod.Item(6, i).Value
                prodn = table_prod.Item(1, i).Value
                cp = table_prod.Item(3, i).Value
                bp = table_prod.Item(4, i).Value
                cmi.Text = table_prod(3, i).Value
            Else
                table_prod.ClearSelection()
                table_prod.Rows.Clear()
            End If
        Catch ex As Exception
            table_prod.ClearSelection()
            table_prod.Rows.Clear()
        End Try
    End Sub

    Private Sub tb_num_ValueChanged(sender As Object, e As EventArgs) Handles tb_num.ValueChanged
        ' Dim result As Double = 0  
        ' If tb_num.Value = 0 Then
        '     lb_ord.Text = 0
        ' Else
        '     result = tb_num.Value * Double.Parse(lb_y.Text)
        ' End If
        ' Try
        '     lb_ord.ForeColor = Color.Green
        '     lb_ord.Text = Integer.Parse(result)
        ' Catch ex As Exception
        '     lb_ord.Text = result
        '     lb_ord.ForeColor = Color.Crimson
        ' End Try
    End Sub

    Private Sub btn_pt(sender As Object, e As EventArgs) Handles Button1.Click
        If lb_branch.Text = "" Then
            btn_addbranch_Click()
        End If
        If dtp.Visible = False Then
            dtp.Visible = True
            connn.msgboxc("P l e a s e  m a k e  s u r e  t h a t  t h e  d a t e  i s  t h e  d a y  b e f o r e     t h e  S T S", 2)
        End If
        If (lb_product.Text = "Product" Or lb_ord.Text = "0" Or lb_branch.Text = "") Then
            connn.msgboxc("Please input required protocol", 2)
        Else
            If lb_ord.ForeColor = Color.Green Or lb_ord.ForeColor = Color.Crimson Then
                dr = lb_ord.Text
                table_list.Rows.Add(table_list.Rows.Count + 1, selectedid, prodn, bp, cp, dr, Double.Parse(cp) * Double.Parse(dr))
                function_reset()
            Else
                connn.msgboxc("Input is not a standard yielding", 2)
            End If
        End If
    End Sub

    Sub computetotal()
        totall.Text = 0
        For Each rows In table_list.Rows
            totall.Text += Double.Parse(rows.cells(4).value) * Double.Parse(rows.cells(5).value)
        Next
    End Sub
End Class
