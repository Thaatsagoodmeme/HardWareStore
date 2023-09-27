using System;
using System.Windows.Forms;
using Database;
using Database.Model;

namespace MB_Accounting
{
    public partial class EmployeesInDepartmentForm : Form
    {
        private ColorTheme _formTheme;
        private Employee _currentUser;
        private HumanResourcesForm _previousForm;

        public EmployeesInDepartmentForm(Employee currentUser, HumanResourcesForm previousForm)
        {
            InitializeComponent();
            // Set font - Montserrat
            SetMontserratFont();
            // Set color mode
            _previousForm = previousForm;
            _formTheme = _previousForm.FormTheme;
            _currentUser = currentUser;
            switch (_formTheme)
            {
                case ColorTheme.Light:
                    SetLightTheme();
                    break;
                case ColorTheme.Dark:
                    SetDarkTheme();
                    break;
            }
            PopulateDepartmentsComboBox();
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
            pictureBoxBackPink.Show();
            pictureBoxBackYellow.Hide();
            pictureBoxMoon.Show();
            pictureBoxSun.Hide();
            // White 
            cbxDepartments.BackColor =
                BackColor =
                ColorPalette.White;
            // Light grey 
            lbxEmployees.BackColor =
                ColorPalette.LightGrey;
            // Dark grey 
            lblHeading.ForeColor =
                lbxEmployees.ForeColor =
                ColorPalette.DarkGrey;
            // Pink 
            lblSelect.ForeColor =
                cbxDepartments.ForeColor =
                ColorPalette.Pink;
        }

        private void SetDarkTheme()
        {
            pictureBoxBackYellow.Show();
            pictureBoxBackPink.Hide();
            pictureBoxSun.Show();
            pictureBoxMoon.Hide();
            // Dark blue 
            BackColor =
                ColorPalette.DarkBlue;
            // Lighter blue 
            cbxDepartments.BackColor =
                ColorPalette.LighterBlue;
            // White 
            lblHeading.ForeColor =
                ColorPalette.White;
            // Yellow 
            lblSelect.ForeColor =
                ColorPalette.Yellow;
            // Darker yellow 
            cbxDepartments.ForeColor =
                ColorPalette.DarkerYellow;
            // Dark grey 
            lbxEmployees.BackColor =
                ColorPalette.LighterBlue;
            // Light grey 
            lbxEmployees.ForeColor =
                ColorPalette.DarkerYellow;
        }

        // Set Montserrat font to controls
        private void SetMontserratFont()
        {
            // Montserrat medium
            Fonts.SetPropertyFont(0, this, lblSelect, cbxDepartments, lbxEmployees);
            // Montserrat semibold
            Fonts.SetPropertyFont(1, lblHeading);
        }

        private void PopulateDepartmentsComboBox()
        {
            cbxDepartments.Items.Clear();
            cbxDepartments.Items.AddRange(DatabaseController.GetDepartments().ToArray());
        }

        private void cbxDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            int departmentId = ((Department)cbxDepartments.SelectedItem).Id;
            lbxEmployees.Items.Clear();
            lbxEmployees.Items.AddRange(DatabaseController.GetEmployees(departmentId).ToArray());
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

        private void GoBack()
        {
            _previousForm.Show();
            Close();
        }
    }
}
