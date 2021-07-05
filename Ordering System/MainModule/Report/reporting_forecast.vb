Public Class reporting_forecast
    Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click
        report_generate_forecast.ShowDialog()
    End Sub

    Sub loadcombobox()
        ComboBox1.Items.Clear()

        Dim data As DataTable = connn.sql_selectdatafromtable("*", "source_branch", "Where able = 1")
        ComboBox1.Items.Add("All")
        For i As Integer = 0 To data.Rows.Count - 1
            ComboBox1.Items.Add(data.Rows(i)(1))
        Next
    End Sub

    Private Sub reporting_forecast_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        loadcombobox()
        ComboBox1.Text = "All"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim d As report_generate_pahabol_onday = New report_generate_pahabol_onday
        d.table = "trans_pahabol_on"
        d.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        trans_show_forcast.qdate = DateTimePicker1.Value
        trans_show_forcast.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        loading_sts_forecast.ShowDialog()
    End Sub
End Class
