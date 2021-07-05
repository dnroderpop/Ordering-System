Public Class login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        register.ShowDialog()
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
        connn.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If textb_username.Text = "" And textb_password.Text = "" Then
        Else

            Dim data = connn.sql_selectdatafromtable("*", "user_accounts",
                            "WHERE `user` = '" & textb_username.Text & "' and password = '" & textb_password.Text & "' and pending = 0")
            If data.Rows.Count = 0 Then

                Label3.Text = "Username or password doesn't match"
                Label3.ForeColor = Color.Crimson
            Else
                My.Settings.myuserid = connn.sql_dataItemget("id", "user_accounts", "id and user = '" & textb_username.Text & "'")
                Mainmenu.Show()
                Mainmenu.reloadform(e)
                Me.Close()
            End If

        End If
    End Sub
End Class
