using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using VPN;
using Database;
using Database.Model;
using Database.Model.Enum;


namespace MB_Accounting
{
    public partial class LoginForm : Form
    {
        private ColorTheme _formTheme;

        public LoginForm()
        {
            InitializeComponent();
            // Set default color mode
            _formTheme = ColorTheme.Light;
            SetLightTheme();
            // Set font - Montserrat
            SetMontserratMediumFont();
            // Input fields placeholder text
            tbxEmail.Text = "email@example.com";
            tbxPassword.Text = "password";
            InitializeVPNConnection();
        }

        private void SetLightTheme()
        {
            // Bottom right picture
            pictureBoxMoon.Show();
            pictureBoxSun.Hide();
            // MB Accounting logo in top middle
            pictureBoxMBAccounting.Show();
            pictureBoxMBAccountingYellow.Hide();
            // User picture in tbxEmail
            pictureBoxUser.Show();
            pictureBoxUserYellow.Hide();
            // Key picture in tbxPassword
            pictureBoxKey.Show();
            pictureBoxKeyYellow.Hide();
            // CVSK logo in bottom middle
            pictureBoxCVSK.Show();
            pictureBoxCVSKWhite.Hide();
            // Light grey elements
            panelLogin.BackColor =
                ColorPalette.LightGrey;
            // Pink elements
            btnLogin.ForeColor =
                lblValidation.ForeColor =
                ColorPalette.Pink;
            // Dark grey elements
            panelLoginBorder.BackColor =
                tbxEmail.ForeColor =
                tbxPassword.ForeColor =
                ColorPalette.DarkGrey;
            // White elements
            tbxEmail.BackColor =
            tbxPassword.BackColor =
            btnLogin.Inactive1 =
            btnLogin.Inactive2 =
            pictureBoxUser.BackColor =
            pictureBoxKey.BackColor =
            BackColor =
            ColorPalette.White;
            // Mild grey elements
            btnLogin.Active1 =
            btnLogin.Active2 =
                ColorPalette.MildGrey;
        }

        private void SetDarkTheme()
        {
            // Bottom right picture
            pictureBoxSun.Show();
            pictureBoxMoon.Hide();
            // MB Accounting logo in top middle
            pictureBoxMBAccountingYellow.Show();
            pictureBoxMBAccounting.Hide();
            // User picture in tbxEmail
            pictureBoxUserYellow.Show();
            pictureBoxUser.Hide();
            // Key picture in tbxPassword
            pictureBoxKeyYellow.Show();
            pictureBoxKey.Hide();
            // CVSK logo in bottom middle
            pictureBoxCVSKWhite.Show();
            pictureBoxCVSK.Hide();
            // Darker yellow 
            panelLogin.BackColor =
                ColorPalette.DarkerYellow;
            // Yellow 
            btnLogin.ForeColor =
                ColorPalette.Yellow;
            // Dark grey 
            panelLoginBorder.BackColor =
                ColorPalette.DarkGrey;
            // White 
            tbxEmail.ForeColor =
                tbxPassword.ForeColor =
                ColorPalette.White;
            // Dark blue 
            tbxPassword.BackColor =
                tbxEmail.BackColor =
                BackColor =
                pictureBoxKeyYellow.BackColor =
                pictureBoxUserYellow.BackColor =
                btnLogin.Inactive1 =
                btnLogin.Inactive2 =
                lblValidation.ForeColor =
                ColorPalette.DarkBlue;
            // Transparent
            lblValidation.BackColor = Color.Transparent;
            // Lighter blue
            btnLogin.Active1 =
            btnLogin.Active2 =
                ColorPalette.LighterBlue;
        }

        // Set Montserrat font to controls
        private void SetMontserratMediumFont()
        {
            // Montserrat medium
            Fonts.SetPropertyFont(0, this, tbxEmail, tbxPassword, btnLogin, lblConnection, lblValidation);
        }

        private async void InitializeVPNConnection()
        {
            try
            {
                lblConnection.ForeColor = Color.Orange;
                lblConnection.Text = "Status: Connecting...";
                bool success = VPNController.Instance.Disconnect();
                // Need a little bit of delay to display "Status: Connecting..."
                await Task.Delay(5);
                if (!success)
                {
                    lblConnection.ForeColor = Color.Crimson;
                    lblConnection.Text = "Status: Failed disconnecting. Check log file.";
                    return;
                }
                success = VPNController.Instance.Connect();
                if (success && VPNController.Instance.IsConnected())
                {
                    lblConnection.ForeColor = Color.LightGreen;
                    lblConnection.Text = "Status: Connected.";
                }
                else
                {
                    lblConnection.ForeColor = Color.Red;
                    lblConnection.Text = "Status: Disconnected.";
                }
            }
            catch (Exception ex)
            {
                lblConnection.ForeColor = Color.Crimson;
                lblConnection.Text = "Status: Failed connecting.";
                MessageBox.Show($"Failed connecting, please check log file for more information.\nError: {ex.Message}");
            }
        }

        // Enable dark theme
        private void pictureBoxMoon_Click(object sender, EventArgs e)
        {
            SetDarkTheme();
            _formTheme = ColorTheme.Dark;
        }

        // Enable light theme
        private void pictureBoxSun_Click(object sender, EventArgs e)
        {
            SetLightTheme();
            _formTheme = ColorTheme.Light;
        }

        // Remove placeholder when field is entered
        private void tbxEmail_Enter(object sender, EventArgs e)
        {
            tbxEmail.Text = String.Empty;
        }

        // Remove placeholder when field is entered
        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            tbxPassword.Text = String.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbxEmail.Text;
            string password = tbxPassword.Text;
            Employee employee = DatabaseController.GetEmployee(email);
            if (employee is object && employee.PasswordHash == password)
            {
                Form form = null;
                switch (employee.Position)
                {
                    case Position.Salesman:
                        form = new SalesmanForm(employee, _formTheme);
                        break;
                    case Position.Department_Manager:
                        form = new DepartmentManagerForm(employee, _formTheme);
                        break;
                    case Position.HR:
                        form = new HumanResourcesForm(employee, _formTheme);
                        break;
                    case Position.Warehouse:
                        form = new SystemAdministratorForm(employee, _formTheme);
                        break;
                    default:
                        lblValidation.Text = "Employee has no position assigned.";
                        return;
                }
                Hide();
                form.ShowDialog();
            }
            else
            {
                lblValidation.Text = "Invalid Credentials.Please try again.";
            }
        }

        private void pbxAntenna_Click(object sender, EventArgs e)
        {
            InitializeVPNConnection();
        }
    }
}
