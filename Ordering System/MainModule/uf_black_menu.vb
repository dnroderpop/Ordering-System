Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Public Class uf_black_menu
    Dim mysqlcon As MySqlConnection
    Dim command As MySqlCommand
    Dim dataadapter As MySqlDataAdapter
    Dim datareader As MySqlDataReader
    Dim mysqlstring As String = "server=" & My.Settings.serverdb _
                    & ";uid=" & My.Settings.userdb _
                    & ";pwd=" & My.Settings.passdb _
                    & ";database=" & My.Settings.namedb
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Call ShowDialog.
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        Dim text As String = ""
        ' Test result.
        If result = DialogResult.OK Then

            ' Get the file path. / to get the file name use this System.IO.Path.GetFileName(OpenFileDialog.FileName) 
            Dim path As String = OpenFileDialog1.FileName
            Try
                ' Read in text.
                text = path
                loadexcel(text)

            Catch ex As Exception


            End Try
        End If

    End Sub

    Sub loadexcel(s As String)

    End Sub

    Private Sub uf_black_menu_Load() Handles MyBase.Load
        ' sqlstring = mysqlstring
        ' Dim data As DataSet = New DataSet
        ' Dim mysqlcon = New MySqlConnection
        ' Dim sqlStringnew = "SELECT * FROM `source_rawmat`"
        ' Try
        '
        '     mysqlcon.ConnectionString = sqlstring
        '     mysqlcon.Open()
        '
        '
        '     command = New MySqlCommand(sqlStringnew, mysqlcon)
        '     dataadapter = New MySqlDataAdapter(command)
        '
        '     dataadapter.Fill(data, "sad")
        '
        '     mysqlcon.Close()
        '
        ' Catch ex As Exception
        '     connn.msgboxc("" + ex.Message, 2)
        ' End Try
        '
        ' table_raw.DataSource = data.Tables("sad")

    End Sub
End Class
