namespace MB_Accounting
{
    partial class CheckWorkShiftsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckWorkShiftsForm));
            this.lblHeading = new System.Windows.Forms.Label();
            this.pictureBoxMoon = new System.Windows.Forms.PictureBox();
            this.pictureBoxSun = new System.Windows.Forms.PictureBox();
            this.lvSchedule = new System.Windows.Forms.ListView();
            this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmployeeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnShiftId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmpId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSelect = new System.Windows.Forms.Label();
            this.cbxEmployees = new System.Windows.Forms.ComboBox();
            this.cbMorning = new System.Windows.Forms.CheckBox();
            this.cbAfternoon = new System.Windows.Forms.CheckBox();
            this.cbEvening = new System.Windows.Forms.CheckBox();
            this.cbRegular = new System.Windows.Forms.CheckBox();
            this.lblHoursAllowed = new System.Windows.Forms.Label();
            this.lblHoursLeft = new System.Windows.Forms.Label();
            this.tbxHoursAllowed = new System.Windows.Forms.TextBox();
            this.tbxHoursLeft = new System.Windows.Forms.TextBox();
            this.pictureBoxBackPink = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackYellow = new System.Windows.Forms.PictureBox();
            this.lvAvailability = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblAvailability = new System.Windows.Forms.Label();
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
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.SlateGray;
            this.lblHeading.Location = new System.Drawing.Point(5, 10);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(1175, 100);
            this.lblHeading.TabIndex = 31;
            this.lblHeading.Text = "Work Shifts for Monday";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxMoon
            // 
            this.pictureBoxMoon.Image = global::MB_Accounting.Properties.Resources.moon;
            this.pictureBoxMoon.Location = new System.Drawing.Point(1066, 654);
            this.pictureBoxMoon.Name = "pictureBoxMoon";
            this.pictureBoxMoon.Size = new System.Drawing.Size(86, 62);
            this.pictureBoxMoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMoon.TabIndex = 41;
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
            this.pictureBoxSun.TabIndex = 42;
            this.pictureBoxSun.TabStop = false;
            this.pictureBoxSun.Click += new System.EventHandler(this.pictureBoxSun_Click);
            // 
            // lvSchedule
            // 
            this.lvSchedule.BackColor = System.Drawing.Color.White;
            this.lvSchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTime,
            this.columnEmployeeName,
            this.columnShiftId,
            this.columnEmpId});
            this.lvSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSchedule.FullRowSelect = true;
            this.lvSchedule.GridLines = true;
            this.lvSchedule.HideSelection = false;
            this.lvSchedule.Location = new System.Drawing.Point(383, 202);
            this.lvSchedule.Name = "lvSchedule";
            this.lvSchedule.Size = new System.Drawing.Size(400, 508);
            this.lvSchedule.TabIndex = 43;
            this.lvSchedule.UseCompatibleStateImageBehavior = false;
            this.lvSchedule.View = System.Windows.Forms.View.Details;
            this.lvSchedule.SelectedIndexChanged += new System.EventHandler(this.lvSchedule_SelectedIndexChanged);
            // 
            // columnTime
            // 
            this.columnTime.Text = "T";
            this.columnTime.Width = 20;
            // 
            // columnEmployeeName
            // 
            this.columnEmployeeName.Text = "Employee name";
            this.columnEmployeeName.Width = 376;
            // 
            // columnShiftId
            // 
            this.columnShiftId.Width = 0;
            // 
            // columnEmpId
            // 
            this.columnEmpId.Width = 0;
            // 
            // lblSelect
            // 
            this.lblSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelect.BackColor = System.Drawing.Color.Transparent;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.ForeColor = System.Drawing.Color.HotPink;
            this.lblSelect.Location = new System.Drawing.Point(13, 106);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(1158, 30);
            this.lblSelect.TabIndex = 45;
            this.lblSelect.Text = "Select Employee";
            this.lblSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxEmployees
            // 
            this.cbxEmployees.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxEmployees.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEmployees.FormattingEnabled = true;
            this.cbxEmployees.Location = new System.Drawing.Point(383, 142);
            this.cbxEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEmployees.Name = "cbxEmployees";
            this.cbxEmployees.Size = new System.Drawing.Size(400, 33);
            this.cbxEmployees.TabIndex = 44;
            this.cbxEmployees.SelectedIndexChanged += new System.EventHandler(this.cbxEmployees_SelectedIndexChanged);
            // 
            // cbMorning
            // 
            this.cbMorning.AutoSize = true;
            this.cbMorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMorning.Location = new System.Drawing.Point(878, 290);
            this.cbMorning.Name = "cbMorning";
            this.cbMorning.Size = new System.Drawing.Size(120, 33);
            this.cbMorning.TabIndex = 46;
            this.cbMorning.Text = "Morning";
            this.cbMorning.UseVisualStyleBackColor = true;
            this.cbMorning.CheckedChanged += new System.EventHandler(this.cbMorning_CheckedChanged);
            this.cbMorning.EnabledChanged += new System.EventHandler(this.cbMorning_EnabledChanged);
            // 
            // cbAfternoon
            // 
            this.cbAfternoon.AutoSize = true;
            this.cbAfternoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAfternoon.Location = new System.Drawing.Point(878, 360);
            this.cbAfternoon.Name = "cbAfternoon";
            this.cbAfternoon.Size = new System.Drawing.Size(135, 33);
            this.cbAfternoon.TabIndex = 47;
            this.cbAfternoon.Text = "Afternoon";
            this.cbAfternoon.UseVisualStyleBackColor = true;
            this.cbAfternoon.CheckedChanged += new System.EventHandler(this.cbAfternoon_CheckedChanged);
            this.cbAfternoon.EnabledChanged += new System.EventHandler(this.cbAfternoon_EnabledChanged);
            // 
            // cbEvening
            // 
            this.cbEvening.AutoSize = true;
            this.cbEvening.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEvening.Location = new System.Drawing.Point(878, 430);
            this.cbEvening.Name = "cbEvening";
            this.cbEvening.Size = new System.Drawing.Size(119, 33);
            this.cbEvening.TabIndex = 48;
            this.cbEvening.Text = "Evening";
            this.cbEvening.UseVisualStyleBackColor = true;
            this.cbEvening.CheckedChanged += new System.EventHandler(this.cbEvening_CheckedChanged);
            this.cbEvening.EnabledChanged += new System.EventHandler(this.cbEvening_EnabledChanged);
            // 
            // cbRegular
            // 
            this.cbRegular.AutoSize = true;
            this.cbRegular.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRegular.Location = new System.Drawing.Point(878, 500);
            this.cbRegular.Name = "cbRegular";
            this.cbRegular.Size = new System.Drawing.Size(117, 33);
            this.cbRegular.TabIndex = 49;
            this.cbRegular.Text = "Regular";
            this.cbRegular.UseVisualStyleBackColor = true;
            this.cbRegular.CheckedChanged += new System.EventHandler(this.cbRegular_CheckedChanged);
            this.cbRegular.EnabledChanged += new System.EventHandler(this.cbRegular_EnabledChanged);
            // 
            // lblHoursAllowed
            // 
            this.lblHoursAllowed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHoursAllowed.BackColor = System.Drawing.Color.Transparent;
            this.lblHoursAllowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursAllowed.ForeColor = System.Drawing.Color.HotPink;
            this.lblHoursAllowed.Location = new System.Drawing.Point(10, 240);
            this.lblHoursAllowed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoursAllowed.Name = "lblHoursAllowed";
            this.lblHoursAllowed.Size = new System.Drawing.Size(363, 30);
            this.lblHoursAllowed.TabIndex = 50;
            this.lblHoursAllowed.Text = "Hours allowed for week";
            this.lblHoursAllowed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoursLeft
            // 
            this.lblHoursLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHoursLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblHoursLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursLeft.ForeColor = System.Drawing.Color.HotPink;
            this.lblHoursLeft.Location = new System.Drawing.Point(9, 365);
            this.lblHoursLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoursLeft.Name = "lblHoursLeft";
            this.lblHoursLeft.Size = new System.Drawing.Size(363, 30);
            this.lblHoursLeft.TabIndex = 51;
            this.lblHoursLeft.Text = "Hours left for week";
            this.lblHoursLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxHoursAllowed
            // 
            this.tbxHoursAllowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHoursAllowed.Location = new System.Drawing.Point(17, 282);
            this.tbxHoursAllowed.Name = "tbxHoursAllowed";
            this.tbxHoursAllowed.Size = new System.Drawing.Size(357, 31);
            this.tbxHoursAllowed.TabIndex = 52;
            this.tbxHoursAllowed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxHoursLeft
            // 
            this.tbxHoursLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHoursLeft.Location = new System.Drawing.Point(17, 412);
            this.tbxHoursLeft.Name = "tbxHoursLeft";
            this.tbxHoursLeft.Size = new System.Drawing.Size(357, 31);
            this.tbxHoursLeft.TabIndex = 53;
            this.tbxHoursLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxBackPink
            // 
            this.pictureBoxBackPink.Image = global::MB_Accounting.Properties.Resources.previous_pink;
            this.pictureBoxBackPink.Location = new System.Drawing.Point(55, 136);
            this.pictureBoxBackPink.Name = "pictureBoxBackPink";
            this.pictureBoxBackPink.Size = new System.Drawing.Size(93, 74);
            this.pictureBoxBackPink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackPink.TabIndex = 54;
            this.pictureBoxBackPink.TabStop = false;
            this.pictureBoxBackPink.Click += new System.EventHandler(this.pictureBoxBackPink_Click);
            // 
            // pictureBoxBackYellow
            // 
            this.pictureBoxBackYellow.Image = global::MB_Accounting.Properties.Resources.previous_yellow;
            this.pictureBoxBackYellow.Location = new System.Drawing.Point(55, 136);
            this.pictureBoxBackYellow.Name = "pictureBoxBackYellow";
            this.pictureBoxBackYellow.Size = new System.Drawing.Size(93, 74);
            this.pictureBoxBackYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackYellow.TabIndex = 55;
            this.pictureBoxBackYellow.TabStop = false;
            this.pictureBoxBackYellow.Click += new System.EventHandler(this.pictureBoxBackYellow_Click);
            // 
            // lvAvailability
            // 
            this.lvAvailability.BackColor = System.Drawing.Color.White;
            this.lvAvailability.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAvailability.FullRowSelect = true;
            this.lvAvailability.GridLines = true;
            this.lvAvailability.HideSelection = false;
            this.lvAvailability.Location = new System.Drawing.Point(33, 520);
            this.lvAvailability.Name = "lvAvailability";
            this.lvAvailability.Size = new System.Drawing.Size(313, 196);
            this.lvAvailability.TabIndex = 56;
            this.lvAvailability.UseCompatibleStateImageBehavior = false;
            this.lvAvailability.View = System.Windows.Forms.View.Details;
            this.lvAvailability.SelectedIndexChanged += new System.EventHandler(this.lvAvailability_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "T";
            this.columnHeader1.Width = 20;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Employee name";
            this.columnHeader2.Width = 289;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 0;
            // 
            // lblAvailability
            // 
            this.lblAvailability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvailability.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailability.ForeColor = System.Drawing.Color.HotPink;
            this.lblAvailability.Location = new System.Drawing.Point(13, 476);
            this.lblAvailability.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(363, 30);
            this.lblAvailability.TabIndex = 57;
            this.lblAvailability.Text = "Availability";
            this.lblAvailability.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckWorkShiftsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.lvAvailability);
            this.Controls.Add(this.pictureBoxBackPink);
            this.Controls.Add(this.pictureBoxBackYellow);
            this.Controls.Add(this.tbxHoursLeft);
            this.Controls.Add(this.tbxHoursAllowed);
            this.Controls.Add(this.lblHoursLeft);
            this.Controls.Add(this.lblHoursAllowed);
            this.Controls.Add(this.cbRegular);
            this.Controls.Add(this.cbEvening);
            this.Controls.Add(this.cbAfternoon);
            this.Controls.Add(this.cbMorning);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.cbxEmployees);
            this.Controls.Add(this.lvSchedule);
            this.Controls.Add(this.pictureBoxMoon);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.pictureBoxSun);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CheckWorkShiftsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Bazaar Accounting - Assign Work Shift";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckWorkShiftsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackPink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackYellow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.PictureBox pictureBoxMoon;
        private System.Windows.Forms.PictureBox pictureBoxSun;
        private System.Windows.Forms.ListView lvSchedule;
        private System.Windows.Forms.ColumnHeader columnTime;
        private System.Windows.Forms.ColumnHeader columnEmployeeName;
        private System.Windows.Forms.ColumnHeader columnShiftId;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox cbxEmployees;
        private System.Windows.Forms.CheckBox cbMorning;
        private System.Windows.Forms.CheckBox cbAfternoon;
        private System.Windows.Forms.CheckBox cbEvening;
        private System.Windows.Forms.CheckBox cbRegular;
        private System.Windows.Forms.ColumnHeader columnEmpId;
        private System.Windows.Forms.Label lblHoursAllowed;
        private System.Windows.Forms.Label lblHoursLeft;
        private System.Windows.Forms.TextBox tbxHoursAllowed;
        private System.Windows.Forms.TextBox tbxHoursLeft;
        private System.Windows.Forms.PictureBox pictureBoxBackPink;
        private System.Windows.Forms.PictureBox pictureBoxBackYellow;
        private System.Windows.Forms.ListView lvAvailability;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblAvailability;
    }
}