using Database.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MB_Accounting
{
    public partial class DepartmentPerformanceForm : Form
    {
        private ColorTheme _formTheme;
        private Employee _currentUser;
        private DepartmentManagerForm _previousForm;
        private List<Product> _products;

        public DepartmentPerformanceForm(Employee currentUser, DepartmentManagerForm previousForm)
        {
            InitializeComponent();
            // Set font - Montserrat
            SetMontserratFont();
            // Set color mode
            _currentUser = currentUser;
            _previousForm = previousForm;
            _formTheme = _previousForm.FormTheme;
            switch (_formTheme)
            {
                case ColorTheme.Light:
                    SetLightTheme();
                    break;
                case ColorTheme.Dark:
                    SetDarkTheme();
                    break;
            }
            mainChart.Series["s1"].IsValueShownAsLabel = true;
            _products = Database.DatabaseController.GetProductsByDepartment(_currentUser.DepartmentId);
            SetDateTimePickers();
            ModifyProducts(dtpStart.Value, dtpEnd.Value);
            foreach (Product product in _products)
            {
                mainChart.Series["s1"].Points.AddXY(product.Name, product.Restocked.ToString());
            }
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

        private void SetDateTimePickers()
        {
            DateTime today = DateTime.Now;
            DateTime month = new DateTime(today.Year, today.Month, 1);
            DateTime startDate = month.AddMonths(-1);
            DateTime endDate = month.AddDays(-1);

            dtpStart.Value = startDate;
            dtpEnd.Value = endDate;
        }

        private void SetLightTheme()
        {
            pictureBoxMoon.Show();
            pictureBoxBackPink.Show();
            pictureBoxSun.Hide();
            pictureBoxBackYellow.Hide();
            // White
            BackColor =
                cbxChartType.BackColor =
                tbxFilter.BackColor =
                cbxFilter.BackColor =
                ColorPalette.White;
            // Pink
            cbxChartType.ForeColor =
               tbxFilter.ForeColor =
               cbxFilter.ForeColor =
               lblMore.ForeColor =
               lblLess.ForeColor =
               ColorPalette.Pink;
            // Dark grey
            lblHeading.ForeColor =
                lblChartType.ForeColor =
                lblFilter.ForeColor =
                labelSD.ForeColor =
                labelEND.ForeColor =
                ColorPalette.DarkGrey;

        }

        private void SetDarkTheme()
        {
            pictureBoxSun.Show();
            pictureBoxBackYellow.Show();
            pictureBoxMoon.Hide();
            pictureBoxBackPink.Hide();
            // Dark blue
            BackColor =
                ColorPalette.DarkBlue;
            // Lighter blue
            cbxFilter.BackColor =
                tbxFilter.BackColor =
                cbxChartType.BackColor =
                ColorPalette.LighterBlue;
            // Darker yellow
            cbxFilter.ForeColor =
                tbxFilter.ForeColor =
                cbxChartType.ForeColor =
                ColorPalette.DarkerYellow;
            // White
                lblHeading.ForeColor =
                ColorPalette.White;
            // Yellow
            lblMore.ForeColor =
                lblLess.ForeColor =
                lblFilter.ForeColor =
                labelSD.ForeColor =
                lblChartType.ForeColor =
                labelEND.ForeColor =
                ColorPalette.Yellow;
        }

        // Set Montserrat font to controls
        private void SetMontserratFont()
        {
            // Montserrat medium
            Fonts.SetPropertyFont(0, this, lblChartType, lblFilter, cbxChartType, cbxFilter, tbxFilter,
                labelSD, labelEND, lblLess, lblMore);
            // Montserrat semibold
            Fonts.SetPropertyFont(1, lblHeading);
        }

        private void GoBack()
        {
            _previousForm.Show();
            Close();
        }

        private void pictureBoxBackPink_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void pictureBoxBackYellow_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void pictureBoxMoon_Click(object sender, EventArgs e)
        {
            SetDarkTheme();
        }

        private void pictureBoxSun_Click(object sender, EventArgs e)
        {
            SetLightTheme();
        }

        private void cbxChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxChartType.SelectedItem)
            {
                case "Column":
                    mainChart.Series["s1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    break;
                case "Pie":
                    mainChart.Series["s1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    break;
                case "Point":
                    mainChart.Series["s1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    break;
                case "Doughnut":
                    mainChart.Series["s1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string input = tbxFilter.Text;
            if (!input.Contains(":"))
            {
                if (input == String.Empty)
                {
                    mainChart.Series["s1"].Points.Clear();
                    foreach (Product product in _products)
                    {
                        mainChart.Series["s1"].Points.AddXY(product.Name, product.Restocked.ToString());
                    }
                }
                return;
            }
            mainChart.Series["s1"].Points.Clear();

            string filterType = input.Split(':')[0];
            string filter = input.Split(':')[1];

            switch (filterType)
            {
                case "name":
                    foreach (Product product in _products)
                    {
                        if (product.Name.Contains(filter))
                        {
                            mainChart.Series["s1"].Points.AddXY(product.Name, product.Restocked.ToString());
                        }
                    }
                    break;
                case "manufacturer":
                    foreach (Product product in _products)
                    {
                        if (product.Manufacturer.Contains(filter))
                        {
                            mainChart.Series["s1"].Points.AddXY(product.Name, product.Restocked.ToString());
                        }
                    }
                    break;
                case "pricebought":
                    bool success = double.TryParse(filter, out double priceBought);
                    if (!success)
                    {
                        return;
                    }
                    foreach (Product product in _products)
                    {
                        if (product.PriceBought <= priceBought)
                        {
                            mainChart.Series["s1"].Points.AddXY(product.Name, product.Restocked.ToString());
                        }
                    }
                    break;
                case "priceselling":
                    bool success1 = double.TryParse(filter, out double priceSelling);
                    if (!success1)
                    {
                        return;
                    }
                    foreach (Product product in _products)
                    {
                        if (product.PriceSelling <= priceSelling)
                        {
                            mainChart.Series["s1"].Points.AddXY(product.Name, product.Restocked.ToString());
                        }
                    }
                    break;
                case "weight":
                    bool success2 = double.TryParse(filter, out double weight);
                    if (!success2)
                    {
                        return;
                    }
                    foreach (Product product in _products)
                    {
                        if (product.Weight <= weight)
                        {
                            mainChart.Series["s1"].Points.AddXY(product.Name, product.Restocked.ToString());
                        }
                    }
                    break;
                case "height":
                    bool success3 = double.TryParse(filter, out double height);
                    if (!success3)
                    {
                        return;
                    }
                    foreach (Product product in _products)
                    {
                        if (product.Height <= height)
                        {
                            mainChart.Series["s1"].Points.AddXY(product.Name, product.Restocked.ToString());
                        }
                    }
                    break;
                case "width":
                    bool success4 = double.TryParse(filter, out double width);
                    if (!success4)
                    {
                        return;
                    }
                    foreach (Product product in _products)
                    {
                        if (product.Width <= width)
                        {
                            mainChart.Series["s1"].Points.AddXY(product.Name, product.Restocked.ToString());
                        }
                    }
                    break;
                case "depth":
                    bool success5 = double.TryParse(filter, out double depth);
                    if (!success5)
                    {
                        return;
                    }
                    foreach (Product product in _products)
                    {
                        if (product.Depth <= depth)
                        {
                            mainChart.Series["s1"].Points.AddXY(product.Name, product.Restocked.ToString());
                        }
                    }
                    break;
                case "description":
                    foreach (Product product in _products)
                    {
                        if (product.Description.Contains(filter))
                        {
                            mainChart.Series["s1"].Points.AddXY(product.Name, product.Restocked.ToString());
                        }
                    }
                    break;
                case "storeisle":
                    bool success6 = double.TryParse(filter, out double storeIsle);
                    if (!success6)
                    {
                        return;
                    }
                    foreach (Product product in _products)
                    {
                        if (product.StoreIsle == storeIsle)
                        {
                            mainChart.Series["s1"].Points.AddXY(product.Name, product.Restocked.ToString());
                        }
                    }
                    break;
                case "warehouseisle":
                    bool success7 = double.TryParse(filter, out double warehouseIsle);
                    if (!success7)
                    {
                        return;
                    }
                    foreach (Product product in _products)
                    {
                        if (product.WarehouseIsle == warehouseIsle)
                        {
                            mainChart.Series["s1"].Points.AddXY(product.Name, product.Restocked.ToString());
                        }
                    }
                    break;
                case "quantity":
                    bool success8 = double.TryParse(filter, out double quantity);
                    if (!success8)
                    {
                        return;
                    }
                    foreach (Product product in _products)
                    {
                        if (product.Quantity <= quantity)
                        {
                            mainChart.Series["s1"].Points.AddXY(product.Name, product.Restocked.ToString());
                        }
                    }
                    break;
            }
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxFilter.SelectedItem)
            {
                case "Name":
                    tbxFilter.Text = "name:";
                    break;
                case "Manufacturer":
                    tbxFilter.Text = "manufacturer:";
                    break;
                case "Price Bought":
                    tbxFilter.Text = "pricebought:";
                    break;
                case "Price Selling":
                    tbxFilter.Text = "priceselling:";
                    break;
                case "Weight":
                    tbxFilter.Text = "weight:";
                    break;
                case "Height":
                    tbxFilter.Text = "height:";
                    break;
                case "Width":
                    tbxFilter.Text = "width:";
                    break;
                case "Depth":
                    tbxFilter.Text = "depth:";
                    break;
                case "Description":
                    tbxFilter.Text = "description:";
                    break;
                case "Store Isle":
                    tbxFilter.Text = "storeisle:";
                    break;
                case "Warehouse Isle":
                    tbxFilter.Text = "warehouseisle:";
                    break;
                case "Quantity":
                    tbxFilter.Text = "quantity:";
                    break;
            }
        }

        private void GoMonthBack()
        {
            dtpStart.Value = dtpStart.Value.AddMonths(-1);
            dtpEnd.Value = dtpEnd.Value.AddMonths(-1);
        }

        private void GoMonthForward()
        {
            dtpStart.Value = dtpStart.Value.AddMonths(1);
            dtpEnd.Value = dtpEnd.Value.AddMonths(1);
        }

        private void lblLess_Click(object sender, EventArgs e)
        {
            GoMonthBack();
            ModifyProducts(dtpStart.Value, dtpEnd.Value);
            textBox1_TextChanged(new object(), null);
        }

        private void lblMore_Click(object sender, EventArgs e)
        {
            GoMonthForward();
            ModifyProducts(dtpStart.Value, dtpEnd.Value);
            textBox1_TextChanged(new object(), null);
        }

        private void ModifyProducts(DateTime startDate, DateTime endDate)
        {
            List<StockRequest> stockRequests = Database.DatabaseController.GetApprovedStockRequests(_currentUser.DepartmentId, startDate, endDate);
            foreach (Product product in _products)

            {
                product.Restocked = 0;
            }
            foreach (StockRequest sr in stockRequests)
            {
                foreach (Product product in _products)
                {
                    if (product.Id == sr.ProductId)
                    {
                        product.Restocked = sr.Quantity;
                    }
                }
            }
        }
    }
}
