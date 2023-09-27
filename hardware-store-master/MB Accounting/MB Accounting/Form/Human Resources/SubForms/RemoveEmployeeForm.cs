using System;
using System.Windows.Forms;
using Database;
using Database.Model;

namespace MB_Accounting
{
    public partial class RemoveEmployeeForm : Form
    {
        private ColorTheme _formTheme;
        private Employee _currentUser;
        private HumanResourcesForm _previousForm;

        public RemoveEmployeeForm(Employee currentUser, HumanResourcesForm previousForm)
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
            PopulateEmployeesComboBox();
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
                cbxEmployees.BackColor =
                tbxEmpId.BackColor =
                tbxFirstName.BackColor =
                tbxLastName.BackColor =
                btnRemoveEmployee.ForeColor =
                ColorPalette.White;
            // Pink 
            lblSelect.ForeColor =
                cbxEmployees.ForeColor =
                tbxEmpId.ForeColor =
                tbxFirstName.ForeColor =
                tbxLastName.ForeColor =
                btnRemoveEmployee.Inactive1 =
                btnRemoveEmployee.Inactive2 =
                ColorPalette.Pink;
            // Darker pink 
            btnRemoveEmployee.Active1 =
                btnRemoveEmployee.Active2 =
                ColorPalette.DarkerPink;
            // Dark grey 
            lblRemoveAnEmployee.ForeColor =
                lblEmployeeId.ForeColor =
                lblFirstName.ForeColor =
                lblLastName.ForeColor =
                ColorPalette.DarkGrey;
        }

        private void SetDarkTheme()
        {
            pictureBoxSun.Show();
            pictureBoxMoon.Hide();
            pictureBoxBackYellow.Show();
            pictureBoxBackPink.Hide();
            // Dark blue 
            btnRemoveEmployee.ForeColor =
                BackColor =
                ColorPalette.DarkBlue;
            // Lighter blue 
            tbxEmpId.BackColor =
                tbxFirstName.BackColor =
                tbxLastName.BackColor =
                cbxEmployees.BackColor =
                ColorPalette.LighterBlue;
            // White 
            lblEmployeeId.ForeColor =
                lblFirstName.ForeColor =
                lblLastName.ForeColor =
                lblRemoveAnEmployee.ForeColor =
                ColorPalette.White;
            // Darker yellow 
            tbxEmpId.ForeColor =
                tbxFirstName.ForeColor =
                tbxLastName.ForeColor =
                cbxEmployees.ForeColor =
                ColorPalette.DarkerYellow;
            // Yellow 
            lblSelect.ForeColor =
                btnRemoveEmployee.Inactive1 =
                btnRemoveEmployee.Inactive2 =
                ColorPalette.Yellow;
            // Darker yellow 
            btnRemoveEmployee.Active1 =
                btnRemoveEmployee.Active2 =
                ColorPalette.DarkerYellow;
        }

        private void PopulateEmployeesComboBox()
        {
            cbxEmployees.Items.Clear();
            cbxEmployees.Items.AddRange(DatabaseController.GetEmployees().ToArray());
        }

        // Set Montserrat font to controls
        private void SetMontserratFont()
        {
            // Montserrat medium
            Fonts.SetPropertyFont(0, this, lblSelect, lblFirstName,
                lblEmployeeId, lblLastName, tbxFirstName,
                tbxEmpId, tbxLastName, btnRemoveEmployee,
                cbxEmployees);
            // Montserrat semibold
            Fonts.SetPropertyFont(1, lblRemoveAnEmployee);
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

        private void cbxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            int employeeId = ((Employee)cbxEmployees.SelectedItem).Id;
            Employee emp = DatabaseController.GetEmployee(employeeId);
            if (emp is null)
            {
                MessageBox.Show($"No employee with id{employeeId} found.");
                return;
            }
            tbxEmpId.Text = emp.Id.ToString();
            tbxFirstName.Text = emp.FirstName;
            tbxLastName.Text = emp.LastName;
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            if(cbxEmployees.SelectedItem is object)
            {
                int employeeId = ((Employee)cbxEmployees.SelectedItem).Id;
                bool success = DatabaseController.DeleteEmployee(employeeId);
                if (success)
                {
                    MessageBox.Show("Employee removed successfully.");
                    PopulateEmployeesComboBox();
                    cbxEmployees.Text =
                        tbxEmpId.Text =
                        tbxFirstName.Text =
                        tbxLastName.Text =
                        String.Empty;
                }
                else
                {
                    MessageBox.Show("Could not remove employee.");
                }
            }
            else
            {
                MessageBox.Show("Please select employee first.");
            }
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
