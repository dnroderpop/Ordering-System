Public Class UF_user_accountsettings
    Private Sub UF_user_accountsettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = connn.sql_dataItemget("nickname", "user_accounts", My.Settings.myuserid)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") Then
            MessageBox.Show("Please dont leave unfilled")
        ElseIf MessageBox.Show("Are you sure?", "MT", MessageBoxButtons.YesNo) Then
            If (connn.sql_customSQLCOMMAND("Update user_accounts set nickname = '" & TextBox1.Text & "' where id = " & My.Settings.myuserid)) Then
                MessageBox.Show("SUCCESS!")
                Mainmenu.reloadname()
                Me.Close()
            End If

        End If
    End Sub
End Class