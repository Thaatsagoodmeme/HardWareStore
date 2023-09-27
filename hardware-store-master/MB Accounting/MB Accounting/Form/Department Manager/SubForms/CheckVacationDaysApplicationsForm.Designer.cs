namespace MB_Accounting
{
    partial class CheckVacationDaysApplicationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckVacationDaysApplicationsForm));
            this.lblHeading = new System.Windows.Forms.Label();
            this.pictureBoxMoon = new System.Windows.Forms.PictureBox();
            this.pictureBoxSun = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackPink = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackYellow = new System.Windows.Forms.PictureBox();
            this.btnApprove = new MB_Accounting.RoundButton();
            this.lbxApplications = new System.Windows.Forms.ListBox();
            this.btnDecline = new MB_Accounting.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackPink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackYellow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.SlateGray;
            this.lblHeading.Location = new System.Drawing.Point(5, 35);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(1175, 100);
            this.lblHeading.TabIndex = 30;
            this.lblHeading.Text = "Check Vacation Applications";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxMoon
            // 
            this.pictureBoxMoon.Image = global::MB_Accounting.Properties.Resources.moon;
            this.pictureBoxMoon.Location = new System.Drawing.Point(1066, 654);
            this.pictureBoxMoon.Name = "pictureBoxMoon";
            this.pictureBoxMoon.Size = new System.Drawing.Size(86, 62);
            this.pictureBoxMoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMoon.TabIndex = 36;
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
            this.pictureBoxSun.TabIndex = 37;
            this.pictureBoxSun.TabStop = false;
            this.pictureBoxSun.Click += new System.EventHandler(this.pictureBoxSun_Click);
            // 
            // pictureBoxBackPink
            // 
            this.pictureBoxBackPink.Image = global::MB_Accounting.Properties.Resources.previous_pink;
            this.pictureBoxBackPink.Location = new System.Drawing.Point(55, 168);
            this.pictureBoxBackPink.Name = "pictureBoxBackPink";
            this.pictureBoxBackPink.Size = new System.Drawing.Size(93, 74);
            this.pictureBoxBackPink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackPink.TabIndex = 38;
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
            this.pictureBoxBackYellow.TabIndex = 39;
            this.pictureBoxBackYellow.TabStop = false;
            this.pictureBoxBackYellow.Click += new System.EventHandler(this.pictureBoxBackYellow_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Active1 = System.Drawing.Color.HotPink;
            this.btnApprove.Active2 = System.Drawing.Color.HotPink;
            this.btnApprove.BackColor = System.Drawing.Color.Transparent;
            this.btnApprove.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Inactive1 = System.Drawing.Color.HotPink;
            this.btnApprove.Inactive2 = System.Drawing.Color.HotPink;
            this.btnApprove.Location = new System.Drawing.Point(166, 583);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Radius = 65;
            this.btnApprove.Size = new System.Drawing.Size(365, 133);
            this.btnApprove.Stroke = false;
            this.btnApprove.StrokeColor = System.Drawing.Color.Gray;
            this.btnApprove.TabIndex = 43;
            this.btnApprove.Text = "Approve";
            this.btnApprove.Transparency = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // lbxApplications
            // 
            this.lbxApplications.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxApplications.FormattingEnabled = true;
            this.lbxApplications.ItemHeight = 25;
            this.lbxApplications.Location = new System.Drawing.Point(166, 217);
            this.lbxApplications.Name = "lbxApplications";
            this.lbxApplications.Size = new System.Drawing.Size(876, 329);
            this.lbxApplications.TabIndex = 47;
            this.lbxApplications.SelectedIndexChanged += new System.EventHandler(this.lbxApplications_SelectedIndexChanged);
            // 
            // btnDecline
            // 
            this.btnDecline.Active1 = System.Drawing.Color.HotPink;
            this.btnDecline.Active2 = System.Drawing.Color.HotPink;
            this.btnDecline.BackColor = System.Drawing.Color.Transparent;
            this.btnDecline.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDecline.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecline.ForeColor = System.Drawing.Color.White;
            this.btnDecline.Inactive1 = System.Drawing.Color.HotPink;
            this.btnDecline.Inactive2 = System.Drawing.Color.HotPink;
            this.btnDecline.Location = new System.Drawing.Point(677, 583);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Radius = 65;
            this.btnDecline.Size = new System.Drawing.Size(365, 133);
            this.btnDecline.Stroke = false;
            this.btnDecline.StrokeColor = System.Drawing.Color.Gray;
            this.btnDecline.TabIndex = 48;
            this.btnDecline.Text = "Decline";
            this.btnDecline.Transparency = false;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // CheckVacationDaysApplicationsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.lbxApplications);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.pictureBoxMoon);
            this.Controls.Add(this.pictureBoxSun);
            this.Controls.Add(this.pictureBoxBackPink);
            this.Controls.Add(this.pictureBoxBackYellow);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CheckVacationDaysApplicationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Bazaar Accounting - Check Vacation Applications";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackPink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackYellow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.PictureBox pictureBoxMoon;
        private System.Windows.Forms.PictureBox pictureBoxSun;
        private System.Windows.Forms.PictureBox pictureBoxBackPink;
        private System.Windows.Forms.PictureBox pictureBoxBackYellow;
        private RoundButton btnApprove;
        private System.Windows.Forms.ListBox lbxApplications;
        private RoundButton btnDecline;
    }
}