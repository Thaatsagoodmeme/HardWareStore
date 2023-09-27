
namespace MB_Accounting
{
    partial class EmployeeInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeInformationForm));
            this.cbxEmployees = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblContractStartDate = new System.Windows.Forms.Label();
            this.lblAvailableVacationDays = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblContractExpirationDate = new System.Windows.Forms.Label();
            this.tbxEmpId = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxBirthdate = new System.Windows.Forms.TextBox();
            this.tbxGender = new System.Windows.Forms.TextBox();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxSalary = new System.Windows.Forms.TextBox();
            this.tbxPosition = new System.Windows.Forms.TextBox();
            this.tbxDepartment = new System.Windows.Forms.TextBox();
            this.tbxContractExpirationDate = new System.Windows.Forms.TextBox();
            this.tbxContractStartDate = new System.Windows.Forms.TextBox();
            this.tbxVacationDays = new System.Windows.Forms.TextBox();
            this.lblEmployeeInformation = new System.Windows.Forms.Label();
            this.pictureBoxMoon = new System.Windows.Forms.PictureBox();
            this.pictureBoxSun = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackPink = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackYellow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackPink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackYellow)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxEmployees
            // 
            this.cbxEmployees.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxEmployees.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEmployees.FormattingEnabled = true;
            this.cbxEmployees.Location = new System.Drawing.Point(370, 190);
            this.cbxEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEmployees.Name = "cbxEmployees";
            this.cbxEmployees.Size = new System.Drawing.Size(400, 33);
            this.cbxEmployees.TabIndex = 0;
            this.cbxEmployees.SelectedIndexChanged += new System.EventHandler(this.cbxEmployees_SelectedIndexChanged);
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
            this.lblSelect.Size = new System.Drawing.Size(400, 36);
            this.lblSelect.TabIndex = 1;
            this.lblSelect.Text = "Select Employee";
            this.lblSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(137, 344);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(137, 29);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(137, 394);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(134, 29);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(137, 446);
            this.lblBirthDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(121, 29);
            this.lblBirthDate.TabIndex = 4;
            this.lblBirthDate.Text = "Birthdate: ";
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeId.Location = new System.Drawing.Point(137, 293);
            this.lblEmployeeId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(154, 29);
            this.lblEmployeeId.TabIndex = 5;
            this.lblEmployeeId.Text = "Employee Id:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(137, 498);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(108, 29);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Address:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(646, 293);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(150, 29);
            this.lblDepartment.TabIndex = 8;
            this.lblDepartment.Text = "Department: ";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(137, 604);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(100, 29);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(137, 552);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(177, 29);
            this.lblPhoneNumber.TabIndex = 6;
            this.lblPhoneNumber.Text = "Phone number:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(646, 344);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(106, 29);
            this.lblPosition.TabIndex = 13;
            this.lblPosition.Text = "Position:";
            // 
            // lblContractStartDate
            // 
            this.lblContractStartDate.AutoSize = true;
            this.lblContractStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblContractStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractStartDate.Location = new System.Drawing.Point(646, 498);
            this.lblContractStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContractStartDate.Name = "lblContractStartDate";
            this.lblContractStartDate.Size = new System.Drawing.Size(124, 58);
            this.lblContractStartDate.TabIndex = 12;
            this.lblContractStartDate.Text = "Contract \r\nStart Date:";
            // 
            // lblAvailableVacationDays
            // 
            this.lblAvailableVacationDays.AutoSize = true;
            this.lblAvailableVacationDays.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailableVacationDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableVacationDays.Location = new System.Drawing.Point(646, 434);
            this.lblAvailableVacationDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailableVacationDays.Name = "lblAvailableVacationDays";
            this.lblAvailableVacationDays.Size = new System.Drawing.Size(170, 58);
            this.lblAvailableVacationDays.TabIndex = 11;
            this.lblAvailableVacationDays.Text = "Available \r\nVacation Days:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.Color.Transparent;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(646, 394);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(86, 29);
            this.lblSalary.TabIndex = 10;
            this.lblSalary.Text = "Salary:";
            // 
            // lblContractExpirationDate
            // 
            this.lblContractExpirationDate.AutoSize = true;
            this.lblContractExpirationDate.BackColor = System.Drawing.Color.Transparent;
            this.lblContractExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractExpirationDate.Location = new System.Drawing.Point(646, 575);
            this.lblContractExpirationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContractExpirationDate.Name = "lblContractExpirationDate";
            this.lblContractExpirationDate.Size = new System.Drawing.Size(182, 58);
            this.lblContractExpirationDate.TabIndex = 14;
            this.lblContractExpirationDate.Text = "Contract \r\nExpiration Date:";
            // 
            // tbxEmpId
            // 
            this.tbxEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmpId.Location = new System.Drawing.Point(345, 293);
            this.tbxEmpId.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEmpId.Name = "tbxEmpId";
            this.tbxEmpId.Size = new System.Drawing.Size(220, 31);
            this.tbxEmpId.TabIndex = 1;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.Location = new System.Drawing.Point(345, 344);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(220, 31);
            this.tbxFirstName.TabIndex = 2;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName.Location = new System.Drawing.Point(345, 394);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(220, 31);
            this.tbxLastName.TabIndex = 3;
            // 
            // tbxBirthdate
            // 
            this.tbxBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBirthdate.Location = new System.Drawing.Point(345, 446);
            this.tbxBirthdate.Margin = new System.Windows.Forms.Padding(4);
            this.tbxBirthdate.Name = "tbxBirthdate";
            this.tbxBirthdate.Size = new System.Drawing.Size(220, 31);
            this.tbxBirthdate.TabIndex = 4;
            // 
            // tbxGender
            // 
            this.tbxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGender.Location = new System.Drawing.Point(345, 604);
            this.tbxGender.Margin = new System.Windows.Forms.Padding(4);
            this.tbxGender.Name = "tbxGender";
            this.tbxGender.Size = new System.Drawing.Size(220, 31);
            this.tbxGender.TabIndex = 7;
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhoneNumber.Location = new System.Drawing.Point(345, 552);
            this.tbxPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(220, 31);
            this.tbxPhoneNumber.TabIndex = 6;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress.Location = new System.Drawing.Point(345, 498);
            this.tbxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(220, 31);
            this.tbxAddress.TabIndex = 5;
            // 
            // tbxSalary
            // 
            this.tbxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSalary.Location = new System.Drawing.Point(851, 394);
            this.tbxSalary.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSalary.Name = "tbxSalary";
            this.tbxSalary.Size = new System.Drawing.Size(220, 31);
            this.tbxSalary.TabIndex = 10;
            // 
            // tbxPosition
            // 
            this.tbxPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPosition.Location = new System.Drawing.Point(851, 344);
            this.tbxPosition.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPosition.Name = "tbxPosition";
            this.tbxPosition.Size = new System.Drawing.Size(220, 31);
            this.tbxPosition.TabIndex = 9;
            // 
            // tbxDepartment
            // 
            this.tbxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDepartment.Location = new System.Drawing.Point(851, 293);
            this.tbxDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDepartment.Name = "tbxDepartment";
            this.tbxDepartment.Size = new System.Drawing.Size(220, 31);
            this.tbxDepartment.TabIndex = 8;
            // 
            // tbxContractExpirationDate
            // 
            this.tbxContractExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxContractExpirationDate.Location = new System.Drawing.Point(851, 602);
            this.tbxContractExpirationDate.Margin = new System.Windows.Forms.Padding(4);
            this.tbxContractExpirationDate.Name = "tbxContractExpirationDate";
            this.tbxContractExpirationDate.Size = new System.Drawing.Size(220, 31);
            this.tbxContractExpirationDate.TabIndex = 13;
            // 
            // tbxContractStartDate
            // 
            this.tbxContractStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxContractStartDate.Location = new System.Drawing.Point(851, 525);
            this.tbxContractStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.tbxContractStartDate.Name = "tbxContractStartDate";
            this.tbxContractStartDate.Size = new System.Drawing.Size(220, 31);
            this.tbxContractStartDate.TabIndex = 12;
            // 
            // tbxVacationDays
            // 
            this.tbxVacationDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxVacationDays.Location = new System.Drawing.Point(851, 461);
            this.tbxVacationDays.Margin = new System.Windows.Forms.Padding(4);
            this.tbxVacationDays.Name = "tbxVacationDays";
            this.tbxVacationDays.Size = new System.Drawing.Size(220, 31);
            this.tbxVacationDays.TabIndex = 11;
            // 
            // lblEmployeeInformation
            // 
            this.lblEmployeeInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployeeInformation.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeInformation.ForeColor = System.Drawing.Color.SlateGray;
            this.lblEmployeeInformation.Location = new System.Drawing.Point(6, 10);
            this.lblEmployeeInformation.Name = "lblEmployeeInformation";
            this.lblEmployeeInformation.Size = new System.Drawing.Size(1175, 100);
            this.lblEmployeeInformation.TabIndex = 28;
            this.lblEmployeeInformation.Text = "Employee Information";
            this.lblEmployeeInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxMoon
            // 
            this.pictureBoxMoon.Image = global::MB_Accounting.Properties.Resources.moon;
            this.pictureBoxMoon.Location = new System.Drawing.Point(1066, 654);
            this.pictureBoxMoon.Name = "pictureBoxMoon";
            this.pictureBoxMoon.Size = new System.Drawing.Size(86, 62);
            this.pictureBoxMoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMoon.TabIndex = 29;
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
            this.pictureBoxSun.TabIndex = 30;
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
            this.pictureBoxBackPink.TabIndex = 31;
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
            this.pictureBoxBackYellow.TabIndex = 32;
            this.pictureBoxBackYellow.TabStop = false;
            this.pictureBoxBackYellow.Click += new System.EventHandler(this.pictureBoxBackYellow_Click);
            // 
            // EmployeeInformationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.lblEmployeeInformation);
            this.Controls.Add(this.tbxContractExpirationDate);
            this.Controls.Add(this.tbxContractStartDate);
            this.Controls.Add(this.tbxVacationDays);
            this.Controls.Add(this.tbxSalary);
            this.Controls.Add(this.tbxPosition);
            this.Controls.Add(this.tbxDepartment);
            this.Controls.Add(this.tbxGender);
            this.Controls.Add(this.tbxPhoneNumber);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.tbxBirthdate);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.tbxEmpId);
            this.Controls.Add(this.lblContractExpirationDate);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblContractStartDate);
            this.Controls.Add(this.lblAvailableVacationDays);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.cbxEmployees);
            this.Controls.Add(this.pictureBoxBackPink);
            this.Controls.Add(this.pictureBoxBackYellow);
            this.Controls.Add(this.pictureBoxMoon);
            this.Controls.Add(this.pictureBoxSun);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Bazaar Accounting - Employee Information";
            this.Load += new System.EventHandler(this.EmployeeInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackPink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackYellow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxEmployees;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblContractStartDate;
        private System.Windows.Forms.Label lblAvailableVacationDays;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblContractExpirationDate;
        private System.Windows.Forms.TextBox tbxEmpId;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxBirthdate;
        private System.Windows.Forms.TextBox tbxGender;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxSalary;
        private System.Windows.Forms.TextBox tbxPosition;
        private System.Windows.Forms.TextBox tbxDepartment;
        private System.Windows.Forms.TextBox tbxContractExpirationDate;
        private System.Windows.Forms.TextBox tbxContractStartDate;
        private System.Windows.Forms.TextBox tbxVacationDays;
        private System.Windows.Forms.Label lblEmployeeInformation;
        private System.Windows.Forms.PictureBox pictureBoxMoon;
        private System.Windows.Forms.PictureBox pictureBoxSun;
        private System.Windows.Forms.PictureBox pictureBoxBackPink;
        private System.Windows.Forms.PictureBox pictureBoxBackYellow;
    }
}