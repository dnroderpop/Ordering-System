Public Class register
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Tuser.Text = "" Or Tpass.Text = "" Or Tnickname.Text = "" Then
            MessageBox.Show("Please fill up this form")
        ElseIf checkusername = False Then

            MessageBox.Show("Please change the username for it is been used")
            Tuser.Select()
        Else
            Dim values As String = "'[value-2]','[value-3]',[value-4],'[value-5]',[value-6]"
            values = values.Replace("[value-2]", Tuser.Text)
            values = values.Replace("[value-3]", Tpass.Text)
            values = values.Replace("[value-4]", "0")
            values = values.Replace("[value-5]", Tnickname.Text)
            values = values.Replace("[value-6]", "1")
            If (connn.sql_insertdatatotable("user_accounts", "`user`, `password`, `rights`, `nickname`, `pending`", values)) = True Then
                MessageBox.Show("Register successfully \nPlease wait for the aproval of your account")

                Me.Close()
            End If

        End If
    End Sub

    Function checkusername() As Boolean
        Dim result As Boolean = False
        Dim datas = connn.sql_selectdatafromtable("user", "user_accounts", "Where user = '" & Tuser.Text & "'")
        If datas.Rows.Count = 0 Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function
End Class