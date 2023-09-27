using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;
using Database.Model;

namespace MB_Accounting
{
    public partial class CreateDepartmentForm : Form
    {
        private ColorTheme _formTheme;
        private Employee _currentUser;
        private HumanResourcesForm _previousForm;

        public CreateDepartmentForm(Employee currentUser, HumanResourcesForm previousForm)
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
            ShowDepartments();
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

            /* Departments tab */
            // White 
            this.BackColor =
                tbxDepartmentName.BackColor =
                btnCreateDepartment.ForeColor =
                btnDeleteDepartment.ForeColor =
                ColorPalette.White;
            // Pink    
            btnCreateDepartment.Inactive1 =
            btnCreateDepartment.Inactive2 =
            btnDeleteDepartment.Inactive1 =
            btnDeleteDepartment.Inactive2 =
            lblDepartmentName.ForeColor =
            tbxDepartmentName.ForeColor =
            ColorPalette.Pink;
            // Darker pink 
            btnCreateDepartment.Active1 =
                btnCreateDepartment.Active2 =
                btnDeleteDepartment.Active1 =
                btnDeleteDepartment.Active2 =
                ColorPalette.DarkerPink;
            // Dark grey 
            lblDepartmentsTabHeading.ForeColor =
                lbxShowCreatedDepartments.ForeColor =
                ColorPalette.DarkGrey;
            // Light grey 
            lbxShowCreatedDepartments.BackColor =
                ColorPalette.LightGrey;
        }

        private void SetDarkTheme()
        {
            pictureBoxSun.Show();
            pictureBoxMoon.Hide();
            pictureBoxBackYellow.Show();
            pictureBoxBackPink.Hide();
            /* Departments tab */
            // Dark blue 
            this.BackColor =
                btnCreateDepartment.ForeColor =
                btnDeleteDepartment.ForeColor =
                ColorPalette.DarkBlue;
            // Lighter yblue 
            tbxDepartmentName.BackColor =
                lbxShowCreatedDepartments.BackColor =
                ColorPalette.LighterBlue;
            // White 
            lblDepartmentsTabHeading.ForeColor =
                ColorPalette.White;
            // Yellow 
            lblDepartmentName.ForeColor =
                btnCreateDepartment.Inactive1 =
                btnCreateDepartment.Inactive2 =
                btnDeleteDepartment.Inactive1 =
                btnDeleteDepartment.Inactive2 =
                ColorPalette.Yellow;
            // Darker yellow 
            btnCreateDepartment.Active1 =
                btnCreateDepartment.Active2 =
                btnDeleteDepartment.Active1 =
                btnDeleteDepartment.Active2 =
                tbxDepartmentName.ForeColor =
                lbxShowCreatedDepartments.ForeColor =
                ColorPalette.DarkerYellow;
        }

        // Set Montserrat font to controls
        private void SetMontserratFont()
        {
            Fonts.SetPropertyFont(0,
                lblDepartmentName, tbxDepartmentName,
                btnCreateDepartment, btnDeleteDepartment,
                lbxShowCreatedDepartments);
            Fonts.SetPropertyFont(1, lblDepartmentsTabHeading);
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

        private void ShowDepartments()
        {
            List<Department> departments = DatabaseController.GetDepartments();
            lbxShowCreatedDepartments.Items.Clear();
            lbxShowCreatedDepartments.Items.AddRange(departments.ToArray());

        }

        private void btnCreateDepartment_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbxDepartmentName.Text))
            {
                MessageBox.Show("Department name cannot be empty.");
                return;
            }
            else if (DatabaseController.GetDepartmentId(tbxDepartmentName.Text) != -1)
            {
                MessageBox.Show($"Department {tbxDepartmentName.Text} already exists.");
                return;
            }
            bool success = DatabaseController.CreateDepartment(tbxDepartmentName.Text);
            if (success)
            {
                MessageBox.Show($"Department {tbxDepartmentName.Text} created successfully.");
            }
            else
            {
                MessageBox.Show($"Failed to create department {tbxDepartmentName.Text}.");
            }
            ShowDepartments();
        }

        private void btnDeleteDepartment_Click(object sender, EventArgs e)
        {
            if (lbxShowCreatedDepartments.SelectedItem is null)
            {
                MessageBox.Show("Please select a department first");
                return;
            }
            string departmentName = ((Department)lbxShowCreatedDepartments.SelectedItem).Name;
            int departmentId = DatabaseController.GetDepartmentId(departmentName);
            if (departmentId == -1)
            {
                MessageBox.Show($"Department {departmentName} does not exist.");
                return;
            }
            bool replaceSuccess = DatabaseController.ReplaceEmployeesDepartment(DatabaseController.GetDepartmentId(departmentName),
                DatabaseController.GetDepartmentId("none"));
            if (!replaceSuccess)
            {
                MessageBox.Show($"Could not replace employees department to 'none.'");
                return;
            }
            bool deleteSuccess = DatabaseController.DeleteStockRequestsByDepartment(departmentId);
            if (!deleteSuccess)
            {
                MessageBox.Show($"Could not delete stock requests for department {departmentName}");
                return;
            }
            deleteSuccess = DatabaseController.DeleteProductsByDepartment(departmentId);
            if (!deleteSuccess)
            {
                MessageBox.Show($"Could not delete products from department {departmentName}");
                return;
            }
            bool success = DatabaseController.DeleteDepartment(departmentName);
            if (success)
            {
                ShowDepartments();
                MessageBox.Show($"Department {departmentName} deleted successfully.");
            }
            else
            {
                MessageBox.Show($"Failed to delete department {departmentName}.");
            }
        }
    }
}
