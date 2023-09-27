namespace MB_Accounting
{
    partial class CreateDepartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateDepartmentForm));
            this.lbxShowCreatedDepartments = new System.Windows.Forms.ListBox();
            this.tbxDepartmentName = new System.Windows.Forms.TextBox();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.lblDepartmentsTabHeading = new System.Windows.Forms.Label();
            this.pictureBoxBackPink = new System.Windows.Forms.PictureBox();
            this.pictureBoxMoon = new System.Windows.Forms.PictureBox();
            this.pictureBoxSun = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackYellow = new System.Windows.Forms.PictureBox();
            this.btnDeleteDepartment = new MB_Accounting.RoundButton();
            this.btnCreateDepartment = new MB_Accounting.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackPink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackYellow)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxShowCreatedDepartments
            // 
            this.lbxShowCreatedDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxShowCreatedDepartments.FormattingEnabled = true;
            this.lbxShowCreatedDepartments.ItemHeight = 25;
            this.lbxShowCreatedDepartments.Location = new System.Drawing.Point(154, 319);
            this.lbxShowCreatedDepartments.Name = "lbxShowCreatedDepartments";
            this.lbxShowCreatedDepartments.Size = new System.Drawing.Size(878, 304);
            this.lbxShowCreatedDepartments.TabIndex = 22;
            // 
            // tbxDepartmentName
            // 
            this.tbxDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDepartmentName.Location = new System.Drawing.Point(154, 209);
            this.tbxDepartmentName.Name = "tbxDepartmentName";
            this.tbxDepartmentName.Size = new System.Drawing.Size(878, 49);
            this.tbxDepartmentName.TabIndex = 21;
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentName.ForeColor = System.Drawing.Color.HotPink;
            this.lblDepartmentName.Location = new System.Drawing.Point(147, 152);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(325, 42);
            this.lblDepartmentName.TabIndex = 26;
            this.lblDepartmentName.Text = "Department name:";
            // 
            // lblDepartmentsTabHeading
            // 
            this.lblDepartmentsTabHeading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepartmentsTabHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmentsTabHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentsTabHeading.ForeColor = System.Drawing.Color.SlateGray;
            this.lblDepartmentsTabHeading.Location = new System.Drawing.Point(6, 10);
            this.lblDepartmentsTabHeading.Name = "lblDepartmentsTabHeading";
            this.lblDepartmentsTabHeading.Size = new System.Drawing.Size(1174, 100);
            this.lblDepartmentsTabHeading.TabIndex = 25;
            this.lblDepartmentsTabHeading.Text = "Departments";
            this.lblDepartmentsTabHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxBackPink
            // 
            this.pictureBoxBackPink.Image = global::MB_Accounting.Properties.Resources.previous_pink;
            this.pictureBoxBackPink.Location = new System.Drawing.Point(34, 93);
            this.pictureBoxBackPink.Name = "pictureBoxBackPink";
            this.pictureBoxBackPink.Size = new System.Drawing.Size(93, 74);
            this.pictureBoxBackPink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackPink.TabIndex = 32;
            this.pictureBoxBackPink.TabStop = false;
            this.pictureBoxBackPink.Click += new System.EventHandler(this.pictureBoxBackPink_Click);
            // 
            // pictureBoxMoon
            // 
            this.pictureBoxMoon.Image = global::MB_Accounting.Properties.Resources.moon;
            this.pictureBoxMoon.Location = new System.Drawing.Point(1066, 654);
            this.pictureBoxMoon.Name = "pictureBoxMoon";
            this.pictureBoxMoon.Size = new System.Drawing.Size(86, 62);
            this.pictureBoxMoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMoon.TabIndex = 33;
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
            this.pictureBoxSun.TabIndex = 34;
            this.pictureBoxSun.TabStop = false;
            this.pictureBoxSun.Click += new System.EventHandler(this.pictureBoxSun_Click);
            // 
            // pictureBoxBackYellow
            // 
            this.pictureBoxBackYellow.Image = global::MB_Accounting.Properties.Resources.previous_yellow;
            this.pictureBoxBackYellow.Location = new System.Drawing.Point(34, 93);
            this.pictureBoxBackYellow.Name = "pictureBoxBackYellow";
            this.pictureBoxBackYellow.Size = new System.Drawing.Size(93, 74);
            this.pictureBoxBackYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackYellow.TabIndex = 35;
            this.pictureBoxBackYellow.TabStop = false;
            this.pictureBoxBackYellow.Click += new System.EventHandler(this.pictureBoxBackYellow_Click);
            // 
            // btnDeleteDepartment
            // 
            this.btnDeleteDepartment.Active1 = System.Drawing.Color.HotPink;
            this.btnDeleteDepartment.Active2 = System.Drawing.Color.HotPink;
            this.btnDeleteDepartment.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteDepartment.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDeleteDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDepartment.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDepartment.Inactive1 = System.Drawing.Color.HotPink;
            this.btnDeleteDepartment.Inactive2 = System.Drawing.Color.HotPink;
            this.btnDeleteDepartment.Location = new System.Drawing.Point(602, 648);
            this.btnDeleteDepartment.Name = "btnDeleteDepartment";
            this.btnDeleteDepartment.Radius = 45;
            this.btnDeleteDepartment.Size = new System.Drawing.Size(430, 95);
            this.btnDeleteDepartment.Stroke = false;
            this.btnDeleteDepartment.StrokeColor = System.Drawing.Color.Gray;
            this.btnDeleteDepartment.TabIndex = 24;
            this.btnDeleteDepartment.Text = "Delete department";
            this.btnDeleteDepartment.Transparency = false;
            this.btnDeleteDepartment.Click += new System.EventHandler(this.btnDeleteDepartment_Click);
            // 
            // btnCreateDepartment
            // 
            this.btnCreateDepartment.Active1 = System.Drawing.Color.HotPink;
            this.btnCreateDepartment.Active2 = System.Drawing.Color.HotPink;
            this.btnCreateDepartment.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateDepartment.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCreateDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateDepartment.ForeColor = System.Drawing.Color.White;
            this.btnCreateDepartment.Inactive1 = System.Drawing.Color.HotPink;
            this.btnCreateDepartment.Inactive2 = System.Drawing.Color.HotPink;
            this.btnCreateDepartment.Location = new System.Drawing.Point(154, 648);
            this.btnCreateDepartment.Name = "btnCreateDepartment";
            this.btnCreateDepartment.Radius = 45;
            this.btnCreateDepartment.Size = new System.Drawing.Size(430, 95);
            this.btnCreateDepartment.Stroke = false;
            this.btnCreateDepartment.StrokeColor = System.Drawing.Color.Gray;
            this.btnCreateDepartment.TabIndex = 23;
            this.btnCreateDepartment.Text = "Create department";
            this.btnCreateDepartment.Transparency = false;
            this.btnCreateDepartment.Click += new System.EventHandler(this.btnCreateDepartment_Click);
            // 
            // CreateDepartmentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pictureBoxMoon);
            this.Controls.Add(this.pictureBoxSun);
            this.Controls.Add(this.pictureBoxBackPink);
            this.Controls.Add(this.lbxShowCreatedDepartments);
            this.Controls.Add(this.tbxDepartmentName);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.btnDeleteDepartment);
            this.Controls.Add(this.btnCreateDepartment);
            this.Controls.Add(this.pictureBoxBackYellow);
            this.Controls.Add(this.lblDepartmentsTabHeading);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ForeColor = System.Drawing.Color.SlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateDepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Bazaar Accounting - Departments";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackPink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackYellow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxShowCreatedDepartments;
        private System.Windows.Forms.TextBox tbxDepartmentName;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label lblDepartmentsTabHeading;
        private RoundButton btnDeleteDepartment;
        private RoundButton btnCreateDepartment;
        private System.Windows.Forms.PictureBox pictureBoxBackPink;
        private System.Windows.Forms.PictureBox pictureBoxMoon;
        private System.Windows.Forms.PictureBox pictureBoxSun;
        private System.Windows.Forms.PictureBox pictureBoxBackYellow;
    }
}