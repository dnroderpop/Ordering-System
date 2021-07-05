Public Class Mainmenu
    Sub reloadform(e)
        Me.Controls.Clear()
        InitializeComponent()
        Mainmenu_Load(e, e)
    End Sub
    Private Sub Mainmenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        connn.Close()
    End Sub

    Sub reloadname()
        Dim dataforwelcome As String = "Hi "

        dataforwelcome += connn.sql_dataItemget("nickname", "user_accounts", My.Settings.myuserid)
        If (connn.checkAdmin()) Then
            dataforwelcome += " (ADMIN)"
        Else
            Dim r = connn.sql_dataItemget("rights", "user_accounts", My.Settings.myuserid)

            If r = 0 Then
                dataforwelcome += " (Guess)"
            ElseIf r = 1 Then
                dataforwelcome += " (Admin)"
            ElseIf r = 2 Then
                dataforwelcome += " (Analyst)"
            ElseIf r = 3 Then
                dataforwelcome += " (Commisarry)"
            ElseIf r = 4 Then
                dataforwelcome += " (Encoder Transaction)"
            ElseIf r = 5 Then
                dataforwelcome += " (Encoder Resources)"
            End If

        End If

            adminch(My.Settings.myuserid)

        label_welcome.Text = dataforwelcome
    End Sub
    Sub adminch(i As Integer)
        Dim right As Integer = Integer.Parse(connn.sql_dataItemget("rights", "user_accounts", My.Settings.myuserid))
        If Not right = 1 Then
            DeliveryToolStripMenuItem.Visible = False
            AssignToolStripMenuItem.Visible = False
            ProductBatchingToolStripMenuItem.Visible = False
            'inventory                                                          .visible = false
            BeginingInventoryToolStripMenuItem.Visible = False
            InventoryToolStripMenuItem.Visible = False
            InvProductsToolStripMenuItem.Visible = False
            InvRawMaterialToolStripMenuItem.Visible = False
        End If
        FileToolStripMenuItem.Visible = True
        AccountSettingsToolStripMenuItem.Visible = True


        '1 and 2
        '''''''''1 
        If right = 0 Or right = 2 Or right = 5 Then
            TransactionToolStripMenuItem.Visible = False
            NewForcastToolStripMenuItem.Visible = False
            PahabolOndayToolStripMenuItem.Visible = False
            PahabolDamageToolStripMenuItem.Visible = False
            BufferToolStripMenuItem.Visible = False
            RAWMATDeliveryToolStripMenuItem.Visible = False
            AdjustmentToolStripMenuItem.Visible = False
            LessOverItemToolStripMenuItem.Visible = False
            '''''''''2                                                .visible = False
            If Not right = 2 Then ReportsToolStripMenuItem.Visible = False
            SummaryForcastToolStripMenuItem.Visible = False
            StockTransferToolStripMenuItem.Visible = False
            ManageSTSToolStripMenuItem.Visible = False
            GenerateSTSPahabolToolStripMenuItem.Visible = False
            GenerateToolStripMenuItem.Visible = False
            GenerateProductionReportToolStripMenuItem.Visible = False
            GenerateScallingReportToolStripMenuItem.Visible = False
        End If
            '3
            If right = 0 Or right = 4 Or right = 5 Then
            ManagersReportToolStripMenuItem.Visible = False
        End If
        '4
        If right = 0 Or right = 3 Or right = 4 Or right = 5 Then
            If Not right = 5 Then ResourcesToolStripMenuItem.Visible = False
            ManageBranchToolStripMenuItem.Visible = False
            ManageProductToolStripMenuItem.Visible = False
            ManageRawMatToolStripMenuItem.Visible = False
            ManageSuppliersToolStripMenuItem.Visible = False
        End If
        '5
        If right = 0 Or right = 3 Or right = 4 Then
            ManageRecipeToolStripMenuItem.Visible = False
        End If
        '6
        If right = 0 Or right = 2 Or right = 3 Or right = 4 Or right = 5 Then
            ManagePendingAccountsadminToolStripMenuItem.Visible = False
            If Not right = 3 Then MasterProductToolStripMenuItem.Visible = False '''''''
            MasterTableToolStripMenuItem.Visible = False
        End If
        '7


    End Sub

    Private Sub Mainmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        reloadname()
        Uf_black_menu1.BringToFront()

    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        If connn.msgboxc("Are you sure to log out?", 3) Then
            Me.Hide()
            My.Settings.myuserid = ""
            login.Show()
        End If
    End Sub



    Private Sub Btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        If connn.msgboxc("Are you sure to exit?", 3) Then
            Me.Close()
            connn.Close()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Uf_black_menu1.BringToFront()
    End Sub

    Private Sub ManagePendingAccountsadminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManagePendingAccountsadminToolStripMenuItem.Click
        If connn.checkAdmin = True Then
            UF_user_manageaccounts1.BringToFront()
            UF_user_manageaccounts1.Select()
            UF_user_manageaccounts1.loadtable()
        Else
            MessageBox.Show("You are not allowed to access this!")
        End If

    End Sub

    Private Sub AccountSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountSettingsToolStripMenuItem.Click
        UF_user_accountsettings.ShowDialog()
    End Sub

    Private Sub ManageRawMatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageRawMatToolStripMenuItem.Click
        Resources_rawmat1.BringToFront()
        Resources_rawmat1.loadtable()
    End Sub

    Private Sub ManageProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageProductToolStripMenuItem.Click
        Resources_product1.BringToFront()
        Resources_product1.loadtable()
    End Sub

    Private Sub ManageBranchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageBranchToolStripMenuItem.Click
        resources_branch.ShowDialog()
    End Sub

    Private Sub ManageRecipeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageRecipeToolStripMenuItem.Click
        Resources_recipe1.BringToFront()
        Resources_recipe1.loadtable()
    End Sub

    Private Sub ManageSuppliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageSuppliersToolStripMenuItem.Click
        resources_supplier.ShowDialog()
    End Sub

    Private Sub NewForcastToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewForcastToolStripMenuItem.Click
        Trans_Forcast1.BringToFront()
        Trans_Forcast1.on_enter()
    End Sub

    Private Sub SummaryForcastToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryForcastToolStripMenuItem.Click
        Reporting_forecast1.bringtofront()
    End Sub

    Private Sub MasterTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterTableToolStripMenuItem.Click
        master_table.Show()
    End Sub

    Private Sub GenerateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateToolStripMenuItem.Click
        reporting_sts.ShowDialog()
    End Sub

    Private Sub ManageSTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageSTSToolStripMenuItem.Click
        Reporting_forecast_sts1.BringToFront()
        Reporting_forecast_sts1.select
    End Sub

    Private Sub PahabolOndayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PahabolOndayToolStripMenuItem.Click
        Trans_pahabol1.BringToFront()
        Trans_pahabol1.on_enter()
    End Sub

    Private Sub GenerateSTSPahabolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateSTSPahabolToolStripMenuItem.Click
        reporting_sts_onday.ShowDialog()
    End Sub

    Private Sub AssignToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssignToolStripMenuItem.Click
        Deliver_assign1.BringToFront()
    End Sub

    Private Sub ProductBatchingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductBatchingToolStripMenuItem.Click
        del_prod.ShowDialog()
    End Sub

    Private Sub MasterProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterProductToolStripMenuItem.Click
        Master_Product.Show()
    End Sub

    Private Sub LessOverItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LessOverItemToolStripMenuItem.Click
        adjust_lestover.Show()
    End Sub

    Private Sub ManagersReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManagersReportToolStripMenuItem.Click
        Mr_panel1.BringToFront()
    End Sub

    Private Sub Uf_black_menu1_Load(sender As Object, e As EventArgs) Handles Uf_black_menu1.Load
    End Sub

End Class