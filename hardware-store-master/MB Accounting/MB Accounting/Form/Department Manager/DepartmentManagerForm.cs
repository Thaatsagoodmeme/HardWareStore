using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Database;
using Database.Model;
using Database.Model.Enum;
using System.Globalization;
using System.Drawing;

namespace MB_Accounting
{
    public partial class DepartmentManagerForm : Form
    {
        private ColorTheme _formTheme;
        private Employee _currentUser;
        private DateTime _chosenDate;

        public DepartmentManagerForm(Employee currentUser, ColorTheme previousFormTheme)
        {
            InitializeComponent();
            LoadYellowImages();
            // Set font - Montserrat
            SetMontserratFont();
            // Set color mode
            _currentUser = currentUser;
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
            _chosenDate = DateTime.Today;
            SetWeekSpan();
            PopulateStockRequestsListBox();
            PopulateRelationshipComboBox();
            tbxAddressSettings.Text = _currentUser.Address;
            tbxEmailSettings.Text = _currentUser.Email;
            tbxPhoneNumberSettings.Text = _currentUser.PhoneNumber;
        }

        public ColorTheme FormTheme
        {
            get { return _formTheme; }
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
            pbArrowLeft.Show();
            pbArrowRight.Show();
            pbArrowLeftYellow.Hide();
            pbArrowRightYellow.Hide();
            /* Main tab */
            // White 
            panelMainTabBackground.BackColor =
                ColorPalette.White;
            // Dark grey 
            lblGreetings.ForeColor =
                ColorPalette.DarkGrey;
            // Pink 
            lblEmployeeName.ForeColor =
                ColorPalette.Pink;

            /* Work shifts tab */
            // White 
            panelWorkShiftsTabBackground.BackColor =
                btnSeeVacationApplications.ForeColor =
                rbtAutomatedSheduling.ForeColor =
                ColorPalette.White;
            // Dark grey 
            lblWorShiftsTabHeading.ForeColor =
                lblMonday.ForeColor =
                lblTuesday.ForeColor =
                lblWednesday.ForeColor =
                lblThursday.ForeColor =
                lblFriday.ForeColor =
                lblSaturday.ForeColor =
                lblSunday.ForeColor =
             ColorPalette.DarkGrey;
            // Pink
            lblWeekSpan.ForeColor =
                btnSeeVacationApplications.Inactive1 =
                btnSeeVacationApplications.Inactive2 =
                rbtAutomatedSheduling.Inactive1 =
                rbtAutomatedSheduling.Inactive2 =
                ColorPalette.Pink;
            // Darker ink
            btnSeeVacationApplications.Active1 =
                btnSeeVacationApplications.Active2 =
                rbtAutomatedSheduling.Active1 =
                rbtAutomatedSheduling.Active2 =
                ColorPalette.DarkerPink;

            /* Stock requests tab */
            // White 
            panelStockRequestsTabBackground.BackColor =
                btnDeleteRequest.ForeColor =
                btnSeeDepartmentPerformance.ForeColor =
                btnApproveRequest.ForeColor =
                btnDepartmentPerformance.ForeColor =
                ColorPalette.White;
            // Pink 
            btnDeleteRequest.Inactive1 =
                btnDeleteRequest.Inactive2 =
                btnSeeDepartmentPerformance.Inactive1 =
                btnSeeDepartmentPerformance.Inactive2 =
                btnApproveRequest.Inactive1 =
                btnApproveRequest.Inactive2 =
                btnDepartmentPerformance.Inactive1 =
                btnDepartmentPerformance.Inactive2 =
                ColorPalette.Pink;
            // Darker pink 
            btnSeeDepartmentPerformance.Active1 =
                btnSeeDepartmentPerformance.Active2 =
                btnDeleteRequest.Active1 =
                btnDeleteRequest.Active2 =
                btnApproveRequest.Active1 =
                btnApproveRequest.Active2 =
                btnDepartmentPerformance.Active1 =
                btnDepartmentPerformance.Active2 =
                ColorPalette.DarkerPink;
            // Light grey 
            lbxStockRequests.BackColor =
                ColorPalette.LightGrey;
            // Dark grey 
            lbxStockRequests.ForeColor =
                lblStockRequestsTabHeading.ForeColor =
                ColorPalette.DarkGrey;

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
                tbxECInfoSettings.BackColor =
                tbxECNameSettings.BackColor =
                cbxRelationship.BackColor =
                ColorPalette.White;
            // Dark grey 
            tabPageSettings.ForeColor =
                lblSettingsTabHeading.ForeColor =
                lblSettingsAddress.ForeColor =
                lblEmailSettings.ForeColor =
                lblPhoneNumberSettings.ForeColor =
                lblCurrentPassword.ForeColor =
                lblNewPassword.ForeColor =
                lblConfirmPassword.ForeColor =
                lblSettingsTabHeading.ForeColor =
                lblECNameSettings.ForeColor =
                lblECInfoSettings.ForeColor =
                ColorPalette.DarkGrey;
            // Pink 
            tbxAddressSettings.ForeColor =
                lblPasswordSettings.ForeColor =
                cbxRelationship.ForeColor =
                lblPersonalInfo.ForeColor =
                lblECSettings.ForeColor =
                tbxPhoneNumberSettings.ForeColor =
                tbxEmailSettings.ForeColor =
                tbxConfirmPasswordSettings.ForeColor =
                tbxNewPasswordSettings.ForeColor =
                tbxCurrentPasswordSettings.ForeColor =
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
            pbArrowLeftYellow.Show();
            pbArrowRightYellow.Show();
            pbArrowLeft.Hide();
            pbArrowRight.Hide();
            /* Main tab */
            // Dark blue 
            panelMainTabBackground.BackColor =
                ColorPalette.DarkBlue;
            // White 
            lblGreetings.ForeColor =
                ColorPalette.White;
            // Yellow 
            lblEmployeeName.ForeColor =
                ColorPalette.Yellow;

            /* Work shifts tab */
            // Dark blue 
            panelWorkShiftsTabBackground.BackColor =
                btnSeeVacationApplications.ForeColor =
                rbtAutomatedSheduling.ForeColor =
                ColorPalette.DarkBlue;
            // White 
            lblWorShiftsTabHeading.ForeColor =
                lblMonday.ForeColor =
                lblTuesday.ForeColor =
                lblWednesday.ForeColor =
                lblThursday.ForeColor =
                lblFriday.ForeColor =
                lblRelationship.ForeColor =
                lblSaturday.ForeColor =
                lblSunday.ForeColor =
                ColorPalette.White;
            // Yellow
            lblWeekSpan.ForeColor =
                btnSeeVacationApplications.Inactive1 =
                btnSeeVacationApplications.Inactive2 =
                rbtAutomatedSheduling.Inactive1 =
                rbtAutomatedSheduling.Inactive2 =
                cbxRelationship.ForeColor =
                ColorPalette.Yellow;
            // Darker yellow
            btnSeeVacationApplications.Active1 =
                btnSeeVacationApplications.Active2 =
                rbtAutomatedSheduling.Active1 =
                rbtAutomatedSheduling.Active2 =
                ColorPalette.DarkerYellow;

            /* Stock requests tab */
            // Dark blue 
            panelStockRequestsTabBackground.BackColor =
                btnDeleteRequest.ForeColor =
                btnSeeDepartmentPerformance.ForeColor =
                btnApproveRequest.ForeColor =
                btnDepartmentPerformance.ForeColor =
                ColorPalette.DarkBlue;
            // Lighter blue
            lbxStockRequests.BackColor =
                cbxRelationship.BackColor =
                ColorPalette.LighterBlue;
            // Yellow 
            btnDeleteRequest.Inactive1 =
                btnDeleteRequest.Inactive2 =
                btnSeeDepartmentPerformance.Inactive1 =
                btnSeeDepartmentPerformance.Inactive2 =
                btnApproveRequest.Inactive1 =
                btnApproveRequest.Inactive2 =
                btnDepartmentPerformance.Inactive1 =
                btnDepartmentPerformance.Inactive2 =
                ColorPalette.Yellow;
            // Darker yellow 
            btnDeleteRequest.Active1 =
                btnDeleteRequest.Active2 =
                btnSeeDepartmentPerformance.Active1 =
                btnSeeDepartmentPerformance.Active2 =
                btnApproveRequest.Active1 =
                btnApproveRequest.Active2 =
                btnDepartmentPerformance.Active1 =
                btnDepartmentPerformance.Active2 =
                lbxStockRequests.ForeColor =
                ColorPalette.DarkerYellow;
            // White 
            lblStockRequestsTabHeading.ForeColor =
                ColorPalette.White;

            /* Settings tab */
            // White elements
            tabPageSettings.ForeColor =
                lblSettingsAddress.ForeColor =
                lblEmailSettings.ForeColor =
                lblPhoneNumberSettings.ForeColor =
                lblCurrentPassword.ForeColor =
                lblNewPassword.ForeColor =
                lblConfirmPassword.ForeColor =
                lblSettingsTabHeading.ForeColor =
                lblECInfoSettings.ForeColor =
                lblECNameSettings.ForeColor =
                ColorPalette.White;
            // Dark blue elements
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
                tbxECNameSettings.ForeColor =
                tbxECInfoSettings.ForeColor =
                ColorPalette.DarkerYellow;
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

        // Set Montserrat font to controls
        private void SetMontserratFont()
        {
            // Montserrat medium
            Fonts.SetPropertyFont(0, this, tabControlMenu, lblGreetings, tabPageWorkShifts,
                lbxStockRequests, tabPageSettings,
                tbxAddressSettings, tbxPhoneNumberSettings, tbxEmailSettings, btnSaveInfo,
                tbxCurrentPasswordSettings, tbxNewPasswordSettings, tbxConfirmPasswordSettings,
                btnSavePassword, lblPasswordSettings, lblPersonalInfo, btnDeleteRequest,
                btnSeeDepartmentPerformance, btnApproveRequest, lblWeekSpan, lblMonday, lblTuesday,
                lblWednesday, lblThursday, lblFriday, lblSaturday, lblSunday, lvMonday,
                lvTuesday, lvWednesday, lvThursday, lvFriday, lvSaturday, lvSunday, btnSeeVacationApplications,
                lblECSettings, lblECNameSettings, lblECInfoSettings, tbxECNameSettings, tbxECInfoSettings,
                rbSaveEc, btnDepartmentPerformance);
            // Montserrat semibold
            Fonts.SetPropertyFont(1, lblEmployeeName, lblWorShiftsTabHeading,
                lblStockRequestsTabHeading, lblSettingsTabHeading);
        }

        public void SetWeekSpan()
        {
            lvMonday.Items.Clear();
            lvTuesday.Items.Clear();
            lvWednesday.Items.Clear();
            lvThursday.Items.Clear();
            lvFriday.Items.Clear();
            lvSaturday.Items.Clear();
            lvSunday.Items.Clear();

            DateTime firstDayDate = FirstDayOfWeek(_chosenDate);
            DateTime lastDayDate = LastDayOfWeek(_chosenDate);
            lblWeekSpan.Text = $"{firstDayDate.Day:00}.{firstDayDate.Month:00} - {lastDayDate.Day:00}.{lastDayDate.Month:00} {_chosenDate.Year}";

            List<WorkShift> chosenWeekShifts = DatabaseController.GetWorkShifts(_currentUser.DepartmentId,
                firstDayDate, lastDayDate);
            if (chosenWeekShifts is null)
            {
                return;
            }

            foreach (WorkShift shift in chosenWeekShifts)
            {
                // Avoid availability and show just shifts
                if (shift.IsShift == 0)
                {
                    continue;
                }

                if (shift.Date == firstDayDate)
                {
                    lvMonday.Items.Add(CreateListViewItem(shift));
                }
                else if (shift.Date == firstDayDate.AddDays(1))
                {
                    lvTuesday.Items.Add(CreateListViewItem(shift));
                }
                else if (shift.Date == firstDayDate.AddDays(2))
                {
                    lvWednesday.Items.Add(CreateListViewItem(shift));
                }
                else if (shift.Date == firstDayDate.AddDays(3))
                {
                    lvThursday.Items.Add(CreateListViewItem(shift));
                }
                else if (shift.Date == firstDayDate.AddDays(4))
                {
                    lvFriday.Items.Add(CreateListViewItem(shift));
                }
                else if (shift.Date == firstDayDate.AddDays(5))
                {
                    lvSaturday.Items.Add(CreateListViewItem(shift));
                }
                else if (shift.Date == lastDayDate)
                {
                    lvSunday.Items.Add(CreateListViewItem(shift));
                }
            }
        }

        private ListViewItem CreateListViewItem(WorkShift workShift)
        {
            string[] arr = new string[] { workShift.Type.ToString(),
                DatabaseController.GetEmployee(workShift.EmployeeId).FullName, workShift.Id.ToString()};
            ListViewItem item = new ListViewItem(arr);
            switch (workShift.Type)
            {
                case WorkShiftType.Morning:
                    item.BackColor = Color.LightGreen;
                    break;
                case WorkShiftType.Afternoon:
                    item.BackColor = Color.LightSalmon;
                    break;
                case WorkShiftType.Evening:
                    item.BackColor = Color.SlateBlue;
                    break;
                case WorkShiftType.Regular:
                    item.BackColor = Color.Tan;
                    break;
            }
            item.ForeColor = ColorPalette.White;
            return item;
        }

        private static DateTime FirstDayOfWeek(DateTime date)
        {
            DayOfWeek fdow = CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek;
            int offset = fdow - date.DayOfWeek;
            DateTime fdowDate = date.AddDays(offset);
            return fdowDate;
        }

        private static DateTime LastDayOfWeek(DateTime date)
        {
            DateTime ldowDate = FirstDayOfWeek(date).AddDays(6);
            return ldowDate;
        }
        private void PopulateRelationshipComboBox()
        {
            foreach (var relationshipType in Enum.GetValues(typeof(RelationshipType)))
            {
                cbxRelationship.Items.Add(relationshipType);
            }
        }
        private void PopulateStockRequestsListBox()
        {
            lbxStockRequests.Items.Clear();
            List<StockRequest> stockRequests = DatabaseController.GetStockRequests(_currentUser.DepartmentId);
            if (stockRequests is null)
            {
                lbxStockRequests.Items.Add("No stock requests currently.");
            }
            else
            {
                foreach(StockRequest sr in stockRequests)
                {
                    if(!sr.Approved)
                    {
                        lbxStockRequests.Items.Add(sr);
                    }
                }
            }
        }

        private void MoveToNextWeek()
        {
            _chosenDate = _chosenDate.AddDays(7);
            SetWeekSpan();
        }

        private void MoveToPreviousWeek()
        {
            _chosenDate = _chosenDate.AddDays(-7);
            SetWeekSpan();
        }

        private void pbArrowRight_Click(object sender, EventArgs e)
        {
            MoveToNextWeek();
        }

        private void pbArrowRightYellow_Click(object sender, EventArgs e)
        {
            MoveToNextWeek();
        }

        private void pbArrowLeft_Click(object sender, EventArgs e)
        {
            MoveToPreviousWeek();
        }

        private void pbArrowLeftYellow_Click(object sender, EventArgs e)
        {
            MoveToPreviousWeek();
        }

        private void btnApproveRequest_Click(object sender, EventArgs e)
        {
            StockRequest stockRequest = (StockRequest)lbxStockRequests.SelectedItem;
            if (stockRequest is object)
            {
                bool success = DatabaseController.ApproveStockRequest(stockRequest.ProductId, stockRequest.Quantity, stockRequest.Id);
                if (success)
                {
                    MessageBox.Show("Stock request approved successfully.");
                    PopulateStockRequestsListBox();
                }
                else
                {
                    MessageBox.Show("Failed approving stock request.");
                }
            }
            else
            {
                MessageBox.Show("Select stock request first.");
            }
        }

        private void btnDeleteRequest_Click(object sender, EventArgs e)
        {
            StockRequest stockRequest = (StockRequest)lbxStockRequests.SelectedItem;
            if (stockRequest is object)
            {
                bool succes = DatabaseController.DeleteStockRequest(stockRequest.Id);
                if (succes)
                {
                    MessageBox.Show("Stock request deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Failed deleting stock request.");
                }
            }
            else
            {
                MessageBox.Show("Select stock request first.");
            }
        }

        private void OpenWorkShifts(DateTime day)
        {
            Hide();
            Form form = new CheckWorkShiftsForm(_currentUser, this, day);
            form.ShowDialog();
        }

        private void lblMonday_Click(object sender, EventArgs e)
        {
            OpenMondayShifts();
        }

        private void lblTuesday_Click(object sender, EventArgs e)
        {
            OpenTuesdayShifts();
        }

        private void lblWednesday_Click(object sender, EventArgs e)
        {
            OpenWednesdayShifts();
        }

        private void lblThursday_Click(object sender, EventArgs e)
        {
            OpenThursdayShifts();
        }

        private void lblFriday_Click(object sender, EventArgs e)
        {
            OpenFridayShifts();
        }

        private void lblSaturday_Click(object sender, EventArgs e)
        {
            OpenSaturdayShifts();
        }

        private void lblSunday_Click(object sender, EventArgs e)
        {
            OpenSundayShifts();
        }

        private void lvMonday_MouseDown(object sender, MouseEventArgs e)
        {
            OpenMondayShifts();

        }

        private void lvTuesday_MouseDown(object sender, MouseEventArgs e)
        {
            OpenTuesdayShifts();
        }

        private void lvWednesday_MouseDown(object sender, MouseEventArgs e)
        {
            OpenWednesdayShifts();
        }

        private void lvThursday_MouseDown(object sender, MouseEventArgs e)
        {
            OpenThursdayShifts();
        }

        private void lvFriday_MouseDown(object sender, MouseEventArgs e)
        {
            OpenFridayShifts();
        }

        private void lvSaturday_MouseDown(object sender, MouseEventArgs e)
        {
            OpenSaturdayShifts();
        }

        private void lvSunday_MouseDown(object sender, MouseEventArgs e)
        {
            OpenSundayShifts();
        }

        private void OpenMondayShifts()
        {
            DateTime day = FirstDayOfWeek(_chosenDate);
            OpenWorkShifts(day);
        }

        private void OpenTuesdayShifts()
        {
            DateTime day = FirstDayOfWeek(_chosenDate).AddDays(1);
            OpenWorkShifts(day);
        }

        private void OpenWednesdayShifts()
        {
            DateTime day = FirstDayOfWeek(_chosenDate).AddDays(2);
            OpenWorkShifts(day);
        }

        private void OpenThursdayShifts()
        {
            DateTime day = FirstDayOfWeek(_chosenDate).AddDays(3);
            OpenWorkShifts(day);
        }

        private void OpenFridayShifts()
        {
            DateTime day = FirstDayOfWeek(_chosenDate).AddDays(4);
            OpenWorkShifts(day);
        }

        private void OpenSaturdayShifts()
        {
            DateTime day = FirstDayOfWeek(_chosenDate).AddDays(5);
            OpenWorkShifts(day);
        }

        private void OpenSundayShifts()
        {
            DateTime day = FirstDayOfWeek(_chosenDate).AddDays(6);
            OpenWorkShifts(day);
        }

        private void btnSeeDepartmentPerformance_Click(object sender, EventArgs e)
        {
            Hide();
            ProductsOverviewForm productsOverviewForm = new ProductsOverviewForm(_currentUser, this);
            productsOverviewForm.ShowDialog();
        }


        private void btnDepartmentPerformance_Click(object sender, EventArgs e)
        {
            Hide();
            DepartmentPerformanceForm departmentPerformanceForm = new DepartmentPerformanceForm(_currentUser, this);
            departmentPerformanceForm.ShowDialog();
        }

        private void lbxStockRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            StockRequest stockRequest = (StockRequest)lbxStockRequests.SelectedItem;
            if (stockRequest is object)
            {
                MessageBox.Show($"Request description: {stockRequest.Description}");
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

        private void DepartmentManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSeeVacationApplications_Click(object sender, EventArgs e)
        {
            Hide();
            CheckVacationDaysApplicationsForm form = new CheckVacationDaysApplicationsForm(_currentUser, this);
            form.ShowDialog();
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

        private void rbtAutomatedSheduling_Click(object sender, EventArgs e)
        {
            DateTime thisWeek = FirstDayOfWeek(DateTime.Now);
            DateTime firstDayDate = FirstDayOfWeek(_chosenDate);
            DateTime lastDayDate = LastDayOfWeek(_chosenDate);
            if(thisWeek.Date < firstDayDate.Date)
            {
                AutomatedSchedulingForm newSuggestion = new AutomatedSchedulingForm(_currentUser, this, firstDayDate, lastDayDate);
                this.Hide();
                newSuggestion.Show();
            }
            else
            {
                MessageBox.Show("Schedule for the current week is locked!");
            }
            
        }
    }
}
