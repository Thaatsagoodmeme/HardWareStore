namespace MB_Accounting
{
    partial class SystemAdministratorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemAdministratorForm));
            this.imageListMenu = new System.Windows.Forms.ImageList(this.components);
            this.imageListMenuYellow = new System.Windows.Forms.ImageList(this.components);
            this.tabControlMenu = new MB_Accounting.VerticalTabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.panelMainTabBackground = new System.Windows.Forms.Panel();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblGreetings = new System.Windows.Forms.Label();
            this.tabPageStock = new System.Windows.Forms.TabPage();
            this.panelStockTabBackground = new System.Windows.Forms.Panel();
            this.rtbxMessage = new System.Windows.Forms.RichTextBox();
            this.lblStoreIsle = new System.Windows.Forms.Label();
            this.tbxWarehouseIsle = new System.Windows.Forms.TextBox();
            this.lblWarehouseIsle = new System.Windows.Forms.Label();
            this.tbxStoreIsle = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.tbxDepth = new System.Windows.Forms.TextBox();
            this.lblDepth = new System.Windows.Forms.Label();
            this.tbxWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.tbxHeight = new System.Windows.Forms.TextBox();
            this.lblDimensions = new System.Windows.Forms.Label();
            this.tbxSellingPrice = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbxWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblSellingPrice = new System.Windows.Forms.Label();
            this.tbxManufacturer = new System.Windows.Forms.TextBox();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.tbxPurchasePrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.btnCreateProduct = new MB_Accounting.RoundButton();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductTabHeading = new System.Windows.Forms.Label();
            this.tabPageDepartments = new System.Windows.Forms.TabPage();
            this.panelDepartmentsTabBackground = new System.Windows.Forms.Panel();
            this.btnDeleteProduct = new MB_Accounting.RoundButton();
            this.lbxShowAllStocksOfDepartment = new System.Windows.Forms.ListBox();
            this.lblProductInformation = new System.Windows.Forms.Label();
            this.tbxWarehouseIsleShow = new System.Windows.Forms.TextBox();
            this.tbxDepartmentShow = new System.Windows.Forms.TextBox();
            this.tbxSellingPriceShow = new System.Windows.Forms.TextBox();
            this.tbxProductNameShow = new System.Windows.Forms.TextBox();
            this.lblProductsWithSameDepartment = new System.Windows.Forms.Label();
            this.lblProductNameShow = new System.Windows.Forms.Label();
            this.lblWarehouseLocationStore = new System.Windows.Forms.Label();
            this.lblDepartmentShow = new System.Windows.Forms.Label();
            this.lblSellingPriceShow = new System.Windows.Forms.Label();
            this.lblSelectProduct = new System.Windows.Forms.Label();
            this.cbxProducts = new System.Windows.Forms.ComboBox();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.panelSettingsTabBackground = new System.Windows.Forms.Panel();
            this.rbSaveEc = new MB_Accounting.RoundButton();
            this.tbxECNameSettings = new System.Windows.Forms.TextBox();
            this.tbxECInfoSettings = new System.Windows.Forms.TextBox();
            this.lblECInfoSettings = new System.Windows.Forms.Label();
            this.lblECNameSettings = new System.Windows.Forms.Label();
            this.lblECSettings = new System.Windows.Forms.Label();
            this.btnSavePassword = new MB_Accounting.RoundButton();
            this.btnSaveInfo = new MB_Accounting.RoundButton();
            this.tbxConfirmPasswordSettings = new System.Windows.Forms.TextBox();
            this.tbxNewPasswordSettings = new System.Windows.Forms.TextBox();
            this.tbxCurrentPasswordSettings = new System.Windows.Forms.TextBox();
            this.tbxEmailSettings = new System.Windows.Forms.TextBox();
            this.tbxPhoneNumberSettings = new System.Windows.Forms.TextBox();
            this.tbxAddressSettings = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.lblAddressSettings = new System.Windows.Forms.Label();
            this.lblPhoneNumberSettings = new System.Windows.Forms.Label();
            this.lblEmailSettings = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPersonalInfo = new System.Windows.Forms.Label();
            this.lblSettingsTabHeading = new System.Windows.Forms.Label();
            this.tabPageColorTheme = new System.Windows.Forms.TabPage();
            this.cbxRelationship = new System.Windows.Forms.ComboBox();
            this.lblRelationship = new System.Windows.Forms.Label();
            this.tabControlMenu.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.panelMainTabBackground.SuspendLayout();
            this.tabPageStock.SuspendLayout();
            this.panelStockTabBackground.SuspendLayout();
            this.tabPageDepartments.SuspendLayout();
            this.panelDepartmentsTabBackground.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.panelSettingsTabBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListMenu
            // 
            this.imageListMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMenu.ImageStream")));
            this.imageListMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMenu.Images.SetKeyName(0, "department.png");
            this.imageListMenu.Images.SetKeyName(1, "boxes.png");
            this.imageListMenu.Images.SetKeyName(2, "settings.png");
            this.imageListMenu.Images.SetKeyName(3, "MB Accounting Logo.png");
            // 
            // imageListMenuYellow
            // 
            this.imageListMenuYellow.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListMenuYellow.ImageSize = new System.Drawing.Size(48, 48);
            this.imageListMenuYellow.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlMenu.Controls.Add(this.tabPageMain);
            this.tabControlMenu.Controls.Add(this.tabPageStock);
            this.tabControlMenu.Controls.Add(this.tabPageDepartments);
            this.tabControlMenu.Controls.Add(this.tabPageSettings);
            this.tabControlMenu.Controls.Add(this.tabPageColorTheme);
            this.tabControlMenu.ImageList = this.imageListMenu;
            this.tabControlMenu.ItemSize = new System.Drawing.Size(150, 250);
            this.tabControlMenu.Location = new System.Drawing.Point(0, -5);
            this.tabControlMenu.Multiline = true;
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(1186, 770);
            this.tabControlMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMenu.TabIndex = 0;
            this.tabControlMenu.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlMenu_Selected);
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.panelMainTabBackground);
            this.tabPageMain.Location = new System.Drawing.Point(254, 4);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(928, 762);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // panelMainTabBackground
            // 
            this.panelMainTabBackground.BackColor = System.Drawing.Color.White;
            this.panelMainTabBackground.Controls.Add(this.lblEmployeeName);
            this.panelMainTabBackground.Controls.Add(this.lblGreetings);
            this.panelMainTabBackground.Location = new System.Drawing.Point(0, 0);
            this.panelMainTabBackground.Name = "panelMainTabBackground";
            this.panelMainTabBackground.Size = new System.Drawing.Size(960, 770);
            this.panelMainTabBackground.TabIndex = 0;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.Color.HotPink;
            this.lblEmployeeName.Location = new System.Drawing.Point(6, 350);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(912, 129);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "John Doe!";
            this.lblEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGreetings
            // 
            this.lblGreetings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGreetings.BackColor = System.Drawing.Color.Transparent;
            this.lblGreetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreetings.ForeColor = System.Drawing.Color.SlateGray;
            this.lblGreetings.Location = new System.Drawing.Point(6, 250);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(919, 100);
            this.lblGreetings.TabIndex = 0;
            this.lblGreetings.Text = "Greetings,";
            this.lblGreetings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageStock
            // 
            this.tabPageStock.Controls.Add(this.panelStockTabBackground);
            this.tabPageStock.ImageIndex = 1;
            this.tabPageStock.Location = new System.Drawing.Point(254, 4);
            this.tabPageStock.Name = "tabPageStock";
            this.tabPageStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStock.Size = new System.Drawing.Size(928, 762);
            this.tabPageStock.TabIndex = 2;
            this.tabPageStock.Text = "Products";
            this.tabPageStock.UseVisualStyleBackColor = true;
            // 
            // panelStockTabBackground
            // 
            this.panelStockTabBackground.BackColor = System.Drawing.Color.White;
            this.panelStockTabBackground.Controls.Add(this.rtbxMessage);
            this.panelStockTabBackground.Controls.Add(this.lblStoreIsle);
            this.panelStockTabBackground.Controls.Add(this.tbxWarehouseIsle);
            this.panelStockTabBackground.Controls.Add(this.lblWarehouseIsle);
            this.panelStockTabBackground.Controls.Add(this.tbxStoreIsle);
            this.panelStockTabBackground.Controls.Add(this.lblLocation);
            this.panelStockTabBackground.Controls.Add(this.lblHeight);
            this.panelStockTabBackground.Controls.Add(this.tbxDepth);
            this.panelStockTabBackground.Controls.Add(this.lblDepth);
            this.panelStockTabBackground.Controls.Add(this.tbxWidth);
            this.panelStockTabBackground.Controls.Add(this.lblWidth);
            this.panelStockTabBackground.Controls.Add(this.tbxHeight);
            this.panelStockTabBackground.Controls.Add(this.lblDimensions);
            this.panelStockTabBackground.Controls.Add(this.tbxSellingPrice);
            this.panelStockTabBackground.Controls.Add(this.lblDescription);
            this.panelStockTabBackground.Controls.Add(this.tbxWeight);
            this.panelStockTabBackground.Controls.Add(this.lblWeight);
            this.panelStockTabBackground.Controls.Add(this.lblSellingPrice);
            this.panelStockTabBackground.Controls.Add(this.tbxManufacturer);
            this.panelStockTabBackground.Controls.Add(this.lblManufacturer);
            this.panelStockTabBackground.Controls.Add(this.tbxPurchasePrice);
            this.panelStockTabBackground.Controls.Add(this.lblPrice);
            this.panelStockTabBackground.Controls.Add(this.cbxDepartment);
            this.panelStockTabBackground.Controls.Add(this.lblDepartment);
            this.panelStockTabBackground.Controls.Add(this.btnCreateProduct);
            this.panelStockTabBackground.Controls.Add(this.tbxProductName);
            this.panelStockTabBackground.Controls.Add(this.lblProductName);
            this.panelStockTabBackground.Controls.Add(this.lblProductTabHeading);
            this.panelStockTabBackground.Location = new System.Drawing.Point(0, 0);
            this.panelStockTabBackground.Name = "panelStockTabBackground";
            this.panelStockTabBackground.Size = new System.Drawing.Size(960, 770);
            this.panelStockTabBackground.TabIndex = 1;
            // 
            // rtbxMessage
            // 
            this.rtbxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbxMessage.Location = new System.Drawing.Point(38, 521);
            this.rtbxMessage.Name = "rtbxMessage";
            this.rtbxMessage.Size = new System.Drawing.Size(836, 80);
            this.rtbxMessage.TabIndex = 55;
            this.rtbxMessage.Text = "";
            // 
            // lblStoreIsle
            // 
            this.lblStoreIsle.AutoSize = true;
            this.lblStoreIsle.BackColor = System.Drawing.Color.Transparent;
            this.lblStoreIsle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStoreIsle.ForeColor = System.Drawing.Color.HotPink;
            this.lblStoreIsle.Location = new System.Drawing.Point(531, 382);
            this.lblStoreIsle.Name = "lblStoreIsle";
            this.lblStoreIsle.Size = new System.Drawing.Size(59, 24);
            this.lblStoreIsle.TabIndex = 54;
            this.lblStoreIsle.Text = "Store:";
            // 
            // tbxWarehouseIsle
            // 
            this.tbxWarehouseIsle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxWarehouseIsle.Location = new System.Drawing.Point(661, 426);
            this.tbxWarehouseIsle.Name = "tbxWarehouseIsle";
            this.tbxWarehouseIsle.Size = new System.Drawing.Size(207, 28);
            this.tbxWarehouseIsle.TabIndex = 52;
            // 
            // lblWarehouseIsle
            // 
            this.lblWarehouseIsle.AutoSize = true;
            this.lblWarehouseIsle.BackColor = System.Drawing.Color.Transparent;
            this.lblWarehouseIsle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWarehouseIsle.ForeColor = System.Drawing.Color.HotPink;
            this.lblWarehouseIsle.Location = new System.Drawing.Point(506, 429);
            this.lblWarehouseIsle.Name = "lblWarehouseIsle";
            this.lblWarehouseIsle.Size = new System.Drawing.Size(113, 24);
            this.lblWarehouseIsle.TabIndex = 53;
            this.lblWarehouseIsle.Text = "Warehouse:";
            // 
            // tbxStoreIsle
            // 
            this.tbxStoreIsle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxStoreIsle.Location = new System.Drawing.Point(661, 377);
            this.tbxStoreIsle.Name = "tbxStoreIsle";
            this.tbxStoreIsle.Size = new System.Drawing.Size(207, 28);
            this.tbxStoreIsle.TabIndex = 50;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLocation.ForeColor = System.Drawing.Color.HotPink;
            this.lblLocation.Location = new System.Drawing.Point(496, 336);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(140, 26);
            this.lblLocation.TabIndex = 51;
            this.lblLocation.Text = "Isle Location:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.BackColor = System.Drawing.Color.Transparent;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeight.ForeColor = System.Drawing.Color.HotPink;
            this.lblHeight.Location = new System.Drawing.Point(527, 182);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(70, 24);
            this.lblHeight.TabIndex = 49;
            this.lblHeight.Text = "Height:";
            // 
            // tbxDepth
            // 
            this.tbxDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxDepth.Location = new System.Drawing.Point(661, 281);
            this.tbxDepth.Name = "tbxDepth";
            this.tbxDepth.Size = new System.Drawing.Size(207, 28);
            this.tbxDepth.TabIndex = 46;
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.BackColor = System.Drawing.Color.Transparent;
            this.lblDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDepth.ForeColor = System.Drawing.Color.HotPink;
            this.lblDepth.Location = new System.Drawing.Point(533, 283);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(65, 24);
            this.lblDepth.TabIndex = 48;
            this.lblDepth.Text = "Depth:";
            // 
            // tbxWidth
            // 
            this.tbxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxWidth.Location = new System.Drawing.Point(661, 229);
            this.tbxWidth.Name = "tbxWidth";
            this.tbxWidth.Size = new System.Drawing.Size(207, 28);
            this.tbxWidth.TabIndex = 45;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.BackColor = System.Drawing.Color.Transparent;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWidth.ForeColor = System.Drawing.Color.HotPink;
            this.lblWidth.Location = new System.Drawing.Point(531, 231);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(63, 24);
            this.lblWidth.TabIndex = 47;
            this.lblWidth.Text = "Width:";
            // 
            // tbxHeight
            // 
            this.tbxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxHeight.Location = new System.Drawing.Point(661, 182);
            this.tbxHeight.Name = "tbxHeight";
            this.tbxHeight.Size = new System.Drawing.Size(207, 28);
            this.tbxHeight.TabIndex = 43;
            // 
            // lblDimensions
            // 
            this.lblDimensions.AutoSize = true;
            this.lblDimensions.BackColor = System.Drawing.Color.Transparent;
            this.lblDimensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDimensions.ForeColor = System.Drawing.Color.HotPink;
            this.lblDimensions.Location = new System.Drawing.Point(496, 138);
            this.lblDimensions.Name = "lblDimensions";
            this.lblDimensions.Size = new System.Drawing.Size(133, 26);
            this.lblDimensions.TabIndex = 44;
            this.lblDimensions.Text = "Dimensions:";
            // 
            // tbxSellingPrice
            // 
            this.tbxSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxSellingPrice.Location = new System.Drawing.Point(223, 289);
            this.tbxSellingPrice.Name = "tbxSellingPrice";
            this.tbxSellingPrice.Size = new System.Drawing.Size(207, 32);
            this.tbxSellingPrice.TabIndex = 42;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription.ForeColor = System.Drawing.Color.HotPink;
            this.lblDescription.Location = new System.Drawing.Point(32, 468);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(127, 26);
            this.lblDescription.TabIndex = 39;
            this.lblDescription.Text = "Description:";
            // 
            // tbxWeight
            // 
            this.tbxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxWeight.Location = new System.Drawing.Point(220, 343);
            this.tbxWeight.Name = "tbxWeight";
            this.tbxWeight.Size = new System.Drawing.Size(207, 32);
            this.tbxWeight.TabIndex = 31;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.BackColor = System.Drawing.Color.Transparent;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWeight.ForeColor = System.Drawing.Color.HotPink;
            this.lblWeight.Location = new System.Drawing.Point(51, 346);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(86, 26);
            this.lblWeight.TabIndex = 35;
            this.lblWeight.Text = "Weight:";
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.AutoSize = true;
            this.lblSellingPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSellingPrice.ForeColor = System.Drawing.Color.HotPink;
            this.lblSellingPrice.Location = new System.Drawing.Point(18, 289);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(140, 26);
            this.lblSellingPrice.TabIndex = 34;
            this.lblSellingPrice.Text = "Selling Price:";
            // 
            // tbxManufacturer
            // 
            this.tbxManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxManufacturer.Location = new System.Drawing.Point(220, 188);
            this.tbxManufacturer.Name = "tbxManufacturer";
            this.tbxManufacturer.Size = new System.Drawing.Size(207, 32);
            this.tbxManufacturer.TabIndex = 30;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.BackColor = System.Drawing.Color.Transparent;
            this.lblManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblManufacturer.ForeColor = System.Drawing.Color.HotPink;
            this.lblManufacturer.Location = new System.Drawing.Point(15, 188);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(145, 26);
            this.lblManufacturer.TabIndex = 33;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // tbxPurchasePrice
            // 
            this.tbxPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxPurchasePrice.Location = new System.Drawing.Point(223, 240);
            this.tbxPurchasePrice.Name = "tbxPurchasePrice";
            this.tbxPurchasePrice.Size = new System.Drawing.Size(207, 32);
            this.tbxPurchasePrice.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.ForeColor = System.Drawing.Color.HotPink;
            this.lblPrice.Location = new System.Drawing.Point(6, 243);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(166, 26);
            this.lblPrice.TabIndex = 29;
            this.lblPrice.Text = "Purchase Price:";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(220, 394);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(207, 34);
            this.cbxDepartment.TabIndex = 2;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDepartment.ForeColor = System.Drawing.Color.HotPink;
            this.lblDepartment.Location = new System.Drawing.Point(27, 399);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(132, 26);
            this.lblDepartment.TabIndex = 27;
            this.lblDepartment.Text = "Department:";
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Active1 = System.Drawing.Color.HotPink;
            this.btnCreateProduct.Active2 = System.Drawing.Color.HotPink;
            this.btnCreateProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateProduct.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCreateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateProduct.ForeColor = System.Drawing.Color.White;
            this.btnCreateProduct.Inactive1 = System.Drawing.Color.HotPink;
            this.btnCreateProduct.Inactive2 = System.Drawing.Color.HotPink;
            this.btnCreateProduct.Location = new System.Drawing.Point(253, 638);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Radius = 45;
            this.btnCreateProduct.Size = new System.Drawing.Size(377, 90);
            this.btnCreateProduct.Stroke = false;
            this.btnCreateProduct.StrokeColor = System.Drawing.Color.Gray;
            this.btnCreateProduct.TabIndex = 4;
            this.btnCreateProduct.Text = "Create product";
            this.btnCreateProduct.Transparency = false;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateStock_Click);
            // 
            // tbxProductName
            // 
            this.tbxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxProductName.Location = new System.Drawing.Point(220, 139);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(207, 32);
            this.tbxProductName.TabIndex = 0;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductName.ForeColor = System.Drawing.Color.HotPink;
            this.lblProductName.Location = new System.Drawing.Point(10, 139);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(154, 26);
            this.lblProductName.TabIndex = 22;
            this.lblProductName.Text = "Product name:";
            // 
            // lblProductTabHeading
            // 
            this.lblProductTabHeading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductTabHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblProductTabHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductTabHeading.ForeColor = System.Drawing.Color.SlateGray;
            this.lblProductTabHeading.Location = new System.Drawing.Point(6, 10);
            this.lblProductTabHeading.Name = "lblProductTabHeading";
            this.lblProductTabHeading.Size = new System.Drawing.Size(916, 100);
            this.lblProductTabHeading.TabIndex = 20;
            this.lblProductTabHeading.Text = "Product";
            this.lblProductTabHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageDepartments
            // 
            this.tabPageDepartments.Controls.Add(this.panelDepartmentsTabBackground);
            this.tabPageDepartments.ImageIndex = 0;
            this.tabPageDepartments.Location = new System.Drawing.Point(254, 4);
            this.tabPageDepartments.Name = "tabPageDepartments";
            this.tabPageDepartments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDepartments.Size = new System.Drawing.Size(928, 762);
            this.tabPageDepartments.TabIndex = 1;
            this.tabPageDepartments.Text = "Product info";
            this.tabPageDepartments.UseVisualStyleBackColor = true;
            // 
            // panelDepartmentsTabBackground
            // 
            this.panelDepartmentsTabBackground.BackColor = System.Drawing.Color.White;
            this.panelDepartmentsTabBackground.Controls.Add(this.btnDeleteProduct);
            this.panelDepartmentsTabBackground.Controls.Add(this.lbxShowAllStocksOfDepartment);
            this.panelDepartmentsTabBackground.Controls.Add(this.lblProductInformation);
            this.panelDepartmentsTabBackground.Controls.Add(this.tbxWarehouseIsleShow);
            this.panelDepartmentsTabBackground.Controls.Add(this.tbxDepartmentShow);
            this.panelDepartmentsTabBackground.Controls.Add(this.tbxSellingPriceShow);
            this.panelDepartmentsTabBackground.Controls.Add(this.tbxProductNameShow);
            this.panelDepartmentsTabBackground.Controls.Add(this.lblProductsWithSameDepartment);
            this.panelDepartmentsTabBackground.Controls.Add(this.lblProductNameShow);
            this.panelDepartmentsTabBackground.Controls.Add(this.lblWarehouseLocationStore);
            this.panelDepartmentsTabBackground.Controls.Add(this.lblDepartmentShow);
            this.panelDepartmentsTabBackground.Controls.Add(this.lblSellingPriceShow);
            this.panelDepartmentsTabBackground.Controls.Add(this.lblSelectProduct);
            this.panelDepartmentsTabBackground.Controls.Add(this.cbxProducts);
            this.panelDepartmentsTabBackground.Location = new System.Drawing.Point(0, 0);
            this.panelDepartmentsTabBackground.Name = "panelDepartmentsTabBackground";
            this.panelDepartmentsTabBackground.Size = new System.Drawing.Size(960, 770);
            this.panelDepartmentsTabBackground.TabIndex = 1;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Active1 = System.Drawing.Color.HotPink;
            this.btnDeleteProduct.Active2 = System.Drawing.Color.HotPink;
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteProduct.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Inactive1 = System.Drawing.Color.HotPink;
            this.btnDeleteProduct.Inactive2 = System.Drawing.Color.HotPink;
            this.btnDeleteProduct.Location = new System.Drawing.Point(248, 654);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Radius = 45;
            this.btnDeleteProduct.Size = new System.Drawing.Size(400, 90);
            this.btnDeleteProduct.Stroke = false;
            this.btnDeleteProduct.StrokeColor = System.Drawing.Color.Gray;
            this.btnDeleteProduct.TabIndex = 60;
            this.btnDeleteProduct.Text = "Delete product";
            this.btnDeleteProduct.Transparency = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // lbxShowAllStocksOfDepartment
            // 
            this.lbxShowAllStocksOfDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxShowAllStocksOfDepartment.FormattingEnabled = true;
            this.lbxShowAllStocksOfDepartment.ItemHeight = 25;
            this.lbxShowAllStocksOfDepartment.Location = new System.Drawing.Point(21, 447);
            this.lbxShowAllStocksOfDepartment.Name = "lbxShowAllStocksOfDepartment";
            this.lbxShowAllStocksOfDepartment.Size = new System.Drawing.Size(870, 179);
            this.lbxShowAllStocksOfDepartment.TabIndex = 59;
            // 
            // lblProductInformation
            // 
            this.lblProductInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductInformation.BackColor = System.Drawing.Color.Transparent;
            this.lblProductInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductInformation.ForeColor = System.Drawing.Color.SlateGray;
            this.lblProductInformation.Location = new System.Drawing.Point(6, 10);
            this.lblProductInformation.Name = "lblProductInformation";
            this.lblProductInformation.Size = new System.Drawing.Size(916, 100);
            this.lblProductInformation.TabIndex = 57;
            this.lblProductInformation.Text = "Product Information";
            this.lblProductInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxWarehouseIsleShow
            // 
            this.tbxWarehouseIsleShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxWarehouseIsleShow.Location = new System.Drawing.Point(808, 320);
            this.tbxWarehouseIsleShow.Margin = new System.Windows.Forms.Padding(4);
            this.tbxWarehouseIsleShow.Name = "tbxWarehouseIsleShow";
            this.tbxWarehouseIsleShow.Size = new System.Drawing.Size(83, 31);
            this.tbxWarehouseIsleShow.TabIndex = 36;
            // 
            // tbxDepartmentShow
            // 
            this.tbxDepartmentShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDepartmentShow.Location = new System.Drawing.Point(671, 260);
            this.tbxDepartmentShow.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDepartmentShow.Name = "tbxDepartmentShow";
            this.tbxDepartmentShow.Size = new System.Drawing.Size(220, 31);
            this.tbxDepartmentShow.TabIndex = 35;
            // 
            // tbxSellingPriceShow
            // 
            this.tbxSellingPriceShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSellingPriceShow.Location = new System.Drawing.Point(234, 322);
            this.tbxSellingPriceShow.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSellingPriceShow.Name = "tbxSellingPriceShow";
            this.tbxSellingPriceShow.Size = new System.Drawing.Size(220, 31);
            this.tbxSellingPriceShow.TabIndex = 33;
            // 
            // tbxProductNameShow
            // 
            this.tbxProductNameShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductNameShow.Location = new System.Drawing.Point(234, 261);
            this.tbxProductNameShow.Margin = new System.Windows.Forms.Padding(4);
            this.tbxProductNameShow.Name = "tbxProductNameShow";
            this.tbxProductNameShow.Size = new System.Drawing.Size(220, 31);
            this.tbxProductNameShow.TabIndex = 31;
            // 
            // lblProductsWithSameDepartment
            // 
            this.lblProductsWithSameDepartment.AutoSize = true;
            this.lblProductsWithSameDepartment.BackColor = System.Drawing.Color.Transparent;
            this.lblProductsWithSameDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsWithSameDepartment.Location = new System.Drawing.Point(15, 408);
            this.lblProductsWithSameDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductsWithSameDepartment.Name = "lblProductsWithSameDepartment";
            this.lblProductsWithSameDepartment.Size = new System.Drawing.Size(372, 29);
            this.lblProductsWithSameDepartment.TabIndex = 41;
            this.lblProductsWithSameDepartment.Text = "Products of the same department:";
            // 
            // lblProductNameShow
            // 
            this.lblProductNameShow.AutoSize = true;
            this.lblProductNameShow.BackColor = System.Drawing.Color.Transparent;
            this.lblProductNameShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNameShow.Location = new System.Drawing.Point(26, 261);
            this.lblProductNameShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductNameShow.Name = "lblProductNameShow";
            this.lblProductNameShow.Size = new System.Drawing.Size(168, 29);
            this.lblProductNameShow.TabIndex = 39;
            this.lblProductNameShow.Text = "Product name:";
            // 
            // lblWarehouseLocationStore
            // 
            this.lblWarehouseLocationStore.AutoSize = true;
            this.lblWarehouseLocationStore.BackColor = System.Drawing.Color.Transparent;
            this.lblWarehouseLocationStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouseLocationStore.Location = new System.Drawing.Point(486, 321);
            this.lblWarehouseLocationStore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarehouseLocationStore.Name = "lblWarehouseLocationStore";
            this.lblWarehouseLocationStore.Size = new System.Drawing.Size(276, 29);
            this.lblWarehouseLocationStore.TabIndex = 37;
            this.lblWarehouseLocationStore.Text = "Warehouse Isle location:";
            // 
            // lblDepartmentShow
            // 
            this.lblDepartmentShow.AutoSize = true;
            this.lblDepartmentShow.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmentShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentShow.Location = new System.Drawing.Point(491, 260);
            this.lblDepartmentShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartmentShow.Name = "lblDepartmentShow";
            this.lblDepartmentShow.Size = new System.Drawing.Size(144, 29);
            this.lblDepartmentShow.TabIndex = 34;
            this.lblDepartmentShow.Text = "Department:";
            // 
            // lblSellingPriceShow
            // 
            this.lblSellingPriceShow.AutoSize = true;
            this.lblSellingPriceShow.BackColor = System.Drawing.Color.Transparent;
            this.lblSellingPriceShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellingPriceShow.Location = new System.Drawing.Point(39, 321);
            this.lblSellingPriceShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSellingPriceShow.Name = "lblSellingPriceShow";
            this.lblSellingPriceShow.Size = new System.Drawing.Size(154, 29);
            this.lblSellingPriceShow.TabIndex = 32;
            this.lblSellingPriceShow.Text = "Selling price:";
            // 
            // lblSelectProduct
            // 
            this.lblSelectProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectProduct.ForeColor = System.Drawing.Color.HotPink;
            this.lblSelectProduct.Location = new System.Drawing.Point(248, 128);
            this.lblSelectProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectProduct.Name = "lblSelectProduct";
            this.lblSelectProduct.Size = new System.Drawing.Size(400, 37);
            this.lblSelectProduct.TabIndex = 30;
            this.lblSelectProduct.Text = "Select product";
            this.lblSelectProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxProducts
            // 
            this.cbxProducts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxProducts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProducts.FormattingEnabled = true;
            this.cbxProducts.Location = new System.Drawing.Point(248, 169);
            this.cbxProducts.Margin = new System.Windows.Forms.Padding(4);
            this.cbxProducts.Name = "cbxProducts";
            this.cbxProducts.Size = new System.Drawing.Size(400, 33);
            this.cbxProducts.TabIndex = 29;
            this.cbxProducts.SelectedIndexChanged += new System.EventHandler(this.cbxProducts_SelectedIndexChanged);
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.panelSettingsTabBackground);
            this.tabPageSettings.ImageIndex = 2;
            this.tabPageSettings.Location = new System.Drawing.Point(254, 4);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(928, 762);
            this.tabPageSettings.TabIndex = 3;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // panelSettingsTabBackground
            // 
            this.panelSettingsTabBackground.BackColor = System.Drawing.Color.White;
            this.panelSettingsTabBackground.Controls.Add(this.lblRelationship);
            this.panelSettingsTabBackground.Controls.Add(this.cbxRelationship);
            this.panelSettingsTabBackground.Controls.Add(this.rbSaveEc);
            this.panelSettingsTabBackground.Controls.Add(this.tbxECNameSettings);
            this.panelSettingsTabBackground.Controls.Add(this.tbxECInfoSettings);
            this.panelSettingsTabBackground.Controls.Add(this.lblECInfoSettings);
            this.panelSettingsTabBackground.Controls.Add(this.lblECNameSettings);
            this.panelSettingsTabBackground.Controls.Add(this.lblECSettings);
            this.panelSettingsTabBackground.Controls.Add(this.btnSavePassword);
            this.panelSettingsTabBackground.Controls.Add(this.btnSaveInfo);
            this.panelSettingsTabBackground.Controls.Add(this.tbxConfirmPasswordSettings);
            this.panelSettingsTabBackground.Controls.Add(this.tbxNewPasswordSettings);
            this.panelSettingsTabBackground.Controls.Add(this.tbxCurrentPasswordSettings);
            this.panelSettingsTabBackground.Controls.Add(this.tbxEmailSettings);
            this.panelSettingsTabBackground.Controls.Add(this.tbxPhoneNumberSettings);
            this.panelSettingsTabBackground.Controls.Add(this.tbxAddressSettings);
            this.panelSettingsTabBackground.Controls.Add(this.lblConfirmPassword);
            this.panelSettingsTabBackground.Controls.Add(this.lblNewPassword);
            this.panelSettingsTabBackground.Controls.Add(this.lblCurrentPassword);
            this.panelSettingsTabBackground.Controls.Add(this.lblAddressSettings);
            this.panelSettingsTabBackground.Controls.Add(this.lblPhoneNumberSettings);
            this.panelSettingsTabBackground.Controls.Add(this.lblEmailSettings);
            this.panelSettingsTabBackground.Controls.Add(this.lblPassword);
            this.panelSettingsTabBackground.Controls.Add(this.lblPersonalInfo);
            this.panelSettingsTabBackground.Controls.Add(this.lblSettingsTabHeading);
            this.panelSettingsTabBackground.Location = new System.Drawing.Point(0, 0);
            this.panelSettingsTabBackground.Name = "panelSettingsTabBackground";
            this.panelSettingsTabBackground.Size = new System.Drawing.Size(960, 770);
            this.panelSettingsTabBackground.TabIndex = 1;
            // 
            // rbSaveEc
            // 
            this.rbSaveEc.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.rbSaveEc.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.rbSaveEc.BackColor = System.Drawing.Color.Transparent;
            this.rbSaveEc.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.rbSaveEc.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSaveEc.ForeColor = System.Drawing.Color.White;
            this.rbSaveEc.Inactive1 = System.Drawing.Color.HotPink;
            this.rbSaveEc.Inactive2 = System.Drawing.Color.HotPink;
            this.rbSaveEc.Location = new System.Drawing.Point(530, 311);
            this.rbSaveEc.Name = "rbSaveEc";
            this.rbSaveEc.Radius = 37;
            this.rbSaveEc.Size = new System.Drawing.Size(373, 74);
            this.rbSaveEc.Stroke = false;
            this.rbSaveEc.StrokeColor = System.Drawing.Color.Gray;
            this.rbSaveEc.TabIndex = 37;
            this.rbSaveEc.Text = "Save contact";
            this.rbSaveEc.Transparency = false;
            this.rbSaveEc.Click += new System.EventHandler(this.rbSaveEc_Click);
            // 
            // tbxECNameSettings
            // 
            this.tbxECNameSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxECNameSettings.Location = new System.Drawing.Point(689, 178);
            this.tbxECNameSettings.Name = "tbxECNameSettings";
            this.tbxECNameSettings.Size = new System.Drawing.Size(205, 31);
            this.tbxECNameSettings.TabIndex = 33;
            // 
            // tbxECInfoSettings
            // 
            this.tbxECInfoSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxECInfoSettings.Location = new System.Drawing.Point(689, 225);
            this.tbxECInfoSettings.Name = "tbxECInfoSettings";
            this.tbxECInfoSettings.Size = new System.Drawing.Size(205, 31);
            this.tbxECInfoSettings.TabIndex = 34;
            // 
            // lblECInfoSettings
            // 
            this.lblECInfoSettings.AutoSize = true;
            this.lblECInfoSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblECInfoSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblECInfoSettings.ForeColor = System.Drawing.Color.SlateGray;
            this.lblECInfoSettings.Location = new System.Drawing.Point(525, 225);
            this.lblECInfoSettings.Name = "lblECInfoSettings";
            this.lblECInfoSettings.Size = new System.Drawing.Size(145, 29);
            this.lblECInfoSettings.TabIndex = 36;
            this.lblECInfoSettings.Text = "Contact Info:";
            // 
            // lblECNameSettings
            // 
            this.lblECNameSettings.AutoSize = true;
            this.lblECNameSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblECNameSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblECNameSettings.ForeColor = System.Drawing.Color.SlateGray;
            this.lblECNameSettings.Location = new System.Drawing.Point(525, 178);
            this.lblECNameSettings.Name = "lblECNameSettings";
            this.lblECNameSettings.Size = new System.Drawing.Size(90, 29);
            this.lblECNameSettings.TabIndex = 35;
            this.lblECNameSettings.Text = "Name: ";
            // 
            // lblECSettings
            // 
            this.lblECSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblECSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblECSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblECSettings.ForeColor = System.Drawing.Color.HotPink;
            this.lblECSettings.Location = new System.Drawing.Point(530, 112);
            this.lblECSettings.Name = "lblECSettings";
            this.lblECSettings.Size = new System.Drawing.Size(364, 46);
            this.lblECSettings.TabIndex = 32;
            this.lblECSettings.Text = "Emergency Contact";
            this.lblECSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSavePassword
            // 
            this.btnSavePassword.Active1 = System.Drawing.Color.HotPink;
            this.btnSavePassword.Active2 = System.Drawing.Color.HotPink;
            this.btnSavePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnSavePassword.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSavePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePassword.ForeColor = System.Drawing.Color.White;
            this.btnSavePassword.Inactive1 = System.Drawing.Color.HotPink;
            this.btnSavePassword.Inactive2 = System.Drawing.Color.HotPink;
            this.btnSavePassword.Location = new System.Drawing.Point(455, 653);
            this.btnSavePassword.Name = "btnSavePassword";
            this.btnSavePassword.Radius = 37;
            this.btnSavePassword.Size = new System.Drawing.Size(421, 75);
            this.btnSavePassword.Stroke = false;
            this.btnSavePassword.StrokeColor = System.Drawing.Color.Gray;
            this.btnSavePassword.TabIndex = 17;
            this.btnSavePassword.Text = "Save password";
            this.btnSavePassword.Transparency = false;
            this.btnSavePassword.Click += new System.EventHandler(this.btnSavePassword_Click);
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.Active1 = System.Drawing.Color.HotPink;
            this.btnSaveInfo.Active2 = System.Drawing.Color.HotPink;
            this.btnSaveInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveInfo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInfo.ForeColor = System.Drawing.Color.White;
            this.btnSaveInfo.Inactive1 = System.Drawing.Color.HotPink;
            this.btnSaveInfo.Inactive2 = System.Drawing.Color.HotPink;
            this.btnSaveInfo.Location = new System.Drawing.Point(92, 363);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Radius = 37;
            this.btnSaveInfo.Size = new System.Drawing.Size(318, 75);
            this.btnSaveInfo.Stroke = false;
            this.btnSaveInfo.StrokeColor = System.Drawing.Color.Gray;
            this.btnSaveInfo.TabIndex = 16;
            this.btnSaveInfo.Text = "Save info";
            this.btnSaveInfo.Transparency = false;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // tbxConfirmPasswordSettings
            // 
            this.tbxConfirmPasswordSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConfirmPasswordSettings.Location = new System.Drawing.Point(649, 594);
            this.tbxConfirmPasswordSettings.Name = "tbxConfirmPasswordSettings";
            this.tbxConfirmPasswordSettings.PasswordChar = '•';
            this.tbxConfirmPasswordSettings.Size = new System.Drawing.Size(245, 31);
            this.tbxConfirmPasswordSettings.TabIndex = 5;
            // 
            // tbxNewPasswordSettings
            // 
            this.tbxNewPasswordSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNewPasswordSettings.Location = new System.Drawing.Point(649, 527);
            this.tbxNewPasswordSettings.Name = "tbxNewPasswordSettings";
            this.tbxNewPasswordSettings.PasswordChar = '•';
            this.tbxNewPasswordSettings.Size = new System.Drawing.Size(245, 31);
            this.tbxNewPasswordSettings.TabIndex = 4;
            // 
            // tbxCurrentPasswordSettings
            // 
            this.tbxCurrentPasswordSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCurrentPasswordSettings.Location = new System.Drawing.Point(649, 461);
            this.tbxCurrentPasswordSettings.Name = "tbxCurrentPasswordSettings";
            this.tbxCurrentPasswordSettings.PasswordChar = '•';
            this.tbxCurrentPasswordSettings.Size = new System.Drawing.Size(245, 31);
            this.tbxCurrentPasswordSettings.TabIndex = 3;
            // 
            // tbxEmailSettings
            // 
            this.tbxEmailSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmailSettings.Location = new System.Drawing.Point(221, 311);
            this.tbxEmailSettings.Name = "tbxEmailSettings";
            this.tbxEmailSettings.Size = new System.Drawing.Size(250, 31);
            this.tbxEmailSettings.TabIndex = 2;
            // 
            // tbxPhoneNumberSettings
            // 
            this.tbxPhoneNumberSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhoneNumberSettings.Location = new System.Drawing.Point(221, 244);
            this.tbxPhoneNumberSettings.Name = "tbxPhoneNumberSettings";
            this.tbxPhoneNumberSettings.Size = new System.Drawing.Size(250, 31);
            this.tbxPhoneNumberSettings.TabIndex = 1;
            // 
            // tbxAddressSettings
            // 
            this.tbxAddressSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddressSettings.Location = new System.Drawing.Point(221, 178);
            this.tbxAddressSettings.Name = "tbxAddressSettings";
            this.tbxAddressSettings.Size = new System.Drawing.Size(250, 31);
            this.tbxAddressSettings.TabIndex = 0;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.SlateGray;
            this.lblConfirmPassword.Location = new System.Drawing.Point(416, 594);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(214, 29);
            this.lblConfirmPassword.TabIndex = 9;
            this.lblConfirmPassword.Text = "Confirm password:";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.ForeColor = System.Drawing.Color.SlateGray;
            this.lblNewPassword.Location = new System.Drawing.Point(416, 527);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(180, 29);
            this.lblNewPassword.TabIndex = 8;
            this.lblNewPassword.Text = "New password:";
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPassword.ForeColor = System.Drawing.Color.SlateGray;
            this.lblCurrentPassword.Location = new System.Drawing.Point(416, 461);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(209, 29);
            this.lblCurrentPassword.TabIndex = 7;
            this.lblCurrentPassword.Text = "Current password:";
            // 
            // lblAddressSettings
            // 
            this.lblAddressSettings.AutoSize = true;
            this.lblAddressSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressSettings.ForeColor = System.Drawing.Color.SlateGray;
            this.lblAddressSettings.Location = new System.Drawing.Point(21, 178);
            this.lblAddressSettings.Name = "lblAddressSettings";
            this.lblAddressSettings.Size = new System.Drawing.Size(108, 29);
            this.lblAddressSettings.TabIndex = 6;
            this.lblAddressSettings.Text = "Address:";
            // 
            // lblPhoneNumberSettings
            // 
            this.lblPhoneNumberSettings.AutoSize = true;
            this.lblPhoneNumberSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumberSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumberSettings.ForeColor = System.Drawing.Color.SlateGray;
            this.lblPhoneNumberSettings.Location = new System.Drawing.Point(21, 244);
            this.lblPhoneNumberSettings.Name = "lblPhoneNumberSettings";
            this.lblPhoneNumberSettings.Size = new System.Drawing.Size(177, 29);
            this.lblPhoneNumberSettings.TabIndex = 5;
            this.lblPhoneNumberSettings.Text = "Phone number:";
            // 
            // lblEmailSettings
            // 
            this.lblEmailSettings.AutoSize = true;
            this.lblEmailSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailSettings.ForeColor = System.Drawing.Color.SlateGray;
            this.lblEmailSettings.Location = new System.Drawing.Point(21, 311);
            this.lblEmailSettings.Name = "lblEmailSettings";
            this.lblEmailSettings.Size = new System.Drawing.Size(80, 29);
            this.lblEmailSettings.TabIndex = 4;
            this.lblEmailSettings.Text = "Email:";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.HotPink;
            this.lblPassword.Location = new System.Drawing.Point(421, 401);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(473, 38);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPersonalInfo
            // 
            this.lblPersonalInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonalInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalInfo.ForeColor = System.Drawing.Color.HotPink;
            this.lblPersonalInfo.Location = new System.Drawing.Point(28, 116);
            this.lblPersonalInfo.Name = "lblPersonalInfo";
            this.lblPersonalInfo.Size = new System.Drawing.Size(445, 38);
            this.lblPersonalInfo.TabIndex = 2;
            this.lblPersonalInfo.Text = "Personal info";
            this.lblPersonalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSettingsTabHeading
            // 
            this.lblSettingsTabHeading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSettingsTabHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblSettingsTabHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsTabHeading.ForeColor = System.Drawing.Color.SlateGray;
            this.lblSettingsTabHeading.Location = new System.Drawing.Point(6, 10);
            this.lblSettingsTabHeading.Name = "lblSettingsTabHeading";
            this.lblSettingsTabHeading.Size = new System.Drawing.Size(916, 100);
            this.lblSettingsTabHeading.TabIndex = 1;
            this.lblSettingsTabHeading.Text = "Settings";
            this.lblSettingsTabHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageColorTheme
            // 
            this.tabPageColorTheme.Location = new System.Drawing.Point(254, 4);
            this.tabPageColorTheme.Name = "tabPageColorTheme";
            this.tabPageColorTheme.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageColorTheme.Size = new System.Drawing.Size(928, 762);
            this.tabPageColorTheme.TabIndex = 4;
            this.tabPageColorTheme.UseVisualStyleBackColor = true;
            // 
            // cbxRelationship
            // 
            this.cbxRelationship.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxRelationship.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRelationship.FormattingEnabled = true;
            this.cbxRelationship.Location = new System.Drawing.Point(689, 272);
            this.cbxRelationship.Name = "cbxRelationship";
            this.cbxRelationship.Size = new System.Drawing.Size(205, 33);
            this.cbxRelationship.TabIndex = 48;
            // 
            // lblRelationship
            // 
            this.lblRelationship.AutoSize = true;
            this.lblRelationship.BackColor = System.Drawing.Color.Transparent;
            this.lblRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelationship.ForeColor = System.Drawing.Color.SlateGray;
            this.lblRelationship.Location = new System.Drawing.Point(530, 272);
            this.lblRelationship.Name = "lblRelationship";
            this.lblRelationship.Size = new System.Drawing.Size(153, 29);
            this.lblRelationship.TabIndex = 49;
            this.lblRelationship.Text = "Relationship:";
            // 
            // SystemAdministratorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.tabControlMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SystemAdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Bazaar Accounting - System Administrator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SystemAdministratorForm_FormClosed);
            this.tabControlMenu.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.panelMainTabBackground.ResumeLayout(false);
            this.tabPageStock.ResumeLayout(false);
            this.panelStockTabBackground.ResumeLayout(false);
            this.panelStockTabBackground.PerformLayout();
            this.tabPageDepartments.ResumeLayout(false);
            this.panelDepartmentsTabBackground.ResumeLayout(false);
            this.panelDepartmentsTabBackground.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.panelSettingsTabBackground.ResumeLayout(false);
            this.panelSettingsTabBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private VerticalTabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageDepartments;
        private System.Windows.Forms.ImageList imageListMenu;
        private System.Windows.Forms.ImageList imageListMenuYellow;
        private System.Windows.Forms.TabPage tabPageStock;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TabPage tabPageColorTheme;
        private System.Windows.Forms.Panel panelMainTabBackground;
        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.Panel panelDepartmentsTabBackground;
        private System.Windows.Forms.Panel panelStockTabBackground;
        private System.Windows.Forms.Panel panelSettingsTabBackground;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblSettingsTabHeading;
        private System.Windows.Forms.Label lblPersonalInfo;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmailSettings;
        private System.Windows.Forms.Label lblPhoneNumberSettings;
        private System.Windows.Forms.Label lblAddressSettings;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.TextBox tbxAddressSettings;
        private System.Windows.Forms.TextBox tbxConfirmPasswordSettings;
        private System.Windows.Forms.TextBox tbxNewPasswordSettings;
        private System.Windows.Forms.TextBox tbxCurrentPasswordSettings;
        private System.Windows.Forms.TextBox tbxEmailSettings;
        private System.Windows.Forms.TextBox tbxPhoneNumberSettings;
        private RoundButton btnSaveInfo;
        private RoundButton btnSavePassword;
        private RoundButton btnCreateProduct;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductTabHeading;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox tbxPurchasePrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbxWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblSellingPrice;
        private System.Windows.Forms.TextBox tbxManufacturer;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.TextBox tbxSellingPrice;
        private System.Windows.Forms.Label lblStoreIsle;
        private System.Windows.Forms.TextBox tbxWarehouseIsle;
        private System.Windows.Forms.Label lblWarehouseIsle;
        private System.Windows.Forms.TextBox tbxStoreIsle;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox tbxDepth;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.TextBox tbxWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox tbxHeight;
        private System.Windows.Forms.Label lblDimensions;
        private System.Windows.Forms.RichTextBox rtbxMessage;
        private System.Windows.Forms.Label lblProductInformation;
        private System.Windows.Forms.TextBox tbxWarehouseIsleShow;
        private System.Windows.Forms.TextBox tbxDepartmentShow;
        private System.Windows.Forms.TextBox tbxSellingPriceShow;
        private System.Windows.Forms.TextBox tbxProductNameShow;
        private System.Windows.Forms.Label lblProductNameShow;
        private System.Windows.Forms.Label lblWarehouseLocationStore;
        private System.Windows.Forms.Label lblDepartmentShow;
        private System.Windows.Forms.Label lblSellingPriceShow;
        private System.Windows.Forms.Label lblSelectProduct;
        private System.Windows.Forms.ComboBox cbxProducts;
        private System.Windows.Forms.Label lblProductsWithSameDepartment;
        private System.Windows.Forms.ListBox lbxShowAllStocksOfDepartment;
        private RoundButton btnDeleteProduct;
        private RoundButton rbSaveEc;
        private System.Windows.Forms.TextBox tbxECNameSettings;
        private System.Windows.Forms.TextBox tbxECInfoSettings;
        private System.Windows.Forms.Label lblECInfoSettings;
        private System.Windows.Forms.Label lblECNameSettings;
        private System.Windows.Forms.Label lblECSettings;
        private System.Windows.Forms.Label lblRelationship;
        private System.Windows.Forms.ComboBox cbxRelationship;
    }
}