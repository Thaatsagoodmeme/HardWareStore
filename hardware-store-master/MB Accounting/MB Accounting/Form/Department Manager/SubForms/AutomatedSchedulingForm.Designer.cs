
namespace MB_Accounting
{
    partial class AutomatedSchedulingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutomatedSchedulingForm));
            this.pictureBoxBackPink = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackYellow = new System.Windows.Forms.PictureBox();
            this.lvSunday = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvSaturday = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvFriday = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvThursday = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvWednesday = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvTuesday = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvMonday = new System.Windows.Forms.ListView();
            this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmployeeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnShiftId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSunday = new System.Windows.Forms.Label();
            this.lblSaturday = new System.Windows.Forms.Label();
            this.lblFriday = new System.Windows.Forms.Label();
            this.lblThursday = new System.Windows.Forms.Label();
            this.lblWednesday = new System.Windows.Forms.Label();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.lblMonday = new System.Windows.Forms.Label();
            this.rbtSuggest = new MB_Accounting.RoundButton();
            this.pbxSpinner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackPink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBackPink
            // 
            this.pictureBoxBackPink.Image = global::MB_Accounting.Properties.Resources.previous_pink;
            this.pictureBoxBackPink.Location = new System.Drawing.Point(24, 21);
            this.pictureBoxBackPink.Name = "pictureBoxBackPink";
            this.pictureBoxBackPink.Size = new System.Drawing.Size(93, 74);
            this.pictureBoxBackPink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackPink.TabIndex = 39;
            this.pictureBoxBackPink.TabStop = false;
            this.pictureBoxBackPink.Click += new System.EventHandler(this.pictureBoxBackPink_Click);
            // 
            // pictureBoxBackYellow
            // 
            this.pictureBoxBackYellow.Image = global::MB_Accounting.Properties.Resources.previous_yellow;
            this.pictureBoxBackYellow.Location = new System.Drawing.Point(24, 21);
            this.pictureBoxBackYellow.Name = "pictureBoxBackYellow";
            this.pictureBoxBackYellow.Size = new System.Drawing.Size(93, 74);
            this.pictureBoxBackYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackYellow.TabIndex = 40;
            this.pictureBoxBackYellow.TabStop = false;
            this.pictureBoxBackYellow.Click += new System.EventHandler(this.pictureBoxBackYellow_Click);
            // 
            // lvSunday
            // 
            this.lvSunday.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.lvSunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSunday.FullRowSelect = true;
            this.lvSunday.GridLines = true;
            this.lvSunday.HideSelection = false;
            this.lvSunday.Location = new System.Drawing.Point(716, 400);
            this.lvSunday.Name = "lvSunday";
            this.lvSunday.Size = new System.Drawing.Size(185, 215);
            this.lvSunday.TabIndex = 63;
            this.lvSunday.UseCompatibleStateImageBehavior = false;
            this.lvSunday.View = System.Windows.Forms.View.Details;
            this.lvSunday.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvSunday_MouseDown);
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "T";
            this.columnHeader16.Width = 20;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Employee name";
            this.columnHeader17.Width = 161;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Width = 0;
            // 
            // lvSaturday
            // 
            this.lvSaturday.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.lvSaturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSaturday.FullRowSelect = true;
            this.lvSaturday.GridLines = true;
            this.lvSaturday.HideSelection = false;
            this.lvSaturday.Location = new System.Drawing.Point(480, 400);
            this.lvSaturday.Name = "lvSaturday";
            this.lvSaturday.Size = new System.Drawing.Size(185, 215);
            this.lvSaturday.TabIndex = 62;
            this.lvSaturday.UseCompatibleStateImageBehavior = false;
            this.lvSaturday.View = System.Windows.Forms.View.Details;
            this.lvSaturday.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvSaturday_MouseDown);
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "T";
            this.columnHeader13.Width = 20;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Employee name";
            this.columnHeader14.Width = 161;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Width = 0;
            // 
            // lvFriday
            // 
            this.lvFriday.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lvFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvFriday.FullRowSelect = true;
            this.lvFriday.GridLines = true;
            this.lvFriday.HideSelection = false;
            this.lvFriday.Location = new System.Drawing.Point(245, 400);
            this.lvFriday.Name = "lvFriday";
            this.lvFriday.Size = new System.Drawing.Size(185, 215);
            this.lvFriday.TabIndex = 61;
            this.lvFriday.UseCompatibleStateImageBehavior = false;
            this.lvFriday.View = System.Windows.Forms.View.Details;
            this.lvFriday.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvFriday_MouseDown);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "T";
            this.columnHeader10.Width = 20;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Employee name";
            this.columnHeader11.Width = 161;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Width = 0;
            // 
            // lvThursday
            // 
            this.lvThursday.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvThursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvThursday.FullRowSelect = true;
            this.lvThursday.GridLines = true;
            this.lvThursday.HideSelection = false;
            this.lvThursday.Location = new System.Drawing.Point(856, 125);
            this.lvThursday.Name = "lvThursday";
            this.lvThursday.Size = new System.Drawing.Size(185, 215);
            this.lvThursday.TabIndex = 60;
            this.lvThursday.UseCompatibleStateImageBehavior = false;
            this.lvThursday.View = System.Windows.Forms.View.Details;
            this.lvThursday.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvThursday_MouseDown);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "T";
            this.columnHeader7.Width = 20;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Employee name";
            this.columnHeader8.Width = 161;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Width = 0;
            // 
            // lvWednesday
            // 
            this.lvWednesday.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvWednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvWednesday.FullRowSelect = true;
            this.lvWednesday.GridLines = true;
            this.lvWednesday.HideSelection = false;
            this.lvWednesday.Location = new System.Drawing.Point(629, 125);
            this.lvWednesday.Name = "lvWednesday";
            this.lvWednesday.Size = new System.Drawing.Size(185, 215);
            this.lvWednesday.TabIndex = 59;
            this.lvWednesday.UseCompatibleStateImageBehavior = false;
            this.lvWednesday.View = System.Windows.Forms.View.Details;
            this.lvWednesday.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvWednesday_MouseDown);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "T";
            this.columnHeader4.Width = 20;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Employee name";
            this.columnHeader5.Width = 161;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Width = 0;
            // 
            // lvTuesday
            // 
            this.lvTuesday.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTuesday.FullRowSelect = true;
            this.lvTuesday.GridLines = true;
            this.lvTuesday.HideSelection = false;
            this.lvTuesday.Location = new System.Drawing.Point(385, 125);
            this.lvTuesday.Name = "lvTuesday";
            this.lvTuesday.Size = new System.Drawing.Size(185, 215);
            this.lvTuesday.TabIndex = 58;
            this.lvTuesday.UseCompatibleStateImageBehavior = false;
            this.lvTuesday.View = System.Windows.Forms.View.Details;
            this.lvTuesday.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvTuesday_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "T";
            this.columnHeader1.Width = 20;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Employee name";
            this.columnHeader2.Width = 161;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 0;
            // 
            // lvMonday
            // 
            this.lvMonday.BackColor = System.Drawing.SystemColors.Window;
            this.lvMonday.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTime,
            this.columnEmployeeName,
            this.columnShiftId});
            this.lvMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMonday.FullRowSelect = true;
            this.lvMonday.GridLines = true;
            this.lvMonday.HideSelection = false;
            this.lvMonday.Location = new System.Drawing.Point(156, 125);
            this.lvMonday.Name = "lvMonday";
            this.lvMonday.Size = new System.Drawing.Size(185, 215);
            this.lvMonday.TabIndex = 57;
            this.lvMonday.UseCompatibleStateImageBehavior = false;
            this.lvMonday.View = System.Windows.Forms.View.Details;
            this.lvMonday.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvMonday_MouseDown);
            // 
            // columnTime
            // 
            this.columnTime.Text = "T";
            this.columnTime.Width = 20;
            // 
            // columnEmployeeName
            // 
            this.columnEmployeeName.Text = "Employee name";
            this.columnEmployeeName.Width = 161;
            // 
            // columnShiftId
            // 
            this.columnShiftId.Width = 0;
            // 
            // lblSunday
            // 
            this.lblSunday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSunday.BackColor = System.Drawing.Color.Transparent;
            this.lblSunday.ForeColor = System.Drawing.Color.DimGray;
            this.lblSunday.Location = new System.Drawing.Point(716, 362);
            this.lblSunday.Name = "lblSunday";
            this.lblSunday.Size = new System.Drawing.Size(185, 35);
            this.lblSunday.TabIndex = 56;
            this.lblSunday.Text = "Sunday";
            this.lblSunday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaturday
            // 
            this.lblSaturday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaturday.BackColor = System.Drawing.Color.Transparent;
            this.lblSaturday.ForeColor = System.Drawing.Color.DimGray;
            this.lblSaturday.Location = new System.Drawing.Point(480, 362);
            this.lblSaturday.Name = "lblSaturday";
            this.lblSaturday.Size = new System.Drawing.Size(185, 35);
            this.lblSaturday.TabIndex = 55;
            this.lblSaturday.Text = "Saturday";
            this.lblSaturday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFriday
            // 
            this.lblFriday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFriday.BackColor = System.Drawing.Color.Transparent;
            this.lblFriday.ForeColor = System.Drawing.Color.DimGray;
            this.lblFriday.Location = new System.Drawing.Point(245, 362);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(185, 35);
            this.lblFriday.TabIndex = 54;
            this.lblFriday.Text = "Friday";
            this.lblFriday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThursday
            // 
            this.lblThursday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThursday.BackColor = System.Drawing.Color.Transparent;
            this.lblThursday.ForeColor = System.Drawing.Color.DimGray;
            this.lblThursday.Location = new System.Drawing.Point(856, 87);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblThursday.Size = new System.Drawing.Size(185, 35);
            this.lblThursday.TabIndex = 53;
            this.lblThursday.Text = "Thursday";
            this.lblThursday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWednesday
            // 
            this.lblWednesday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWednesday.BackColor = System.Drawing.Color.Transparent;
            this.lblWednesday.ForeColor = System.Drawing.Color.DimGray;
            this.lblWednesday.Location = new System.Drawing.Point(624, 87);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(190, 35);
            this.lblWednesday.TabIndex = 52;
            this.lblWednesday.Text = "Wednesday";
            this.lblWednesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTuesday
            // 
            this.lblTuesday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTuesday.BackColor = System.Drawing.Color.Transparent;
            this.lblTuesday.ForeColor = System.Drawing.Color.DimGray;
            this.lblTuesday.Location = new System.Drawing.Point(385, 87);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(185, 35);
            this.lblTuesday.TabIndex = 51;
            this.lblTuesday.Text = "Tuesday";
            this.lblTuesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonday
            // 
            this.lblMonday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonday.BackColor = System.Drawing.Color.Transparent;
            this.lblMonday.ForeColor = System.Drawing.Color.DimGray;
            this.lblMonday.Location = new System.Drawing.Point(156, 87);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(185, 35);
            this.lblMonday.TabIndex = 50;
            this.lblMonday.Text = "Monday";
            this.lblMonday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtSuggest
            // 
            this.rbtSuggest.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.rbtSuggest.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.rbtSuggest.BackColor = System.Drawing.Color.Transparent;
            this.rbtSuggest.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.rbtSuggest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtSuggest.ForeColor = System.Drawing.Color.White;
            this.rbtSuggest.Inactive1 = System.Drawing.Color.HotPink;
            this.rbtSuggest.Inactive2 = System.Drawing.Color.HotPink;
            this.rbtSuggest.Location = new System.Drawing.Point(934, 441);
            this.rbtSuggest.Name = "rbtSuggest";
            this.rbtSuggest.Radius = 55;
            this.rbtSuggest.Size = new System.Drawing.Size(195, 108);
            this.rbtSuggest.Stroke = false;
            this.rbtSuggest.StrokeColor = System.Drawing.Color.Gray;
            this.rbtSuggest.TabIndex = 66;
            this.rbtSuggest.Text = "Suggest";
            this.rbtSuggest.Transparency = false;
            this.rbtSuggest.Click += new System.EventHandler(this.rbtSuggest_Click);
            // 
            // pbxSpinner
            // 
            this.pbxSpinner.BackColor = System.Drawing.Color.Transparent;
            this.pbxSpinner.Image = global::MB_Accounting.Properties.Resources.mbloading;
            this.pbxSpinner.Location = new System.Drawing.Point(141, 79);
            this.pbxSpinner.Name = "pbxSpinner";
            this.pbxSpinner.Size = new System.Drawing.Size(988, 536);
            this.pbxSpinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxSpinner.TabIndex = 67;
            this.pbxSpinner.TabStop = false;
            this.pbxSpinner.Visible = false;
            // 
            // AutomatedSchedulingForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pbxSpinner);
            this.Controls.Add(this.rbtSuggest);
            this.Controls.Add(this.lvSunday);
            this.Controls.Add(this.lvSaturday);
            this.Controls.Add(this.lvFriday);
            this.Controls.Add(this.lvThursday);
            this.Controls.Add(this.lvWednesday);
            this.Controls.Add(this.lvTuesday);
            this.Controls.Add(this.lvMonday);
            this.Controls.Add(this.lblSunday);
            this.Controls.Add(this.lblSaturday);
            this.Controls.Add(this.lblFriday);
            this.Controls.Add(this.lblThursday);
            this.Controls.Add(this.lblWednesday);
            this.Controls.Add(this.lblTuesday);
            this.Controls.Add(this.lblMonday);
            this.Controls.Add(this.pictureBoxBackPink);
            this.Controls.Add(this.pictureBoxBackYellow);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutomatedSchedulingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Bazaar Accounting - Check Automated Scheduling";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackPink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpinner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBackPink;
        private System.Windows.Forms.PictureBox pictureBoxBackYellow;
        private System.Windows.Forms.ListView lvSunday;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ListView lvSaturday;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ListView lvFriday;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ListView lvThursday;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView lvWednesday;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lvTuesday;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvMonday;
        private System.Windows.Forms.ColumnHeader columnTime;
        private System.Windows.Forms.ColumnHeader columnEmployeeName;
        private System.Windows.Forms.ColumnHeader columnShiftId;
        private System.Windows.Forms.Label lblSunday;
        private System.Windows.Forms.Label lblSaturday;
        private System.Windows.Forms.Label lblFriday;
        private System.Windows.Forms.Label lblThursday;
        private System.Windows.Forms.Label lblWednesday;
        private System.Windows.Forms.Label lblTuesday;
        private System.Windows.Forms.Label lblMonday;
        private RoundButton rbtSuggest;
        private System.Windows.Forms.PictureBox pbxSpinner;
    }
}