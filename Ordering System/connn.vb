Imports MySql.Data.MySqlClient
Public Class connn
    Dim timevalues As Integer
    Dim erroor As String = ""
    Dim mysqlcon As MySqlConnection
    Dim command As MySqlCommand
    Dim dataadapter As MySqlDataAdapter
    Dim datareader As MySqlDataReader

    Dim mysqlstring As String = "server=" & My.Settings.serverdb _
                    & ";uid=" & My.Settings.userdb _
                    & ";pwd=" & My.Settings.passdb _
                    & ";database=" & My.Settings.namedb

    Function stsnum(branchid As String, qdate As Date, AmPm As String) As String
        Dim result As String = ""


        result += Integer.Parse(branchid).ToString("D2") & "-"

        result += qdate.Year & qdate.Month.ToString("D2") & qdate.Day.ToString("D2") & "-"

        If AmPm = "Second Delivery" Then
            result += "02"
        ElseIf AmPm = "pa" Then
            result += "03"
        Else
            result += "01"
        End If

        Return result
    End Function
    Function datetoquery(dates As String) As String
        Dim mdate As String
        Try
            mdate = CDate(dates).ToString("yyyy-MM-dd")

        Catch e As Exception
            Me.msgboxc(e.Message, 2)
            mdate = ""
        End Try
        Return mdate
    End Function

    Private Sub Connn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadconnect()
    End Sub

    Sub loadconnect()
        ProgressBar1.Value = 0

        'If MessageBox.Show("Would you like to set up first or proceed?", "MT", MessageBoxButtons.YesNo) = DialogResult.Yes Then
        '    conset.ShowDialog()
        'Else
        Timer1.Enabled = True
        'End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conset.ShowDialog()
        timevalues = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        timevalues = 0
        Timer1.Enabled = True
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timevalues += 10
        Button1.Visible = False
        If timevalues = 60 Then
            mysqlstring = "server=" & My.Settings.serverdb _
                    & ";uid=" & My.Settings.userdb _
                    & ";pwd=" & My.Settings.passdb _
                    & ";database=" & My.Settings.namedb
            If CheckConnection() = True Then
                Sresult.Text = "Connection initialized"
                Me.msgboxc("Connected to the database!", 1)
                timevalues = 100
                Timer1.Enabled = False
                login.Show()
                Me.Hide()
            Else
                Button1.Show()
                timevalues = 100
            End If

        End If

        ProgressBar1.Value = timevalues / 1
        ProgressBar1.Refresh()

        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
        End If

    End Sub


    ''''''''''''''''''''''''''''''''''''''''''''''For Messages''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="message">Your message here</param>
    ''' <param name="type">1=success,2error,3yesno,4retrycancel</param>
    ''' <returns></returns>
    Function msgboxc(message As String, type As Integer) As Boolean
        Dim result As Boolean = False
        If type = 1 Then
            MessageBox.Show(message, "MT", MessageBoxButtons.OK, MessageBoxIcon.Information)
            result = True
        ElseIf type = 2 Then
            MessageBox.Show(message, "MT", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            result = True
        ElseIf type = 3 Then
            If MessageBox.Show(message, "MT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                result = True
            Else
                result = False
            End If
        ElseIf type = 4 Then
            If MessageBox.Show(message, "MT", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = DialogResult.Retry Then
                result = True
            Else
                result = False
            End If
        End If

        Return result
    End Function


    ''''''''''''''''''''''''''''''''''connection queries starts here'''''''''''''''''''''''''''''''''''''''
    ''' <summary>
    ''' to check the connection if its valid or not
    ''' </summary>
    ''' <returns></returns>
    Public Function CheckConnection() As Boolean
        Dim result As Boolean
        result = False
        mysqlcon = New MySqlConnection
        Dim querystring = "Select * from user_accounts"
        Try
            mysqlcon.ConnectionString = mysqlstring
            mysqlcon.Open()

            command = New MySqlCommand(querystring, mysqlcon)
            command.ExecuteNonQuery()

            mysqlcon.Close()
            result = True
        Catch ex As Exception
            erroor = ex.Message
            result = False
        End Try

        Sresult.Text = erroor
        Return result
    End Function

    Public Function login_signin() As Boolean
        Dim result As Boolean = False

        Return result
    End Function

    ''' <summary>
    ''' This node will give you the power to get any table information needed "SELECT " + selection + " FROM `" + tablename + "` " + additionalParam + ""
    ''' </summary>
    ''' <param name="selection">the select param of SQL eg. [`username`,`password`,`firstname`,`lastname`]</param>
    ''' <param name="tablename">the name of the table eg. [`table_name`]</param>
    ''' <param name="additionalParam">any aditional parameter you will need eg. [Where `Availability` = 'true']</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function sql_selectdatafromtable(ByVal selection, ByVal tablename, ByVal additionalParam) As DataTable
        sqlstring = mysqlstring
        Dim data As New DataTable
        Dim mysqlcon = New MySqlConnection
        Dim sqlStringnew = "SELECT " + selection + " FROM `" + tablename + "` " + additionalParam + ""
        Try

            mysqlcon.ConnectionString = sqlstring
            mysqlcon.Open()


            command = New MySqlCommand(sqlStringnew, mysqlcon)
            dataadapter = New MySqlDataAdapter(command)

            dataadapter.Fill(data)

            mysqlcon.Close()

        Catch ex As Exception
            msgboxc("" + ex.Message, 2)
        End Try

        Return data
    End Function


    ''' <summary>
    ''' this node will set or insert Data to the table you specified "INSERT INTO `table`(columntext) VALUES (values)"
    ''' </summary>
    ''' <param name="tablename"> The table name that you want to change eg. [table_name]</param>
    ''' <param name="columnText"> the columns that you need eg. [`username`,`password`]</param>
    ''' <param name="ValuesText"> the values that you want to insert in the columns eg ['usernameofmine','passwordofmine']</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function sql_insertdatatotable(ByVal tablename, ByVal columnText, ByVal ValuesText) As Boolean
        sqlString = mysqlstring
        Dim mysqlcon = New MySqlConnection
        Dim sqlStringNew = "INSERT INTO `@table`(@columntext) VALUES (@values)"
        sqlStringNew = sqlStringNew.Replace("@table", tablename)
        sqlStringNew = sqlStringNew.Replace("@columntext", columnText)
        sqlStringNew = sqlStringNew.Replace("@values", ValuesText)
        command = New MySqlCommand()
        Dim status = False
        Try
            mysqlcon.ConnectionString = sqlString
            mysqlcon.Open()

            command = New MySqlCommand(sqlStringNew, mysqlcon)
            command.ExecuteNonQuery()

            mysqlcon.Close()
            status = True
        Catch ex As Exception
            msgboxc("" + ex.Message, 2)
            status = False
        End Try

        Return status
    End Function


    ''' <summary>
    ''' This node will remove an row in the given database by the id "DELETE FROM `@table` WHERE `@table`.`id` = @id"
    ''' </summary>
    ''' <param name="tablename"></param>
    ''' <param name="id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function sql_removeitemfromDatabase(ByVal tablename, ByVal id) As Boolean
        sqlString = mysqlstring
        Dim mysqlcon = New MySqlConnection
        Dim mysqlStringNew = "DELETE FROM `@table` WHERE `@table`.`id` = @id"
        mysqlStringNew = mysqlStringNew.Replace("@table", tablename)
        mysqlStringNew = mysqlStringNew.Replace("@id", id)
        Dim status = False
        Try
            mysqlcon.ConnectionString = sqlString
            mysqlcon.Open()

            command = New MySqlCommand(mysqlStringNew, mysqlcon)
            command.ExecuteNonQuery()

            mysqlcon.Close()
            status = True
        Catch ex As Exception
            msgboxc("" + ex.Message, 2)
            status = False
        End Try
        Return status
    End Function



    ''' <summary>
    ''' This will give you the power to alter datas in any tables in the database "UPDATE `#table` SET #values Where `id`='$rowId'"
    ''' </summary>
    ''' <param name="tablename">table name eg. [users_table]</param>
    ''' <param name="rowId">Table Id eg [1]</param>
    ''' <param name="ValueString">Strings to actually replace the row eg. [`id`='5',`username`='4',`password`='3',`firstname`='2',`lastname`='1']</param>
    ''' <returns>Returns True of successful or False if not</returns>
    ''' <remarks></remarks>
    Function sql_changeValueRowtableByID(ByVal tablename As String, ByVal ValueString As String, ByVal rowId As String) As Boolean
        sqlString = mysqlstring
        Dim mysqlcon = New MySqlConnection
        Dim sqlStringNew = "UPDATE `#table` SET #values Where `id`='#rowId'"
        sqlStringNew = sqlStringNew.Replace("#table", tablename)
        sqlStringNew = sqlStringNew.Replace("#values", ValueString)
        sqlStringNew = sqlStringNew.Replace("#rowId", rowId)
        Dim result As Boolean

        Try
            mysqlcon.ConnectionString = sqlString
            mysqlcon.Open()
            command = New MySqlCommand(sqlStringNew, mysqlcon)
            command.ExecuteNonQuery()
            mysqlcon.Close()
            result = True
        Catch ex As Exception
            msgboxc("" + ex.Message, 2)
            result = False
        End Try

        Return result
    End Function

    ''' <summary>
    ''' This will give you access to mysqlcommands directly to server but it cant receive data or retrieve any information
    ''' </summary>
    ''' <param name="cussqlstring">You Mysql command here</param>
    ''' <returns></returns>
    Function sql_customSQLCOMMAND(ByVal cussqlstring As String) As Boolean
        Dim status As Boolean
        sqlString = mysqlstring
        Dim mysqlcon = New MySqlConnection
        Try
            mysqlcon.ConnectionString = sqlString
            mysqlcon.Open()
            command = New MySqlCommand(cussqlstring, mysqlcon)
            command.ExecuteNonQuery()
            mysqlcon.Close()
            status = True
        Catch ex As Exception
            msgboxc("" + ex.Message, 2)
            status = False
        End Try

        Return status
    End Function
    Function sql_customSQLCOMMAND_select(ByVal cussqlstring As String) As DataTable

        Dim status As DataTable = New DataTable
        sqlString = mysqlstring
        Dim mysqlcon = New MySqlConnection
        Try
            mysqlcon.ConnectionString = sqlString
            mysqlcon.Open()


            command = New MySqlCommand(cussqlstring, mysqlcon)
            dataadapter = New MySqlDataAdapter(command)

            dataadapter.Fill(status)

            mysqlcon.Close()
        Catch ex As Exception
            msgboxc("" + ex.Message, 2)
        End Try

        Return status
    End Function
    Function sql_customSQLCOMMAND_select(ByVal cussqlstring As String, i As Integer) As DataTable
        Dim mysqlstring As String = "server=" & My.Settings.serverdb _
                    & ";uid=" & My.Settings.userdb _
                    & ";pwd=" & My.Settings.passdb _
                    & ";database=information_schema"
        Dim status As DataTable = New DataTable
        sqlString = mysqlstring
        Dim mysqlcon = New MySqlConnection
        Try
            mysqlcon.ConnectionString = sqlString
            mysqlcon.Open()


            command = New MySqlCommand(cussqlstring, mysqlcon)
            dataadapter = New MySqlDataAdapter(command)

            dataadapter.Fill(status)

            mysqlcon.Close()
        Catch ex As Exception
            msgboxc("" + ex.Message, 2)
        End Try

        Return status
    End Function
    Function sql_customSQLCOMMAND_select(ByVal cussqlstring As String, data As DataSet, tablename As String) As DataSet
        Dim status As New DataSet
        status = data
        sqlString = mysqlstring
        Dim mysqlcon = New MySqlConnection
        Try
            mysqlcon.ConnectionString = sqlString
            mysqlcon.Open()


            command = New MySqlCommand(cussqlstring, mysqlcon)
            dataadapter = New MySqlDataAdapter(command)

            dataadapter.Fill(status, tablename)

            mysqlcon.Close()
        Catch ex As Exception
            msgboxc("" + ex.Message, 2)
        End Try

        Return status
    End Function

    Function sql_dataItemget(ByVal sel As String, ByVal table As String, ByVal id As String) As String
        Dim str = ""
        Try
            Dim data = Me.sql_selectdatafromtable(sel, table, "WHERE `id` = " & id)

            str = data.Rows(0)(0)
        Catch ex As Exception
            str = ""
        End Try

        Return str
    End Function


    Function checkAdmin() As Boolean
        Dim admin = False
        If (Me.sql_dataItemget("rights", "user_accounts", My.Settings.myuserid) = "1") Then
            admin = True
        End If
        Return admin
    End Function
End Class