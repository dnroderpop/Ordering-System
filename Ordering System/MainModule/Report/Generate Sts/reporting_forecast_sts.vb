Public Class reporting_forecast_sts
    Dim selectedid As String
    Private Sub reporting_forecast_sts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadcb()
        cb_branch.SelectedIndex = 0
        cb_branch.Text = cb_branch.SelectedText
        cb_del.SelectedIndex = 0
        cb_del.Text = cb_del.SelectedText
        Button1.Enabled = False
    End Sub
    Sub loadcb()
        cb_branch.Items.Clear()
        Dim data As DataTable = connn.sql_selectdatafromtable("*", "source_branch", "Where able = 1")
        For i As Integer = 0 To data.Rows.Count - 1
            cb_branch.Items.Add(data.Rows(i)(1))
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If cb_branch.Text = "" Then
            connn.msgboxc("Please input the right branch", 2)
        Else
            loadtable()
        End If
    End Sub

    Sub loadtable()
        Dim qdate As String = connn.datetoquery(dtp_date.Value.ToShortDateString)
        Dim branch As String = connn.sql_dataItemget("id", "source_branch", "id and name = '" & cb_branch.Text() & "'")
        Dim sqlstring As String = "select prod,sum(qty) from trans_order where branch = @branch and date = '@date' group by prod"
        sqlstring = sqlstring.Replace("@branch", branch)
        sqlstring = sqlstring.Replace("@date", qdate)
        Dim data As DataTable = connn.sql_customSQLCOMMAND_select(sqlstring)
        table_list.Rows.Clear()
        table_first.Rows.Clear()
        table_second.Rows.Clear()

        For i As Integer = 0 To data.Rows.Count - 1
            Dim name As String = connn.sql_dataItemget("name", "source_product", data.Rows(i)(0))
            table_list.Rows.Add(i, name, data.Rows(i)(1))
        Next

        dtp_qdate.Value = DateAdd(DateInterval.Day, 1, dtp_date.Value)
        lbSTSNUM.Text = connn.stsnum(branch, dtp_qdate.Value, "First Delivery")
        lbSTSNUM_2.Text = connn.stsnum(branch, dtp_qdate.Value, "Second Delivery")

        Dim dta As DataTable = connn.sql_customSQLCOMMAND_select("SELECT * FROM `trans_sts` where stsid = '" & lbSTSNUM.Text & "' or stsid = '" & lbSTSNUM_2.Text & "' ")

        If Not dta.Rows.Count = 0 Then
            table_list.Rows.Clear()
            connn.msgboxc("The Report Have been already Generated for the " & dtp_qdate.Value.ToLongDateString, 2)
        End If
    End Sub

    Private Sub table_list_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles table_list.CellClick
        Dim i As Integer
        Try
            i = table_list.CurrentRow.Index
            table_list.CurrentRow.Selected = True
            If (i >= 0) Then
                selectedid = table_list.Item(0, i).Value
                lb_prod.Text = table_list.Item(1, i).Value
                num_num.Maximum = Decimal.Parse(table_list.Item(2, i).Value)
                num_num.Value = Decimal.Parse(table_list.Item(2, i).Value)
                Button1.Enabled = True
                Button3.Enabled = True
            Else
                table_list.ClearSelection()
                table_list.Rows.Clear()
            End If
        Catch ex As Exception
            table_list.ClearSelection()
            table_list.Rows.Clear()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim prodid, name, cat As String
        Dim quantity, uniprice, totalamount As Double
        name = lb_prod.Text
        prodid = connn.sql_dataItemget("id", "source_product", "id and name = '" & name & "'")
        quantity = num_num.Value
        uniprice = connn.sql_dataItemget("srpc", "source_product", prodid)
        totalamount = Double.Parse(quantity) * Double.Parse(uniprice)
        cat = connn.sql_dataItemget("category", "source_product", prodid)

        If lb_prod.Text = "Product Name" And num_num.Value = 0 Then
            connn.msgboxc("Please Input the right protocol", 2)
        Else
            If cb_del.Text = "First Delivery" Then

                Dim result As Boolean = True
                Dim tquantity As Integer
                For Each rows In table_first.Rows
                    If Not rows.Cells(1).Value = name Then
                    Else
                        result = False
                        tquantity = quantity + Integer.Parse(rows.Cells(2).Value)
                        table_first.Rows.Remove(rows)
                        table_first.Rows.Add(table_first.Rows.Count, name, tquantity, uniprice, totalamount, cat)
                    End If
                Next

                If result = True Then
                    table_first.Rows.Add(table_first.Rows.Count, name, quantity, uniprice, totalamount, cat)
                    minuslist(selectedid, quantity)
                Else
                    minuslist(selectedid, quantity)
                End If


            Else

                Dim result As Boolean = True
                Dim tquantity As Integer
                For Each rows In table_second.Rows
                    If Not rows.Cells(1).Value = name Then
                    Else
                        result = False
                        tquantity = quantity + rows.Cells(2).Value
                        table_second.Rows.Remove(rows)
                        table_second.Rows.Add(table_second.Rows.Count, name, tquantity, uniprice, totalamount, cat)
                    End If
                Next

                If result = True Then
                    table_second.Rows.Add(table_second.Rows.Count, name, quantity, uniprice, totalamount, cat)
                    minuslist(selectedid, quantity)
                Else
                    minuslist(selectedid, quantity)
                End If
            End If

            num_num.Value = 0
            lb_prod.Text = "Product Name"
            Button1.Enabled = False
            table_list.ClearSelection()
        End If
    End Sub

    Sub minuslist(id As Integer, qty As Integer)


        For Each rows In table_list.Rows
            If rows.Cells(0).Value.ToString = id.ToString Then
                Dim val = Integer.Parse(rows.Cells(2).Value) - qty
                If val <= 0 Then
                    table_list.Rows.Remove(rows)
                Else
                    rows.Cells(2).Value = val
                End If
            End If
        Next


    End Sub

    Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click
        If (Not table_list.Rows.Count = 0) Or (table_first.Rows.Count = 0 And table_second.Rows.Count = 0) Then
            connn.msgboxc("Please input correct Protocol!", 2)
        Else
            For Each rows In table_first.Rows
                Dim stsid, prod, qty, unit, tamt, cat, time, branch, batch As String
                stsid = lbSTSNUM.Text
                prod = rows.cells(1).value
                qty = rows.cells(2).value
                unit = rows.cells(3).value
                tamt = rows.cells(4).value
                cat = rows.cells(5).value
                time = "First Delivery"
                batch = connn.sql_dataItemget("batch", "product_del", connn.sql_dataItemget("id", "source_product", "id and name like '" & prod & "'"))
                If batch = "" Then batch = 0
                branch = connn.sql_dataItemget("id", "source_branch", "id and name = '" & cb_branch.Text & "'")

                Dim val As String = "'[value-1]','[value-2]',[value-3],[value-4],[value-5],'[value-6]','[value-7]',[value-8],'[value-9]',[value-10]"
                Dim col As String = "`stsid`, `prod`, `qty`, `unt`, `tamt`, `cat`, `time`, `branch`,`Date`,`Batch`"
                val = val.Replace("[value-1]", stsid)
                val = val.Replace("[value-2]", prod)
                val = val.Replace("[value-3]", qty)
                val = val.Replace("[value-4]", unit)
                val = val.Replace("[value-5]", tamt)
                val = val.Replace("[value-6]", cat)
                val = val.Replace("[value-7]", time)
                val = val.Replace("[value-8]", branch)
                val = val.Replace("[value-9]", connn.datetoquery(dtp_qdate.Value))
                val = val.Replace("[value-10]", batch)
                connn.sql_insertdatatotable("trans_sts", col, val)
            Next


            For Each rows In table_second.Rows
                Dim stsid, prod, qty, unit, tamt, cat, time, branch, batch As String
                stsid = lbSTSNUM_2.Text
                prod = rows.cells(1).value
                qty = rows.cells(2).value
                unit = rows.cells(3).value
                tamt = rows.cells(4).value
                cat = rows.cells(5).value
                time = "Second Delivery"
                batch = connn.sql_dataItemget("batch", "product_del", connn.sql_dataItemget("id", "source_product", "id and name like '" & prod & "'"))
                If batch = "" Then batch = 0
                branch = connn.sql_dataItemget("id", "source_branch", "id and name = '" & cb_branch.Text & "'")

                Dim val As String = "'[value-1]','[value-2]',[value-3],[value-4],[value-5],'[value-6]','[value-7]',[value-8],'[value-9]',[value-10]"
                Dim col As String = "`stsid`, `prod`, `qty`, `unt`, `tamt`, `cat`, `time`, `branch`,`Date`,`Batch`"
                val = val.Replace("[value-1]", stsid)
                val = val.Replace("[value-2]", prod)
                val = val.Replace("[value-3]", qty)
                val = val.Replace("[value-4]", unit)
                val = val.Replace("[value-5]", tamt)
                val = val.Replace("[value-6]", cat)
                val = val.Replace("[value-7]", time)
                val = val.Replace("[value-8]", branch)
                val = val.Replace("[value-9]", connn.datetoquery(dtp_qdate.Value))
                val = val.Replace("[value-10]", batch)
                connn.sql_insertdatatotable("trans_sts", col, val)
            Next
            table_first.Rows.Clear()

            table_second.Rows.Clear()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If connn.msgboxc("Removing This Items will be filed on your name, Are you sure?", 3) Then
            quantity = num_num.Value

            minuslist(selectedid, quantity)

            num_num.Value = 0
            lb_prod.Text = "Product Name"
            Button3.Enabled = False
        End If

    End Sub

    Private Sub table_list_KeyUp(sender As Object, e As KeyEventArgs) Handles table_list.KeyUp
        If e.KeyCode = Keys.Enter Then
            Button1_Click(e, e)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If InputBox("Protocol Admin Pass :", "Mang Tinapay", "Thank you") = "mangttinapay" Then
            Dim table_rows As DataGridViewRowCollection = table_list.Rows

            For j As Integer = 0 To table_rows.Count - 1

                Dim prodid, name, cat As String
                Dim quantity, uniprice, totalamount As Double
                name = table_rows(j).Cells(1).Value
                prodid = connn.sql_dataItemget("id", "source_product", "id and name = '" & name & "'")
                quantity = table_rows(j).Cells(2).Value
                uniprice = connn.sql_dataItemget("srpc", "source_product", prodid)
                totalamount = Double.Parse(quantity) * Double.Parse(uniprice)
                cat = connn.sql_dataItemget("category", "source_product", prodid)
                selectedid = table_rows(j).Cells(0).Value

                If cb_del.Text = "First Delivery" Then

                    Dim result As Boolean = True
                    Dim tquantity As Integer
                    Dim i As Integer = 0
                    While i <= table_first.Rows.Count - 1
                        If Not table_first.Rows(i).Cells(1).Value = name Then
                        Else
                            result = False
                            tquantity = quantity + Integer.Parse(table_first.Rows(i).Cells(2).Value)
                            table_first.Rows.Remove(table_first.Rows(i))
                            table_first.Rows.Add(table_first.Rows.Count, name, tquantity, uniprice, totalamount, cat)
                        End If
                        i += 1
                    End While

                    If result = True Then
                        table_first.Rows.Add(table_first.Rows.Count, name, quantity, uniprice, totalamount, cat)
                    Else
                    End If
                Else ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    Dim result As Boolean = True
                    Dim tquantity As Integer
                    Dim i As Integer = 0
                    While i <= table_second.Rows.Count - 1
                        If Not table_second.Rows(i).Cells(1).Value = name Then
                        Else
                            result = False
                            tquantity = quantity + Integer.Parse(table_second.Rows(i).Cells(2).Value)
                            table_second.Rows.Remove(table_second.Rows(i))
                            table_second.Rows.Add(table_second.Rows.Count, name, tquantity, uniprice, totalamount, cat)
                        End If
                        i += 1
                    End While

                    If result = True Then
                        table_second.Rows.Add(table_second.Rows.Count, name, quantity, uniprice, totalamount, cat)
                    Else
                    End If
                End If

                num_num.Value = 0
                lb_prod.Text = "Product Name"
                Button1.Enabled = False
                table_list.ClearSelection()


            Next

            table_list.Rows.Clear()
            table_rows.Clear()
        End If
    End Sub
End Class
