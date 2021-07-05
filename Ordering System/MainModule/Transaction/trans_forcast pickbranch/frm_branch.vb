Public Class frm_branch
    Public pick As String
    Private Sub frm_branch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim data As DataTable
        table_prod.ClearSelection()
        table_prod.Rows.Clear()
        data = connn.sql_selectdatafromtable("*", "source_branch", "where able = 1")
        Try

            If Not data.Rows.Count = 0 Then

                Dim i As Integer = 0
                While i < data.Rows.Count

                    table_prod.Rows.Add({data.Rows(i)(0).ToString, data.Rows(i)(1).ToString})

                    i += 1
                End While

            End If
        Catch ex As Exception
            Me.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = DialogResult.Yes
        Mainmenu.Trans_Forcast1.lb_branch.Text = pick
    End Sub

    Private Sub table_prod_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles table_prod.CellClick
        Dim i As Integer
        Try
            i = table_prod.CurrentRow.Index
            table_prod.CurrentRow.Selected = True
            If (i >= 0) Then
                pick = table_prod.Item(1, i).Value
                Button2.Visible = True
            Else
                table_prod.ClearSelection()
                table_prod.Rows.Clear()
            End If
        Catch ex As Exception
            table_prod.ClearSelection()
            table_prod.Rows.Clear()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DialogResult = DialogResult.Ignore
    End Sub
End Class