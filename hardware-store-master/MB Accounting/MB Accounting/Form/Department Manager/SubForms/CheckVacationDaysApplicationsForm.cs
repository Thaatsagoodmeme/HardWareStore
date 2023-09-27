using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Database;
using Database.Model;

namespace MB_Accounting
{
    public partial class CheckVacationDaysApplicationsForm : Form
    {
        private ColorTheme _formTheme;
        private Employee _currentUser;
        private DepartmentManagerForm _previousForm;

        public CheckVacationDaysApplicationsForm(Employee currentUser, DepartmentManagerForm previousForm)
        {
            InitializeComponent();
            // Set font - Montserrat
            SetMontserratFont();
            _currentUser = currentUser;
            // Set color mode
            _previousForm = previousForm;
            _formTheme = previousForm.FormTheme;
            switch (_formTheme)
            {
                case ColorTheme.Light:
                    SetLightTheme();
                    break;
                case ColorTheme.Dark:
                    SetDarkTheme();
                    break;
            }
            PopulateListBox();
        }

        // Disable close button
        private const int CP_DISABLE_CLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CP_DISABLE_CLOSE_BUTTON;
                return cp;
            }
        }

        private void SetLightTheme()
        {
            pictureBoxMoon.Show();
            pictureBoxSun.Hide();
            pictureBoxBackPink.Show();
            pictureBoxBackYellow.Hide();
            // White 
            BackColor =
                btnApprove.ForeColor =
                btnDecline.ForeColor =
                ColorPalette.White;
            // Pink
            btnApprove.Inactive1 =
                btnApprove.Inactive2 =
                btnDecline.Inactive1 =
                btnDecline.Inactive2 =
                ColorPalette.Pink;
            // Darker pink
            btnApprove.Active1 =
                btnApprove.Active2 =
                btnDecline.Active1 =
                btnDecline.Active2 =
                ColorPalette.DarkerPink;
            // Dark grey
            lblHeading.ForeColor =
                lbxApplications.ForeColor =
                ColorPalette.DarkGrey;
            // Light grey 
            lbxApplications.BackColor =
                ColorPalette.LightGrey;
        }

        private void SetDarkTheme()
        {
            pictureBoxSun.Show();
            pictureBoxMoon.Hide();
            pictureBoxBackYellow.Show();
            pictureBoxBackPink.Hide();
            // Dark blue
            BackColor =
                btnDecline.ForeColor =
                btnApprove.ForeColor =
                ColorPalette.DarkBlue;
            // White 
            lblHeading.ForeColor =
                ColorPalette.White;
            // Yellow
            btnApprove.Inactive1 =
                btnApprove.Inactive2 =
                btnDecline.Inactive1 =
                btnDecline.Inactive2 =
                ColorPalette.Yellow;
            // Darker yellow
            btnApprove.Active1 =
                btnApprove.Active2 =
                btnDecline.Active1 =
                btnDecline.Active2 =
                lbxApplications.ForeColor =
                ColorPalette.DarkerYellow;
            // Lighter blue 
            lbxApplications.BackColor =
                ColorPalette.LighterBlue;
        }

        // Set Montserrat font to controls
        private void SetMontserratFont()
        {
            // Montserrat medium
            Fonts.SetPropertyFont(0, this, lbxApplications, btnApprove, btnDecline);
            // Montserrat semibold
            Fonts.SetPropertyFont(1, lblHeading);
        }

        private void PopulateListBox()
        {
            lbxApplications.Items.Clear();
            List<VacationApplication> vacationApplications = DatabaseController.GetVacationApplications(_currentUser.DepartmentId);
            if (vacationApplications is null)
            {
                lbxApplications.Items.Add("There are no vacation applications currently.");
            }
            else
            {
                lbxApplications.Items.AddRange(vacationApplications.ToArray());
            }
        }
        
        // Enable light theme
        private void pictureBoxSun_Click(object sender, EventArgs e)
        {
            _formTheme = ColorTheme.Light;
            SetLightTheme();
        }

        // Enable dark theme
        private void pictureBoxMoon_Click(object sender, EventArgs e)
        {
            _formTheme = ColorTheme.Dark;
            SetDarkTheme();
        }

        private void pictureBoxBackPink_Click(object sender, EventArgs e)
        { 
            GoBack(); 
        }

        private void pictureBoxBackYellow_Click(object sender, EventArgs e)
        { 
            GoBack(); 
        }

        private void lbxApplications_SelectedIndexChanged(object sender, EventArgs e)
        {
            VacationApplication application = (VacationApplication)lbxApplications.SelectedItem;
            MessageBox.Show($"Message: {application.Message}\nAvailable vacation days: {DatabaseController.GetEmployee(application.EmployeeId).AvailableVacationDays}\nStart date: {application.StartDate}\nEnd date: {application.EndDate}");
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            VacationApplication application = (VacationApplication)lbxApplications.SelectedItem;
            if (application is null)
            {
                MessageBox.Show("Vacation application is not selected.");
                return;
            }
            DateTime date = application.StartDate;
            while (DateTime.Compare(date, application.EndDate) <= 0) 
            {
                DatabaseController.ApproveVacationApplication(application.EmployeeId, date);
                date = date.AddDays(1);
            }
            DatabaseController.DeleteVacationApplication(application.Id);
            TimeSpan span = application.EndDate.Subtract(application.StartDate);
            int newVacationDays = DatabaseController.GetEmployee(application.EmployeeId).AvailableVacationDays - span.Days;
            if (newVacationDays < 0)
            { newVacationDays = 0; }
            bool success = DatabaseController.UpdateEmployeeVacationDays(application.EmployeeId, newVacationDays);
            if (success)
            {
                PopulateListBox();
                MessageBox.Show("Application approved.");
            }
            else
            {
                MessageBox.Show("Failed approving application.");
            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            VacationApplication application = (VacationApplication)lbxApplications.SelectedItem;
            bool success = DatabaseController.DeleteVacationApplication(application.Id);
            if(success)
            {
                PopulateListBox();
                MessageBox.Show("Application declined.");
            }
            else
            {
                MessageBox.Show("Failed declining application.");
            }
        }

        private void GoBack()
        {
            _previousForm.Show();
            Close();
        }
    }
}
