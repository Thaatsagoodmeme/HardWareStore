using System;
using System.Windows.Forms;
using Database;
using Database.Model;
using Database.Model.Enum;

namespace MB_Accounting
{
    public partial class HumanResourcesForm : Form
    {
        private ColorTheme _formTheme;
        private Employee _currentUser;

        public ColorTheme FormTheme
        {
            get { return _formTheme; }
        }

        public HumanResourcesForm(Employee currentUser, ColorTheme previousFormTheme)
        {
            InitializeComponent();
            LoadYellowImages();
            // Set font - Montserrat
            SetMontserratFont();
            _currentUser = currentUser;
            // Set color mode
            _formTheme = previousFormTheme;
            switch (_formTheme)
            {
                case ColorTheme.Light:
                    SetLightTheme();
                    tabControlMenu.ColorTheme = _formTheme;
                    tabControlMenu.ImageList = imageListMenu;
                    break;
                case ColorTheme.Dark:
                    tabControlMenu.ColorTheme = _formTheme;
                    tabControlMenu.ImageList = imageListMenuYellow;
                    SetDarkTheme();
                    break;
            }
            lblEmployeeName.Text = $"{_currentUser.FirstName} {_currentUser.LastName}";
            tbxAddressSettings.Text = _currentUser.Address;
            tbxEmailSettings.Text = _currentUser.Email;
            tbxPhoneNumberSettings.Text = _currentUser.PhoneNumber;
            dateTimeBirthDate.Value = DateTime.Now;
            PopulatePositionsComboBox();
            PopulateDepartmentsComboBox();
            PopulateRelationshipComboBox();
            PopulateRelationshipSettingsComboBox();
        }

        private void LoadYellowImages()
        {
            imageListMenuYellow.Images.Add(Properties.Resources.approved_yellow);
            imageListMenuYellow.Images.SetKeyName(0, "approved_yellow");
            imageListMenuYellow.Images.Add(Properties.Resources.research_yellow);
            imageListMenuYellow.Images.SetKeyName(1, "research_yellow");
            imageListMenuYellow.Images.Add(Properties.Resources.settings_yellow);
            imageListMenuYellow.Images.SetKeyName(2, "settings_yellow");
            imageListMenuYellow.Images.Add(Properties.Resources.MB_Accounting_Logo_Yellow);
            imageListMenuYellow.Images.SetKeyName(3, "MB_Accounting_Logo_Yellow");
        }

        private void SetLightTheme()
        {
            /* Main tab */
            // White 
            panelMainTabBackground.BackColor =
                BackColor =
                ColorPalette.White;
            // Dark grey 
            lblGreetings.ForeColor =
                ColorPalette.DarkGrey;
            // Pink 
            lblEmployeeName.ForeColor =
                ColorPalette.Pink;

            /* Hire tab */
            // White 
            btnSubmit.ForeColor =
                panelHireTabBackground.BackColor =
                tbxFirstName.BackColor =
                tbxLastName.BackColor =
                dateTimeBirthDate.CalendarMonthBackground =
                tbxAddress.BackColor =
                tbxPhoneNumber.BackColor =
                cbxDepartment.BackColor =
                cbxPosition.BackColor =
                tbxEmail.BackColor =
                tbxPassword.BackColor =
                tbxConfirmPassword.BackColor =
                lblHireTabHeading.BackColor =
                tbxECName.BackColor =
                tbxECInfo.BackColor =
                tbxCity.BackColor =
                cbxRelationship.BackColor =
                ColorPalette.White;
            // Dark grey 
            tabPageHire.ForeColor =
                lblFirstName.ForeColor =
                lblLastName.ForeColor =
                lblGender.ForeColor =
                lblAddress.ForeColor =
                lblPhoneNumber.ForeColor =
                lblBirthDate.ForeColor =
                lblPassword.ForeColor =
                lblEmail.ForeColor =
                lblDepartment.ForeColor =
                lblPosition.ForeColor =
                lblHireTabHeading.ForeColor =
                lblConfirmPwd.ForeColor =
                lblECInfo.ForeColor =
                lblECName.ForeColor =
                lblCity.ForeColor =
                ColorPalette.DarkGrey;
            // Pink 
            tabPageManage.ForeColor =
                tabPageSettings.ForeColor =
                tabPageHire.BackColor =
                btnSubmit.Inactive1 =
                btnSubmit.Inactive2 =
                tbxFirstName.ForeColor =
                tbxLastName.ForeColor =
                dateTimeBirthDate.CalendarForeColor =
                rbMale.ForeColor =
                rbFemale.ForeColor =
                rbOther.ForeColor =
                tbxAddress.ForeColor =
                tbxPhoneNumber.ForeColor =
                cbxDepartment.ForeColor =
                cbxPosition.ForeColor =
                tbxEmail.ForeColor =
                tbxPassword.ForeColor =
                tbxConfirmPassword.ForeColor =
                tbxECName.ForeColor =
                tbxECInfo.ForeColor =
                lblEC.ForeColor =
                tbxCity.ForeColor =
                cbxRelationship.ForeColor =
                ColorPalette.Pink;
            // Darker pink 
            btnSubmit.Active1 =
                btnSubmit.Active2 =
                ColorPalette.DarkerPink;

            /* Manage tab */
            // Dark grey 
            tabPageManage.ForeColor =
                lblManageHeading.ForeColor =
                ColorPalette.DarkGrey;
            // White 
            btnCheckEmployeeInformation.ForeColor =
                btnRemoveAnEmployee.ForeColor =
                btnPromoteAnEmployee.ForeColor =
                btnUpdateEmployeeInformation.ForeColor =
                btnSeeAllEmployeesInADepartment.ForeColor =
                btnCreateDepartment.ForeColor =
                panelManageTabBackground.BackColor =
                ColorPalette.White;
            // Pink 
            btnCheckEmployeeInformation.Inactive1 =
                btnCheckEmployeeInformation.Inactive2 =
                lblQuestion.ForeColor =
                btnRemoveAnEmployee.Inactive1 =
                btnRemoveAnEmployee.Inactive2 =
                btnPromoteAnEmployee.Inactive1 =
                btnPromoteAnEmployee.Inactive2 =
                btnUpdateEmployeeInformation.Inactive1 =
                btnUpdateEmployeeInformation.Inactive2 =
                btnSeeAllEmployeesInADepartment.Inactive1 =
                btnSeeAllEmployeesInADepartment.Inactive2 =
                btnCreateDepartment.Inactive1 =
                btnCreateDepartment.Inactive2 =
                ColorPalette.Pink;
            // Darker pink 
            btnCheckEmployeeInformation.Active1 =
                btnCheckEmployeeInformation.Active2 =
                btnRemoveAnEmployee.Active1 =
                btnRemoveAnEmployee.Active2 =
                btnPromoteAnEmployee.Active1 =
                btnPromoteAnEmployee.Active2 =
                btnUpdateEmployeeInformation.Active1 =
                btnUpdateEmployeeInformation.Active2 =
                btnSeeAllEmployeesInADepartment.Active1 =
                btnSeeAllEmployeesInADepartment.Active2 =
                btnCreateDepartment.Active1 =
                btnCreateDepartment.Active2 =
                ColorPalette.DarkerPink;
            /* Settings tab */
            // White 
            panelSettingsTabBackground.BackColor =
                btnSaveInfo.ForeColor =
                btnSavePassword.ForeColor =
                rbSaveEc.ForeColor =
                tbxPhoneNumberSettings.BackColor =
                tbxEmailSettings.BackColor =
                tbxConfirmPasswordSettings.BackColor =
                tbxNewPasswordSettings.BackColor =
                tbxCurrentPasswordSettings.BackColor =
                tbxAddressSettings.BackColor =
                tbxECNameSettings.BackColor =
                tbxECInfoSettings.BackColor =
                cbxRelationshipSettings.BackColor =
                ColorPalette.White;
            // Dark grey 
            tabPageSettings.ForeColor =
                lblSettingTabHeading.ForeColor =
                lblAddressSettings.ForeColor =
                lblPhoneNumberSettings.ForeColor =
                lblEmailSettings.ForeColor =
                lblConfirmPassword.ForeColor =
                lblCurrentPassword.ForeColor =
                lblNewPassword.ForeColor =
                lblECNameSettings.ForeColor =
                lblECInfoSettings.ForeColor =
                ColorPalette.DarkGrey;
            // Pink 
            tbxAddressSettings.ForeColor =
                lblPasswordSettings.ForeColor =
                lblPersonalInfo.ForeColor =
                lblECSettings.ForeColor =
                tbxPhoneNumberSettings.ForeColor =
                tbxEmailSettings.ForeColor =
                tbxCurrentPasswordSettings.ForeColor =
                tbxNewPasswordSettings.ForeColor =
                tbxConfirmPasswordSettings.ForeColor =
                cbxRelationshipSettings.ForeColor =
                tbxECInfoSettings.ForeColor =
                tbxECNameSettings.ForeColor =
                btnSaveInfo.Inactive1 =
                btnSaveInfo.Inactive2 =
                btnSavePassword.Inactive2 =
                btnSavePassword.Inactive1 =
                rbSaveEc.Inactive1 =
                rbSaveEc.Inactive2 =
                ColorPalette.Pink;
            // Darker pink 
            btnSaveInfo.Active1 =
                btnSaveInfo.Active2 =
                btnSavePassword.Active1 =
                btnSavePassword.Active2 =
                rbSaveEc.Active1 =
                rbSaveEc.Active2 =
                ColorPalette.DarkerPink;
        }

        private void SetDarkTheme()
        {
            /* Main tab */
            // Dark blue 
            panelMainTabBackground.BackColor =
                BackColor =
                ColorPalette.DarkBlue;
            // White 
            lblGreetings.ForeColor =
                ColorPalette.White;
            // Yellow 
            lblEmployeeName.ForeColor =
                ColorPalette.Yellow;

            /* Hire tab */
            // White 
            tabPageHire.ForeColor =
                lblHireTabHeading.ForeColor =
                lblFirstName.ForeColor =
                lblLastName.ForeColor =
                lblGender.ForeColor =
                lblAddress.ForeColor =
                lblPhoneNumber.ForeColor =
                lblBirthDate.ForeColor =
                lblPassword.ForeColor =
                lblEmail.ForeColor =
                lblDepartment.ForeColor =
                lblPosition.ForeColor =
                lblConfirmPwd.ForeColor =
                lblECName.ForeColor =
                lblECInfo.ForeColor =
                lblRelationship.ForeColor =
                lblCity.ForeColor =
                ColorPalette.White;
            // Yellow 
            rbMale.ForeColor =
                rbFemale.ForeColor =
                rbOther.ForeColor =
                btnSubmit.Inactive1 =
                btnSubmit.Inactive2 =
                lblEC.ForeColor =
                ColorPalette.Yellow;
            // Darker yellow 
            btnSubmit.Active1 =
                btnSubmit.Active2 =
                tbxFirstName.ForeColor =
                tbxLastName.ForeColor =
                dateTimeBirthDate.CalendarForeColor =
                tbxAddress.ForeColor =
                tbxPhoneNumber.ForeColor =
                cbxDepartment.ForeColor =
                cbxPosition.ForeColor =
                tbxEmail.ForeColor =
                tbxPassword.ForeColor =
                tbxConfirmPassword.ForeColor =
                tbxECName.ForeColor =
                tbxECInfo.ForeColor =
                tbxCity.ForeColor =
                cbxRelationship.ForeColor =
                ColorPalette.DarkerYellow;
            // Dark blue 
            panelHireTabBackground.BackColor =
                lblHireTabHeading.BackColor =
                btnSubmit.ForeColor =
                ColorPalette.DarkBlue;
            // Light blue 
            tbxFirstName.BackColor =
                tbxLastName.BackColor =
                dateTimeBirthDate.CalendarMonthBackground =
                tbxAddress.BackColor =
                tbxPhoneNumber.BackColor =
                cbxDepartment.BackColor =
                cbxPosition.BackColor =
                tbxEmail.BackColor =
                tbxPassword.BackColor =
                tbxConfirmPassword.BackColor =
                tbxECName.BackColor =
                tbxECInfo.BackColor =
                tbxCity.BackColor =
                cbxRelationship.BackColor =
                ColorPalette.LighterBlue;

            /* Manage tab */
            // White 
            lblManageHeading.ForeColor =
                ColorPalette.White;
            // Dark blue 
            btnCheckEmployeeInformation.ForeColor =
                btnRemoveAnEmployee.ForeColor =
                panelManageTabBackground.BackColor =
                btnPromoteAnEmployee.ForeColor =
                btnUpdateEmployeeInformation.ForeColor =
                btnSeeAllEmployeesInADepartment.ForeColor =
                btnCreateDepartment.ForeColor =
                ColorPalette.DarkBlue;
            // Yellow 
            btnCheckEmployeeInformation.Inactive1 =
                btnCheckEmployeeInformation.Inactive2 =
                btnRemoveAnEmployee.Inactive1 =
                btnRemoveAnEmployee.Inactive2 =
                btnPromoteAnEmployee.Inactive1 =
                btnPromoteAnEmployee.Inactive2 =
                btnUpdateEmployeeInformation.Inactive1 =
                btnUpdateEmployeeInformation.Inactive2 =
                btnSeeAllEmployeesInADepartment.Inactive1 =
                btnSeeAllEmployeesInADepartment.Inactive2 =
                btnCreateDepartment.Inactive1 =
                btnCreateDepartment.Inactive2 =
                lblQuestion.ForeColor =
            ColorPalette.Yellow;
            // Darker yellow 
            btnCheckEmployeeInformation.Active1 =
                btnCheckEmployeeInformation.Active2 =
                btnRemoveAnEmployee.Active1 =
                btnRemoveAnEmployee.Active2 =
                btnPromoteAnEmployee.Active1 =
                btnPromoteAnEmployee.Active2 =
                btnUpdateEmployeeInformation.Active1 =
                btnUpdateEmployeeInformation.Active2 =
                btnSeeAllEmployeesInADepartment.Active1 =
                btnSeeAllEmployeesInADepartment.Active2 =
                btnCreateDepartment.Active1 =
                btnCreateDepartment.Active2 =
                ColorPalette.DarkerYellow;

            /* Settings tab */
            // White 
            tabPageSettings.ForeColor =
                lblSettingTabHeading.ForeColor =
                lblAddressSettings.ForeColor =
                lblPhoneNumberSettings.ForeColor =
                lblEmailSettings.ForeColor =
                lblConfirmPassword.ForeColor =
                lblCurrentPassword.ForeColor =
                lblNewPassword.ForeColor =
                lblECInfoSettings.ForeColor =
                lblECNameSettings.ForeColor =
                ColorPalette.White;
            // Dark blue 
            panelSettingsTabBackground.BackColor =
                tbxAddressSettings.ForeColor =
                tbxPhoneNumberSettings.ForeColor =
                tbxEmailSettings.ForeColor =
                tbxCurrentPasswordSettings.ForeColor =
                tbxNewPasswordSettings.ForeColor =
                tbxConfirmPasswordSettings.ForeColor =
                btnSaveInfo.ForeColor =
                btnSavePassword.ForeColor =
                rbSaveEc.ForeColor =
                ColorPalette.DarkBlue;
            // Lighter blue
            tbxAddressSettings.BackColor =
                tbxPhoneNumberSettings.BackColor =
                tbxEmailSettings.BackColor =
                tbxCurrentPasswordSettings.BackColor =
                tbxNewPasswordSettings.BackColor =
                tbxConfirmPasswordSettings.BackColor =
                tbxECInfoSettings.BackColor =
                tbxECNameSettings.BackColor =
                ColorPalette.LighterBlue;
            // Yellow 
            lblPersonalInfo.ForeColor =
                lblPasswordSettings.ForeColor =
                lblECSettings.ForeColor =
                btnSaveInfo.Inactive1 =
                btnSaveInfo.Inactive2 =
                btnSavePassword.Inactive2 =
                btnSavePassword.Inactive1 =
                rbSaveEc.Inactive1 =
                rbSaveEc.Inactive2 =
                ColorPalette.Yellow;
            // Darker yellow 
            btnSaveInfo.Active1 =
                btnSaveInfo.Active2 =
                btnSavePassword.Active1 =
                btnSavePassword.Active2 =
                rbSaveEc.Active1 =
                rbSaveEc.Active2 =
                tbxAddressSettings.ForeColor =
                tbxPhoneNumberSettings.ForeColor =
                tbxEmailSettings.ForeColor =
                tbxCurrentPasswordSettings.ForeColor =
                tbxNewPasswordSettings.ForeColor =
                tbxConfirmPasswordSettings.ForeColor =
                tbxECInfoSettings.ForeColor =
                tbxECNameSettings.ForeColor =
                ColorPalette.DarkerYellow;
        }

        // Set Montserrat font to controls
        private void SetMontserratFont()
        {
            // Montserrat medium
            Fonts.SetPropertyFont(0, this, tabControlMenu, lblGreetings, tabPageHire, tbxFirstName,
                tbxLastName, tbxAddress,
                lblPhoneNumber, cbxDepartment,
                cbxPosition, tbxEmail, tbxPassword,
                tbxPhoneNumber, btnSubmit,
                tbxConfirmPassword, tabPageManage, lblQuestion,
                btnCheckEmployeeInformation, btnRemoveAnEmployee,
                btnPromoteAnEmployee, btnUpdateEmployeeInformation,
                btnSeeAllEmployeesInADepartment, tabPageSettings,
                tbxAddressSettings, tbxPhoneNumberSettings,
                tbxEmailSettings, btnSaveInfo,
                tbxCurrentPasswordSettings, tbxNewPasswordSettings,
                tbxConfirmPasswordSettings, btnSavePassword,
                lblPasswordSettings, lblPersonalInfo, lblEC, lblECName, lblECInfo, tbxECName, tbxECInfo,
                btnCreateDepartment, lblECSettings, lblECNameSettings, lblECInfoSettings,
                tbxECNameSettings, tbxECInfoSettings, rbSaveEc);
            // Montserrat semibold
            Fonts.SetPropertyFont(1, lblEmployeeName, lblEmployeeName, lblHireTabHeading,
                lblManageHeading, lblSettingTabHeading);
        }

        private void PopulatePositionsComboBox()
        {
            foreach (var position in Enum.GetValues(typeof(Position)))
            {
                cbxPosition.Items.Add(position);
            }
        }
        private void PopulateRelationshipComboBox()
        {
            foreach (var relationshipType in Enum.GetValues(typeof(RelationshipType)))
            {
                cbxRelationship.Items.Add(relationshipType);
            }
        }
        private void PopulateRelationshipSettingsComboBox()
        {
            foreach (var relationshipType in Enum.GetValues(typeof(RelationshipType)))
            {
                cbxRelationshipSettings.Items.Add(relationshipType);
            }
        }
        private void PopulateDepartmentsComboBox()
        {
            cbxDepartment.Items.Clear();
            cbxDepartment.Items.AddRange(DatabaseController.GetDepartments().ToArray());
        }

        // Enable light/dark theme
        private void tabControlMenu_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPageColorTheme)
            {
                tabControlMenu.SelectedIndex = 0;
                if (_formTheme == ColorTheme.Light)
                {
                    _formTheme = ColorTheme.Dark;
                    tabControlMenu.ColorTheme = _formTheme;
                    tabControlMenu.ImageList = imageListMenuYellow;
                    SetDarkTheme();
                }
                else
                {
                    _formTheme = ColorTheme.Light;
                    tabControlMenu.ColorTheme = _formTheme;
                    tabControlMenu.ImageList = imageListMenu;
                    SetLightTheme();
                }
            }
            // Refresh tab control
            tabControlMenu.Invalidate();
        }

        // Hire employee
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbxFirstName.Text) || String.IsNullOrWhiteSpace(tbxLastName.Text) ||
                String.IsNullOrWhiteSpace(tbxPassword.Text) || String.IsNullOrWhiteSpace(tbxEmail.Text) ||
                 String.IsNullOrWhiteSpace(tbxAddress.Text) ||
                String.IsNullOrWhiteSpace(tbxPhoneNumber.Text) ||
                String.IsNullOrWhiteSpace(cbxPosition.Text))
            {
                MessageBox.Show("Empty fields are not allowed.");
                return;
            }
            string firstName = tbxFirstName.Text;
            string lastName = tbxLastName.Text;
            if (tbxPassword.Text != tbxConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            if (tbxPassword.Text.Length < 6)
            {
                MessageBox.Show("Passwords cannot be shorter than 6 symbols.");
                return;
            }
            string password = tbxPassword.Text;
            string email = tbxEmail.Text;
            if (DatabaseController.CheckIfEmployeeExists(email))
            {
                MessageBox.Show("Employee with such email already exists.");
                return;
            }
            else if (!DatabaseController.IsEmailValid(email))
            {
                MessageBox.Show("Invalid email.");
                return;
            }
            DateTime bd = dateTimeBirthDate.Value;
            if (bd > DateTime.Now)
            {
                MessageBox.Show("Birth date cannot be after today.");
                return;
            }
            string gender;
            if (rbFemale.Checked)
            {
                gender = rbFemale.Text;
            }
            else if (rbMale.Checked)
            {
                gender = rbMale.Text;
            }
            else
            {
                gender = rbOther.Text;
            }
            if (cbxDepartment.SelectedItem is null)
            {
                MessageBox.Show("Please select a department.");
                return;
            }
            int departmentId = ((Department)cbxDepartment.SelectedItem).Id;
            string city = tbxCity.Text;
            string address = tbxAddress.Text;
            string phoneNr = tbxPhoneNumber.Text;
            bool enumSuccess = Enum.TryParse(cbxPosition.Text, out Position position);
            if (!enumSuccess)
            {
                MessageBox.Show("Position is invalid.");
                return;
            }
            bool success = DatabaseController.CreateEmployee(firstName, lastName, password,
            email, departmentId, bd, gender, city,
            address, phoneNr,
            position);
            if (success)
            {
                Employee newEmployee = DatabaseController.GetEmployee(email);
                AddContractForm addContractForm = new AddContractForm(newEmployee, _formTheme); 
                RelationshipType ecRelationship = (RelationshipType)cbxRelationship.SelectedItem;
                EmergencyContact ec = new EmergencyContact(tbxECName.Text, tbxECInfo.Text, ecRelationship);
                newEmployee.EditEmergencyContact(ec);
                DatabaseController.ModifyEmergencyContact(newEmployee, ec);
                addContractForm.ShowDialog();
                MessageBox.Show("Employee added successfully.");
            }
            else
            {
                MessageBox.Show("Failed adding employee.");
            }
        }

        // Check employee information
        private void btnCheckEmployeeInformation_Click(object sender, EventArgs e)
        {
            Hide();
            EmployeeInformationForm form = new EmployeeInformationForm(_currentUser, this);
            form.ShowDialog();
        }

        // Remove an employee
        private void btnRemoveAnEmployee_Click(object sender, EventArgs e)
        {
            Hide();
            RemoveEmployeeForm form = new RemoveEmployeeForm(_currentUser, this);
            form.ShowDialog();
        }

        // Promote an employee
        private void btnPromoteAnEmployee_Click(object sender, EventArgs e)
        {
            Hide();
            PromoteEmployeeForm form = new PromoteEmployeeForm(_currentUser, this);
            form.ShowDialog();
        }

        // Update employee information
        private void btnUpdateEmployeeInformation_Click(object sender, EventArgs e)
        {
            Hide();
            UpdateEmployeeInformationForm form = new UpdateEmployeeInformationForm(_currentUser, this);
            form.ShowDialog();
        }

        // See all employees in a department
        private void btnSeeAllEmployeesInADepartment_Click(object sender, EventArgs e)
        {
            Hide();
            EmployeesInDepartmentForm form = new EmployeesInDepartmentForm(_currentUser, this);
            form.ShowDialog();
        }

        // Save info
        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            string newAddress = tbxAddressSettings.Text;
            string newEmail = tbxEmailSettings.Text;
            string newPhoneNumber = tbxPhoneNumberSettings.Text;
            if (String.IsNullOrWhiteSpace(newAddress) || String.IsNullOrWhiteSpace(newEmail) ||
                String.IsNullOrWhiteSpace(newPhoneNumber))
            {
                MessageBox.Show("Fields cannot be empty.");
                return;
            }
            bool isEmailValid = DatabaseController.IsEmailValid(newEmail);
            if (!isEmailValid)
            {
                MessageBox.Show("Invalid email.");
                return;
            }
            bool success = DatabaseController.UpdateEmployeePersonalInfo(_currentUser.Id, newAddress, newPhoneNumber, newEmail);
            if (success)
            {
                MessageBox.Show("Personal info updated successfully.");
            }
            else
            {
                MessageBox.Show("Failed updating personal info.");
            }
        }

        // Save password
        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            string currentPassword = tbxCurrentPasswordSettings.Text;
            string newPassword = tbxNewPasswordSettings.Text;
            string confirmPassword = tbxConfirmPasswordSettings.Text;
            if (String.IsNullOrWhiteSpace(currentPassword) || String.IsNullOrWhiteSpace(newPassword) ||
                String.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Fields cannot be empty.");
                return;
            }
            if (currentPassword == _currentUser.PasswordHash)
            {
                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match.");
                }
                else if (String.IsNullOrWhiteSpace(newPassword))
                {
                    MessageBox.Show("Password cannot be empty.");
                }
                else if (newPassword.Length < 6)
                {
                    MessageBox.Show("Password should be at least 6 characters long.");
                }
                else if (newPassword == currentPassword)
                {
                    MessageBox.Show("New password cannot be same as old password.");
                }
                else
                {
                    DatabaseController.UpdateEmployeePassword(_currentUser.Id, newPassword);
                    MessageBox.Show("Password updated successfully.");
                }
            }
            else
            {
                MessageBox.Show("Invalid current password.");
            }
        }

        private void btnCraeteDepartment_Click(object sender, EventArgs e)
        {
            Hide();
            CreateDepartmentForm form = new CreateDepartmentForm(_currentUser, this);
            form.ShowDialog();
        }

        private void HumanResourcesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void rbSaveEc_Click(object sender, EventArgs e)
        {
            string newECname = tbxECNameSettings.Text;
            string newECinfo = tbxECInfoSettings.Text;
            RelationshipType ecRelationship = (RelationshipType)cbxRelationshipSettings.SelectedItem;

            try
            {
                if (!String.IsNullOrEmpty(newECname) && !String.IsNullOrEmpty(newECinfo))
                {
                    EmergencyContact newEc = new EmergencyContact(newECname, newECinfo, ecRelationship);
                    DatabaseController.ModifyEmergencyContact(_currentUser, newEc);
                }
                MessageBox.Show("Saved.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
