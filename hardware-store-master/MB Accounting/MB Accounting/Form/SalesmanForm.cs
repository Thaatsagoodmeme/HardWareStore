using System;
using System.Windows.Forms;
using Database;
using Database.Model;
using Database.Model.Enum;

namespace MB_Accounting
{
    public partial class SalesmanForm : Form
    {
        private ColorTheme _formTheme;
        private Employee _currentUser;

        public ColorTheme FormTheme
        {
            get { return _formTheme; }
        }

        public SalesmanForm(Employee currentUser, ColorTheme previousFormTheme)
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
            lblEmployeeName.Text = $"{currentUser.FirstName} {currentUser.LastName}";
            tbxAddressSettings.Text = _currentUser.Address;
            tbxEmailSettings.Text = _currentUser.Email;
            tbxPhoneNumberSettings.Text = _currentUser.PhoneNumber;
            PopulateProductsComboBox();
            PopulateRelationshipComboBox();
        }

        private void LoadYellowImages()
        {
            imageListMenuYellow.Images.Add(Properties.Resources.calendar_yellow);
            imageListMenuYellow.Images.SetKeyName(0, "calendar_yellow");
            imageListMenuYellow.Images.Add(Properties.Resources.wheelbarrow_yellow);
            imageListMenuYellow.Images.SetKeyName(1, "wheelbarrow_yellow");
            imageListMenuYellow.Images.Add(Properties.Resources.settings_yellow);
            imageListMenuYellow.Images.SetKeyName(2, "settings_yellow");
            imageListMenuYellow.Images.Add(Properties.Resources.MB_Accounting_Logo_Yellow);
            imageListMenuYellow.Images.SetKeyName(3, "MB_Accounting_Logo_Yellow");
        }

        private void SetLightTheme()
        {
            /* Main tab */
            // Dark grey 
            lblGreetings.ForeColor =
                ColorPalette.DarkGrey;
            // White 
            panelMainTabBackground.BackColor =
                lblEmployeeName.BackColor =
                lblGreetings.BackColor =
                ColorPalette.White;
            // Pink 
            lblEmployeeName.ForeColor =
                ColorPalette.Pink;

            /* My schedule tab */
            // White 
            panelScheduleTabBackground.BackColor =
                btnApply.ForeColor =
                rtbxMessage.BackColor =
                ColorPalette.White;
            // Pink 
            btnApply.Inactive1 =
                btnApply.Inactive2 =
                rtbxMessage.ForeColor =
                ColorPalette.Pink;
            // Darker pink 
            btnApply.Active1 =
                btnApply.Active2 =
                ColorPalette.DarkerPink;
            // Dark grey 
            lblScheduleTabHeading.ForeColor =
                lblStartDate.ForeColor =
                lblEndDate.ForeColor =
                lblMessage.ForeColor =
                ColorPalette.DarkGrey;

            /* Stock request tab */
            // Dark grey 
            lblRequestStockHeading.ForeColor =
                lblProduct.ForeColor =
                lblQuantity.ForeColor =
                lblRequestDescription.ForeColor =
                tabPageRequestStock.ForeColor =
                ColorPalette.DarkGrey;
            // White 
            panelRequestStockTabBackground.BackColor =
                btnRequestStock.ForeColor =
                rtbxRequestDescription.BackColor =
                tbxRequestQuantity.BackColor =
                cbxProducts.BackColor =
                ColorPalette.White;
            // Pink 
            btnRequestStock.Inactive1 =
               btnRequestStock.Inactive2 =
               tbxRequestQuantity.ForeColor =
               cbxProducts.ForeColor =
               rtbxRequestDescription.ForeColor =
               ColorPalette.Pink;
            // Darker pink 
            btnRequestStock.Active1 =
                btnRequestStock.Active2 =
                ColorPalette.DarkerPink;

            /* Settings tab */
            // Dark grey 
            lblSettingsTabHeading.ForeColor =
                lblEmailSettings.ForeColor =
                lblAddressSettings.ForeColor =
                lblPhoneNumberSettings.ForeColor =
                lblCurrentPassword.ForeColor =
                lbllNewPassword.ForeColor =
                lblConfirmPassword.ForeColor =
                tabPageSettings.ForeColor =
                lblECNameSettings.ForeColor =
                lblECInfoSettings.ForeColor =
                ColorPalette.DarkGrey;
            // White 
            panelSettingsTabBackground.BackColor =
                btnSaveInfo.ForeColor =
                btnSavePassword.ForeColor =
                tbxPhoneNumberSettings.BackColor =
                tbxEmailSettings.BackColor =
                tbxConfirmPasswordSettings.BackColor =
                tbxNewPasswordSettings.BackColor =
                tbxCurrentPasswordSettings.BackColor =
                tbxAddressSettings.BackColor =
                tbxECNameSettings.BackColor =
                tbxECInfoSettings.BackColor =
                cbxRelationship.BackColor =
                rbSaveEc.ForeColor =
                ColorPalette.White;
            // Pink 
            btnSavePassword.Inactive1 =
                btnSavePassword.Inactive2 =
                btnSaveInfo.Inactive1 =
                btnSaveInfo.Inactive2 =
                rbSaveEc.Inactive1 =
                rbSaveEc.Inactive2 =
                lblPersonalInfo.ForeColor =
                lblPasswordSettings.ForeColor =
                tbxAddressSettings.ForeColor =
                tbxPhoneNumberSettings.ForeColor =
                tbxEmailSettings.ForeColor =
                tbxCurrentPasswordSettings.ForeColor =
                tbxNewPasswordSettings.ForeColor =
                tbxConfirmPasswordSettings.ForeColor =
                tbxECInfoSettings.ForeColor =
                tbxECNameSettings.ForeColor =
                lblECSettings.ForeColor =
                cbxRelationship.ForeColor =
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
                lblEmployeeName.BackColor =
                lblGreetings.BackColor =
                ColorPalette.DarkBlue;
            lblGreetings.ForeColor =
                ColorPalette.White;
            lblEmployeeName.ForeColor =
                ColorPalette.Yellow;

            /* My schedule tab */
            // Dark blue 
            panelScheduleTabBackground.BackColor =
                btnApply.ForeColor =
                ColorPalette.DarkBlue;
            // Lighter blue 
            rtbxMessage.BackColor =
                ColorPalette.LighterBlue;
            // White 
            lblScheduleTabHeading.ForeColor =
                lblStartDate.ForeColor =
                lblEndDate.ForeColor =
                lblMessage.ForeColor =
                ColorPalette.White;
            // Yellow 
            btnApply.Inactive1 =
                btnApply.Inactive2 =
                ColorPalette.Yellow;
            // Darker yellow 
            btnApply.Active1 =
                btnApply.Active2 =
                rtbxMessage.ForeColor =
                ColorPalette.DarkerYellow;

            /* Request stock tab */
            // White 
            lblRequestStockHeading.ForeColor =
                lblProduct.ForeColor =
                lblQuantity.ForeColor =
                lblRequestDescription.ForeColor =
                ColorPalette.White;
            // Dark blue 
            panelRequestStockTabBackground.BackColor =
                btnRequestStock.ForeColor =
                tbxRequestQuantity.ForeColor =
                cbxProducts.ForeColor =
                rtbxRequestDescription.ForeColor =
                ColorPalette.DarkBlue;
            // Lighter blue 
            cbxProducts.BackColor =
                tbxRequestQuantity.BackColor =
                rtbxRequestDescription.BackColor =
                ColorPalette.LighterBlue;
            // Yellow 
            btnRequestStock.Inactive1 =
                btnRequestStock.Inactive2 =
                ColorPalette.Yellow;
            // Darker yellow 
            btnRequestStock.Active1 =
                btnRequestStock.Active2 =
                cbxProducts.ForeColor =
                tbxRequestQuantity.ForeColor =
                rtbxRequestDescription.ForeColor =
                ColorPalette.DarkerYellow;

            /* Settings tab */
            // White 
            tabPageSettings.ForeColor =
                lblSettingsTabHeading.ForeColor =
                lblAddressSettings.ForeColor =
                lblPhoneNumberSettings.ForeColor =
                lblEmailSettings.ForeColor =
                lblConfirmPassword.ForeColor =
                lblCurrentPassword.ForeColor =
                lbllNewPassword.ForeColor =
                lblRelationship.ForeColor =
                lblECNameSettings.ForeColor =
                lblECInfoSettings.ForeColor =
                ColorPalette.White;
            // Dark blue 
            panelSettingsTabBackground.BackColor =
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
                cbxRelationship.BackColor =
                ColorPalette.LighterBlue;
            // Yellow elements
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
                tbxECNameSettings.ForeColor =
                tbxECInfoSettings.ForeColor =
                cbxRelationship.ForeColor =
                ColorPalette.DarkerYellow;
        }

        // Set Montserrat font to controls
        private void SetMontserratFont()
        {
            // Montserrat medium
            Fonts.SetPropertyFont(0, this, tabPageMain, lblGreetings, tabPageSchedule,
                tabPageRequestStock, cbxProducts,
                tbxRequestQuantity, rtbxRequestDescription,
                btnRequestStock, btnSaveInfo, btnSavePassword,
                tabPageSettings, tbxAddressSettings, tbxPhoneNumberSettings,
                tbxEmailSettings, tbxCurrentPasswordSettings, tbxNewPasswordSettings,
                tbxConfirmPasswordSettings, lblMessage,
                lblStartDate, lblEndDate, rtbxMessage,
                btnApply, lblECSettings, lblECInfoSettings, lblECNameSettings,
                tbxECInfoSettings, tbxECNameSettings, rbSaveEc);
            // Montserrat semibold
            Fonts.SetPropertyFont(1, lblEmployeeName, lblScheduleTabHeading,
                lblRequestStockHeading, lblSettingsTabHeading);
        }
        private void PopulateRelationshipComboBox()
        {
            foreach (var relationshipType in Enum.GetValues(typeof(RelationshipType)))
            {
                cbxRelationship.Items.Add(relationshipType);
            }
        }
        private void PopulateProductsComboBox()
        {
            cbxProducts.Items.AddRange(DatabaseController.GetProductsByDepartment(_currentUser.DepartmentId).ToArray());

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

        private void btnApply_Click(object sender, EventArgs e)
        {
            DateTime startDate = mcStartDate.SelectionRange.Start;
            DateTime endDate = mcEndDate.SelectionRange.Start;
            if (startDate >= endDate)
            {
                MessageBox.Show("Start date cannot be after end date.");
                return;
            }
            else if (startDate < DateTime.Now.AddMonths(1))
            {
                MessageBox.Show("Vacation can start at least after one month.");
                return;
            }
            string message = rtbxMessage.Text;
            bool success = DatabaseController.CreateVacationApplication(_currentUser.Id, startDate, endDate, message);
            if (success)
            {
                MessageBox.Show("Application successfully sent.");
            }
            else
            {
                MessageBox.Show("Failed sending applicaiton.");
            }
        }

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

        private void btnRequestStock_Click(object sender, EventArgs e)
        {
            string productName = null;
            int quantity = -1;
            string description = rtbxRequestDescription.Text;
            try
            {
                if (cbxProducts.SelectedItem is null)
                {
                    MessageBox.Show("Please select a product first.");
                    return;
                }
                productName = ((Product)cbxProducts.SelectedItem).Name;
                quantity = int.Parse(tbxRequestQuantity.Text);
                if (quantity <= 0)
                {
                    throw new ArgumentException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid quantity type.");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Choose an existing product or department.");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Invalid quantity amount.");
            }
            if (productName != null && quantity > 0)
            {
                int productId = DatabaseController.GetProductId(productName);
                bool success = DatabaseController.CreateStockRequest(productId, quantity, description, _currentUser.DepartmentId);
                if (success)
                {
                    MessageBox.Show("Stock request created successfully.");
                }
                else
                {
                    MessageBox.Show("Failed creating stock request.");
                }
            }
        }

        private void SalesmanForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void rbSaveEc_Click(object sender, EventArgs e)
        {
            string newECname = tbxECNameSettings.Text;
            string newECinfo = tbxECInfoSettings.Text;
            RelationshipType ecRelationship = (RelationshipType)cbxRelationship.SelectedItem;

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
