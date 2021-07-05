Public Class functions_adjustment
    Public Sub removefromorder(ispahabol As Boolean, prodid As Integer, quantity As Integer, branchid As Integer, dateOfOrder As Date, type As String, note As String)
        Dim table As String = "trans_order"
        Dim value As Decimal
        If ispahabol = True Then 'kung pahabol

            table = "trans_pahabol_on"

        Else 'kung hindi pahabol

            table = "trans_order"

        End If
        Dim qty, qty2 As Decimal
        If table = "trans_pahabol_on" Then
            connn.msgboxc("Changing the pahabol order is too complicated, Your programer adviced that only the STS will be changed", 2)
        Else

            qty = connn.sql_dataItemget("qty", table, "id and branch = " & branchid & " and prod = " & prodid & " and date = '" & connn.datetoquery(dateOfOrder) & "' limit 1")

            Dim data As DataTable = connn.sql_selectdatafromtable("qty", table, "Where branch = " & branchid & " and prod = " & prodid & " and date = '" & connn.datetoquery(dateOfOrder) & "'")
            If Not data.Rows.Count < 1 Then
                For row As Integer = 0 To data.Rows.Count - 1
                    qty2 += Decimal.Parse(data.Rows(row)(0))
                Next

                value = quantity - (qty2 - qty)
            Else
                value = quantity
            End If

            Dim sqlcommandstring As String = "update " & table & " set qty = " & value & " Where branch = " & branchid & " and prod = " & prodid & " and date = '" & connn.datetoquery(dateOfOrder) & "' limit 1"

            Dim isadded As Boolean = False

            If qty <= quantity Then
                isadded = True
            End If

            If reportadjustment(type, branchid, connn.datetoquery(dateOfOrder.ToShortDateString), "Forecast N/A", prodid, qty, quantity, table, note, isadded) Then
                connn.sql_customSQLCOMMAND(sqlcommandstring)
                connn.msgboxc("Adjustment Successfully Changed!", 1)
            End If
        End If

    End Sub

    Public Sub removefromsts(id1stdel? As Boolean, isPahabol As Boolean, prodid As Integer, quantity As Integer, branchid As Integer, dateOfOrder As Date, type As String, note As String, batch As String)
        Dim clause As String
        stsdel = "pa"

        Dim value As Decimal

        If id1stdel And isPahabol = False Then

            stsdel = "First Delivery"

        ElseIf id1stdel = False And isPahabol = False Then

            stsdel = "Second Delivery"

        End If
        Dim curdates As Date = dateOfOrder
        If stsdel = "pa" Then
            clause = " and batch = " & batch
            curdates = dateOfOrder
        Else
            clause = ""
            curdates = DateAdd(DateInterval.Day, 1, dateOfOrder)
        End If
        Dim stsid As String = connn.stsnum(branchid, curdates, stsdel)
        Dim product As String = connn.sql_dataItemget("name", "source_product", prodid)

        Dim data As DataTable = connn.sql_customSQLCOMMAND_select("SELECT  `qty`, `unt`, `tamt` FROM `trans_sts` WHERE stsid = '" & stsid & "' and prod like '%" & product & "%' " & clause & "")

        qty = data.Rows(0)(0)
        value = quantity
        tamt = value * data.Rows(0)(1)
        Dim sqlcommandstring As String = "update trans_sts set qty = " & value & ",tamt = " & tamt & " Where stsid = '" & stsid & "' and prod like '%" & product & "%' " & clause & " limit 1"

        Dim isadded As Boolean = False
        If qty <= quantity Then
            isadded = True
        End If
        If stsdel = "pa" Then
            stsdel = "Pahabol"
        End If

        If reportadjustment(type, branchid, connn.datetoquery(curdates.ToShortDateString), stsid, prodid, qty, quantity, stsdel, note, isadded) Then
            connn.sql_customSQLCOMMAND(sqlcommandstring)
            connn.msgboxc("Adjustment Successfully Changed!", 1)
        End If
    End Sub

    ''' <summary>
    ''' will return 3 if only the sts and not at the order is available 4 if the with sts is true but only the order is available
    ''' </summary>
    ''' <param name="id1stdel"></param>
    ''' <param name="isPahabol"></param>
    ''' <param name="haveSTS"></param>
    ''' <param name="curdate"></param>
    ''' <param name="branchid"></param>
    ''' <param name="prodid"></param>
    ''' <returns></returns>
    Public Function checkForItemsInGivenDetails(id1stdel? As Boolean, isPahabol As Boolean, haveSTS? As Boolean, curdate As Date, branchid As Integer, prodid As Integer, batch As Integer) As Integer
        Dim result As Integer = 0
        Dim sts, order As Boolean
        Dim table, stsdel As String
        table = "trans_order"
        stsdel = "pa"
        If Not prodid = 0 Then
            If isPahabol Then

                table = "trans_pahabol_on"

            End If

            If haveSTS Then

                If id1stdel And isPahabol = False Then

                    stsdel = "01"

                ElseIf id1stdel = False And isPahabol = False Then

                    stsdel = "Second Delivery"

                End If
                Dim curdates As Date = curdate
                If stsdel = "pa" Then
                    clause = " and batch = " & batch
                    curdates = curdate
                Else
                    curdates = DateAdd(DateInterval.Day, 1, curdate)
                End If
                Dim stsid As String = connn.stsnum(branchid, curdates, stsdel)
                Dim product As String = connn.sql_dataItemget("name", "source_product", prodid)

                Dim data As DataTable = connn.sql_customSQLCOMMAND_select("SELECT * FROM `trans_sts` WHERE stsid = '" & stsid & "' and prod like '%" & product & "%' " & clause & " limit 1")
                If data.Rows.Count = 0 Then
                    sts = False
                Else sts = True
                End If
            End If

            Dim sqlstringfororder As String = "SELECT * FROM `" & table & "` where date = '" & connn.datetoquery(curdate) & "' and branch = " & branchid & " and prod = " & prodid & " limit 1"
            Dim dateorder As DataTable = connn.sql_customSQLCOMMAND_select(sqlstringfororder)
            If dateorder.Rows.Count = 0 Then
                order = False
            Else
                order = True
            End If

            If haveSTS Then
                If sts And order Then
                    result = 2
                ElseIf sts And order = False Then
                    result = 3
                End If
            Else
                If order And sts = False Then
                    result = 4
                Else
                    result = 1
                End If
            End If
        Else
            connn.msgboxc("You haven't selected a product as a reference", 2)
            result = 1
        End If

        Return result
    End Function

    Function reportadjustment(adjusttype As String, branch As Integer, qdate As String, stsid As String, prodid As Integer, preqty As Integer, toqty As Integer, additional As String, note As String, isadded As Boolean) As Boolean
        Dim useradjust As Integer = Integer.Parse(My.Settings.myuserid)
        Dim result As Boolean = False
        Dim mysqlstring As String = "INSERT INTO `adjustment`(`adjusttype`, `branch`, `date`, `stsid`, `prodid`, `preqty`, `toqty`, `additional`, `note`, `useradjusted`, `isadded`) VALUES ('[value-1]',[value-2],'[value-3]','[value-4]',[value-5],[value-6],[value-7],'[value-8]','[value-9]',[value-10],[value-11])"
        mysqlstring = mysqlstring.Replace("[value-1]", adjusttype)
        mysqlstring = mysqlstring.Replace("[value-2]", branch)
        mysqlstring = mysqlstring.Replace("[value-3]", qdate)
        mysqlstring = mysqlstring.Replace("[value-4]", stsid)
        mysqlstring = mysqlstring.Replace("[value-5]", prodid)
        mysqlstring = mysqlstring.Replace("[value-6]", preqty)
        mysqlstring = mysqlstring.Replace("[value-7]", toqty)
        mysqlstring = mysqlstring.Replace("[value-8]", additional)
        mysqlstring = mysqlstring.Replace("[value-9]", note)
        mysqlstring = mysqlstring.Replace("[value-10]", useradjust)
        mysqlstring = mysqlstring.Replace("[value-11]", isadded)
        If connn.sql_customSQLCOMMAND(mysqlstring) Then
            result = True
        End If
        Return result
    End Function

End Class
