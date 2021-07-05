Imports System.ComponentModel

Public Class UF_user_manageaccounts
    Dim data, data2 As DataTable
    Dim selectedid As Integer
    Dim selectedrights As Integer

    Sub function_reset()
        lr.ForeColor = Color.Black
        lr.Text = "Selected module"
        Label2.Text = "Select a User"
    End Sub
    Private Sub Table_name_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles table_name.CellClick
        Dim i As Integer
        Try
            i = table_name.CurrentRow.Index
            table_name.CurrentRow.Selected = True
            If (i >= 0) Then
                Label2.Text = table_name.Item(1, i).Value
                selectedid = table_name.Item(0, i).Value
                If table_name.Item(3, i).Value = "ADMIN" Then
                    selectedrigths = 1
                Else
                    selectedrigths = 0
                End If
                lr.Text = Label1.Text
                lr.ForeColor = Label1.ForeColor
            Else
                function_reset()
            End If
        Catch ex As Exception
            function_reset()
        End Try

    End Sub
    Private Sub Table_register_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles table_register.CellClick
        Dim i As Integer
        Try
            i = table_register.CurrentRow.Index
            table_register.CurrentRow.Selected = True
            If (i >= 0) Then
                Label2.Text = table_register.Item(1, i).Value
                selectedid = table_register.Item(0, i).Value
                If table_register.Item(3, i).Value = "ADMIN" Then
                    selectedrigths = 1
                Else
                    selectedrigths = 0
                End If
                lr.Text = Label3.Text
                lr.ForeColor = Label3.ForeColor
            Else
                function_reset()
            End If
        Catch ex As Exception
            function_reset()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Label2.Text = "Select a user" Then
            MessageBox.Show("Select A user first!")
        Else
            If lr.ForeColor = Label1.ForeColor Then

                If MessageBox.Show("Are you sure to APPROVE USER?", "MT", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                    If connn.sql_customSQLCOMMAND("Update user_accounts set rights = " & selectedrights & " pending = 0, able = 1 , rights = " & selectedrigts & " where id = " & selectedid) Then
                        MessageBox.Show("Success!")
                        loadtable()
                    End If

                End If

            Else
                If MessageBox.Show("Are you sure to CHANGE POSITION OF USER?", "MT", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                    If connn.sql_customSQLCOMMAND("Update user_accounts set rights = " & selectedrights & " where id = " & selectedid) Then
                        MessageBox.Show("Success!")
                        loadtable()
                    End If

                End If
            End If
        End If
    End Sub

    Sub loadtable()
        data = New DataTable
        data2 = New DataTable
        table_register.ClearSelection()
        table_register.Rows.Clear()
        table_name.ClearSelection()
        table_name.Rows.Clear()
        data = connn.sql_selectdatafromtable("*", "user_accounts", "where pending = 1")
        data2 = connn.sql_selectdatafromtable("*", "user_accounts", "where pending = 0 and able = 1")
        If Not data.Rows.Count = 0 Then

            Dim i As Integer = 0
            Dim autor As String = "Unknown"

            While i < data.Rows.Count
                If data.Rows(i)(3).ToString = 0 Then
                    autor = "Guess"
                ElseIf data.Rows(i)(3).ToString = 1 Then
                    autor = "Admin"
                ElseIf data.Rows(i)(3).ToString = 2 Then
                    autor = "Analyst"
                ElseIf data.Rows(i)(3).ToString = 3 Then
                    autor = "Commisarry"
                ElseIf data.Rows(i)(3).ToString = 4 Then
                    autor = "Encoder Transaction"
                ElseIf data.Rows(i)(3).ToString = 5 Then
                    autor = "Encoder Resources"
                End If
                table_name.Rows.Add({data.Rows(i)(0).ToString, data.Rows(i)(1).ToString, data.Rows(i)(2).ToString, autor, data.Rows(i)(4).ToString, data.Rows(i)(5).ToString})
                i += 1
            End While
        End If
        If Not data2.Rows.Count = 0 Then

            Dim i As Integer = 0
            Dim autor As String = "Unknown"

            While i < data2.Rows.Count
                If data2.Rows(i)(3).ToString = 0 Then
                    autor = "Guess"
                ElseIf data2.Rows(i)(3).ToString = 1 Then
                    autor = "Admin"
                ElseIf data2.Rows(i)(3).ToString = 2 Then
                    autor = "Analyst"
                ElseIf data2.Rows(i)(3).ToString = 3 Then
                    autor = "Commisarry"
                ElseIf data2.Rows(i)(3).ToString = 4 Then
                    autor = "Encoder Transaction"
                ElseIf data2.Rows(i)(3).ToString = 5 Then
                    autor = "Encoder Resources"
                End If
                table_register.Rows.Add({data2.Rows(i)(0).ToString, data2.Rows(i)(1).ToString, data2.Rows(i)(2).ToString, autor, data2.Rows(i)(4).ToString, data2.Rows(i)(5).ToString})
                i += 1
            End While
        End If
        function_reset()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        selectedrights = ComboBox1.SelectedIndex
    End Sub

    Private Sub Btn_name_Click(sender As Object, e As EventArgs) Handles btn_name.Click
        If Label2.Text = "Select a user" Then
            MessageBox.Show("Select A user first!")
        Else
            If lr.ForeColor = Label1.ForeColor Then

                If MessageBox.Show("Are you sure to REMOVE PENDING USER?", "MT", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                    If connn.sql_removeitemfromDatabase("user_accounts", selectedid) Then
                        MessageBox.Show("Success!")
                        loadtable()
                    End If

                End If

            Else
                If MessageBox.Show("Are you sure to REMOVE REGISTERED USER?", "MT", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                    If connn.sql_customSQLCOMMAND("update user_accounts set able = 0 where id = " & selectedid) Then
                        MessageBox.Show("Success!")
                        loadtable()
                    End If

                End If
            End If
        End If
    End Sub


End Class
