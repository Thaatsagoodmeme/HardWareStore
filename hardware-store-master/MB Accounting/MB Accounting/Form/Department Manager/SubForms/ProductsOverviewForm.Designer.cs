
namespace MB_Accounting
{
    partial class ProductsOverviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsOverviewForm));
            this.lbxProducts = new System.Windows.Forms.ListBox();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.pictureBoxBackPink = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackYellow = new System.Windows.Forms.PictureBox();
            this.pictureBoxMoon = new System.Windows.Forms.PictureBox();
            this.pictureBoxSun = new System.Windows.Forms.PictureBox();
            this.lblQuantity = new System.Windows.Forms.Label();
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
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackPink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSun)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxProducts
            // 
            this.lbxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxProducts.FormattingEnabled = true;
            this.lbxProducts.ItemHeight = 25;
            this.lbxProducts.Location = new System.Drawing.Point(178, 168);
            this.lbxProducts.Margin = new System.Windows.Forms.Padding(4);
            this.lbxProducts.Name = "lbxProducts";
            this.lbxProducts.Size = new System.Drawing.Size(524, 154);
            this.lbxProducts.TabIndex = 0;
            this.lbxProducts.SelectedValueChanged += new System.EventHandler(this.lbxProducts_SelectedValueChanged);
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxQuantity.Location = new System.Drawing.Point(252, 613);
            this.tbxQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(207, 31);
            this.tbxQuantity.TabIndex = 4;
            // 
            // lblHeading
            // 
            this.lblHeading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.SlateGray;
            this.lblHeading.Location = new System.Drawing.Point(5, 35);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(1175, 100);
            this.lblHeading.TabIndex = 30;
            this.lblHeading.Text = "Products Overview";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxBackPink
            // 
            this.pictureBoxBackPink.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBackPink.Image = global::MB_Accounting.Properties.Resources.previous_pink;
            this.pictureBoxBackPink.Location = new System.Drawing.Point(55, 168);
            this.pictureBoxBackPink.Name = "pictureBoxBackPink";
            this.pictureBoxBackPink.Size = new System.Drawing.Size(93, 74);
            this.pictureBoxBackPink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackPink.TabIndex = 43;
            this.pictureBoxBackPink.TabStop = false;
            this.pictureBoxBackPink.Click += new System.EventHandler(this.pictureBoxBackPink_Click);
            // 
            // pictureBoxBackYellow
            // 
            this.pictureBoxBackYellow.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBackYellow.Image = global::MB_Accounting.Properties.Resources.previous_yellow;
            this.pictureBoxBackYellow.Location = new System.Drawing.Point(55, 168);
            this.pictureBoxBackYellow.Name = "pictureBoxBackYellow";
            this.pictureBoxBackYellow.Size = new System.Drawing.Size(93, 74);
            this.pictureBoxBackYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackYellow.TabIndex = 44;
            this.pictureBoxBackYellow.TabStop = false;
            this.pictureBoxBackYellow.Click += new System.EventHandler(this.pictureBoxBackYellow_Click);
            // 
            // pictureBoxMoon
            // 
            this.pictureBoxMoon.Image = global::MB_Accounting.Properties.Resources.moon;
            this.pictureBoxMoon.Location = new System.Drawing.Point(1066, 654);
            this.pictureBoxMoon.Name = "pictureBoxMoon";
            this.pictureBoxMoon.Size = new System.Drawing.Size(86, 62);
            this.pictureBoxMoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMoon.TabIndex = 45;
            this.pictureBoxMoon.TabStop = false;
            this.pictureBoxMoon.Click += new System.EventHandler(this.pictureBoxMoon_Click);
            // 
            // pictureBoxSun
            // 
            this.pictureBoxSun.Image = global::MB_Accounting.Properties.Resources.sun;
            this.pictureBoxSun.Location = new System.Drawing.Point(1066, 654);
            this.pictureBoxSun.Name = "pictureBoxSun";
            this.pictureBoxSun.Size = new System.Drawing.Size(86, 62);
            this.pictureBoxSun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSun.TabIndex = 46;
            this.pictureBoxSun.TabStop = false;
            this.pictureBoxSun.Click += new System.EventHandler(this.pictureBoxSun_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.SlateGray;
            this.lblQuantity.Location = new System.Drawing.Point(62, 615);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(106, 29);
            this.lblQuantity.TabIndex = 48;
            this.lblQuantity.Text = "Quantity:";
            // 
            // rtbxMessage
            // 
            this.rtbxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbxMessage.Location = new System.Drawing.Point(921, 352);
            this.rtbxMessage.Name = "rtbxMessage";
            this.rtbxMessage.Size = new System.Drawing.Size(231, 263);
            this.rtbxMessage.TabIndex = 81;
            this.rtbxMessage.Text = "";
            // 
            // lblStoreIsle
            // 
            this.lblStoreIsle.AutoSize = true;
            this.lblStoreIsle.BackColor = System.Drawing.Color.Transparent;
            this.lblStoreIsle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStoreIsle.ForeColor = System.Drawing.Color.SlateGray;
            this.lblStoreIsle.Location = new System.Drawing.Point(560, 591);
            this.lblStoreIsle.Name = "lblStoreIsle";
            this.lblStoreIsle.Size = new System.Drawing.Size(69, 25);
            this.lblStoreIsle.TabIndex = 80;
            this.lblStoreIsle.Text = "Store:";
            // 
            // tbxWarehouseIsle
            // 
            this.tbxWarehouseIsle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxWarehouseIsle.Location = new System.Drawing.Point(690, 635);
            this.tbxWarehouseIsle.Name = "tbxWarehouseIsle";
            this.tbxWarehouseIsle.Size = new System.Drawing.Size(207, 28);
            this.tbxWarehouseIsle.TabIndex = 78;
            // 
            // lblWarehouseIsle
            // 
            this.lblWarehouseIsle.AutoSize = true;
            this.lblWarehouseIsle.BackColor = System.Drawing.Color.Transparent;
            this.lblWarehouseIsle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWarehouseIsle.ForeColor = System.Drawing.Color.SlateGray;
            this.lblWarehouseIsle.Location = new System.Drawing.Point(535, 638);
            this.lblWarehouseIsle.Name = "lblWarehouseIsle";
            this.lblWarehouseIsle.Size = new System.Drawing.Size(128, 25);
            this.lblWarehouseIsle.TabIndex = 79;
            this.lblWarehouseIsle.Text = "Warehouse:";
            // 
            // tbxStoreIsle
            // 
            this.tbxStoreIsle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxStoreIsle.Location = new System.Drawing.Point(690, 586);
            this.tbxStoreIsle.Name = "tbxStoreIsle";
            this.tbxStoreIsle.Size = new System.Drawing.Size(207, 28);
            this.tbxStoreIsle.TabIndex = 76;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLocation.ForeColor = System.Drawing.Color.SlateGray;
            this.lblLocation.Location = new System.Drawing.Point(525, 545);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(140, 26);
            this.lblLocation.TabIndex = 77;
            this.lblLocation.Text = "Isle Location:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.BackColor = System.Drawing.Color.Transparent;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeight.ForeColor = System.Drawing.Color.SlateGray;
            this.lblHeight.Location = new System.Drawing.Point(556, 391);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(80, 25);
            this.lblHeight.TabIndex = 75;
            this.lblHeight.Text = "Height:";
            // 
            // tbxDepth
            // 
            this.tbxDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxDepth.Location = new System.Drawing.Point(690, 490);
            this.tbxDepth.Name = "tbxDepth";
            this.tbxDepth.Size = new System.Drawing.Size(207, 28);
            this.tbxDepth.TabIndex = 72;
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.BackColor = System.Drawing.Color.Transparent;
            this.lblDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDepth.ForeColor = System.Drawing.Color.SlateGray;
            this.lblDepth.Location = new System.Drawing.Point(562, 492);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(75, 25);
            this.lblDepth.TabIndex = 74;
            this.lblDepth.Text = "Depth:";
            // 
            // tbxWidth
            // 
            this.tbxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxWidth.Location = new System.Drawing.Point(690, 438);
            this.tbxWidth.Name = "tbxWidth";
            this.tbxWidth.Size = new System.Drawing.Size(207, 28);
            this.tbxWidth.TabIndex = 71;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.BackColor = System.Drawing.Color.Transparent;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWidth.ForeColor = System.Drawing.Color.SlateGray;
            this.lblWidth.Location = new System.Drawing.Point(560, 440);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(73, 25);
            this.lblWidth.TabIndex = 73;
            this.lblWidth.Text = "Width:";
            // 
            // tbxHeight
            // 
            this.tbxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxHeight.Location = new System.Drawing.Point(690, 391);
            this.tbxHeight.Name = "tbxHeight";
            this.tbxHeight.Size = new System.Drawing.Size(207, 28);
            this.tbxHeight.TabIndex = 69;
            // 
            // lblDimensions
            // 
            this.lblDimensions.AutoSize = true;
            this.lblDimensions.BackColor = System.Drawing.Color.Transparent;
            this.lblDimensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDimensions.ForeColor = System.Drawing.Color.SlateGray;
            this.lblDimensions.Location = new System.Drawing.Point(525, 347);
            this.lblDimensions.Name = "lblDimensions";
            this.lblDimensions.Size = new System.Drawing.Size(146, 29);
            this.lblDimensions.TabIndex = 70;
            this.lblDimensions.Text = "Dimensions:";
            // 
            // tbxSellingPrice
            // 
            this.tbxSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxSellingPrice.Location = new System.Drawing.Point(252, 498);
            this.tbxSellingPrice.Name = "tbxSellingPrice";
            this.tbxSellingPrice.Size = new System.Drawing.Size(207, 31);
            this.tbxSellingPrice.TabIndex = 68;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription.ForeColor = System.Drawing.Color.SlateGray;
            this.lblDescription.Location = new System.Drawing.Point(963, 311);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(141, 29);
            this.lblDescription.TabIndex = 67;
            this.lblDescription.Text = "Description:";
            // 
            // tbxWeight
            // 
            this.tbxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxWeight.Location = new System.Drawing.Point(252, 552);
            this.tbxWeight.Name = "tbxWeight";
            this.tbxWeight.Size = new System.Drawing.Size(207, 31);
            this.tbxWeight.TabIndex = 63;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.BackColor = System.Drawing.Color.Transparent;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWeight.ForeColor = System.Drawing.Color.SlateGray;
            this.lblWeight.Location = new System.Drawing.Point(62, 558);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(94, 29);
            this.lblWeight.TabIndex = 66;
            this.lblWeight.Text = "Weight:";
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.AutoSize = true;
            this.lblSellingPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSellingPrice.ForeColor = System.Drawing.Color.SlateGray;
            this.lblSellingPrice.Location = new System.Drawing.Point(47, 498);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(156, 29);
            this.lblSellingPrice.TabIndex = 65;
            this.lblSellingPrice.Text = "Selling Price:";
            // 
            // tbxManufacturer
            // 
            this.tbxManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxManufacturer.Location = new System.Drawing.Point(252, 394);
            this.tbxManufacturer.Name = "tbxManufacturer";
            this.tbxManufacturer.Size = new System.Drawing.Size(207, 31);
            this.tbxManufacturer.TabIndex = 62;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.BackColor = System.Drawing.Color.Transparent;
            this.lblManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblManufacturer.ForeColor = System.Drawing.Color.SlateGray;
            this.lblManufacturer.Location = new System.Drawing.Point(44, 397);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(158, 29);
            this.lblManufacturer.TabIndex = 64;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // tbxPurchasePrice
            // 
            this.tbxPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxPurchasePrice.Location = new System.Drawing.Point(252, 449);
            this.tbxPurchasePrice.Name = "tbxPurchasePrice";
            this.tbxPurchasePrice.Size = new System.Drawing.Size(207, 31);
            this.tbxPurchasePrice.TabIndex = 57;
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPurchasePrice.ForeColor = System.Drawing.Color.SlateGray;
            this.lblPurchasePrice.Location = new System.Drawing.Point(35, 452);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(182, 29);
            this.lblPurchasePrice.TabIndex = 61;
            this.lblPurchasePrice.Text = "Purchase Price:";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxProductName.Location = new System.Drawing.Point(252, 344);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(207, 31);
            this.tbxProductName.TabIndex = 56;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductName.ForeColor = System.Drawing.Color.SlateGray;
            this.lblProductName.Location = new System.Drawing.Point(39, 348);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(168, 29);
            this.lblProductName.TabIndex = 59;
            this.lblProductName.Text = "Product name:";
            // 
            // ProductsOverviewForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.rtbxMessage);
            this.Controls.Add(this.lblStoreIsle);
            this.Controls.Add(this.tbxWarehouseIsle);
            this.Controls.Add(this.lblWarehouseIsle);
            this.Controls.Add(this.tbxStoreIsle);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.tbxDepth);
            this.Controls.Add(this.lblDepth);
            this.Controls.Add(this.tbxWidth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.tbxHeight);
            this.Controls.Add(this.lblDimensions);
            this.Controls.Add(this.tbxSellingPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tbxWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblSellingPrice);
            this.Controls.Add(this.tbxManufacturer);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.tbxPurchasePrice);
            this.Controls.Add(this.lblPurchasePrice);
            this.Controls.Add(this.tbxProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.pictureBoxMoon);
            this.Controls.Add(this.pictureBoxBackPink);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.lbxProducts);
            this.Controls.Add(this.pictureBoxBackYellow);
            this.Controls.Add(this.pictureBoxSun);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductsOverviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Bazaar Accounting - Products Overview";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackPink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxProducts;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.PictureBox pictureBoxBackPink;
        private System.Windows.Forms.PictureBox pictureBoxBackYellow;
        private System.Windows.Forms.PictureBox pictureBoxMoon;
        private System.Windows.Forms.PictureBox pictureBoxSun;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.RichTextBox rtbxMessage;
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
        private System.Windows.Forms.TextBox tbxSellingPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbxWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblSellingPrice;
        private System.Windows.Forms.TextBox tbxManufacturer;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.TextBox tbxPurchasePrice;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
    }
}