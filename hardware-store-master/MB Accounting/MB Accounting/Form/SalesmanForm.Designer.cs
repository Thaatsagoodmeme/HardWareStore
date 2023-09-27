namespace MB_Accounting
{
    partial class SalesmanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesmanForm));
            this.imageListMenu = new System.Windows.Forms.ImageList(this.components);
            this.imageListMenuYellow = new System.Windows.Forms.ImageList(this.components);
            this.tabControlMenu = new MB_Accounting.VerticalTabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblGreetings = new System.Windows.Forms.Label();
            this.panelMainTabBackground = new System.Windows.Forms.Panel();
            this.tabPageSchedule = new System.Windows.Forms.TabPage();
            this.panelScheduleTabBackground = new System.Windows.Forms.Panel();
            this.rtbxMessage = new System.Windows.Forms.RichTextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.mcEndDate = new System.Windows.Forms.MonthCalendar();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnApply = new MB_Accounting.RoundButton();
            this.mcStartDate = new System.Windows.Forms.MonthCalendar();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblScheduleTabHeading = new System.Windows.Forms.Label();
            this.tabPageRequestStock = new System.Windows.Forms.TabPage();
            this.panelRequestStockTabBackground = new System.Windows.Forms.Panel();
            this.btnRequestStock = new MB_Accounting.RoundButton();
            this.lblRequestDescription = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.rtbxRequestDescription = new System.Windows.Forms.RichTextBox();
            this.tbxRequestQuantity = new System.Windows.Forms.TextBox();
            this.cbxProducts = new System.Windows.Forms.ComboBox();
            this.lblRequestStockHeading = new System.Windows.Forms.Label();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.panelSettingsTabBackground = new System.Windows.Forms.Panel();
            this.cbxRelationship = new System.Windows.Forms.ComboBox();
            this.lblRelationship = new System.Windows.Forms.Label();
            this.rbSaveEc = new MB_Accounting.RoundButton();
            this.tbxECNameSettings = new System.Windows.Forms.TextBox();
            this.tbxECInfoSettings = new System.Windows.Forms.TextBox();
            this.lblECInfoSettings = new System.Windows.Forms.Label();
            this.lblECNameSettings = new System.Windows.Forms.Label();
            this.lblECSettings = new System.Windows.Forms.Label();
            this.tbxConfirmPasswordSettings = new System.Windows.Forms.TextBox();
            this.tbxNewPasswordSettings = new System.Windows.Forms.TextBox();
            this.tbxCurrentPasswordSettings = new System.Windows.Forms.TextBox();
            this.tbxEmailSettings = new System.Windows.Forms.TextBox();
            this.tbxPhoneNumberSettings = new System.Windows.Forms.TextBox();
            this.tbxAddressSettings = new System.Windows.Forms.TextBox();
            this.btnSavePassword = new MB_Accounting.RoundButton();
            this.btnSaveInfo = new MB_Accounting.RoundButton();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lbllNewPassword = new System.Windows.Forms.Label();
            this.lblPasswordSettings = new System.Windows.Forms.Label();
            this.lblEmailSettings = new System.Windows.Forms.Label();
            this.lblPhoneNumberSettings = new System.Windows.Forms.Label();
            this.lblAddressSettings = new System.Windows.Forms.Label();
            this.lblPersonalInfo = new System.Windows.Forms.Label();
            this.lblSettingsTabHeading = new System.Windows.Forms.Label();
            this.tabPageColorTheme = new System.Windows.Forms.TabPage();
            this.tabControlMenu.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPageSchedule.SuspendLayout();
            this.panelScheduleTabBackground.SuspendLayout();
            this.tabPageRequestStock.SuspendLayout();
            this.panelRequestStockTabBackground.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.panelSettingsTabBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListMenu
            // 
            this.imageListMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMenu.ImageStream")));
            this.imageListMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMenu.Images.SetKeyName(0, "calendar.png");
            this.imageListMenu.Images.SetKeyName(1, "wheelbarrow.png");
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
            this.tabControlMenu.Controls.Add(this.tabPageSchedule);
            this.tabControlMenu.Controls.Add(this.tabPageRequestStock);
            this.tabControlMenu.Controls.Add(this.tabPageSettings);
            this.tabControlMenu.Controls.Add(this.tabPageColorTheme);
            this.tabControlMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMenu.ImageList = this.imageListMenu;
            this.tabControlMenu.ItemSize = new System.Drawing.Size(150, 250);
            this.tabControlMenu.Location = new System.Drawing.Point(0, -5);
            this.tabControlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.tabPageMain.Controls.Add(this.lblEmployeeName);
            this.tabPageMain.Controls.Add(this.lblGreetings);
            this.tabPageMain.Controls.Add(this.panelMainTabBackground);
            this.tabPageMain.Location = new System.Drawing.Point(254, 4);
            this.tabPageMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageMain.Size = new System.Drawing.Size(928, 762);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lblGreetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreetings.ForeColor = System.Drawing.Color.SlateGray;
            this.lblGreetings.Location = new System.Drawing.Point(6, 250);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(919, 100);
            this.lblGreetings.TabIndex = 0;
            this.lblGreetings.Text = "Greetings,";
            this.lblGreetings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMainTabBackground
            // 
            this.panelMainTabBackground.BackColor = System.Drawing.Color.White;
            this.panelMainTabBackground.Location = new System.Drawing.Point(0, 0);
            this.panelMainTabBackground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMainTabBackground.Name = "panelMainTabBackground";
            this.panelMainTabBackground.Size = new System.Drawing.Size(960, 770);
            this.panelMainTabBackground.TabIndex = 2;
            // 
            // tabPageSchedule
            // 
            this.tabPageSchedule.Controls.Add(this.panelScheduleTabBackground);
            this.tabPageSchedule.ImageIndex = 0;
            this.tabPageSchedule.Location = new System.Drawing.Point(254, 4);
            this.tabPageSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSchedule.Name = "tabPageSchedule";
            this.tabPageSchedule.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSchedule.Size = new System.Drawing.Size(928, 762);
            this.tabPageSchedule.TabIndex = 1;
            this.tabPageSchedule.Text = "Vacation";
            this.tabPageSchedule.UseVisualStyleBackColor = true;
            // 
            // panelScheduleTabBackground
            // 
            this.panelScheduleTabBackground.BackColor = System.Drawing.Color.White;
            this.panelScheduleTabBackground.Controls.Add(this.rtbxMessage);
            this.panelScheduleTabBackground.Controls.Add(this.lblMessage);
            this.panelScheduleTabBackground.Controls.Add(this.mcEndDate);
            this.panelScheduleTabBackground.Controls.Add(this.lblEndDate);
            this.panelScheduleTabBackground.Controls.Add(this.btnApply);
            this.panelScheduleTabBackground.Controls.Add(this.mcStartDate);
            this.panelScheduleTabBackground.Controls.Add(this.lblStartDate);
            this.panelScheduleTabBackground.Controls.Add(this.lblScheduleTabHeading);
            this.panelScheduleTabBackground.Location = new System.Drawing.Point(0, 0);
            this.panelScheduleTabBackground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelScheduleTabBackground.Name = "panelScheduleTabBackground";
            this.panelScheduleTabBackground.Size = new System.Drawing.Size(960, 770);
            this.panelScheduleTabBackground.TabIndex = 3;
            // 
            // rtbxMessage
            // 
            this.rtbxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbxMessage.Location = new System.Drawing.Point(660, 249);
            this.rtbxMessage.Name = "rtbxMessage";
            this.rtbxMessage.Size = new System.Drawing.Size(227, 162);
            this.rtbxMessage.TabIndex = 53;
            this.rtbxMessage.Text = "";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(712, 201);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(118, 29);
            this.lblMessage.TabIndex = 52;
            this.lblMessage.Text = "Message:";
            // 
            // mcEndDate
            // 
            this.mcEndDate.Location = new System.Drawing.Point(356, 249);
            this.mcEndDate.MaxSelectionCount = 1;
            this.mcEndDate.Name = "mcEndDate";
            this.mcEndDate.TabIndex = 51;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(411, 201);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(115, 29);
            this.lblEndDate.TabIndex = 50;
            this.lblEndDate.Text = "End date:";
            // 
            // btnApply
            // 
            this.btnApply.Active1 = System.Drawing.Color.HotPink;
            this.btnApply.Active2 = System.Drawing.Color.HotPink;
            this.btnApply.BackColor = System.Drawing.Color.Transparent;
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Inactive1 = System.Drawing.Color.HotPink;
            this.btnApply.Inactive2 = System.Drawing.Color.HotPink;
            this.btnApply.Location = new System.Drawing.Point(262, 568);
            this.btnApply.Name = "btnApply";
            this.btnApply.Radius = 65;
            this.btnApply.Size = new System.Drawing.Size(365, 133);
            this.btnApply.Stroke = false;
            this.btnApply.StrokeColor = System.Drawing.Color.Gray;
            this.btnApply.TabIndex = 49;
            this.btnApply.Text = "Apply";
            this.btnApply.Transparency = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // mcStartDate
            // 
            this.mcStartDate.Location = new System.Drawing.Point(47, 249);
            this.mcStartDate.MaxSelectionCount = 1;
            this.mcStartDate.Name = "mcStartDate";
            this.mcStartDate.TabIndex = 48;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(100, 201);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(121, 29);
            this.lblStartDate.TabIndex = 47;
            this.lblStartDate.Text = "Start date:";
            // 
            // lblScheduleTabHeading
            // 
            this.lblScheduleTabHeading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScheduleTabHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblScheduleTabHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduleTabHeading.ForeColor = System.Drawing.Color.SlateGray;
            this.lblScheduleTabHeading.Location = new System.Drawing.Point(6, 10);
            this.lblScheduleTabHeading.Name = "lblScheduleTabHeading";
            this.lblScheduleTabHeading.Size = new System.Drawing.Size(916, 100);
            this.lblScheduleTabHeading.TabIndex = 0;
            this.lblScheduleTabHeading.Text = "My Schedule";
            this.lblScheduleTabHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageRequestStock
            // 
            this.tabPageRequestStock.Controls.Add(this.panelRequestStockTabBackground);
            this.tabPageRequestStock.ImageIndex = 1;
            this.tabPageRequestStock.Location = new System.Drawing.Point(254, 4);
            this.tabPageRequestStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageRequestStock.Name = "tabPageRequestStock";
            this.tabPageRequestStock.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageRequestStock.Size = new System.Drawing.Size(928, 762);
            this.tabPageRequestStock.TabIndex = 2;
            this.tabPageRequestStock.Text = "Request stock";
            this.tabPageRequestStock.UseVisualStyleBackColor = true;
            // 
            // panelRequestStockTabBackground
            // 
            this.panelRequestStockTabBackground.BackColor = System.Drawing.Color.White;
            this.panelRequestStockTabBackground.Controls.Add(this.btnRequestStock);
            this.panelRequestStockTabBackground.Controls.Add(this.lblRequestDescription);
            this.panelRequestStockTabBackground.Controls.Add(this.lblQuantity);
            this.panelRequestStockTabBackground.Controls.Add(this.lblProduct);
            this.panelRequestStockTabBackground.Controls.Add(this.rtbxRequestDescription);
            this.panelRequestStockTabBackground.Controls.Add(this.tbxRequestQuantity);
            this.panelRequestStockTabBackground.Controls.Add(this.cbxProducts);
            this.panelRequestStockTabBackground.Controls.Add(this.lblRequestStockHeading);
            this.panelRequestStockTabBackground.Location = new System.Drawing.Point(0, 0);
            this.panelRequestStockTabBackground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRequestStockTabBackground.Name = "panelRequestStockTabBackground";
            this.panelRequestStockTabBackground.Size = new System.Drawing.Size(960, 770);
            this.panelRequestStockTabBackground.TabIndex = 3;
            // 
            // btnRequestStock
            // 
            this.btnRequestStock.Active1 = System.Drawing.Color.HotPink;
            this.btnRequestStock.Active2 = System.Drawing.Color.HotPink;
            this.btnRequestStock.BackColor = System.Drawing.Color.Transparent;
            this.btnRequestStock.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRequestStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestStock.ForeColor = System.Drawing.Color.White;
            this.btnRequestStock.Inactive1 = System.Drawing.Color.HotPink;
            this.btnRequestStock.Inactive2 = System.Drawing.Color.HotPink;
            this.btnRequestStock.Location = new System.Drawing.Point(245, 631);
            this.btnRequestStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRequestStock.Name = "btnRequestStock";
            this.btnRequestStock.Radius = 37;
            this.btnRequestStock.Size = new System.Drawing.Size(421, 75);
            this.btnRequestStock.Stroke = false;
            this.btnRequestStock.StrokeColor = System.Drawing.Color.Gray;
            this.btnRequestStock.TabIndex = 12;
            this.btnRequestStock.Text = "Make request";
            this.btnRequestStock.Transparency = false;
            this.btnRequestStock.Click += new System.EventHandler(this.btnRequestStock_Click);
            // 
            // lblRequestDescription
            // 
            this.lblRequestDescription.AutoSize = true;
            this.lblRequestDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblRequestDescription.ForeColor = System.Drawing.Color.SlateGray;
            this.lblRequestDescription.Location = new System.Drawing.Point(114, 364);
            this.lblRequestDescription.Name = "lblRequestDescription";
            this.lblRequestDescription.Size = new System.Drawing.Size(138, 58);
            this.lblRequestDescription.TabIndex = 7;
            this.lblRequestDescription.Text = "Request \r\ndescription:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.ForeColor = System.Drawing.Color.SlateGray;
            this.lblQuantity.Location = new System.Drawing.Point(114, 297);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(106, 29);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct.ForeColor = System.Drawing.Color.SlateGray;
            this.lblProduct.Location = new System.Drawing.Point(114, 229);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(102, 29);
            this.lblProduct.TabIndex = 5;
            this.lblProduct.Text = "Product:";
            // 
            // rtbxRequestDescription
            // 
            this.rtbxRequestDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbxRequestDescription.Location = new System.Drawing.Point(324, 367);
            this.rtbxRequestDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbxRequestDescription.Name = "rtbxRequestDescription";
            this.rtbxRequestDescription.Size = new System.Drawing.Size(401, 182);
            this.rtbxRequestDescription.TabIndex = 4;
            this.rtbxRequestDescription.Text = "";
            // 
            // tbxRequestQuantity
            // 
            this.tbxRequestQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRequestQuantity.Location = new System.Drawing.Point(324, 297);
            this.tbxRequestQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxRequestQuantity.Name = "tbxRequestQuantity";
            this.tbxRequestQuantity.Size = new System.Drawing.Size(401, 31);
            this.tbxRequestQuantity.TabIndex = 3;
            // 
            // cbxProducts
            // 
            this.cbxProducts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxProducts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProducts.FormattingEnabled = true;
            this.cbxProducts.Location = new System.Drawing.Point(324, 229);
            this.cbxProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxProducts.Name = "cbxProducts";
            this.cbxProducts.Size = new System.Drawing.Size(401, 33);
            this.cbxProducts.TabIndex = 2;
            // 
            // lblRequestStockHeading
            // 
            this.lblRequestStockHeading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRequestStockHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblRequestStockHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestStockHeading.ForeColor = System.Drawing.Color.SlateGray;
            this.lblRequestStockHeading.Location = new System.Drawing.Point(6, 10);
            this.lblRequestStockHeading.Name = "lblRequestStockHeading";
            this.lblRequestStockHeading.Size = new System.Drawing.Size(919, 100);
            this.lblRequestStockHeading.TabIndex = 1;
            this.lblRequestStockHeading.Text = "Request stock";
            this.lblRequestStockHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.panelSettingsTabBackground);
            this.tabPageSettings.ImageIndex = 2;
            this.tabPageSettings.Location = new System.Drawing.Point(254, 4);
            this.tabPageSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSettings.Size = new System.Drawing.Size(928, 762);
            this.tabPageSettings.TabIndex = 3;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // panelSettingsTabBackground
            // 
            this.panelSettingsTabBackground.BackColor = System.Drawing.Color.White;
            this.panelSettingsTabBackground.Controls.Add(this.cbxRelationship);
            this.panelSettingsTabBackground.Controls.Add(this.lblRelationship);
            this.panelSettingsTabBackground.Controls.Add(this.rbSaveEc);
            this.panelSettingsTabBackground.Controls.Add(this.tbxECNameSettings);
            this.panelSettingsTabBackground.Controls.Add(this.tbxECInfoSettings);
            this.panelSettingsTabBackground.Controls.Add(this.lblECInfoSettings);
            this.panelSettingsTabBackground.Controls.Add(this.lblECNameSettings);
            this.panelSettingsTabBackground.Controls.Add(this.lblECSettings);
            this.panelSettingsTabBackground.Controls.Add(this.tbxConfirmPasswordSettings);
            this.panelSettingsTabBackground.Controls.Add(this.tbxNewPasswordSettings);
            this.panelSettingsTabBackground.Controls.Add(this.tbxCurrentPasswordSettings);
            this.panelSettingsTabBackground.Controls.Add(this.tbxEmailSettings);
            this.panelSettingsTabBackground.Controls.Add(this.tbxPhoneNumberSettings);
            this.panelSettingsTabBackground.Controls.Add(this.tbxAddressSettings);
            this.panelSettingsTabBackground.Controls.Add(this.btnSavePassword);
            this.panelSettingsTabBackground.Controls.Add(this.btnSaveInfo);
            this.panelSettingsTabBackground.Controls.Add(this.lblCurrentPassword);
            this.panelSettingsTabBackground.Controls.Add(this.lblConfirmPassword);
            this.panelSettingsTabBackground.Controls.Add(this.lbllNewPassword);
            this.panelSettingsTabBackground.Controls.Add(this.lblPasswordSettings);
            this.panelSettingsTabBackground.Controls.Add(this.lblEmailSettings);
            this.panelSettingsTabBackground.Controls.Add(this.lblPhoneNumberSettings);
            this.panelSettingsTabBackground.Controls.Add(this.lblAddressSettings);
            this.panelSettingsTabBackground.Controls.Add(this.lblPersonalInfo);
            this.panelSettingsTabBackground.Controls.Add(this.lblSettingsTabHeading);
            this.panelSettingsTabBackground.Location = new System.Drawing.Point(0, 0);
            this.panelSettingsTabBackground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSettingsTabBackground.Name = "panelSettingsTabBackground";
            this.panelSettingsTabBackground.Size = new System.Drawing.Size(960, 770);
            this.panelSettingsTabBackground.TabIndex = 0;
            // 
            // cbxRelationship
            // 
            this.cbxRelationship.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxRelationship.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRelationship.FormattingEnabled = true;
            this.cbxRelationship.Location = new System.Drawing.Point(700, 269);
            this.cbxRelationship.Name = "cbxRelationship";
            this.cbxRelationship.Size = new System.Drawing.Size(199, 33);
            this.cbxRelationship.TabIndex = 48;
            // 
            // lblRelationship
            // 
            this.lblRelationship.AutoSize = true;
            this.lblRelationship.BackColor = System.Drawing.Color.Transparent;
            this.lblRelationship.ForeColor = System.Drawing.Color.SlateGray;
            this.lblRelationship.Location = new System.Drawing.Point(531, 273);
            this.lblRelationship.Name = "lblRelationship";
            this.lblRelationship.Size = new System.Drawing.Size(153, 29);
            this.lblRelationship.TabIndex = 47;
            this.lblRelationship.Text = "Relationship:";
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
            this.rbSaveEc.Location = new System.Drawing.Point(552, 328);
            this.rbSaveEc.Name = "rbSaveEc";
            this.rbSaveEc.Radius = 37;
            this.rbSaveEc.Size = new System.Drawing.Size(347, 75);
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
            this.tbxECNameSettings.Location = new System.Drawing.Point(701, 177);
            this.tbxECNameSettings.Name = "tbxECNameSettings";
            this.tbxECNameSettings.Size = new System.Drawing.Size(198, 31);
            this.tbxECNameSettings.TabIndex = 33;
            // 
            // tbxECInfoSettings
            // 
            this.tbxECInfoSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxECInfoSettings.Location = new System.Drawing.Point(702, 223);
            this.tbxECInfoSettings.Name = "tbxECInfoSettings";
            this.tbxECInfoSettings.Size = new System.Drawing.Size(198, 31);
            this.tbxECInfoSettings.TabIndex = 34;
            // 
            // lblECInfoSettings
            // 
            this.lblECInfoSettings.AutoSize = true;
            this.lblECInfoSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblECInfoSettings.ForeColor = System.Drawing.Color.SlateGray;
            this.lblECInfoSettings.Location = new System.Drawing.Point(531, 225);
            this.lblECInfoSettings.Name = "lblECInfoSettings";
            this.lblECInfoSettings.Size = new System.Drawing.Size(145, 29);
            this.lblECInfoSettings.TabIndex = 36;
            this.lblECInfoSettings.Text = "Contact Info:";
            // 
            // lblECNameSettings
            // 
            this.lblECNameSettings.AutoSize = true;
            this.lblECNameSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblECNameSettings.ForeColor = System.Drawing.Color.SlateGray;
            this.lblECNameSettings.Location = new System.Drawing.Point(530, 177);
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
            this.lblECSettings.Location = new System.Drawing.Point(528, 116);
            this.lblECSettings.Name = "lblECSettings";
            this.lblECSettings.Size = new System.Drawing.Size(364, 38);
            this.lblECSettings.TabIndex = 32;
            this.lblECSettings.Text = "Emergency Contact";
            this.lblECSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxConfirmPasswordSettings
            // 
            this.tbxConfirmPasswordSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConfirmPasswordSettings.Location = new System.Drawing.Point(651, 598);
            this.tbxConfirmPasswordSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxConfirmPasswordSettings.Name = "tbxConfirmPasswordSettings";
            this.tbxConfirmPasswordSettings.PasswordChar = '•';
            this.tbxConfirmPasswordSettings.Size = new System.Drawing.Size(248, 31);
            this.tbxConfirmPasswordSettings.TabIndex = 5;
            // 
            // tbxNewPasswordSettings
            // 
            this.tbxNewPasswordSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNewPasswordSettings.Location = new System.Drawing.Point(651, 531);
            this.tbxNewPasswordSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxNewPasswordSettings.Name = "tbxNewPasswordSettings";
            this.tbxNewPasswordSettings.PasswordChar = '•';
            this.tbxNewPasswordSettings.Size = new System.Drawing.Size(248, 31);
            this.tbxNewPasswordSettings.TabIndex = 4;
            // 
            // tbxCurrentPasswordSettings
            // 
            this.tbxCurrentPasswordSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCurrentPasswordSettings.Location = new System.Drawing.Point(651, 465);
            this.tbxCurrentPasswordSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxCurrentPasswordSettings.Name = "tbxCurrentPasswordSettings";
            this.tbxCurrentPasswordSettings.PasswordChar = '•';
            this.tbxCurrentPasswordSettings.Size = new System.Drawing.Size(248, 31);
            this.tbxCurrentPasswordSettings.TabIndex = 3;
            // 
            // tbxEmailSettings
            // 
            this.tbxEmailSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmailSettings.Location = new System.Drawing.Point(237, 310);
            this.tbxEmailSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxEmailSettings.Name = "tbxEmailSettings";
            this.tbxEmailSettings.Size = new System.Drawing.Size(249, 31);
            this.tbxEmailSettings.TabIndex = 2;
            // 
            // tbxPhoneNumberSettings
            // 
            this.tbxPhoneNumberSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhoneNumberSettings.Location = new System.Drawing.Point(237, 243);
            this.tbxPhoneNumberSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPhoneNumberSettings.Name = "tbxPhoneNumberSettings";
            this.tbxPhoneNumberSettings.Size = new System.Drawing.Size(249, 31);
            this.tbxPhoneNumberSettings.TabIndex = 1;
            // 
            // tbxAddressSettings
            // 
            this.tbxAddressSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddressSettings.Location = new System.Drawing.Point(237, 177);
            this.tbxAddressSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAddressSettings.Name = "tbxAddressSettings";
            this.tbxAddressSettings.Size = new System.Drawing.Size(249, 31);
            this.tbxAddressSettings.TabIndex = 0;
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
            this.btnSavePassword.Location = new System.Drawing.Point(453, 657);
            this.btnSavePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSavePassword.Name = "btnSavePassword";
            this.btnSavePassword.Radius = 37;
            this.btnSavePassword.Size = new System.Drawing.Size(421, 75);
            this.btnSavePassword.Stroke = false;
            this.btnSavePassword.StrokeColor = System.Drawing.Color.Gray;
            this.btnSavePassword.TabIndex = 11;
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
            this.btnSaveInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Radius = 37;
            this.btnSaveInfo.Size = new System.Drawing.Size(318, 75);
            this.btnSaveInfo.Stroke = false;
            this.btnSaveInfo.StrokeColor = System.Drawing.Color.Gray;
            this.btnSaveInfo.TabIndex = 10;
            this.btnSaveInfo.Text = "Save info";
            this.btnSaveInfo.Transparency = false;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPassword.ForeColor = System.Drawing.Color.SlateGray;
            this.lblCurrentPassword.Location = new System.Drawing.Point(402, 465);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(209, 29);
            this.lblCurrentPassword.TabIndex = 9;
            this.lblCurrentPassword.Text = "Current password:";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.SlateGray;
            this.lblConfirmPassword.Location = new System.Drawing.Point(402, 598);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(214, 29);
            this.lblConfirmPassword.TabIndex = 8;
            this.lblConfirmPassword.Text = "Confirm password:";
            // 
            // lbllNewPassword
            // 
            this.lbllNewPassword.AutoSize = true;
            this.lbllNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbllNewPassword.ForeColor = System.Drawing.Color.SlateGray;
            this.lbllNewPassword.Location = new System.Drawing.Point(402, 531);
            this.lbllNewPassword.Name = "lbllNewPassword";
            this.lbllNewPassword.Size = new System.Drawing.Size(180, 29);
            this.lbllNewPassword.TabIndex = 7;
            this.lbllNewPassword.Text = "New password:";
            // 
            // lblPasswordSettings
            // 
            this.lblPasswordSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPasswordSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordSettings.ForeColor = System.Drawing.Color.HotPink;
            this.lblPasswordSettings.Location = new System.Drawing.Point(407, 406);
            this.lblPasswordSettings.Name = "lblPasswordSettings";
            this.lblPasswordSettings.Size = new System.Drawing.Size(493, 38);
            this.lblPasswordSettings.TabIndex = 6;
            this.lblPasswordSettings.Text = "Password";
            this.lblPasswordSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmailSettings
            // 
            this.lblEmailSettings.AutoSize = true;
            this.lblEmailSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailSettings.ForeColor = System.Drawing.Color.SlateGray;
            this.lblEmailSettings.Location = new System.Drawing.Point(18, 310);
            this.lblEmailSettings.Name = "lblEmailSettings";
            this.lblEmailSettings.Size = new System.Drawing.Size(80, 29);
            this.lblEmailSettings.TabIndex = 5;
            this.lblEmailSettings.Text = "Email:";
            // 
            // lblPhoneNumberSettings
            // 
            this.lblPhoneNumberSettings.AutoSize = true;
            this.lblPhoneNumberSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumberSettings.ForeColor = System.Drawing.Color.SlateGray;
            this.lblPhoneNumberSettings.Location = new System.Drawing.Point(18, 243);
            this.lblPhoneNumberSettings.Name = "lblPhoneNumberSettings";
            this.lblPhoneNumberSettings.Size = new System.Drawing.Size(177, 29);
            this.lblPhoneNumberSettings.TabIndex = 4;
            this.lblPhoneNumberSettings.Text = "Phone number:";
            // 
            // lblAddressSettings
            // 
            this.lblAddressSettings.AutoSize = true;
            this.lblAddressSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressSettings.ForeColor = System.Drawing.Color.SlateGray;
            this.lblAddressSettings.Location = new System.Drawing.Point(18, 177);
            this.lblAddressSettings.Name = "lblAddressSettings";
            this.lblAddressSettings.Size = new System.Drawing.Size(108, 29);
            this.lblAddressSettings.TabIndex = 3;
            this.lblAddressSettings.Text = "Address:";
            // 
            // lblPersonalInfo
            // 
            this.lblPersonalInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonalInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalInfo.ForeColor = System.Drawing.Color.HotPink;
            this.lblPersonalInfo.Location = new System.Drawing.Point(28, 116);
            this.lblPersonalInfo.Name = "lblPersonalInfo";
            this.lblPersonalInfo.Size = new System.Drawing.Size(463, 38);
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
            this.tabPageColorTheme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageColorTheme.Name = "tabPageColorTheme";
            this.tabPageColorTheme.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageColorTheme.Size = new System.Drawing.Size(928, 762);
            this.tabPageColorTheme.TabIndex = 4;
            this.tabPageColorTheme.UseVisualStyleBackColor = true;
            // 
            // SalesmanForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.tabControlMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalesmanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Bazaar Accounting - Salesman";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SalesmanForm_FormClosed);
            this.tabControlMenu.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageSchedule.ResumeLayout(false);
            this.panelScheduleTabBackground.ResumeLayout(false);
            this.panelScheduleTabBackground.PerformLayout();
            this.tabPageRequestStock.ResumeLayout(false);
            this.panelRequestStockTabBackground.ResumeLayout(false);
            this.panelRequestStockTabBackground.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.panelSettingsTabBackground.ResumeLayout(false);
            this.panelSettingsTabBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private VerticalTabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageSchedule;
        private System.Windows.Forms.TabPage tabPageRequestStock;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TabPage tabPageColorTheme;
        private System.Windows.Forms.ImageList imageListMenu;
        private System.Windows.Forms.ImageList imageListMenuYellow;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.Panel panelMainTabBackground;
        private System.Windows.Forms.Panel panelScheduleTabBackground;
        private System.Windows.Forms.Label lblScheduleTabHeading;
        private System.Windows.Forms.Panel panelRequestStockTabBackground;
        private System.Windows.Forms.Panel panelSettingsTabBackground;
        private System.Windows.Forms.TextBox tbxConfirmPasswordSettings;
        private System.Windows.Forms.TextBox tbxNewPasswordSettings;
        private System.Windows.Forms.TextBox tbxCurrentPasswordSettings;
        private System.Windows.Forms.TextBox tbxEmailSettings;
        private System.Windows.Forms.TextBox tbxPhoneNumberSettings;
        private System.Windows.Forms.TextBox tbxAddressSettings;
        private RoundButton btnSavePassword;
        private RoundButton btnSaveInfo;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lbllNewPassword;
        private System.Windows.Forms.Label lblPasswordSettings;
        private System.Windows.Forms.Label lblEmailSettings;
        private System.Windows.Forms.Label lblPhoneNumberSettings;
        private System.Windows.Forms.Label lblAddressSettings;
        private System.Windows.Forms.Label lblPersonalInfo;
        private System.Windows.Forms.Label lblSettingsTabHeading;
        private RoundButton btnRequestStock;
        private System.Windows.Forms.Label lblRequestDescription;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.RichTextBox rtbxRequestDescription;
        private System.Windows.Forms.TextBox tbxRequestQuantity;
        private System.Windows.Forms.ComboBox cbxProducts;
        private System.Windows.Forms.Label lblRequestStockHeading;
        private System.Windows.Forms.RichTextBox rtbxMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.MonthCalendar mcEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private RoundButton btnApply;
        private System.Windows.Forms.MonthCalendar mcStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private RoundButton rbSaveEc;
        private System.Windows.Forms.TextBox tbxECNameSettings;
        private System.Windows.Forms.TextBox tbxECInfoSettings;
        private System.Windows.Forms.Label lblECInfoSettings;
        private System.Windows.Forms.Label lblECNameSettings;
        private System.Windows.Forms.Label lblECSettings;
        private System.Windows.Forms.ComboBox cbxRelationship;
        private System.Windows.Forms.Label lblRelationship;
    }
}