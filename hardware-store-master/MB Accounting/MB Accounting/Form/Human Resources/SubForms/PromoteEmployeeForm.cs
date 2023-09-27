using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Database;
using Database.Model;
using Database.Model.Enum;

namespace MB_Accounting
{
    public partial class PromoteEmployeeForm : Form
    {
        private ColorTheme _formTheme;
        private Employee _currentUser;
        private HumanResourcesForm _previousForm;

        public PromoteEmployeeForm(Employee currentUser, HumanResourcesForm previousForm)
        {
            InitializeComponent();
            dtpExpirationDate.Value = currentUser.ContractExpirationDate;
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
            PopulatePositionsComboBox();
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
            tbxSalary.BackColor =
                cbxPosition.BackColor =
                cbxEmployees.BackColor =
                btnPromote.ForeColor =
                BackColor =
                ColorPalette.White;
            // Dark grey 
            lblPromoteAnEmployee.ForeColor =
                lblPosition.ForeColor =
                lblSalary.ForeColor =
                lblFte.ForeColor =
                lblStartDate.ForeColor =
                lblExpires.ForeColor =
                cbxTemporary.ForeColor =
                lblTitle.ForeColor =
                ColorPalette.DarkGrey;
            // Pink 
            lblSelect.ForeColor =
                tbxSalary.ForeColor =
                nFte.ForeColor =
                cbxEmployees.ForeColor =
                cbxPosition.ForeColor =
                btnPromote.Inactive1 =
                btnPromote.Inactive2 =
                ColorPalette.Pink;
            // Darker pink 
            btnPromote.Active1 =
                btnPromote.Active2 =
                ColorPalette.DarkerPink;
        }

        private void SetDarkTheme()
        {
            pictureBoxSun.Show();
            pictureBoxMoon.Hide();
            pictureBoxBackYellow.Show();
            pictureBoxBackPink.Hide();
            // Dark blue  
            btnPromote.ForeColor =
                BackColor =
                ColorPalette.DarkBlue;
            // Lighter blue 
            tbxSalary.BackColor =
                cbxEmployees.BackColor =
                cbxPosition.BackColor =
                ColorPalette.LighterBlue;
            // White 
            lblPromoteAnEmployee.ForeColor =
                lblSalary.ForeColor =
                lblPosition.ForeColor =
                lblFte.ForeColor =
                lblStartDate.ForeColor =
                lblExpires.ForeColor =
                lblTitle.ForeColor =
                cbxTemporary.ForeColor =
                ColorPalette.White;
            // Darker yellow 
            cbxEmployees.ForeColor =
                cbxPosition.ForeColor =
                nFte.ForeColor =
                tbxSalary.ForeColor =
                ColorPalette.DarkerYellow;
            // Yellow 
            lblSelect.ForeColor =
                btnPromote.Inactive1 =
                btnPromote.Inactive2 =
                ColorPalette.Yellow;
            // Darker yellow elements
            btnPromote.Active1 =
                btnPromote.Active2 =
                ColorPalette.DarkerYellow;
        }

        // Set Montserrat font to controls
        private void SetMontserratFont()
        {
            // Montserrat medium
            Fonts.SetPropertyFont(0, this, lblSelect, lblPosition,
                lblSalary, tbxSalary, cbxEmployees,
                cbxPosition, btnPromote, lblTitle, lblFte, nFte,
                lblStartDate, dtpStartDate, lblExpires, dtpExpirationDate,
                cbxTemporary);
            // Montserrat semibold
            Fonts.SetPropertyFont(1, lblPromoteAnEmployee);
        }

        private void PopulatePositionsComboBox()
        {
            cbxPosition.Items.Clear();
            foreach (var position in Enum.GetValues(typeof(Position)).Cast<Position>())
            {
                cbxPosition.Items.Add(position.ToString());
            }
        }

        private void PopulateEmployeesComboBox()
        {
            cbxEmployees.Items.Clear();
            cbxEmployees.Items.AddRange(DatabaseController.GetEmployees().ToArray());
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

        private void pictureBoxBackPink_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void pictureBoxBackYellow_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void cbxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            int employeeId = ((Employee)cbxEmployees.SelectedItem).Id;
            Employee employee = DatabaseController.GetEmployee(employeeId);
            if (employee is null)
            {
                MessageBox.Show($"No employee with id{employeeId} found.");
                return;
            }
            tbxSalary.Text = employee.Salary.ToString();
            cbxPosition.Text = employee.Position.ToString();
        }

        private void btnPromote_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxEmployees.SelectedItem is object)
                {
                    bool enumSuccess = Enum.TryParse(cbxPosition.Text, out Position position);
                    if (!enumSuccess)
                    {
                        MessageBox.Show("Position is invalid.");
                        return;
                    }
                    int employeeId = ((Employee)cbxEmployees.SelectedItem).Id;
                    double updatedSalary = double.Parse(tbxSalary.Text);
                    double fte = double.Parse(nFte.Value.ToString());
                    DateTime startDate = dtpStartDate.Value;
                    DateTime expirationDate = dtpExpirationDate.Value;
                    if (updatedSalary < 0)
                    {
                        MessageBox.Show("Salary cannot be negative.");
                        return;
                    }
                    Contract c = new Contract { FTE = fte, IsTemporary = cbxTemporary.Checked, StartDate = startDate, ExpirationDate = expirationDate };
                    Employee emp = DatabaseController.GetEmployee(employeeId);
                    emp.AddContract(c);
                    bool success = DatabaseController.PromoteEmployee(employeeId, updatedSalary, position, c);
                    if (success)
                    {
                        MessageBox.Show("Employee promoted successfully.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select employee first.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GoBack()
        {
            _previousForm.Show();
            Close();
        }

        private void cbxTemporary_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxTemporary.Checked)
            {
                lblExpires.Visible = false;
                dtpExpirationDate.Visible = false;
            }
            else
            {
                lblExpires.Visible = true;
                dtpExpirationDate.Visible = true;
            }
        }
    }
}
