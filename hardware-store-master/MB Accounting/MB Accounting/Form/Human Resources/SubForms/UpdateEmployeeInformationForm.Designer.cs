namespace MB_Accounting
{
    partial class UpdateEmployeeInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateEmployeeInformationForm));
            this.pictureBoxSun = new System.Windows.Forms.PictureBox();
            this.pictureBoxMoon = new System.Windows.Forms.PictureBox();
            this.lblUpdateEmployeeInformation = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.cbxEmployees = new System.Windows.Forms.ComboBox();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxEmpId = new System.Windows.Forms.TextBox();
            this.lblContractExpirationDate = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.btnUpdateEmployee = new MB_Accounting.RoundButton();
            this.pictureBoxBackPink = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackYellow = new System.Windows.Forms.PictureBox();
            this.dtpContractExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
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
            // lblUpdateEmployeeInformation
            // 
            this.lblUpdateEmployeeInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUpdateEmployeeInformation.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateEmployeeInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateEmployeeInformation.ForeColor = System.Drawing.Color.SlateGray;
            this.lblUpdateEmployeeInformation.Location = new System.Drawing.Point(6, 10);
            this.lblUpdateEmployeeInformation.Name = "lblUpdateEmployeeInformation";
            this.lblUpdateEmployeeInformation.Size = new System.Drawing.Size(1176, 100);
            this.lblUpdateEmployeeInformation.TabIndex = 35;
            this.lblUpdateEmployeeInformation.Text = "Update Employee Information";
            this.lblUpdateEmployeeInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelect
            // 
            this.lblSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelect.BackColor = System.Drawing.Color.Transparent;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.ForeColor = System.Drawing.Color.HotPink;
            this.lblSelect.Location = new System.Drawing.Point(381, 141);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(399, 37);
            this.lblSelect.TabIndex = 34;
            this.lblSelect.Text = "Select Employee";
            this.lblSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxEmployees
            // 
            this.cbxEmployees.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxEmployees.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEmployees.FormattingEnabled = true;
            this.cbxEmployees.Location = new System.Drawing.Point(381, 182);
            this.cbxEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEmployees.Name = "cbxEmployees";
            this.cbxEmployees.Size = new System.Drawing.Size(400, 33);
            this.cbxEmployees.TabIndex = 0;
            this.cbxEmployees.SelectedIndexChanged += new System.EventHandler(this.cbxEmployees_SelectedIndexChanged);
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhoneNumber.Location = new System.Drawing.Point(834, 372);
            this.tbxPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(220, 31);
            this.tbxPhoneNumber.TabIndex = 5;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress.Location = new System.Drawing.Point(329, 466);
            this.tbxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(220, 31);
            this.tbxAddress.TabIndex = 4;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName.Location = new System.Drawing.Point(329, 361);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(220, 31);
            this.tbxLastName.TabIndex = 3;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.Location = new System.Drawing.Point(329, 311);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(220, 31);
            this.tbxFirstName.TabIndex = 2;
            // 
            // tbxEmpId
            // 
            this.tbxEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmpId.Location = new System.Drawing.Point(329, 260);
            this.tbxEmpId.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEmpId.Name = "tbxEmpId";
            this.tbxEmpId.Size = new System.Drawing.Size(220, 31);
            this.tbxEmpId.TabIndex = 1;
            // 
            // lblContractExpirationDate
            // 
            this.lblContractExpirationDate.AutoSize = true;
            this.lblContractExpirationDate.BackColor = System.Drawing.Color.Transparent;
            this.lblContractExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractExpirationDate.ForeColor = System.Drawing.Color.SlateGray;
            this.lblContractExpirationDate.Location = new System.Drawing.Point(630, 420);
            this.lblContractExpirationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContractExpirationDate.Name = "lblContractExpirationDate";
            this.lblContractExpirationDate.Size = new System.Drawing.Size(182, 58);
            this.lblContractExpirationDate.TabIndex = 48;
            this.lblContractExpirationDate.Text = "Contract \r\nExpiration Date:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.SlateGray;
            this.lblAddress.Location = new System.Drawing.Point(121, 466);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(108, 29);
            this.lblAddress.TabIndex = 43;
            this.lblAddress.Text = "Address:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.SlateGray;
            this.lblDepartment.Location = new System.Drawing.Point(630, 260);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(150, 29);
            this.lblDepartment.TabIndex = 42;
            this.lblDepartment.Text = "Department: ";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.SlateGray;
            this.lblGender.Location = new System.Drawing.Point(630, 316);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(100, 29);
            this.lblGender.TabIndex = 41;
            this.lblGender.Text = "Gender:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.SlateGray;
            this.lblPhoneNumber.Location = new System.Drawing.Point(630, 372);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(177, 29);
            this.lblPhoneNumber.TabIndex = 40;
            this.lblPhoneNumber.Text = "Phone number:";
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeId.ForeColor = System.Drawing.Color.SlateGray;
            this.lblEmployeeId.Location = new System.Drawing.Point(121, 260);
            this.lblEmployeeId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(154, 29);
            this.lblEmployeeId.TabIndex = 39;
            this.lblEmployeeId.Text = "Employee Id:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.SlateGray;
            this.lblLastName.Location = new System.Drawing.Point(121, 361);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(134, 29);
            this.lblLastName.TabIndex = 37;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.SlateGray;
            this.lblFirstName.Location = new System.Drawing.Point(121, 311);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(137, 29);
            this.lblFirstName.TabIndex = 36;
            this.lblFirstName.Text = "First Name:";
            // 
            // cbxGender
            // 
            this.cbxGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbxGender.Location = new System.Drawing.Point(834, 316);
            this.cbxGender.Margin = new System.Windows.Forms.Padding(4);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(220, 33);
            this.cbxGender.TabIndex = 7;
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(834, 260);
            this.cbxDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(220, 33);
            this.cbxDepartment.TabIndex = 6;
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Active1 = System.Drawing.Color.HotPink;
            this.btnUpdateEmployee.Active2 = System.Drawing.Color.HotPink;
            this.btnUpdateEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateEmployee.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpdateEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEmployee.ForeColor = System.Drawing.Color.White;
            this.btnUpdateEmployee.Inactive1 = System.Drawing.Color.HotPink;
            this.btnUpdateEmployee.Inactive2 = System.Drawing.Color.HotPink;
            this.btnUpdateEmployee.Location = new System.Drawing.Point(417, 572);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Radius = 65;
            this.btnUpdateEmployee.Size = new System.Drawing.Size(365, 133);
            this.btnUpdateEmployee.Stroke = false;
            this.btnUpdateEmployee.StrokeColor = System.Drawing.Color.Gray;
            this.btnUpdateEmployee.TabIndex = 62;
            this.btnUpdateEmployee.Text = "Update info";
            this.btnUpdateEmployee.Transparency = false;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // pictureBoxBackPink
            // 
            this.pictureBoxBackPink.Image = global::MB_Accounting.Properties.Resources.previous_pink;
            this.pictureBoxBackPink.Location = new System.Drawing.Point(55, 168);
            this.pictureBoxBackPink.Name = "pictureBoxBackPink";
            this.pictureBoxBackPink.Size = new System.Drawing.Size(93, 74);
            this.pictureBoxBackPink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackPink.TabIndex = 65;
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
            this.pictureBoxBackYellow.TabIndex = 66;
            this.pictureBoxBackYellow.TabStop = false;
            this.pictureBoxBackYellow.Click += new System.EventHandler(this.pictureBoxBackYellow_Click);
            // 
            // dtpContractExpirationDate
            // 
            this.dtpContractExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpContractExpirationDate.Location = new System.Drawing.Point(834, 447);
            this.dtpContractExpirationDate.Name = "dtpContractExpirationDate";
            this.dtpContractExpirationDate.Size = new System.Drawing.Size(220, 31);
            this.dtpContractExpirationDate.TabIndex = 67;
            // 
            // tbxCity
            // 
            this.tbxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCity.Location = new System.Drawing.Point(329, 414);
            this.tbxCity.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(220, 31);
            this.tbxCity.TabIndex = 68;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.SlateGray;
            this.lblCity.Location = new System.Drawing.Point(121, 414);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(65, 29);
            this.lblCity.TabIndex = 69;
            this.lblCity.Text = "City: ";
            // 
            // UpdateEmployeeInformationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.tbxCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.dtpContractExpirationDate);
            this.Controls.Add(this.pictureBoxBackPink);
            this.Controls.Add(this.cbxDepartment);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Controls.Add(this.tbxPhoneNumber);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.tbxEmpId);
            this.Controls.Add(this.lblContractExpirationDate);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblUpdateEmployeeInformation);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.cbxEmployees);
            this.Controls.Add(this.pictureBoxSun);
            this.Controls.Add(this.pictureBoxMoon);
            this.Controls.Add(this.pictureBoxBackYellow);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateEmployeeInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Bazaar Accounting - Update Employee Information";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackPink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackYellow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSun;
        private System.Windows.Forms.PictureBox pictureBoxMoon;
        private System.Windows.Forms.Label lblUpdateEmployeeInformation;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox cbxEmployees;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxEmpId;
        private System.Windows.Forms.Label lblContractExpirationDate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private RoundButton btnUpdateEmployee;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.PictureBox pictureBoxBackPink;
        private System.Windows.Forms.PictureBox pictureBoxBackYellow;
        private System.Windows.Forms.DateTimePicker dtpContractExpirationDate;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Label lblCity;
    }
}