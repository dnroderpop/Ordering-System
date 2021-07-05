Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class report_generate_pahabol_onday
    Public table As String
    Private Sub report_generate_pahabol_onday_load(sender As Object, e As EventArgs) Handles MyBase.Load
        connn.sql_customSQLCOMMAND("TRUNCATE `mangtinapay`.`forecast_details`")
        Dim data As DataTable
        Dim branch As String
        branch = Mainmenu.Reporting_forecast1.ComboBox1.Text

        If branch = "All" Then
            data = connn.sql_customSQLCOMMAND_select("Select prod,sum(qty) from " & table & " where date = '" & connn.datetoquery(Mainmenu.Reporting_forecast1.DateTimePicker1.Value.ToShortDateString) & "' group by prod")
        Else
            Dim branchid As Integer = Integer.Parse(connn.sql_dataItemget("id", "source_branch", "id and name = '" & branch & "'"))
            data = connn.sql_customSQLCOMMAND_select("Select prod,sum(qty)  from " & table & "  where branch = " & branchid & " and date = '" & connn.datetoquery(Mainmenu.Reporting_forecast1.DateTimePicker1.Value.ToShortDateString) & "' group by prod")

        End If
        For i As Integer = 0 To data.Rows.Count - 1
            Dim d, s As String
            d = connn.sql_dataItemget("name", "source_product", data.Rows(i)(0).ToString)
            s = data.Rows(i)(1).ToString
            connn.sql_customSQLCOMMAND("INSERT INTO `forecast_details`(`product`, `total`) VALUES ('" & d & "'," & s & ")")
        Next

        Dim filelocation As String = "report\creport_forecast.rpt"
        Dim CR As New ReportDocument
        CR.Load(filelocation)
        crv_form.ReportSource = CR

        Dim text As TextObject = CR.ReportDefinition.ReportObjects.Item("t_branch")
        Dim dataforwelcome = connn.sql_dataItemget("nickname", "user_accounts", My.Settings.myuserid)
        Dim text2 As TextObject = CR.ReportDefinition.ReportObjects.Item("t_name")
        text2.Text = connn.sql_dataItemget("nickname", "user_accounts", My.Settings.myuserid)
        text.Text = "Forecast for " & Mainmenu.Reporting_forecast1.DateTimePicker1.Value.ToLongDateString & "    Branch: " & branch


        Dim crystalexport As New crystalexport
        crystalexport.crystalexport(CR, "sum", Mainmenu.Reporting_forecast1.DateTimePicker1.Value.ToLongDateString & " Branch " & branch)


        crv_form.RefreshReport()
    End Sub
End Class