namespace MB_Accounting
{
    partial class EmployeesInDepartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesInDepartmentForm));
            this.pictureBoxSun = new System.Windows.Forms.PictureBox();
            this.pictureBoxMoon = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackPink = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackYellow = new System.Windows.Forms.PictureBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.cbxDepartments = new System.Windows.Forms.ComboBox();
            this.lbxEmployees = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackPink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackYellow)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSun
            // 
            this.pictureBoxSun.Image = global::MB_Accounting.Properties.Resources.sun;
            this.pictureBoxSun.Location = new System.Drawing.Point(1066, 654);
            this.pictureBoxSun.Name = "pictureBoxSun";
            this.pictureBoxSun.Size = new System.Drawing.Size(86, 62);
            this.pictureBoxSun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSun.TabIndex = 31;
            this.pictureBoxSun.TabStop = false;
            this.pictureBoxSun.Click += new System.EventHandler(this.pictureBoxSun_Click);
            // 
            // pictureBoxMoon
            // 
            this.pictureBoxMoon.Image = global::MB_Accounting.Properties.Resources.moon;
            this.pictureBoxMoon.Location = new System.Drawing.Point(1066, 654);
            this.pictureBoxMoon.Name = "pictureBoxMoon";
            this.pictureBoxMoon.Size = new System.Drawing.Size(86, 62);
            this.pictureBoxMoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMoon.TabIndex = 32;
            this.pictureBoxMoon.TabStop = false;
            this.pictureBoxMoon.Click += new System.EventHandler(this.pictureBoxMoon_Click);
            // 
            // pictureBoxBackPink
            // 
            this.pictureBoxBackPink.Image = global::MB_Accounting.Properties.Resources.previous_pink;
            this.pictureBoxBackPink.Location = new System.Drawing.Point(55, 168);
            this.pictureBoxBackPink.Name = "pictureBoxBackPink";
            this.pictureBoxBackPink.Size = new System.Drawing.Size(93, 74);
            this.pictureBoxBackPink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackPink.TabIndex = 33;
            this.pictureBoxBackPink.TabStop = false;
            this.pictureBoxBackPink.Click += new System.EventHandler(this.pictureBoxBackPink_Click);
            // 
            // pictureBoxBackYellow
            // 
            this.pictureBoxBackYellow.Image = global::MB_Accounting.Properties.Resources.previous_yellow;
            this.pictureBoxBackYellow.Location = new System.Drawing.Point(55, 168);
            this.pictureBoxBackYellow.Name = "pictureBoxBackYellow";
            this.pictureBoxBackYellow.Size = new System.Drawing.Size(93, 74);
            this.pictureBoxBackYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackYellow.TabIndex = 34;
            this.pictureBoxBackYellow.TabStop = false;
            this.pictureBoxBackYellow.Click += new System.EventHandler(this.pictureBoxBackYellow_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.SlateGray;
            this.lblHeading.Location = new System.Drawing.Point(6, 10);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(1176, 100);
            this.lblHeading.TabIndex = 37;
            this.lblHeading.Text = "Employees In A Department";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelect
            // 
            this.lblSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelect.BackColor = System.Drawing.Color.Transparent;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.ForeColor = System.Drawing.Color.HotPink;
            this.lblSelect.Location = new System.Drawing.Point(393, 152);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(400, 36);
            this.lblSelect.TabIndex = 36;
            this.lblSelect.Text = "Select Department";
            this.lblSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxDepartments
            // 
            this.cbxDepartments.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxDepartments.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDepartments.FormattingEnabled = true;
            this.cbxDepartments.Location = new System.Drawing.Point(393, 192);
            this.cbxDepartments.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDepartments.Name = "cbxDepartments";
            this.cbxDepartments.Size = new System.Drawing.Size(400, 33);
            this.cbxDepartments.TabIndex = 35;
            this.cbxDepartments.SelectedIndexChanged += new System.EventHandler(this.cbxDepartments_SelectedIndexChanged);
            // 
            // lbxEmployees
            // 
            this.lbxEmployees.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbxEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxEmployees.FormattingEnabled = true;
            this.lbxEmployees.ItemHeight = 25;
            this.lbxEmployees.Location = new System.Drawing.Point(159, 253);
            this.lbxEmployees.Name = "lbxEmployees";
            this.lbxEmployees.Size = new System.Drawing.Size(876, 404);
            this.lbxEmployees.TabIndex = 38;
            // 
            // EmployeesInDepartmentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.lbxEmployees);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.cbxDepartments);
            this.Controls.Add(this.pictureBoxBackPink);
            this.Controls.Add(this.pictureBoxMoon);
            this.Controls.Add(this.pictureBoxSun);
            this.Controls.Add(this.pictureBoxBackYellow);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeesInDepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Bazaar Accounting - Employees In A Department";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackPink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackYellow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSun;
        private System.Windows.Forms.PictureBox pictureBoxMoon;
        private System.Windows.Forms.PictureBox pictureBoxBackPink;
        private System.Windows.Forms.PictureBox pictureBoxBackYellow;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox cbxDepartments;
        private System.Windows.Forms.ListBox lbxEmployees;
    }
}