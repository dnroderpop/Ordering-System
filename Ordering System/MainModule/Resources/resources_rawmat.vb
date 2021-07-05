Public Class resources_rawmat
    Dim data As DataTable
    Dim id, na, vol, uom, gramsc, amtu, amtg As String
    Dim selectedid As String

    Private Sub Resources_rawmat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_search.AutoCompleteMode = AutoCompleteMode.Append
        cb_search.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub

    Sub loadtable()
        table_raw.ClearSelection()
        table_raw.Rows.Clear()
        cb_search.Items.Clear()
        cb_search.Text = ""
        data = connn.sql_selectdatafromtable("*", "source_rawmat", "where able = 1")
        Try

            If Not data.Rows.Count = 0 Then

                Dim i As Integer = 0
                While i < data.Rows.Count

                    table_raw.Rows.Add({data.Rows(i)(0).ToString, data.Rows(i)(1).ToString, data.Rows(i)(2), data.Rows(i)(3).ToString, data.Rows(i)(4).ToString, data.Rows(i)(5), data.Rows(i)(6)})
                    cb_search.Items.Add(data.Rows(i)(0).ToString)
                    cb_search.Items.Add(data.Rows(i)(1).ToString)
                    i += 1
                End While

            End If
        Catch ex As Exception
        End Try
        function_reset()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            t_ag.Enabled = False

            Try
                t_ag.Value = Decimal.Round(t_au.Value / t_v.Value, 4, MidpointRounding.AwayFromZero)
            Catch ex As Exception

            End Try
        Else
            t_ag.Enabled = Enabled

        End If
    End Sub

    Sub calculate_tag()
        If CheckBox1.CheckState = CheckState.Checked Then
            Try
                t_ag.Value = Decimal.Round(t_au.Value / t_v.Value, 4, MidpointRounding.AwayFromZero)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub T_v_ValueChanged(sender As Object, e As EventArgs) Handles t_v.ValueChanged
        calculate_tag()
    End Sub

    Private Sub T_au_ValueChanged(sender As Object, e As EventArgs) Handles t_au.ValueChanged
        calculate_tag()
    End Sub

    Private Sub Btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If connn.msgboxc("Are you sure to delete [" & selectedid & "] ?", 3) Then
            If connn.sql_customSQLCOMMAND("update source_rawmat set able = 0 where id = '" & selectedid & "'") Then
                function_reset()
                loadtable()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        table_raw.ClearSelection()
        table_raw.Rows.Clear()
        data = connn.sql_selectdatafromtable("*", "source_rawmat", "Where able = 1 and (id like '" & cb_search.Text & "' or  name like '%" & cb_search.Text & "%')")
        Try

            If Not data.Rows.Count = 0 Then

                Dim i As Integer = 0
                While i < data.Rows.Count
                    table_raw.Rows.Add({data.Rows(i)(0).ToString, data.Rows(i)(1).ToString, data.Rows(i)(2).ToString, data.Rows(i)(3).ToString, data.Rows(i)(4).ToString, data.Rows(i)(5).ToString, data.Rows(i)(6).ToString})
                    i += 1
                End While

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Table_raw_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles table_raw.CellClick
        Dim i As Integer
        Try
            function_reset()
            i = table_raw.CurrentRow.Index
            selectedid = table_raw.Item(0, i).Value
            table_raw.CurrentRow.Selected = True
            If (i >= 0) Then
                Lmat.Text = table_raw.Item(1, i).Value
                selectedid = table_raw.Item(0, i).Value
                btn_add.Visible = False
                btn_update.Visible = True
                t_c.Text = table_raw.Item(0, i).Value
                t_n.Text = table_raw.Item(1, i).Value
                t_v.Text = table_raw.Item(2, i).Value
                t_g.Text = table_raw.Item(3, i).Value
                t_u.Text = table_raw.Item(4, i).Value
                t_au.Text = table_raw.Item(5, i).Value
                t_ag.Text = table_raw.Item(6, i).Value
                Ladd.Text = "Change a Property"
                Ladd.ForeColor = Color.DarkSlateGray
                t_ag.Enabled = True
                CheckBox1.CheckState = CheckState.Unchecked
                btn_delete.Enabled = True
            Else
                table_raw.ClearSelection()
                table_raw.Rows.Clear()
            End If
        Catch ex As Exception
            table_raw.ClearSelection()
            table_raw.Rows.Clear()
        End Try
    End Sub

    Sub function_reset()
        btn_add.Visible = True
        btn_update.Visible = False
        btn_delete.Enabled = False
        table_raw.ClearSelection()
        CheckBox1.CheckState = CheckState.Checked
        t_ag.Enabled = False
        Lmat.Text = "Selected Material"
        Ladd.Text = "Add a raw material"
        Ladd.ForeColor = Color.ForestGreen
        t_c.Text = ""
        t_n.Text = ""
        t_v.Text = "0"
        t_g.Text = ""
        t_u.Text = ""
        t_au.Text = "0"
        t_ag.Text = "0"
        id = ""
        na = ""
        vol = ""
        uom = ""
        gramsc = ""
        amtu = ""
        amtg = ""
    End Sub

    Sub function_getitems()
        id = t_c.Text
        na = t_n.Text
        vol = t_v.Text
        uom = t_u.Text
        gramsc = t_g.Text
        amtu = t_au.Text
        amtg = t_ag.Text
    End Sub

    Private Sub Btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        function_reset()
        loadtable()
    End Sub



    Private Sub Btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        function_getitems()
        If id = "" Or na = "" Or vol = "" Or uom = "" Or amtu = "" Or amtg = "" Then
            MessageBox.Show("If possibly dont leave any blank items. Except GramsConversion")
        Else
            Dim values As String = "'[value-1]','[value-2]',[value-3],'[value-4]','[value-5]',[value-6],[value-7],1"
            values = values.Replace("[value-1]", id)
            values = values.Replace("[value-2]", na)
            values = values.Replace("[value-3]", vol)
            values = values.Replace("[value-4]", uom)
            values = values.Replace("[value-5]", gramsc)
            values = values.Replace("[value-6]", amtu)
            values = values.Replace("[value-7]", amtg)

            If connn.sql_insertdatatotable("source_rawmat", "`id`, `name`, `vol`, `uom`, `gramscon`, `amt_unit`, `amt_grams`,`able`", values) Then
                function_reset()
                loadtable()
                connn.msgboxc("Success!", 1)
            End If
        End If
    End Sub


    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        function_getitems()

        If id = "" Or na = "" Or vol = "" Or uom = "" Or amtu = "" Or amtg = "" Then
            MessageBox.Show("If possibly dont leave any blank items. Except GramsConversion")
        Else
            Dim sqlstring As String = "UPDATE `source_rawmat` SET `id`='[value-1]',`name`='[value-2]',`vol`=[value-3],`uom`='[value-4]',`gramscon`='[value-5]',`amt_unit`=[value-6],`amt_grams`=[value-7] where id = '" & selectedid & "'"
            sqlstring = sqlstring.Replace("[value-1]", id)
            sqlstring = sqlstring.Replace("[value-2]", na)
            sqlstring = sqlstring.Replace("[value-3]", vol)
            sqlstring = sqlstring.Replace("[value-4]", uom)
            sqlstring = sqlstring.Replace("[value-5]", gramsc)
            sqlstring = sqlstring.Replace("[value-6]", amtu)
            sqlstring = sqlstring.Replace("[value-7]", amtg)
            If connn.sql_customSQLCOMMAND(sqlstring) Then
                function_reset()
                loadtable()
                connn.msgboxc("Success!", 1)
            End If
        End If
    End Sub
End Class
