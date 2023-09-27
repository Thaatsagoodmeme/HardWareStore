using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Database;
using Database.Model;

namespace MB_Accounting
{
    public partial class ProductsOverviewForm : Form
    {
        private ColorTheme _formTheme;
        private Employee _currentUser;
        private DepartmentManagerForm _previousForm;

        public ProductsOverviewForm(Employee currentUser, DepartmentManagerForm previousForm)
        {
            InitializeComponent();
            // Set color mode
            // Set font - Montserrat
            SetMontserratFont();
            _currentUser = currentUser;
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
            pictureBoxBackPink.Show();
            pictureBoxBackYellow.Hide();
            pictureBoxMoon.Show();
            pictureBoxSun.Hide();
            // White
            tbxProductName.BackColor =
                tbxManufacturer.BackColor =
                tbxPurchasePrice.BackColor =
                tbxSellingPrice.BackColor =
                tbxWeight.BackColor =
                tbxQuantity.BackColor =
                tbxHeight.BackColor =
                tbxWidth.BackColor =
                tbxDepth.BackColor =
                tbxStoreIsle.BackColor =
                tbxWarehouseIsle.BackColor =
                rtbxMessage.BackColor =
                BackColor =
                ColorPalette.White;
            // Pink
            tbxProductName.ForeColor =
                tbxManufacturer.ForeColor =
                tbxPurchasePrice.ForeColor =
                tbxSellingPrice.ForeColor =
                tbxWeight.ForeColor =
                tbxQuantity.ForeColor =
                tbxHeight.ForeColor =
                tbxWidth.ForeColor =
                tbxDepth.ForeColor =
                tbxStoreIsle.ForeColor =
                tbxWarehouseIsle.ForeColor =
                rtbxMessage.ForeColor =
                ColorPalette.Pink;
            // Dark grey
            lblHeading.ForeColor =
                lblDimensions.ForeColor = 
                lblLocation.ForeColor = 
                lblProductName.ForeColor =
                lblManufacturer.ForeColor =
                lblPurchasePrice.ForeColor =
                lblSellingPrice.ForeColor =
                lblWeight.ForeColor =
                lblQuantity.ForeColor =
                lblHeight.ForeColor =
                lblWidth.ForeColor =
                lblDepth.ForeColor =
                lblStoreIsle.ForeColor =
                lblWarehouseIsle.ForeColor =
                lblDescription.ForeColor =
                lbxProducts.ForeColor =
                ColorPalette.DarkGrey;
            // Light grey
            lbxProducts.BackColor =
                ColorPalette.LightGrey;
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
            // White
            lblHeading.ForeColor =
                lblDimensions.ForeColor=
                lblLocation.ForeColor =
                lblProductName.ForeColor =
                lblManufacturer.ForeColor =
                lblPurchasePrice.ForeColor =
                lblSellingPrice.ForeColor =
                lblWeight.ForeColor =
                lblQuantity.ForeColor =
                lblHeight.ForeColor =
                lblWidth.ForeColor =
                lblDepth.ForeColor =
                lblStoreIsle.ForeColor =
                lblWarehouseIsle.ForeColor =
                lblDescription.ForeColor =
                ColorPalette.White;
            // Lighter blue
            lbxProducts.BackColor =
                tbxProductName.BackColor =
                tbxManufacturer.BackColor =
                tbxPurchasePrice.BackColor =
                tbxSellingPrice.BackColor =
                tbxWeight.BackColor =
                tbxQuantity.BackColor =
                tbxHeight.BackColor =
                tbxWidth.BackColor =
                tbxDepth.BackColor =
                tbxStoreIsle.BackColor =
                tbxWarehouseIsle.BackColor =
                rtbxMessage.BackColor =
                ColorPalette.LighterBlue;
            // Darker yellow
            lbxProducts.ForeColor =
                 tbxProductName.ForeColor =
                tbxManufacturer.ForeColor =
                tbxPurchasePrice.ForeColor =
                tbxSellingPrice.ForeColor =
                tbxWeight.ForeColor =
                tbxQuantity.ForeColor =
                tbxHeight.ForeColor =
                tbxWidth.ForeColor =
                tbxDepth.ForeColor =
                tbxStoreIsle.ForeColor =
                tbxWarehouseIsle.ForeColor =
                rtbxMessage.ForeColor =
                ColorPalette.DarkerYellow;
        }

        // Set Montserrat font to controls
        private void SetMontserratFont()
        {
            // Montserrat medium
            Fonts.SetPropertyFont(0, this, lblProductName, lblManufacturer, lblPurchasePrice, lblSellingPrice, lblDimensions, lblLocation, 
                lblWeight, lblQuantity, lblHeight,lblWidth, lblDepth, lblStoreIsle, lblWarehouseIsle, lblDescription,
                tbxProductName, tbxManufacturer, tbxPurchasePrice, tbxSellingPrice, tbxWeight, tbxQuantity, tbxHeight, tbxWidth, tbxDepth, tbxStoreIsle, tbxWarehouseIsle, rtbxMessage);
            // Montserrat semibold
            Fonts.SetPropertyFont(1, lblHeading);
        }

        private void PopulateListBox()
        {
            lbxProducts.Items.Clear();
            List<Product> products = DatabaseController.GetProductsByDepartment(_currentUser.DepartmentId);
            if (products is null)
            {
                lbxProducts.Items.Add("There are no products in this department");
            }
            else
            {
               lbxProducts.Items.AddRange(products.ToArray());
            }
        }

        private void lbxProducts_SelectedValueChanged(object sender, EventArgs e)
        {
            Product p = (Product)lbxProducts.SelectedItem;
            tbxProductName.Text = p.Name;
            tbxManufacturer.Text = p.Manufacturer;
            tbxPurchasePrice.Text = p.PriceBought.ToString();
            tbxSellingPrice.Text = p.PriceSelling.ToString();
            tbxWeight.Text = p.Weight.ToString();
            tbxQuantity.Text = p.Quantity.ToString();
            tbxHeight.Text = p.Height.ToString();
            tbxWidth.Text = p.Width.ToString();
            tbxDepth.Text = p.Depth.ToString();
            tbxStoreIsle.Text = p.StoreIsle.ToString();
            tbxWarehouseIsle.Text = p.WarehouseIsle.ToString();
            rtbxMessage.Text = p.Description;
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
