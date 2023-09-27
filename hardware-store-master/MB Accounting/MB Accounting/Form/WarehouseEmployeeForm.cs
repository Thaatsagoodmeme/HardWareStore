using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Database;
using Database.Model;
using Database.Model.Enum;

namespace MB_Accounting
{
    public partial class SystemAdministratorForm : Form
    {
        private ColorTheme _formTheme;
        private Employee _currentUser;

        public SystemAdministratorForm(Employee currentUser, ColorTheme previousformTheme)
        {
            InitializeComponent();
            LoadYellowImages();
            // Set font - Montserrat
            SetMontserratFont();
            _currentUser = currentUser;
            // Set color mode
            _formTheme = previousformTheme;
            switch (_formTheme)
            {
                case ColorTheme.Light:
                    SetLightTheme();
                    tabControlMenu.ColorTheme = _formTheme;
                    tabControlMenu.ImageList = imageListMenu;
                    break;
                case ColorTheme.Dark:
                    tabControlMenu.ColorTheme = _formTheme;
                    tabControlMenu.ImageList = imageListMenuYellow;
                    SetDarkTheme();
                    break;
            }
            PopulateRelationshipComboBox();
            lblEmployeeName.Text = $"{_currentUser.FirstName} {_currentUser.LastName}";
            tbxAddressSettings.Text = _currentUser.Address;
            tbxEmailSettings.Text = _currentUser.Email;
            tbxPhoneNumberSettings.Text = _currentUser.PhoneNumber;
            if (cbxDepartment.Items.Count != 0)
            {
                cbxDepartment.SelectedIndex = 0;
            }
            cbxDepartment.Items.AddRange(DatabaseController.GetDepartments().ToArray());
            LoadProducts();
        }

        private void LoadYellowImages()
        {
            imageListMenuYellow.Images.Add(Properties.Resources.department_yellow);
            imageListMenuYellow.Images.SetKeyName(0, "department_yellow");
            imageListMenuYellow.Images.Add(Properties.Resources.boxes_yellow);
            imageListMenuYellow.Images.SetKeyName(1, "boxes_yellow");
            imageListMenuYellow.Images.Add(Properties.Resources.settings_yellow);
            imageListMenuYellow.Images.SetKeyName(2, "settings_yellow");
            imageListMenuYellow.Images.Add(Properties.Resources.MB_Accounting_Logo_Yellow);
            imageListMenuYellow.Images.SetKeyName(3, "MB_Accounting_Logo_Yellow");
        }

        private void SetLightTheme()
        {
            /* Main tab */
            // White 
            panelMainTabBackground.BackColor =
                ColorPalette.White;
            // Dark grey 
            lblGreetings.ForeColor =
                ColorPalette.DarkGrey;
            // Pink 
            lblEmployeeName.ForeColor =
                ColorPalette.Pink;

            /* Departments tab */
            // White 
            tbxProductNameShow.BackColor =
                tbxSellingPriceShow.BackColor =
                tbxDepartmentShow.BackColor =
                tbxWarehouseIsleShow.BackColor =
                //tbxAddress.BackColor =
                cbxProducts.BackColor =
                panelDepartmentsTabBackground.BackColor =
                ColorPalette.White;
            // Pink 
            lblSelectProduct.ForeColor =
                tbxProductNameShow.ForeColor =
                tbxSellingPriceShow.ForeColor =
                tbxDepartmentShow.ForeColor =
                tbxWarehouseIsleShow.ForeColor =
                //tbxAddress.ForeColor =
                cbxProducts.ForeColor =
                ColorPalette.Pink;
            // Dark grey 
            lblProductInformation.ForeColor =
                lblProductNameShow.ForeColor =
                lblSellingPriceShow.ForeColor =
                lblDepartmentShow.ForeColor =
                lblWarehouseLocationStore.ForeColor =
                lblProductsWithSameDepartment.ForeColor =
                lblDepartment.ForeColor =
                ColorPalette.DarkGrey;

            /* Products tab */
            // White 
            panelStockTabBackground.BackColor =
                tbxProductName.BackColor =
                tbxPurchasePrice.BackColor =
                tbxManufacturer.BackColor =
                tbxSellingPrice.BackColor =
                tbxWeight.BackColor =
                tbxHeight.BackColor =
                tbxWidth.BackColor =
                tbxDepth.BackColor =
                tbxStoreIsle.BackColor =
                tbxWarehouseIsle.BackColor =
                rtbxMessage.BackColor =
                cbxDepartment.BackColor =
                btnCreateProduct.ForeColor =
                btnDeleteProduct.ForeColor =
                ColorPalette.White;
            // Pink 
            btnCreateProduct.Inactive1 =
                btnCreateProduct.Inactive2 =
                btnDeleteProduct.Inactive1 =
                btnDeleteProduct.Inactive2 =
                lblProductName.ForeColor =
                tbxProductName.ForeColor =
                lblManufacturer.ForeColor =
                tbxManufacturer.ForeColor =
                lblSellingPrice.ForeColor =
                tbxSellingPrice.ForeColor =
                lblWeight.ForeColor =
                tbxWeight.ForeColor =
                lblHeight.ForeColor =
                tbxHeight.ForeColor =
                lblWidth.ForeColor =
                tbxWidth.ForeColor =
                lblDepth.ForeColor =
                tbxDepth.ForeColor =
                lblStoreIsle.ForeColor =
                tbxStoreIsle.ForeColor =
                lblWarehouseIsle.ForeColor =
                tbxWarehouseIsle.ForeColor =
                lblDimensions.ForeColor =
                lblLocation.ForeColor =
                lblDescription.ForeColor =
                rtbxMessage.ForeColor =
                lblPrice.ForeColor =
                lblDepartment.ForeColor =
                tbxPurchasePrice.ForeColor =
                cbxDepartment.ForeColor =
                ColorPalette.Pink;
            // Darker pink 
            btnCreateProduct.Active1 =
                btnCreateProduct.Active2 =
                btnDeleteProduct.Active1 =
                btnDeleteProduct.Active2 =
                ColorPalette.DarkerPink;
            // Dark grey 
            lblProductTabHeading.ForeColor =
                lbxShowAllStocksOfDepartment.ForeColor =
                ColorPalette.DarkGrey;
            // Light grey 
            lbxShowAllStocksOfDepartment.BackColor =
                ColorPalette.LightGrey;

            /* Settings tab */
            // White 
            panelSettingsTabBackground.BackColor =
                tbxPhoneNumberSettings.BackColor =
                tbxEmailSettings.BackColor =
                tbxConfirmPasswordSettings.BackColor =
                tbxNewPasswordSettings.BackColor =
                tbxCurrentPasswordSettings.BackColor =
                tbxAddressSettings.BackColor =
                btnSaveInfo.ForeColor =
                btnSavePassword.ForeColor =
                rbSaveEc.ForeColor =
                tbxECNameSettings.BackColor =
                tbxECInfoSettings.BackColor =
                cbxRelationship.BackColor =
                ColorPalette.White;
            // Dark grey 
            tabPageSettings.ForeColor =
                lblSettingsTabHeading.ForeColor =
                lblAddressSettings.ForeColor =
                lblPhoneNumberSettings.ForeColor =
                lblEmailSettings.ForeColor =
                lblConfirmPassword.ForeColor =
                lblCurrentPassword.ForeColor =
                lblNewPassword.ForeColor =
                lblECInfoSettings.ForeColor =
                lblECNameSettings.ForeColor =
                ColorPalette.DarkGrey;
            // Pink 
            tbxAddressSettings.ForeColor =
                lblPassword.ForeColor =
                lblPersonalInfo.ForeColor =
                tbxPhoneNumberSettings.ForeColor =
                tbxEmailSettings.ForeColor =
                tbxCurrentPasswordSettings.ForeColor =
                tbxNewPasswordSettings.ForeColor =
                tbxConfirmPasswordSettings.ForeColor =
                btnSaveInfo.Inactive1 =
                btnSaveInfo.Inactive2 =
                btnSavePassword.Inactive2 =
                btnSavePassword.Inactive1 =
                lblECSettings.ForeColor =
                rbSaveEc.Inactive1 =
                rbSaveEc.Inactive2 =
                tbxECInfoSettings.ForeColor =
                tbxECNameSettings.ForeColor =
                cbxRelationship.ForeColor =
                ColorPalette.Pink;
            // Darker pink 
            btnSavePassword.Active1 =
                btnSavePassword.Active2 =
                btnSaveInfo.Active1 =
                btnSaveInfo.Active2 =
                rbSaveEc.Active1 =
                rbSaveEc.Active2 =
                ColorPalette.DarkerPink;
        }

        private void SetDarkTheme()
        {
            /* Main tab */
            // Dark blue 
            panelMainTabBackground.BackColor =
                ColorPalette.DarkBlue;
            // White 
            lblGreetings.ForeColor =
                ColorPalette.White;
            // Yellow 
            lblEmployeeName.ForeColor =
                ColorPalette.Yellow;

            /* Departments tab */
            // Dark blue 
            panelDepartmentsTabBackground.BackColor =
                ColorPalette.DarkBlue;
            // White 
            lblProductInformation.ForeColor =
                lblProductNameShow.ForeColor =
                lblSellingPriceShow.ForeColor =
                lblDepartmentShow.ForeColor =
                lblWarehouseLocationStore.ForeColor =
                //lblDescriptionShow.ForeColor =
                lblProductsWithSameDepartment.ForeColor =
                lblRelationship.ForeColor =
                ColorPalette.White;
            // Darker yellow 
            tbxProductNameShow.ForeColor =
                tbxSellingPriceShow.ForeColor =
                tbxDepartmentShow.ForeColor =
                tbxWarehouseIsleShow.ForeColor =
                cbxRelationship.ForeColor =
                //tbxAddress.ForeColor =
                cbxProducts.ForeColor =
                ColorPalette.DarkerYellow;
            // Lighter blue elements
            tbxProductNameShow.BackColor =
                tbxSellingPriceShow.BackColor =
                tbxDepartmentShow.BackColor =
                tbxWarehouseIsleShow.BackColor =
                cbxRelationship.BackColor =
                //tbxAddress.BackColor =
                cbxProducts.BackColor =
                ColorPalette.LighterBlue;
            // Yellow elements
            lblSelectProduct.ForeColor =
                ColorPalette.Yellow;

            /* Product tab */
            // Dark blue 
            panelStockTabBackground.BackColor =
                btnCreateProduct.ForeColor =
                btnDeleteProduct.ForeColor =
                tbxProductName.ForeColor =
                ColorPalette.DarkBlue;
            // Lighter blue 
            tbxProductName.BackColor =
                tbxPurchasePrice.BackColor =
                tbxManufacturer.BackColor =
                tbxSellingPrice.BackColor =
                tbxWeight.BackColor =
                tbxHeight.BackColor =
                tbxWidth.BackColor =
                tbxDepth.BackColor =
                tbxStoreIsle.BackColor =
                tbxWarehouseIsle.BackColor =
                rtbxMessage.BackColor =
                cbxDepartment.BackColor =
                lbxShowAllStocksOfDepartment.BackColor =
                ColorPalette.LighterBlue;
            // White 
            lblProductTabHeading.ForeColor =
                ColorPalette.White;
            // Yellow 
            lblProductName.ForeColor =
                btnCreateProduct.Inactive1 =
                btnCreateProduct.Inactive2 =
                btnDeleteProduct.Inactive1 =
                btnDeleteProduct.Inactive2 =
                lblPrice.ForeColor =
                lblDepartment.ForeColor =
                lblManufacturer.ForeColor =
                lblSellingPrice.ForeColor =
                lblWeight.ForeColor =
                lblHeight.ForeColor =
                lblWidth.ForeColor =
                lblDepth.ForeColor =
                lblStoreIsle.ForeColor =
                lblWarehouseIsle.ForeColor =
                lblDimensions.ForeColor =
                lblLocation.ForeColor =
                lblDescription.ForeColor =
                ColorPalette.Yellow;
            // Darker yellow 
            btnCreateProduct.Active1 =
                btnCreateProduct.Active2 =
                btnDeleteProduct.Active1 =
                btnDeleteProduct.Active2 =
                tbxPurchasePrice.ForeColor =
                cbxDepartment.ForeColor =
                tbxProductName.ForeColor =
                tbxManufacturer.ForeColor =
                tbxSellingPrice.ForeColor =
                tbxWeight.ForeColor =
                tbxHeight.ForeColor =
                tbxWidth.ForeColor =
                tbxDepth.ForeColor =
                tbxStoreIsle.ForeColor =
                tbxWarehouseIsle.ForeColor =
                rtbxMessage.ForeColor =
                lbxShowAllStocksOfDepartment.ForeColor =
                ColorPalette.DarkerYellow;

            /* Settings tab */
            // White 
            tabPageSettings.ForeColor =
                lblSettingsTabHeading.ForeColor =
                lblAddressSettings.ForeColor =
                lblPhoneNumberSettings.ForeColor =
                lblEmailSettings.ForeColor =
                lblConfirmPassword.ForeColor =
                lblCurrentPassword.ForeColor =
                lblNewPassword.ForeColor =
                lblECNameSettings.ForeColor =
                lblECInfoSettings.ForeColor =
                ColorPalette.White;
            // Dark blue 
            panelSettingsTabBackground.BackColor =
                btnSaveInfo.ForeColor =
                btnSavePassword.ForeColor =
                rbSaveEc.ForeColor =
                ColorPalette.DarkBlue;
            // Lighter blue
            tbxAddressSettings.BackColor =
                tbxPhoneNumberSettings.BackColor =
                tbxEmailSettings.BackColor =
                tbxCurrentPasswordSettings.BackColor =
                tbxNewPasswordSettings.BackColor =
                tbxConfirmPasswordSettings.BackColor =
                tbxECNameSettings.BackColor =
                tbxECInfoSettings.BackColor =
                ColorPalette.LighterBlue;
            // Yellow 
            lblPersonalInfo.ForeColor =
                lblPassword.ForeColor =
                btnSaveInfo.Inactive1 =
                btnSaveInfo.Inactive2 =
                btnSavePassword.Inactive2 =
                btnSavePassword.Inactive1 =
                rbSaveEc.Inactive1 =
                rbSaveEc.Inactive2 =
                lblECSettings.ForeColor =
                ColorPalette.Yellow;
            // Darker yellow 
            btnSavePassword.Active1 =
                btnSavePassword.Active2 =
                btnSaveInfo.Active1 =
                btnSaveInfo.Active2 =
                rbSaveEc.Active1 =
                rbSaveEc.Active2 =
                tbxAddressSettings.ForeColor =
                tbxPhoneNumberSettings.ForeColor =
                tbxEmailSettings.ForeColor =
                tbxCurrentPasswordSettings.ForeColor =
                tbxNewPasswordSettings.ForeColor =
                tbxConfirmPasswordSettings.ForeColor =
                tbxECInfoSettings.ForeColor =
                tbxECNameSettings.ForeColor =
                ColorPalette.DarkerYellow;
        }

        // Set Montserrat font to controls
        private void SetMontserratFont()
        {
            // Global
            Fonts.SetPropertyFont(0, this, tabControlMenu);
            // Main tab
            Fonts.SetPropertyFont(0, lblGreetings);
            Fonts.SetPropertyFont(1, lblEmployeeName);
            // Departments tab
            Fonts.SetPropertyFont(0, this, lblSelectProduct, lblProductNameShow,
                lblSellingPriceShow, lblDepartmentShow, lblWarehouseLocationStore,
                lblProductsWithSameDepartment, lblDepartment, cbxProducts, tbxProductNameShow,
                tbxSellingPriceShow, tbxWarehouseIsleShow, tbxDepartmentShow);
            Fonts.SetPropertyFont(1, lblProductInformation);
            // Stock tab
            Fonts.SetPropertyFont(0, tabPageStock,
                lblProductName, tbxProductName,
                btnCreateProduct, btnDeleteProduct,
                lblPrice, lblDepartment,
                tbxPurchasePrice, cbxDepartment,
                lbxShowAllStocksOfDepartment, lblManufacturer, lblSellingPrice,
                lblWeight, lblDescription, lblDimensions, lblHeight, lblWidth, lblDepth,
                lblStoreIsle, lblWarehouseIsle, lblLocation, tbxManufacturer, tbxSellingPrice,
                tbxWeight, rtbxMessage, tbxHeight, tbxWidth, tbxDepth, tbxStoreIsle, tbxWarehouseIsle);
            Fonts.SetPropertyFont(1, lblProductTabHeading);
            // Settings tab
            Fonts.SetPropertyFont(0, tabPageSettings,
                tbxEmailSettings, tbxAddressSettings,
                tbxPhoneNumberSettings, tbxCurrentPasswordSettings,
                tbxConfirmPasswordSettings, tbxNewPasswordSettings,
                btnSaveInfo, btnSavePassword, lblPersonalInfo,
                lblPassword, lblEmailSettings,
                lblAddressSettings, lblPhoneNumberSettings,
                lblCurrentPassword, lblNewPassword,
                lblConfirmPassword, lblECSettings, lblECNameSettings,
                lblECInfoSettings, tbxECInfoSettings, tbxECNameSettings,
                rbSaveEc);
            Fonts.SetPropertyFont(1, lblSettingsTabHeading);
        }
        private void PopulateRelationshipComboBox()
        {
            foreach (var relationshipType in Enum.GetValues(typeof(RelationshipType)))
            {
                cbxRelationship.Items.Add(relationshipType);
            }
        }
        // Enable light/dark theme
        private void tabControlMenu_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPageColorTheme)
            {
                tabControlMenu.SelectedIndex = 0;
                if (_formTheme == ColorTheme.Light)
                {
                    _formTheme = ColorTheme.Dark;
                    tabControlMenu.ColorTheme = _formTheme;
                    tabControlMenu.ImageList = imageListMenuYellow;
                    SetDarkTheme();
                }
                else
                {
                    _formTheme = ColorTheme.Light;
                    tabControlMenu.ColorTheme = _formTheme;
                    tabControlMenu.ImageList = imageListMenu;
                    SetLightTheme();
                }
            }
            // Refresh tab control
            tabControlMenu.Invalidate();
        }

        private void btnCreateStock_Click(object sender, EventArgs e)
        {
            double productBoughtPrice, productSellingPrice, weight = 0, height = 0, width = 0, depth = 0;
            int storeIsle = 0, warehouseIsle = 0;
            bool correctDimensions = true, correctIsles = true;
            string productName = tbxProductName.Text;
            if (String.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("Product name cannot be empty.");
                return;
            }
            string productManufacturer = tbxManufacturer.Text;
            if (String.IsNullOrWhiteSpace(productManufacturer))
            {
                MessageBox.Show("Manufacturer cannot be empty.");
                return;
            }
            bool success = double.TryParse(tbxPurchasePrice.Text, out productBoughtPrice);
            if (!success)
            {
                MessageBox.Show("Invalid product bought price.");
                return;
            }
            success = double.TryParse(tbxSellingPrice.Text, out productSellingPrice);
            if (!success)
            {
                MessageBox.Show("Invalid product selling price.");
                return;
            }
            try
            {
                weight = Convert.ToDouble(tbxWeight.Text);
            }
            catch (FormatException)
            {
                correctDimensions = false;
            }

            if (!correctDimensions || weight <= 0)
            {
                MessageBox.Show("Invalid product weight.");
                return;
            }

            try
            {
                height = Convert.ToDouble(tbxHeight.Text);
                width = Convert.ToDouble(tbxWidth.Text);
                depth = Convert.ToDouble(tbxDepth.Text);
            }
            catch (FormatException)
            {
                correctDimensions = false;
            }

            if (!correctDimensions || height <= 0 || width <= 0 || depth <= 0)
            {
                MessageBox.Show("Invalid dimensions");
                return;
            }

            try
            {
                storeIsle = Convert.ToInt32(tbxStoreIsle.Text);
                warehouseIsle = Convert.ToInt32(tbxWarehouseIsle.Text);
            }
            catch (FormatException)
            {
                correctIsles = false;
            }

            if (!correctIsles || storeIsle <= 0 || warehouseIsle <= 0)
            {
                MessageBox.Show("Invalid locations");
                return;
            }

            if (cbxDepartment.SelectedItem is null)
            {
                MessageBox.Show("Please select a valid deparment");
                return;
            }
            int productDepartmentId = ((Department)cbxDepartment.SelectedItem).Id;
            if (DatabaseController.CheckIfProductExists(productName, productDepartmentId))
            {
                MessageBox.Show($"Product {productName} already exists in this department.");
                return;
            }

            string description = rtbxMessage.Text;
            bool createSuccess = DatabaseController.CreateProduct(productName, productManufacturer, productBoughtPrice,
                productSellingPrice, weight, height, width, depth, productDepartmentId, storeIsle, warehouseIsle, description);

            if (createSuccess)
            {
                MessageBox.Show($"Product {productName} created successfully.");
            }
            else
            {
                MessageBox.Show($"Failed to create product{productName}.");
            }
            LoadProducts();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            bool success = true;
            Product productLisbox = (Product)lbxShowAllStocksOfDepartment.SelectedItem;
            Product productCombobox = ((Product)cbxProducts.SelectedItem);
            if (productLisbox != null)
            {
                success = DatabaseController.DeleteProduct(productLisbox.Id);

            }
            else
            {
                if (productCombobox == null)
                {
                    MessageBox.Show("No product found.");
                    return;
                }
                productLisbox = productCombobox;
                success = DatabaseController.DeleteProduct(productCombobox.Id);
            }

            if (success)
            {
                MessageBox.Show($"Product {productLisbox.Name} deleted successfully.");
                LoadProducts();
            }
            else
            {
                MessageBox.Show($"Failed to delete product {productLisbox.Name}.");
            }
            ClearProductBoxes();

        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            string newAddress = tbxAddressSettings.Text;
            string newEmail = tbxEmailSettings.Text;
            string newPhoneNumber = tbxPhoneNumberSettings.Text;
            if (String.IsNullOrWhiteSpace(newAddress) || String.IsNullOrWhiteSpace(newEmail) ||
                String.IsNullOrWhiteSpace(newPhoneNumber))
            {
                MessageBox.Show("Fields cannot be empty.");
                return;
            }
            bool isEmailValid = DatabaseController.IsEmailValid(newEmail);
            if (!isEmailValid)
            {
                MessageBox.Show("Invalid email.");
                return;
            }
            bool success = DatabaseController.UpdateEmployeePersonalInfo(_currentUser.Id, newAddress, newPhoneNumber, newEmail);
            if (success)
            {
                MessageBox.Show("Personal info updated successfully.");
            }
            else
            {
                MessageBox.Show("Failed updating personal info.");
            }
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            string currentPassword = tbxCurrentPasswordSettings.Text;
            string newPassword = tbxNewPasswordSettings.Text;
            string confirmPassword = tbxConfirmPasswordSettings.Text;
            if (String.IsNullOrWhiteSpace(currentPassword) || String.IsNullOrWhiteSpace(newPassword) ||
                String.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Fields cannot be empty.");
                return;
            }
            if (currentPassword == _currentUser.PasswordHash)
            {
                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match.");
                }
                else if (String.IsNullOrWhiteSpace(newPassword))
                {
                    MessageBox.Show("Password cannot be empty.");
                }
                else if (newPassword.Length < 6)
                {
                    MessageBox.Show("Password should be at least 6 characters long.");
                }
                else if (newPassword == currentPassword)
                {
                    MessageBox.Show("New password cannot be same as old password.");
                }
                else
                {
                    DatabaseController.UpdateEmployeePassword(_currentUser.Id, newPassword);
                    MessageBox.Show("Password updated successfully.");
                }
            }
            else
            {
                MessageBox.Show("Invalid current password.");
            }
        }

        private void SystemAdministratorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int productId = ((Product)cbxProducts.SelectedItem).Id;
            if (productId == -1)
            {
                MessageBox.Show("No product found.");
                return;
            }

            Product currentProduct = DatabaseController.GetProduct(productId);
            int departmentId = currentProduct.DepartmentId;
            tbxProductNameShow.Text = currentProduct.Name;
            tbxSellingPriceShow.Text = currentProduct.PriceSelling.ToString();
            tbxDepartmentShow.Text = DatabaseController.GetDepartment(departmentId);
            tbxWarehouseIsleShow.Text = currentProduct.StoreIsle.ToString();
            lbxShowAllStocksOfDepartment.Items.Clear();
            foreach (Product product in DatabaseController.GetProductsByDepartment(departmentId).ToArray())
            {
                if (product.Id != currentProduct.Id)
                {
                    lbxShowAllStocksOfDepartment.Items.Add(product);
                }
            }

        }

        public void ClearProductBoxes()
        {
            cbxProducts.Text = String.Empty;
            tbxProductNameShow.Text = String.Empty;
            tbxSellingPriceShow.Text = String.Empty;
            tbxDepartmentShow.Text = String.Empty;
            tbxWarehouseIsleShow.Text = String.Empty;
            lbxShowAllStocksOfDepartment.Items.Clear();
        }

        public void LoadProducts()
        {
            cbxProducts.Items.Clear();
            cbxProducts.Items.AddRange(DatabaseController.GetProducts().ToArray());
        }

        private void rbSaveEc_Click(object sender, EventArgs e)
        {
            string newECname = tbxECNameSettings.Text;
            string newECinfo = tbxECInfoSettings.Text;
            RelationshipType ecRelationship = (RelationshipType)cbxRelationship.SelectedItem;

            try
            {
                if (!String.IsNullOrEmpty(newECname) && !String.IsNullOrEmpty(newECinfo))
                {
                    EmergencyContact newEc = new EmergencyContact(newECname, newECinfo, ecRelationship);
                    DatabaseController.ModifyEmergencyContact(_currentUser, newEc);
                }
                MessageBox.Show("Saved.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
