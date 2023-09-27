using System;
using System.Windows.Forms;
using Database;
using Database.Model;

namespace MB_Accounting
{
    public partial class EmployeeInformationForm : Form
    {
        private ColorTheme _formTheme;
        private Employee _currentUser;
        private HumanResourcesForm _previousForm;

        public EmployeeInformationForm(Employee currentUser, HumanResourcesForm previousForm)
        {
            InitializeComponent();
            _previousForm = previousForm;
            // Set font - Montserrat
            SetMontserratFont();
            _currentUser = currentUser;
            // Set color mode
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
            pictureBoxBackPink.Show();
            pictureBoxSun.Hide();
            pictureBoxBackYellow.Hide();
            // White 
            tbxEmpId.BackColor =
                tbxFirstName.BackColor =
                tbxLastName.BackColor =
                tbxBirthdate.BackColor =
                tbxAddress.BackColor =
                tbxPhoneNumber.BackColor =
                tbxGender.BackColor =
                tbxDepartment.BackColor =
                tbxPosition.BackColor =
                tbxSalary.BackColor =
                tbxVacationDays.BackColor =
                tbxContractStartDate.BackColor =
                tbxContractExpirationDate.BackColor =
                cbxEmployees.BackColor =
                BackColor =
                ColorPalette.White;
            // Pink 
            lblSelect.ForeColor =
                tbxEmpId.ForeColor =
                tbxFirstName.ForeColor =
                tbxLastName.ForeColor =
                tbxBirthdate.ForeColor =
                tbxAddress.ForeColor =
                tbxPhoneNumber.ForeColor =
                tbxGender.ForeColor =
                tbxDepartment.ForeColor =
                tbxPosition.ForeColor =
                tbxSalary.ForeColor =
                tbxVacationDays.ForeColor =
                tbxContractStartDate.ForeColor =
                tbxContractExpirationDate.ForeColor =
                cbxEmployees.ForeColor =
                ColorPalette.Pink;
            // Dark grey 
            lblEmployeeInformation.ForeColor =
                lblEmployeeId.ForeColor =
                lblFirstName.ForeColor =
                lblLastName.ForeColor =
                lblBirthDate.ForeColor =
                lblAddress.ForeColor =
                lblPhoneNumber.ForeColor =
                lblGender.ForeColor =
                lblDepartment.ForeColor =
                lblPosition.ForeColor =
                lblSalary.ForeColor =
                lblAvailableVacationDays.ForeColor =
                lblContractStartDate.ForeColor =
                lblContractExpirationDate.ForeColor =
                ColorPalette.DarkGrey;
        }

        private void SetDarkTheme()
        {
            pictureBoxSun.Show();
            pictureBoxMoon.Hide();
            pictureBoxBackYellow.Show();
            pictureBoxBackPink.Hide();
            // Dark blue 
            BackColor =
                ColorPalette.DarkBlue;
            // White 
            lblEmployeeInformation.ForeColor =
                lblEmployeeId.ForeColor =
                lblFirstName.ForeColor =
                lblLastName.ForeColor =
                lblBirthDate.ForeColor =
                lblAddress.ForeColor =
                lblPhoneNumber.ForeColor =
                lblGender.ForeColor =
                lblDepartment.ForeColor =
                lblPosition.ForeColor =
                lblSalary.ForeColor =
                lblAvailableVacationDays.ForeColor =
                lblContractStartDate.ForeColor =
                lblContractExpirationDate.ForeColor =
                ColorPalette.White;
            // Darker yellow 
            tbxEmpId.ForeColor =
                tbxFirstName.ForeColor =
                tbxLastName.ForeColor =
                tbxBirthdate.ForeColor =
                tbxAddress.ForeColor =
                tbxPhoneNumber.ForeColor =
                tbxGender.ForeColor =
                tbxDepartment.ForeColor =
                tbxPosition.ForeColor =
                tbxSalary.ForeColor =
                tbxVacationDays.ForeColor =
                tbxContractStartDate.ForeColor =
                tbxContractExpirationDate.ForeColor =
                cbxEmployees.ForeColor =
                ColorPalette.DarkerYellow;
            // Lighter blue elements
            tbxEmpId.BackColor =
                tbxFirstName.BackColor =
                tbxLastName.BackColor =
                tbxBirthdate.BackColor =
                tbxAddress.BackColor =
                tbxPhoneNumber.BackColor =
                tbxGender.BackColor =
                tbxDepartment.BackColor =
                tbxPosition.BackColor =
                tbxSalary.BackColor =
                tbxVacationDays.BackColor =
                tbxContractStartDate.BackColor =
                tbxContractExpirationDate.BackColor =
                cbxEmployees.BackColor =
                ColorPalette.LighterBlue;
            // Yellow elements
            lblSelect.ForeColor =
                ColorPalette.Yellow;
        }

        // Set Montserrat font to controls
        private void SetMontserratFont()
        {
            // Montserrat medium
            Fonts.SetPropertyFont(0, this, lblSelect, lblEmployeeId,
                lblFirstName, lblLastName, lblBirthDate,
                lblAddress, lblPhoneNumber, lblGender,
                lblDepartment, lblPosition, lblSalary,
                lblAvailableVacationDays, lblContractStartDate,
                lblContractExpirationDate, tbxEmpId,
                tbxFirstName, tbxLastName, tbxBirthdate,
                tbxAddress, tbxPhoneNumber, tbxGender,
                tbxDepartment, tbxPosition, tbxSalary,
                tbxVacationDays, tbxContractStartDate,
                tbxContractExpirationDate, cbxEmployees);
            // Montserrat semibold
            Fonts.SetPropertyFont(1, lblEmployeeInformation);
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

        private void PopulateEmployeesComboBox()
        {
            cbxEmployees.Items.Clear();
            cbxEmployees.Items.AddRange(DatabaseController.GetEmployees().ToArray());
        }

        private void cbxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            int employeeId = ((Employee)cbxEmployees.SelectedItem).Id;
            if (employeeId == -1)
            {
                MessageBox.Show("No employee found.");
                return;
            }
            Employee emp = DatabaseController.GetEmployee(employeeId);
            tbxAddress.Text = emp.Address;
            tbxBirthdate.Text = emp.BirthDate.ToString("MM/dd/yyyy");
            tbxContractExpirationDate.Text = emp.ContractExpirationDate.ToString("MM/dd/yyyy");
            tbxContractStartDate.Text = emp.ContractStartDate.ToString("MM/dd/yyyy");
            tbxDepartment.Text = DatabaseController.GetDepartment(emp.DepartmentId);
            tbxEmpId.Text = emp.Id.ToString();
            tbxFirstName.Text = emp.FirstName;
            tbxGender.Text = emp.Gender.ToString();
            tbxLastName.Text = emp.LastName;
            tbxPhoneNumber.Text = emp.PhoneNumber;
            tbxPosition.Text = emp.Position.ToString();
            tbxSalary.Text = emp.Salary.ToString();
            tbxVacationDays.Text = emp.AvailableVacationDays.ToString();
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

        private void EmployeeInformationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
