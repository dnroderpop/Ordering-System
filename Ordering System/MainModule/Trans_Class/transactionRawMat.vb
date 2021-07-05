Public Class transactionRawMat
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="product"></param>
    ''' <param name="qty"></param>
    ''' <param name="modules">order,buff,pahbd,pahbo,supp</param>
    ''' <param name="dates"></param>
    ''' <param name="num"></param>
    Sub queryme(product As String, qty As String, modules As String, dates As String, num As String)
        qty = qty / Double.Parse(connn.sql_dataItemget("yielding", "source_product", product))
        Dim total As Double
        Dim mdate As String = CDate(dates).ToString("yyyy-MM-dd")
        Dim datarecipe As DataTable = connn.sql_customSQLCOMMAND_select("SELECT * FROM `source_recipe` where `prodid` = " & product)
        Dim tablename, columns, value As String
        For i As Integer = 0 To datarecipe.Rows.Count - 1
            rawmats = datarecipe.Rows(i)(2)
            total = qty * datarecipe.Rows(i)(4)
            tablename = "trans_rawmat"
            columns = "`prod`, `rawmat`, `qty`, `module`, `date`,`trans_number`"
            value = "[value-1],'[value-2]',[value-3],'[value-4]','[value-5]'," & num
            value = value.Replace("[value-1]", product)
            value = value.Replace("[value-2]", rawmats)
            value = value.Replace("[value-3]", total)
            value = value.Replace("[value-4]", modules)
            value = value.Replace("[value-5]", mdate)
            connn.sql_insertdatatotable(tablename, columns, value)
        Next


    End Sub

    ''' <summary>
    ''' Returns the Transaction Number for desired module
    ''' </summary>
    ''' <param name="trans">options are order,buff,pahbd,pahbo,supp</param>
    ''' <returns></returns>
    Function return_trans_number(ByVal trans As String) As String
        Dim number As Integer
        Dim result As String = ""
        number = -1
        Select Case trans
            Case "order"
                number = Integer.Parse(connn.sql_dataItemget("order_num", "settings_trans", 1))
            Case "buff"
                number = Integer.Parse(connn.sql_dataItemget("buffer_num", "settings_trans", 1))
            Case "pahbd"
                number = Integer.Parse(connn.sql_dataItemget("pahabold_num", "settings_trans", 1))
            Case "pahbo"
                number = Integer.Parse(connn.sql_dataItemget("pahabolo_num", "settings_trans", 1))
            Case "supp"
                number = Integer.Parse(connn.sql_dataItemget("supplier_num", "settings_trans", 1))
            Case Else
                number = 0
        End Select
        result = String.Format("{0: 0000000}", number)

        Return result
    End Function

End Class
