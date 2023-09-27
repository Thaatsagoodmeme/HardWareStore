
namespace MB_Accounting
{
    partial class PromoteEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PromoteEmployeeForm));
            this.tbxSalary = new System.Windows.Forms.TextBox();
            this.cbxPosition = new System.Windows.Forms.ComboBox();
            this.lblPromoteAnEmployee = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.cbxEmployees = new System.Windows.Forms.ComboBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.pictureBoxMoon = new System.Windows.Forms.PictureBox();
            this.pictureBoxSun = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackPink = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackYellow = new System.Windows.Forms.PictureBox();
            this.lblFte = new System.Windows.Forms.Label();
            this.cbxTemporary = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.nFte = new System.Windows.Forms.NumericUpDown();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblExpires = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.btnPromote = new MB_Accounting.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackPink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFte)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxSalary
            // 
            this.tbxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSalary.Location = new System.Drawing.Point(553, 312);
            this.tbxSalary.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSalary.Name = "tbxSalary";
            this.tbxSalary.Size = new System.Drawing.Size(250, 31);
            this.tbxSalary.TabIndex = 1;
            // 
            // cbxPosition
            // 
            this.cbxPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPosition.FormattingEnabled = true;
            this.cbxPosition.Location = new System.Drawing.Point(553, 424);
            this.cbxPosition.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPosition.Name = "cbxPosition";
            this.cbxPosition.Size = new System.Drawing.Size(250, 33);
            this.cbxPosition.TabIndex = 2;
            // 
            // lblPromoteAnEmployee
            // 
            this.lblPromoteAnEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPromoteAnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.lblPromoteAnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromoteAnEmployee.ForeColor = System.Drawing.Color.SlateGray;
            this.lblPromoteAnEmployee.Location = new System.Drawing.Point(6, 10);
            this.lblPromoteAnEmployee.Name = "lblPromoteAnEmployee";
            this.lblPromoteAnEmployee.Size = new System.Drawing.Size(1175, 100);
            this.lblPromoteAnEmployee.TabIndex = 29;
            this.lblPromoteAnEmployee.Text = "Promote An Employee";
            this.lblPromoteAnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelect
            // 
            this.lblSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelect.BackColor = System.Drawing.Color.Transparent;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.ForeColor = System.Drawing.Color.HotPink;
            this.lblSelect.Location = new System.Drawing.Point(370, 150);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(433, 29);
            this.lblSelect.TabIndex = 31;
            this.lblSelect.Text = "Select Employee";
            this.lblSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxEmployees
            // 
            this.cbxEmployees.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxEmployees.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEmployees.FormattingEnabled = true;
            this.cbxEmployees.Location = new System.Drawing.Point(370, 183);
            this.cbxEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEmployees.Name = "cbxEmployees";
            this.cbxEmployees.Size = new System.Drawing.Size(433, 33);
            this.cbxEmployees.TabIndex = 0;
            this.cbxEmployees.SelectedIndexChanged += new System.EventHandler(this.cbxEmployees_SelectedIndexChanged);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.Color.Transparent;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.SlateGray;
            this.lblSalary.Location = new System.Drawing.Point(362, 312);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(86, 29);
            this.lblSalary.TabIndex = 32;
            this.lblSalary.Text = "Salary:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.SlateGray;
            this.lblPosition.Location = new System.Drawing.Point(362, 424);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(106, 29);
            this.lblPosition.TabIndex = 33;
            this.lblPosition.Text = "Position:";
            // 
            // pictureBoxMoon
            // 
            this.pictureBoxMoon.Image = global::MB_Accounting.Properties.Resources.moon;
            this.pictureBoxMoon.Location = new System.Drawing.Point(1066, 654);
            this.pictureBoxMoon.Name = "pictureBoxMoon";
            this.pictureBoxMoon.Size = new System.Drawing.Size(86, 62);
            this.pictureBoxMoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMoon.TabIndex = 42;
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
            this.pictureBoxSun.TabIndex = 43;
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
            this.pictureBoxBackPink.TabIndex = 44;
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
            this.pictureBoxBackYellow.TabIndex = 45;
            this.pictureBoxBackYellow.TabStop = false;
            this.pictureBoxBackYellow.Click += new System.EventHandler(this.pictureBoxBackYellow_Click);
            // 
            // lblFte
            // 
            this.lblFte.AutoSize = true;
            this.lblFte.BackColor = System.Drawing.Color.Transparent;
            this.lblFte.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFte.ForeColor = System.Drawing.Color.SlateGray;
            this.lblFte.Location = new System.Drawing.Point(362, 368);
            this.lblFte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFte.Name = "lblFte";
            this.lblFte.Size = new System.Drawing.Size(66, 29);
            this.lblFte.TabIndex = 47;
            this.lblFte.Text = "FTE:";
            // 
            // cbxTemporary
            // 
            this.cbxTemporary.AutoSize = true;
            this.cbxTemporary.Checked = true;
            this.cbxTemporary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxTemporary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTemporary.Location = new System.Drawing.Point(829, 546);
            this.cbxTemporary.Name = "cbxTemporary";
            this.cbxTemporary.Size = new System.Drawing.Size(134, 29);
            this.cbxTemporary.TabIndex = 49;
            this.cbxTemporary.Text = "Temporary";
            this.cbxTemporary.UseVisualStyleBackColor = true;
            this.cbxTemporary.CheckedChanged += new System.EventHandler(this.cbxTemporary_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.SlateGray;
            this.lblTitle.Location = new System.Drawing.Point(370, 233);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(433, 65);
            this.lblTitle.TabIndex = 50;
            this.lblTitle.Text = "Add a new contract";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nFte
            // 
            this.nFte.DecimalPlaces = 1;
            this.nFte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nFte.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nFte.Location = new System.Drawing.Point(553, 368);
            this.nFte.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nFte.Name = "nFte";
            this.nFte.Size = new System.Drawing.Size(250, 31);
            this.nFte.TabIndex = 51;
            this.nFte.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.SlateGray;
            this.lblStartDate.Location = new System.Drawing.Point(365, 491);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(130, 29);
            this.lblStartDate.TabIndex = 52;
            this.lblStartDate.Text = "Start Date: ";
            // 
            // lblExpires
            // 
            this.lblExpires.AutoSize = true;
            this.lblExpires.BackColor = System.Drawing.Color.Transparent;
            this.lblExpires.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpires.ForeColor = System.Drawing.Color.SlateGray;
            this.lblExpires.Location = new System.Drawing.Point(365, 546);
            this.lblExpires.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpires.Name = "lblExpires";
            this.lblExpires.Size = new System.Drawing.Size(100, 29);
            this.lblExpires.TabIndex = 53;
            this.lblExpires.Text = "Expires:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dtpStartDate.Location = new System.Drawing.Point(553, 488);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(250, 32);
            this.dtpStartDate.TabIndex = 54;
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dtpExpirationDate.Location = new System.Drawing.Point(553, 546);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.Size = new System.Drawing.Size(250, 32);
            this.dtpExpirationDate.TabIndex = 55;
            // 
            // btnPromote
            // 
            this.btnPromote.Active1 = System.Drawing.Color.HotPink;
            this.btnPromote.Active2 = System.Drawing.Color.HotPink;
            this.btnPromote.BackColor = System.Drawing.Color.Transparent;
            this.btnPromote.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPromote.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromote.ForeColor = System.Drawing.Color.White;
            this.btnPromote.Inactive1 = System.Drawing.Color.HotPink;
            this.btnPromote.Inactive2 = System.Drawing.Color.HotPink;
            this.btnPromote.Location = new System.Drawing.Point(441, 621);
            this.btnPromote.Name = "btnPromote";
            this.btnPromote.Radius = 47;
            this.btnPromote.Size = new System.Drawing.Size(312, 95);
            this.btnPromote.Stroke = false;
            this.btnPromote.StrokeColor = System.Drawing.Color.Gray;
            this.btnPromote.TabIndex = 41;
            this.btnPromote.Text = "Promote";
            this.btnPromote.Transparency = false;
            this.btnPromote.Click += new System.EventHandler(this.btnPromote_Click);
            // 
            // PromoteEmployeeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.dtpExpirationDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblExpires);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.nFte);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cbxTemporary);
            this.Controls.Add(this.lblFte);
            this.Controls.Add(this.pictureBoxBackPink);
            this.Controls.Add(this.pictureBoxMoon);
            this.Controls.Add(this.btnPromote);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.cbxEmployees);
            this.Controls.Add(this.lblPromoteAnEmployee);
            this.Controls.Add(this.cbxPosition);
            this.Controls.Add(this.tbxSalary);
            this.Controls.Add(this.pictureBoxSun);
            this.Controls.Add(this.pictureBoxBackYellow);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PromoteEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Bazaar Accounting - Promote an Employee";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackPink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxSalary;
        private System.Windows.Forms.ComboBox cbxPosition;
        private System.Windows.Forms.Label lblPromoteAnEmployee;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox cbxEmployees;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblPosition;
        private RoundButton btnPromote;
        private System.Windows.Forms.PictureBox pictureBoxMoon;
        private System.Windows.Forms.PictureBox pictureBoxSun;
        private System.Windows.Forms.PictureBox pictureBoxBackPink;
        private System.Windows.Forms.PictureBox pictureBoxBackYellow;
        private System.Windows.Forms.Label lblFte;
        private System.Windows.Forms.CheckBox cbxTemporary;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.NumericUpDown nFte;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblExpires;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpExpirationDate;
    }
}