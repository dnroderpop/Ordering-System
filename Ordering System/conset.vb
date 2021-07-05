Public Class conset
    Private Sub Conset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tserver.Text = My.Settings.serverdb
        Tuser.Text = My.Settings.userdb
        Tpass.Text = My.Settings.passdb
        Tname.Text = My.Settings.namedb
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.serverdb = Tserver.Text
        My.Settings.userdb = Tuser.Text
        My.Settings.passdb = Tpass.Text
        My.Settings.namedb = Tname.Text

        MessageBox.Show("Successfully Saved!")
    End Sub

    Private Sub Conset_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        connn.loadconnect()
    End Sub
End Class