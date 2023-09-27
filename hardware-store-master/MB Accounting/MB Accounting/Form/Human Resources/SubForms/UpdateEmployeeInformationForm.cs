using System;
using System.Windows.Forms;
using Database;
using Database.Model;

namespace MB_Accounting
{
    public partial class UpdateEmployeeInformationForm : Form
    {
        private ColorTheme _formTheme;
        private Employee _currentUser;
        private HumanResourcesForm _previousForm;

        public UpdateEmployeeInformationForm(Employee currentUser, HumanResourcesForm previousForm)
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
            pictureBoxMoon.Show();
            pictureBoxSun.Hide();
            pictureBoxBackPink.Show();
            pictureBoxBackYellow.Hide();
            // White 
            tbxEmpId.BackColor =
                tbxFirstName.BackColor =
                tbxLastName.BackColor =
                tbxAddress.BackColor =
                tbxPhoneNumber.BackColor =
                cbxDepartment.BackColor =
                cbxGender.BackColor =
                dtpContractExpirationDate.BackColor =
                cbxEmployees.BackColor =
                btnUpdateEmployee.ForeColor =
                tbxCity.BackColor =
                BackColor =
                ColorPalette.White;
            // Dark grey 
            lblUpdateEmployeeInformation.ForeColor =
                lblFirstName.ForeColor =
                lblEmployeeId.ForeColor =
                lblLastName.ForeColor =
                lblAddress.ForeColor =
                lblPhoneNumber.ForeColor =
                lblDepartment.ForeColor =
                lblGender.ForeColor =
                lblContractExpirationDate.ForeColor =
                lblCity.ForeColor =
                ColorPalette.DarkGrey;
            // Pink 
            lblSelect.ForeColor =
                cbxEmployees.ForeColor =
                tbxEmpId.ForeColor =
                tbxFirstName.ForeColor =
                tbxLastName.ForeColor =
                tbxAddress.ForeColor =
                tbxCity.ForeColor =
                tbxPhoneNumber.ForeColor =
                cbxDepartment.ForeColor =
                cbxGender.ForeColor =
                dtpContractExpirationDate.ForeColor =
                btnUpdateEmployee.Inactive1 =
                btnUpdateEmployee.Inactive2 =
                ColorPalette.Pink;
            // Darker pink 
            btnUpdateEmployee.Active1 =
                btnUpdateEmployee.Active2 =
                ColorPalette.DarkerPink;
        }

        private void SetDarkTheme()
        {
            pictureBoxSun.Show();
            pictureBoxMoon.Hide();
            pictureBoxBackYellow.Show();
            pictureBoxBackPink.Hide();
            // Dark blue 
            btnUpdateEmployee.ForeColor =
                BackColor =
                ColorPalette.DarkBlue;
            // Lighter blue 
            tbxEmpId.BackColor =
                tbxFirstName.BackColor =
                tbxLastName.BackColor =
                tbxAddress.BackColor =
                tbxPhoneNumber.BackColor =
                tbxCity.BackColor =
                cbxDepartment.BackColor =
                cbxGender.BackColor =
                dtpContractExpirationDate.BackColor =
                cbxEmployees.BackColor =
                ColorPalette.LighterBlue;
            // White 
            lblUpdateEmployeeInformation.ForeColor =
                lblFirstName.ForeColor =
                lblEmployeeId.ForeColor =
                lblLastName.ForeColor =
                lblAddress.ForeColor =
                lblPhoneNumber.ForeColor =
                lblDepartment.ForeColor =
                lblGender.ForeColor =
                lblCity.ForeColor =
                lblContractExpirationDate.ForeColor =
                ColorPalette.White;
            // Darker yellow 
            tbxEmpId.ForeColor =
                tbxFirstName.ForeColor =
                tbxLastName.ForeColor =
                tbxAddress.ForeColor =
                tbxPhoneNumber.ForeColor =
                tbxCity.ForeColor =
                cbxDepartment.ForeColor =
                cbxGender.ForeColor =
                dtpContractExpirationDate.ForeColor =
                cbxEmployees.ForeColor =
                ColorPalette.DarkerYellow;
            // Yellow 
            lblSelect.ForeColor =
                btnUpdateEmployee.Inactive1 =
                btnUpdateEmployee.Inactive2 =
                ColorPalette.Yellow;
            // Darker yellow 
            btnUpdateEmployee.Active1 =
                btnUpdateEmployee.Active2 =
                ColorPalette.DarkerYellow;
        }

        // Set Montserrat font to controls
        private void SetMontserratFont()
        {
            // Montserrat medium
            Fonts.SetPropertyFont(0, this, lblFirstName, lblEmployeeId,
                lblLastName, lblAddress, lblPhoneNumber,
                lblContractExpirationDate, lblSelect, cbxEmployees,
                tbxEmpId, tbxFirstName, tbxLastName, tbxAddress,
                tbxPhoneNumber, cbxDepartment, cbxGender,
                dtpContractExpirationDate, btnUpdateEmployee, lblCity, tbxCity,
                lblDepartment, lblAddress);
            // Montserrat semibold
            Fonts.SetPropertyFont(1, lblUpdateEmployeeInformation);
        }

        // Enable dark theme
        private void pictureBoxMoon_Click(object sender, EventArgs e)
        {
            _formTheme = ColorTheme.Dark;
            SetDarkTheme();
        }

        // Enable light theme
        private void pictureBoxSun_Click(object sender, EventArgs e)
        {
            _formTheme = ColorTheme.Light;
            SetLightTheme();
        }

        private void PopulateEmployeesComboBox()
        {
            cbxEmployees.Items.Clear();
            cbxEmployees.Items.AddRange(DatabaseController.GetEmployees().ToArray());
        }

        private void PopulateDepartmentsComboBox()
        {
            cbxDepartment.Items.Clear();
            cbxDepartment.Items.AddRange(DatabaseController.GetDepartments().ToArray());
        }

        private void cbxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee emp = DatabaseController.GetEmployee(((Employee)cbxEmployees.SelectedItem).Id);
            tbxEmpId.Text = emp.Id.ToString();
            tbxFirstName.Text = emp.FirstName;
            tbxLastName.Text = emp.LastName;
            tbxAddress.Text = emp.Address;
            tbxPhoneNumber.Text = emp.PhoneNumber;
            cbxDepartment.Text = DatabaseController.GetDepartment(emp.DepartmentId);
            cbxGender.Text = emp.Gender.ToString();
            dtpContractExpirationDate.Value = emp.ContractExpirationDate;
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (cbxEmployees.SelectedItem is object)
            {
                int empId = ((Employee)cbxEmployees.SelectedItem).Id;
                string firstName = tbxFirstName.Text;
                string lastName = tbxLastName.Text;
                string city = tbxCity.Text;
                string address = tbxAddress.Text;
                string phoneNumber = tbxPhoneNumber.Text;
                int departmentId = ((Department)cbxDepartment.SelectedItem).Id;
                string gender = cbxGender.Text;
                if (String.IsNullOrWhiteSpace(firstName) || String.IsNullOrWhiteSpace(lastName) ||
                    String.IsNullOrWhiteSpace(address) || String.IsNullOrWhiteSpace(phoneNumber) ||
                    String.IsNullOrWhiteSpace(gender))
                {
                    MessageBox.Show("No empty fields allowed!");
                    return;
                }
                DateTime contractExpirationDate = dtpContractExpirationDate.Value;
                if (contractExpirationDate < DateTime.Now)
                {
                    MessageBox.Show("Contract expiration date cannot be earlier than now.");
                    return;
                }
                bool updateSuccess = DatabaseController.UpdateEmployeeInformation(empId, firstName, lastName, city, address,
                    phoneNumber, departmentId, gender, contractExpirationDate);
                if (updateSuccess)
                {
                    MessageBox.Show("Info updated successfully.");
                    PopulateEmployeesComboBox();
                }
                else
                {
                    MessageBox.Show("Failed updating employee info.");
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
