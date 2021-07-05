<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mainmenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mainmenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewForcastToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PahabolOndayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PahabolDamageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BufferToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RAWMATDeliveryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdjustmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LessOverItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryForcastToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockTransferToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageSTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateSTSPahabolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateScallingReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateProductionReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManagersReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeliveryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssignToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductBatchingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvRawMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeginingInventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResourcesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageRawMatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageRecipeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageBranchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageSuppliersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManagePendingAccountsadminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelBackground = New System.Windows.Forms.Panel()
        Me.Uf_black_menu1 = New Ordering_System.uf_black_menu()
        Me.UF_user_manageaccounts1 = New Ordering_System.UF_user_manageaccounts()
        Me.Resources_product1 = New Ordering_System.resources_product()
        Me.Resources_rawmat1 = New Ordering_System.resources_rawmat()
        Me.Resources_recipe1 = New Ordering_System.resources_recipe()
        Me.Trans_Forcast1 = New Ordering_System.trans_Forcast()
        Me.Reporting_forecast1 = New Ordering_System.reporting_forecast()
        Me.Reporting_forecast_sts1 = New Ordering_System.reporting_forecast_sts()
        Me.Trans_pahabol1 = New Ordering_System.trans_pahabol()
        Me.Deliver_assign1 = New Ordering_System.deliver_assign()
        Me.Mr_panel1 = New Ordering_System.mr_panel()
        Me.label_welcome = New System.Windows.Forms.Label()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SecurityLogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelBackground.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.MintCream
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransactionToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.DeliveryToolStripMenuItem, Me.InventoryToolStripMenuItem, Me.ResourcesToolStripMenuItem, Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 163)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1022, 52)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewForcastToolStripMenuItem, Me.PahabolOndayToolStripMenuItem, Me.PahabolDamageToolStripMenuItem, Me.BufferToolStripMenuItem, Me.RAWMATDeliveryToolStripMenuItem, Me.AdjustmentToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!)
        Me.TransactionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TransactionToolStripMenuItem.Image = Global.Ordering_System.My.Resources.Resources.shopping_basket
        Me.TransactionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(194, 48)
        Me.TransactionToolStripMenuItem.Text = "Transactions"
        '
        'NewForcastToolStripMenuItem
        '
        Me.NewForcastToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.NewForcastToolStripMenuItem.Image = Global.Ordering_System.My.Resources.Resources.edit_property
        Me.NewForcastToolStripMenuItem.Name = "NewForcastToolStripMenuItem"
        Me.NewForcastToolStripMenuItem.Size = New System.Drawing.Size(217, 28)
        Me.NewForcastToolStripMenuItem.Text = "New Forcast"
        '
        'PahabolOndayToolStripMenuItem
        '
        Me.PahabolOndayToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.PahabolOndayToolStripMenuItem.Image = Global.Ordering_System.My.Resources.Resources.add_property
        Me.PahabolOndayToolStripMenuItem.Name = "PahabolOndayToolStripMenuItem"
        Me.PahabolOndayToolStripMenuItem.Size = New System.Drawing.Size(217, 28)
        Me.PahabolOndayToolStripMenuItem.Text = "Pahabol | On day"
        '
        'PahabolDamageToolStripMenuItem
        '
        Me.PahabolDamageToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.PahabolDamageToolStripMenuItem.Image = Global.Ordering_System.My.Resources.Resources.add_property
        Me.PahabolDamageToolStripMenuItem.Name = "PahabolDamageToolStripMenuItem"
        Me.PahabolDamageToolStripMenuItem.Size = New System.Drawing.Size(217, 28)
        Me.PahabolDamageToolStripMenuItem.Text = "Pahabol | Damage"
        '
        'BufferToolStripMenuItem
        '
        Me.BufferToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.BufferToolStripMenuItem.Image = Global.Ordering_System.My.Resources.Resources.add_property
        Me.BufferToolStripMenuItem.Name = "BufferToolStripMenuItem"
        Me.BufferToolStripMenuItem.Size = New System.Drawing.Size(217, 28)
        Me.BufferToolStripMenuItem.Text = "Buffer"
        '
        'RAWMATDeliveryToolStripMenuItem
        '
        Me.RAWMATDeliveryToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.RAWMATDeliveryToolStripMenuItem.Image = Global.Ordering_System.My.Resources.Resources.package
        Me.RAWMATDeliveryToolStripMenuItem.Name = "RAWMATDeliveryToolStripMenuItem"
        Me.RAWMATDeliveryToolStripMenuItem.Size = New System.Drawing.Size(217, 28)
        Me.RAWMATDeliveryToolStripMenuItem.Text = "Raw Mat Delivery"
        '
        'AdjustmentToolStripMenuItem
        '
        Me.AdjustmentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LessOverItemToolStripMenuItem})
        Me.AdjustmentToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.AdjustmentToolStripMenuItem.Image = Global.Ordering_System.My.Resources.Resources.combo
        Me.AdjustmentToolStripMenuItem.Name = "AdjustmentToolStripMenuItem"
        Me.AdjustmentToolStripMenuItem.Size = New System.Drawing.Size(217, 28)
        Me.AdjustmentToolStripMenuItem.Text = "Adjustment"
        '
        'LessOverItemToolStripMenuItem
        '
        Me.LessOverItemToolStripMenuItem.Name = "LessOverItemToolStripMenuItem"
        Me.LessOverItemToolStripMenuItem.Size = New System.Drawing.Size(271, 28)
        Me.LessOverItemToolStripMenuItem.Text = "Less Over Stock Adjustment"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SummaryForcastToolStripMenuItem, Me.StockTransferToolStripMenuItem, Me.GenerateScallingReportToolStripMenuItem, Me.GenerateProductionReportToolStripMenuItem, Me.ManagersReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!)
        Me.ReportsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ReportsToolStripMenuItem.Image = Global.Ordering_System.My.Resources.Resources.purchase_order
        Me.ReportsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(143, 48)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'SummaryForcastToolStripMenuItem
        '
        Me.SummaryForcastToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.SummaryForcastToolStripMenuItem.Image = Global.Ordering_System.My.Resources.Resources.purchase_order
        Me.SummaryForcastToolStripMenuItem.Name = "SummaryForcastToolStripMenuItem"
        Me.SummaryForcastToolStripMenuItem.Size = New System.Drawing.Size(276, 28)
        Me.SummaryForcastToolStripMenuItem.Text = "Summary"
        '
        'StockTransferToolStripMenuItem
        '
        Me.StockTransferToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageSTSToolStripMenuItem, Me.GenerateToolStripMenuItem, Me.GenerateSTSPahabolToolStripMenuItem})
        Me.StockTransferToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.StockTransferToolStripMenuItem.Image = CType(resources.GetObject("StockTransferToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StockTransferToolStripMenuItem.Name = "StockTransferToolStripMenuItem"
        Me.StockTransferToolStripMenuItem.Size = New System.Drawing.Size(276, 28)
        Me.StockTransferToolStripMenuItem.Text = "Stock Transfer"
        '
        'ManageSTSToolStripMenuItem
        '
        Me.ManageSTSToolStripMenuItem.Name = "ManageSTSToolStripMenuItem"
        Me.ManageSTSToolStripMenuItem.Size = New System.Drawing.Size(246, 28)
        Me.ManageSTSToolStripMenuItem.Text = "Manage STS"
        '
        'GenerateToolStripMenuItem
        '
        Me.GenerateToolStripMenuItem.Name = "GenerateToolStripMenuItem"
        Me.GenerateToolStripMenuItem.Size = New System.Drawing.Size(246, 28)
        Me.GenerateToolStripMenuItem.Text = "Generate STS"
        '
        'GenerateSTSPahabolToolStripMenuItem
        '
        Me.GenerateSTSPahabolToolStripMenuItem.Name = "GenerateSTSPahabolToolStripMenuItem"
        Me.GenerateSTSPahabolToolStripMenuItem.Size = New System.Drawing.Size(246, 28)
        Me.GenerateSTSPahabolToolStripMenuItem.Text = "Generate STS (Pahabol)"
        '
        'GenerateScallingReportToolStripMenuItem
        '
        Me.GenerateScallingReportToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.GenerateScallingReportToolStripMenuItem.Image = CType(resources.GetObject("GenerateScallingReportToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GenerateScallingReportToolStripMenuItem.Name = "GenerateScallingReportToolStripMenuItem"
        Me.GenerateScallingReportToolStripMenuItem.Size = New System.Drawing.Size(276, 28)
        Me.GenerateScallingReportToolStripMenuItem.Text = "Generate Scalling Report"
        '
        'GenerateProductionReportToolStripMenuItem
        '
        Me.GenerateProductionReportToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.GenerateProductionReportToolStripMenuItem.Image = CType(resources.GetObject("GenerateProductionReportToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GenerateProductionReportToolStripMenuItem.Name = "GenerateProductionReportToolStripMenuItem"
        Me.GenerateProductionReportToolStripMenuItem.Size = New System.Drawing.Size(276, 28)
        Me.GenerateProductionReportToolStripMenuItem.Text = "Generate Production Report"
        '
        'ManagersReportToolStripMenuItem
        '
        Me.ManagersReportToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.ManagersReportToolStripMenuItem.Image = Global.Ordering_System.My.Resources.Resources.pencil
        Me.ManagersReportToolStripMenuItem.Name = "ManagersReportToolStripMenuItem"
        Me.ManagersReportToolStripMenuItem.Size = New System.Drawing.Size(276, 28)
        Me.ManagersReportToolStripMenuItem.Text = "Managers Report"
        '
        'DeliveryToolStripMenuItem
        '
        Me.DeliveryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AssignToolStripMenuItem, Me.ProductBatchingToolStripMenuItem})
        Me.DeliveryToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!)
        Me.DeliveryToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.DeliveryToolStripMenuItem.Image = Global.Ordering_System.My.Resources.Resources.users
        Me.DeliveryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DeliveryToolStripMenuItem.Name = "DeliveryToolStripMenuItem"
        Me.DeliveryToolStripMenuItem.Size = New System.Drawing.Size(145, 48)
        Me.DeliveryToolStripMenuItem.Text = "Delivery"
        '
        'AssignToolStripMenuItem
        '
        Me.AssignToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.AssignToolStripMenuItem.Name = "AssignToolStripMenuItem"
        Me.AssignToolStripMenuItem.Size = New System.Drawing.Size(203, 28)
        Me.AssignToolStripMenuItem.Text = "Assign Delivery"
        '
        'ProductBatchingToolStripMenuItem
        '
        Me.ProductBatchingToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.ProductBatchingToolStripMenuItem.Name = "ProductBatchingToolStripMenuItem"
        Me.ProductBatchingToolStripMenuItem.Size = New System.Drawing.Size(203, 28)
        Me.ProductBatchingToolStripMenuItem.Text = "Product Batching"
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InvRawMaterialToolStripMenuItem, Me.InvProductsToolStripMenuItem, Me.BeginingInventoryToolStripMenuItem})
        Me.InventoryToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!)
        Me.InventoryToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.InventoryToolStripMenuItem.Image = Global.Ordering_System.My.Resources.Resources.package
        Me.InventoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(158, 48)
        Me.InventoryToolStripMenuItem.Text = "Inventory"
        '
        'InvRawMaterialToolStripMenuItem
        '
        Me.InvRawMaterialToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.InvRawMaterialToolStripMenuItem.Name = "InvRawMaterialToolStripMenuItem"
        Me.InvRawMaterialToolStripMenuItem.Size = New System.Drawing.Size(214, 28)
        Me.InvRawMaterialToolStripMenuItem.Text = "Inv | Raw Material"
        '
        'InvProductsToolStripMenuItem
        '
        Me.InvProductsToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.InvProductsToolStripMenuItem.Name = "InvProductsToolStripMenuItem"
        Me.InvProductsToolStripMenuItem.Size = New System.Drawing.Size(214, 28)
        Me.InvProductsToolStripMenuItem.Text = "Inv | Products"
        '
        'BeginingInventoryToolStripMenuItem
        '
        Me.BeginingInventoryToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.BeginingInventoryToolStripMenuItem.Name = "BeginingInventoryToolStripMenuItem"
        Me.BeginingInventoryToolStripMenuItem.Size = New System.Drawing.Size(214, 28)
        Me.BeginingInventoryToolStripMenuItem.Text = "Begining Inventory"
        '
        'ResourcesToolStripMenuItem
        '
        Me.ResourcesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageRawMatToolStripMenuItem, Me.ManageProductToolStripMenuItem, Me.ManageRecipeToolStripMenuItem, Me.ManageBranchToolStripMenuItem, Me.ManageSuppliersToolStripMenuItem})
        Me.ResourcesToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!)
        Me.ResourcesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ResourcesToolStripMenuItem.Image = Global.Ordering_System.My.Resources.Resources.filled_box
        Me.ResourcesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ResourcesToolStripMenuItem.Name = "ResourcesToolStripMenuItem"
        Me.ResourcesToolStripMenuItem.Size = New System.Drawing.Size(171, 48)
        Me.ResourcesToolStripMenuItem.Text = "Resources"
        '
        'ManageRawMatToolStripMenuItem
        '
        Me.ManageRawMatToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.ManageRawMatToolStripMenuItem.Name = "ManageRawMatToolStripMenuItem"
        Me.ManageRawMatToolStripMenuItem.Size = New System.Drawing.Size(209, 28)
        Me.ManageRawMatToolStripMenuItem.Text = "Manage Raw Mat"
        '
        'ManageProductToolStripMenuItem
        '
        Me.ManageProductToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.ManageProductToolStripMenuItem.Name = "ManageProductToolStripMenuItem"
        Me.ManageProductToolStripMenuItem.Size = New System.Drawing.Size(209, 28)
        Me.ManageProductToolStripMenuItem.Text = "Manage Product"
        '
        'ManageRecipeToolStripMenuItem
        '
        Me.ManageRecipeToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.ManageRecipeToolStripMenuItem.Name = "ManageRecipeToolStripMenuItem"
        Me.ManageRecipeToolStripMenuItem.Size = New System.Drawing.Size(209, 28)
        Me.ManageRecipeToolStripMenuItem.Text = "Manage Recipe"
        '
        'ManageBranchToolStripMenuItem
        '
        Me.ManageBranchToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.ManageBranchToolStripMenuItem.Name = "ManageBranchToolStripMenuItem"
        Me.ManageBranchToolStripMenuItem.Size = New System.Drawing.Size(209, 28)
        Me.ManageBranchToolStripMenuItem.Text = "Manage Branch"
        '
        'ManageSuppliersToolStripMenuItem
        '
        Me.ManageSuppliersToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.ManageSuppliersToolStripMenuItem.Name = "ManageSuppliersToolStripMenuItem"
        Me.ManageSuppliersToolStripMenuItem.Size = New System.Drawing.Size(209, 28)
        Me.ManageSuppliersToolStripMenuItem.Text = "Manage Suppliers"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManagePendingAccountsadminToolStripMenuItem, Me.AccountSettingsToolStripMenuItem, Me.MasterTableToolStripMenuItem, Me.MasterProductToolStripMenuItem, Me.SecurityLogsToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!)
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.FileToolStripMenuItem.Image = Global.Ordering_System.My.Resources.Resources.administrator
        Me.FileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(120, 48)
        Me.FileToolStripMenuItem.Text = "Users"
        Me.FileToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ManagePendingAccountsadminToolStripMenuItem
        '
        Me.ManagePendingAccountsadminToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManagePendingAccountsadminToolStripMenuItem.Image = Global.Ordering_System.My.Resources.Resources.users
        Me.ManagePendingAccountsadminToolStripMenuItem.Name = "ManagePendingAccountsadminToolStripMenuItem"
        Me.ManagePendingAccountsadminToolStripMenuItem.Size = New System.Drawing.Size(326, 34)
        Me.ManagePendingAccountsadminToolStripMenuItem.Text = "Manage Pending Accounts (admin)"
        '
        'AccountSettingsToolStripMenuItem
        '
        Me.AccountSettingsToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountSettingsToolStripMenuItem.Image = Global.Ordering_System.My.Resources.Resources.edit_image_512
        Me.AccountSettingsToolStripMenuItem.Name = "AccountSettingsToolStripMenuItem"
        Me.AccountSettingsToolStripMenuItem.Size = New System.Drawing.Size(326, 34)
        Me.AccountSettingsToolStripMenuItem.Text = "Account settings"
        '
        'MasterTableToolStripMenuItem
        '
        Me.MasterTableToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterTableToolStripMenuItem.Name = "MasterTableToolStripMenuItem"
        Me.MasterTableToolStripMenuItem.Size = New System.Drawing.Size(326, 34)
        Me.MasterTableToolStripMenuItem.Text = "Master Table"
        '
        'MasterProductToolStripMenuItem
        '
        Me.MasterProductToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!)
        Me.MasterProductToolStripMenuItem.Name = "MasterProductToolStripMenuItem"
        Me.MasterProductToolStripMenuItem.Size = New System.Drawing.Size(326, 34)
        Me.MasterProductToolStripMenuItem.Text = "Master Product"
        '
        'PanelBackground
        '
        Me.PanelBackground.BackColor = System.Drawing.Color.Azure
        Me.PanelBackground.Controls.Add(Me.Uf_black_menu1)
        Me.PanelBackground.Controls.Add(Me.UF_user_manageaccounts1)
        Me.PanelBackground.Controls.Add(Me.Resources_product1)
        Me.PanelBackground.Controls.Add(Me.Resources_rawmat1)
        Me.PanelBackground.Controls.Add(Me.Resources_recipe1)
        Me.PanelBackground.Controls.Add(Me.Trans_Forcast1)
        Me.PanelBackground.Controls.Add(Me.Reporting_forecast1)
        Me.PanelBackground.Controls.Add(Me.Reporting_forecast_sts1)
        Me.PanelBackground.Controls.Add(Me.Trans_pahabol1)
        Me.PanelBackground.Controls.Add(Me.Deliver_assign1)
        Me.PanelBackground.Controls.Add(Me.Mr_panel1)
        Me.PanelBackground.Location = New System.Drawing.Point(0, 216)
        Me.PanelBackground.Name = "PanelBackground"
        Me.PanelBackground.Size = New System.Drawing.Size(1367, 522)
        Me.PanelBackground.TabIndex = 2
        '
        'Uf_black_menu1
        '
        Me.Uf_black_menu1.BackColor = System.Drawing.Color.MintCream
        Me.Uf_black_menu1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Uf_black_menu1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Uf_black_menu1.Location = New System.Drawing.Point(0, 0)
        Me.Uf_black_menu1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Uf_black_menu1.Name = "Uf_black_menu1"
        Me.Uf_black_menu1.Size = New System.Drawing.Size(1367, 522)
        Me.Uf_black_menu1.TabIndex = 1
        '
        'UF_user_manageaccounts1
        '
        Me.UF_user_manageaccounts1.BackColor = System.Drawing.Color.Azure
        Me.UF_user_manageaccounts1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UF_user_manageaccounts1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UF_user_manageaccounts1.Location = New System.Drawing.Point(0, 0)
        Me.UF_user_manageaccounts1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UF_user_manageaccounts1.Name = "UF_user_manageaccounts1"
        Me.UF_user_manageaccounts1.Size = New System.Drawing.Size(1367, 522)
        Me.UF_user_manageaccounts1.TabIndex = 0
        '
        'Resources_product1
        '
        Me.Resources_product1.BackColor = System.Drawing.Color.Azure
        Me.Resources_product1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Resources_product1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resources_product1.Location = New System.Drawing.Point(0, 0)
        Me.Resources_product1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Resources_product1.Name = "Resources_product1"
        Me.Resources_product1.Size = New System.Drawing.Size(1367, 522)
        Me.Resources_product1.TabIndex = 3
        '
        'Resources_rawmat1
        '
        Me.Resources_rawmat1.AutoSize = True
        Me.Resources_rawmat1.BackColor = System.Drawing.Color.Azure
        Me.Resources_rawmat1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Resources_rawmat1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resources_rawmat1.Location = New System.Drawing.Point(0, 0)
        Me.Resources_rawmat1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Resources_rawmat1.Name = "Resources_rawmat1"
        Me.Resources_rawmat1.Size = New System.Drawing.Size(1367, 522)
        Me.Resources_rawmat1.TabIndex = 2
        '
        'Resources_recipe1
        '
        Me.Resources_recipe1.BackColor = System.Drawing.Color.Azure
        Me.Resources_recipe1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Resources_recipe1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resources_recipe1.Location = New System.Drawing.Point(0, 0)
        Me.Resources_recipe1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Resources_recipe1.Name = "Resources_recipe1"
        Me.Resources_recipe1.Size = New System.Drawing.Size(1367, 522)
        Me.Resources_recipe1.TabIndex = 4
        '
        'Trans_Forcast1
        '
        Me.Trans_Forcast1.BackColor = System.Drawing.Color.Azure
        Me.Trans_Forcast1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Trans_Forcast1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        Me.Trans_Forcast1.Location = New System.Drawing.Point(0, 0)
        Me.Trans_Forcast1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Trans_Forcast1.Name = "Trans_Forcast1"
        Me.Trans_Forcast1.Size = New System.Drawing.Size(1367, 522)
        Me.Trans_Forcast1.TabIndex = 5
        '
        'Reporting_forecast1
        '
        Me.Reporting_forecast1.BackColor = System.Drawing.Color.Azure
        Me.Reporting_forecast1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reporting_forecast1.Location = New System.Drawing.Point(-1, 0)
        Me.Reporting_forecast1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Reporting_forecast1.Name = "Reporting_forecast1"
        Me.Reporting_forecast1.Size = New System.Drawing.Size(1366, 535)
        Me.Reporting_forecast1.TabIndex = 6
        '
        'Reporting_forecast_sts1
        '
        Me.Reporting_forecast_sts1.BackColor = System.Drawing.Color.Azure
        Me.Reporting_forecast_sts1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reporting_forecast_sts1.Location = New System.Drawing.Point(0, 0)
        Me.Reporting_forecast_sts1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Reporting_forecast_sts1.Name = "Reporting_forecast_sts1"
        Me.Reporting_forecast_sts1.Size = New System.Drawing.Size(1366, 547)
        Me.Reporting_forecast_sts1.TabIndex = 7
        '
        'Trans_pahabol1
        '
        Me.Trans_pahabol1.BackColor = System.Drawing.Color.Azure
        Me.Trans_pahabol1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Trans_pahabol1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Trans_pahabol1.Location = New System.Drawing.Point(0, 0)
        Me.Trans_pahabol1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Trans_pahabol1.Name = "Trans_pahabol1"
        Me.Trans_pahabol1.Size = New System.Drawing.Size(1367, 522)
        Me.Trans_pahabol1.TabIndex = 8
        '
        'Deliver_assign1
        '
        Me.Deliver_assign1.BackColor = System.Drawing.Color.MintCream
        Me.Deliver_assign1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deliver_assign1.Location = New System.Drawing.Point(-1, 0)
        Me.Deliver_assign1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Deliver_assign1.Name = "Deliver_assign1"
        Me.Deliver_assign1.Size = New System.Drawing.Size(1366, 547)
        Me.Deliver_assign1.TabIndex = 9
        '
        'Mr_panel1
        '
        Me.Mr_panel1.BackColor = System.Drawing.Color.MintCream
        Me.Mr_panel1.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mr_panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Mr_panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Mr_panel1.Name = "Mr_panel1"
        Me.Mr_panel1.Size = New System.Drawing.Size(1366, 535)
        Me.Mr_panel1.TabIndex = 10
        '
        'label_welcome
        '
        Me.label_welcome.BackColor = System.Drawing.Color.MintCream
        Me.label_welcome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.label_welcome.Location = New System.Drawing.Point(832, 178)
        Me.label_welcome.Name = "label_welcome"
        Me.label_welcome.Size = New System.Drawing.Size(460, 30)
        Me.label_welcome.TabIndex = 3
        Me.label_welcome.Text = "Hi"
        Me.label_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_logout
        '
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_logout.Location = New System.Drawing.Point(1298, 174)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(68, 38)
        Me.btn_logout.TabIndex = 4
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.ForeColor = System.Drawing.Color.Maroon
        Me.btn_close.Location = New System.Drawing.Point(1317, 12)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(37, 36)
        Me.btn_close.TabIndex = 5
        Me.btn_close.Text = "X"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Azure
        Me.PictureBox1.Image = Global.Ordering_System.My.Resources.Resources.toppaper
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1367, 162)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'SecurityLogsToolStripMenuItem
        '
        Me.SecurityLogsToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecurityLogsToolStripMenuItem.Name = "SecurityLogsToolStripMenuItem"
        Me.SecurityLogsToolStripMenuItem.Size = New System.Drawing.Size(326, 28)
        Me.SecurityLogsToolStripMenuItem.Text = "Security Logs"
        '
        'Mainmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(1366, 750)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.PanelBackground)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.label_welcome)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Mainmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mainmenu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelBackground.ResumeLayout(False)
        Me.PanelBackground.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManagePendingAccountsadminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelBackground As Panel
    Friend WithEvents label_welcome As Label
    Friend WithEvents btn_logout As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents UF_user_manageaccounts1 As UF_user_manageaccounts
    Friend WithEvents Uf_black_menu1 As uf_black_menu
    Friend WithEvents ResourcesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageRawMatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageBranchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageRecipeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Resources_rawmat1 As resources_rawmat
    Friend WithEvents TransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Resources_product1 As resources_product
    Friend WithEvents Resources_recipe1 As resources_recipe
    Friend WithEvents NewForcastToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PahabolOndayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PahabolDamageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BufferToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdjustmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageSuppliersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvRawMaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SummaryForcastToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockTransferToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerateScallingReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerateProductionReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RAWMATDeliveryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BeginingInventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Trans_Forcast1 As trans_Forcast
    Friend WithEvents Reporting_forecast1 As reporting_forecast
    Friend WithEvents MasterTableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageSTSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Reporting_forecast_sts1 As reporting_forecast_sts
    Friend WithEvents GenerateSTSPahabolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Trans_pahabol1 As trans_pahabol
    Friend WithEvents ManagersReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeliveryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AssignToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Deliver_assign1 As deliver_assign
    Friend WithEvents ProductBatchingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LessOverItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Mr_panel1 As mr_panel
    Friend WithEvents SecurityLogsToolStripMenuItem As ToolStripMenuItem
End Class
