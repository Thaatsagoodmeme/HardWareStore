using Database;
using Database.Model;
using System;
using System.Windows.Forms;

namespace MB_Accounting
{
    public partial class AddContractForm : Form
    {
        private Employee _currentUser;

        public AddContractForm(Employee currentUser, ColorTheme colorTheme)
        {
            InitializeComponent();
            _currentUser = currentUser;
            switch (colorTheme)
            {
                case ColorTheme.Light:
                    SetLightTheme();
                    break;
                case ColorTheme.Dark:
                    SetDarkTheme();
                    break;
            }
            SetMontserratFont();
        }

        private void SetLightTheme()
        {
            // White
            BackColor =
                nFte.BackColor =
                tbxSalary.BackColor =
                btnAdd.ForeColor =
                ColorPalette.White;
            // Dark grey
            lblFte.ForeColor =
                lblSalary.ForeColor =
                lblTitle.ForeColor =
                lblStartDate.ForeColor =
                lblExpires.ForeColor =
            ColorPalette.DarkGrey;
            // Pink
            tbxSalary.ForeColor =
                nFte.ForeColor =
                cbxTemporary.ForeColor =
                btnAdd.Inactive1 =
                btnAdd.Inactive2 =
                ColorPalette.Pink;
            // Darker pink
            btnAdd.Active1 =
                btnAdd.Active2 =
                ColorPalette.DarkerPink;
        }

        private void SetDarkTheme()
        {
            // White
            lblSalary.ForeColor =
                lblFte.ForeColor =
                lblStartDate.ForeColor =
                lblExpires.ForeColor =
                ColorPalette.White;
            // Yellow
            lblTitle.ForeColor =
                cbxTemporary.ForeColor =
                btnAdd.Inactive1 =
                btnAdd.Inactive2 =
                ColorPalette.Yellow;
            // Darker yellow
            btnAdd.Active1 =
                btnAdd.Active2 =
                tbxSalary.ForeColor = 
                nFte.ForeColor =
                ColorPalette.DarkerYellow;
            // Dark blue
            btnAdd.ForeColor =
                BackColor = 
                ColorPalette.DarkBlue;
            // Lighter blue
            tbxSalary.BackColor =
                nFte.BackColor =
                ColorPalette.LighterBlue;
        }

        // Set Montserrat font to controls
        private void SetMontserratFont()
        {
            Fonts.SetPropertyFont(0,
                this, lblFte, lblStartDate, lblExpires, lblSalary, cbxTemporary,
                nFte, dtpStartDate, dtpExpirationDate, tbxSalary, btnAdd);
            Fonts.SetPropertyFont(1, lblTitle);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double salary = double.Parse(tbxSalary.Text);
                if (salary >= 10000)
                {
                    MessageBox.Show("Salary value too high");
                    return;
                }
                double fte = double.Parse(nFte.Value.ToString());
                DateTime startDate = dtpStartDate.Value;
                DateTime expirationDate = dtpExpirationDate.Value;
                Contract c = new Contract
                {
                    StartDate = startDate,
                    ExpirationDate = expirationDate,
                    FTE = fte,
                    IsTemporary = cbxTemporary.Checked
                };
                _currentUser.ContractExpirationDate = c.ExpirationDate;
                _currentUser.Salary = salary;
                DatabaseController.AddContract(_currentUser.Id, salary, c);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxTemporary_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTemporary.Checked)
            {
                lblExpires.Visible = true;
                dtpExpirationDate.Visible = true;
            }
            else
            {
                lblExpires.Visible = false;
                dtpExpirationDate.Visible = false;
            }
        }
    }
}
