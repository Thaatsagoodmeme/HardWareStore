using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Database;
using Database.Model;
using Database.Model.Enum;

namespace MB_Accounting
{
    public partial class CheckWorkShiftsForm : Form
    {
        private ColorTheme _formTheme;
        private Employee _currentUser;
        private DateTime _chosenDate;
        private DepartmentManagerForm _previousForm;
        private AutomatedSchedulingForm _previousAutoForm;
        private Employee _selectedEmployee;

        public CheckWorkShiftsForm(Employee currentUser, DepartmentManagerForm previousForm, DateTime chosenDate)
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
            _chosenDate = chosenDate;
            lblHeading.Text = $"Work Shifts for {_chosenDate.DayOfWeek}";
            PopulateComboBox();
            PopulateListView();
        }
        public CheckWorkShiftsForm(Employee currentUser, AutomatedSchedulingForm previousForm, DateTime chosenDate)
        {
            InitializeComponent();
            // Set font - Montserrat
            SetMontserratFont();
            // Set color mode
            _currentUser = currentUser;
            _previousAutoForm = previousForm;
            _formTheme = _previousAutoForm.FormTheme;
            switch (_formTheme)
            {
                case ColorTheme.Light:
                    SetLightTheme();
                    break;
                case ColorTheme.Dark:
                    SetDarkTheme();
                    break;
            }
            _chosenDate = chosenDate;
            lblHeading.Text = $"Work Shifts for {_chosenDate.DayOfWeek}";
            PopulateComboBox();
            PopulateListView();
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
            BackColor =
                cbxEmployees.BackColor =
                tbxHoursLeft.BackColor =
                tbxHoursAllowed.BackColor =
                ColorPalette.White;
            // Dark grey
            lblHeading.ForeColor =
                cbMorning.ForeColor =
                cbAfternoon.ForeColor =
                cbEvening.ForeColor =
                cbRegular.ForeColor =
                lblHoursAllowed.ForeColor =
                lblHoursLeft.ForeColor =
                lblAvailability.ForeColor = 
                ColorPalette.DarkGrey;
            // Pink
            lblSelect.ForeColor =
                cbxEmployees.ForeColor =
                tbxHoursAllowed.ForeColor =
                tbxHoursLeft.ForeColor =
                ColorPalette.Pink;
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
            // White
            lblHeading.ForeColor =
                cbMorning.ForeColor =
                cbAfternoon.ForeColor =
                cbEvening.ForeColor =
                cbRegular.ForeColor =
                lblHoursLeft.ForeColor =
                lblHoursAllowed.ForeColor =
                lblAvailability.ForeColor =
                ColorPalette.White;
            // Yellow
            lblSelect.ForeColor =
                ColorPalette.Yellow;
            // Lighter blue
            cbxEmployees.BackColor =
                tbxHoursLeft.BackColor =
                tbxHoursAllowed.BackColor =
                ColorPalette.LighterBlue;
            // Darker yellow
            cbxEmployees.ForeColor =
                tbxHoursAllowed.ForeColor =
                tbxHoursLeft.ForeColor =
                ColorPalette.DarkerYellow;
        }

        // Set Montserrat font to controls
        private void SetMontserratFont()
        {
            // Montserrat medium
            Fonts.SetPropertyFont(0, this, lblSelect, cbxEmployees, lvSchedule, cbMorning,
                cbAfternoon, cbEvening, cbRegular, lblHoursAllowed, lblHoursLeft, tbxHoursAllowed,
                tbxHoursLeft, lblAvailability, lvAvailability);
            // Montserrat semibold
            Fonts.SetPropertyFont(1, lblHeading);
        }

        private void PopulateListView()
        {
            lvSchedule.Items.Clear();
            lvAvailability.Items.Clear();

            List<WorkShift> workShifts = DatabaseController.GetWorkShifts(_currentUser.DepartmentId, _chosenDate);

            if (workShifts is object)
            {
                foreach (WorkShift shift in workShifts)
                {
                    if(shift.IsShift == 0 && _previousForm != null)
                    {
                        lvAvailability.Items.Add(CreateListViewItem(shift));
                    }
                    else if(shift.IsShift == 1)
                    {
                       lvSchedule.Items.Add(CreateListViewItem(shift));
                    }
                }
            }
        }
        public void PopulateListViewOtherDepts(List<WorkShift> otherDeptShifts)
        {
            lvAvailability.Items.Clear();

            if (otherDeptShifts is object)
            {
                foreach (WorkShift shift in otherDeptShifts)
                {
                    if (shift.Date == _chosenDate)
                    {
                        lvAvailability.Items.Add(CreateListViewItem(shift));
                    }
                }
            }
        }

        private void PopulateComboBox()
        {
            List<Employee> employees = DatabaseController.GetEmployees(_currentUser.DepartmentId);

            if (employees is object)
            {
                cbxEmployees.Items.AddRange(employees.ToArray());
            }
        }

        private void PopulateTextBoxes(Employee selectedEmployee)
        {
            double hoursAllowed = DatabaseController.GetEmployeeCurrentFTE(selectedEmployee.Id) * 40;
            tbxHoursAllowed.Text = hoursAllowed.ToString();
            double shiftsForCurrentWeek = DatabaseController.GetAmountOfShiftsForCurrentWeek(selectedEmployee.Id, _chosenDate);
            double hoursWorkedForCurrentWeek = shiftsForCurrentWeek;
            if (selectedEmployee.Position == Position.Salesman)
            {
                hoursWorkedForCurrentWeek *= 4.5;
            }
            else
            {
                hoursWorkedForCurrentWeek *= 8;
            }
            tbxHoursLeft.Text = (hoursAllowed - hoursWorkedForCurrentWeek).ToString();
        }

        private void PopulateCheckBoxes(Employee selectedEmployee)
        {
            // Disable events to prevent bugs
            cbMorning.CheckedChanged -= cbMorning_CheckedChanged;
            cbAfternoon.CheckedChanged -= cbAfternoon_CheckedChanged;
            cbEvening.CheckedChanged -= cbEvening_CheckedChanged;
            cbRegular.CheckedChanged -= cbRegular_CheckedChanged;

            cbMorning.Checked = false;
            cbAfternoon.Checked = false;
            cbEvening.Checked = false;
            cbRegular.Checked = false;

            switch (selectedEmployee.Position)
            {
                case Position.Salesman:
                    cbMorning.Enabled = true;
                    cbAfternoon.Enabled = true;
                    cbEvening.Enabled = true;
                    cbRegular.Enabled = false;
                    break;
                default:
                    cbMorning.Enabled = false;
                    cbAfternoon.Enabled = false;
                    cbEvening.Enabled = false;
                    cbRegular.Enabled = true;
                    break;
            }

            List<WorkShift> selectedEmployeeShifts =
                DatabaseController.GetEmployeeWorkShifts(selectedEmployee.Id, _chosenDate);
            if (selectedEmployeeShifts is null)
            {
                return;
            }

            foreach (WorkShift shift in selectedEmployeeShifts)
            {
                if (shift.IsShift == 1)
                {
                    switch (shift.Type)
                    {
                        case WorkShiftType.Morning:
                            cbMorning.Checked = true;
                            break;
                        case WorkShiftType.Afternoon:
                            cbAfternoon.Checked = true;
                            break;
                        case WorkShiftType.Evening:
                            cbEvening.Checked = true;
                            break;
                        case WorkShiftType.Regular:
                            cbRegular.Checked = true;
                            break;
                    }
                }
            }

            cbMorning.CheckedChanged += cbMorning_CheckedChanged;
            cbAfternoon.CheckedChanged += cbAfternoon_CheckedChanged;
            cbEvening.CheckedChanged += cbEvening_CheckedChanged;
            cbRegular.CheckedChanged += cbRegular_CheckedChanged;
        }

        private ListViewItem CreateListViewItem(WorkShift workShift)
        {
            Employee employee = DatabaseController.GetEmployee(workShift.EmployeeId);
            if(employee.DepartmentId != _currentUser.DepartmentId)
            {
                cbxEmployees.Items.Add(employee);
            }
            string[] arr = new string[] { workShift.Type.ToString(),
               employee.FullName, workShift.Id.ToString(), workShift.EmployeeId.ToString() };
            ListViewItem item = new ListViewItem(arr);
            switch (workShift.Type)
            {
                case WorkShiftType.Morning:
                    item.BackColor = Color.LightGreen;
                    break;
                case WorkShiftType.Afternoon:
                    item.BackColor = Color.LightSalmon;
                    break;
                case WorkShiftType.Evening:
                    item.BackColor = Color.SlateBlue;
                    break;
                case WorkShiftType.Regular:
                    item.BackColor = Color.Tan;
                    break;
            }
            item.ForeColor = ColorPalette.White;
            return item;
        }

        private void cbxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedEmployee = (Employee)cbxEmployees.SelectedItem;
            if (_selectedEmployee is null)
            {
                return;
            }
            PopulateCheckBoxes(_selectedEmployee);
            PopulateTextBoxes(_selectedEmployee);
        }

        private void lvSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSchedule.SelectedItems.Count > 0)
            {
                int employeeId = int.Parse(lvSchedule.SelectedItems[0].SubItems[3].Text);
                foreach (Employee emp in cbxEmployees.Items)
                {
                    if (employeeId == emp.Id)
                    {
                        _selectedEmployee = emp;
                        break;
                    }
                }
                PopulateCheckBoxes(_selectedEmployee);
                PopulateTextBoxes(_selectedEmployee);
                cbxEmployees.SelectedItem = _selectedEmployee;
            }
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

        private void cbMorning_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedEmployee is null)
            {
                return;
            }

            cbMorning.CheckedChanged -= cbMorning_CheckedChanged;
            if (cbMorning.Checked && double.Parse(tbxHoursLeft.Text) < 4.5)
            {
                MessageBox.Show($"Employee can work maximum {tbxHoursAllowed.Text} hours per week.");
                cbMorning.Checked = false;
                cbMorning.CheckedChanged += cbMorning_CheckedChanged;
                return;
            }

            if (!cbMorning.Checked)
            {
                DatabaseController.DeleteWorkShift(_selectedEmployee.Id, _chosenDate, WorkShiftType.Morning);
            }
            else
            {
                if (cbAfternoon.Checked && cbEvening.Checked)
                {
                    DatabaseController.DeleteWorkShiftAvailability(_selectedEmployee.Id, _chosenDate, WorkShiftType.Morning);
                    DatabaseController.CreateWorkShift(_selectedEmployee.Id, _chosenDate, WorkShiftType.Morning, _currentUser.DepartmentId);

                    MessageBox.Show("Warning: employee already has two shifts assigned for this day.");
                }
                else
                {
                    if (cbEvening.Checked)
                    {
                        MessageBox.Show("Employee can only have two shifts after each other.");
                        cbMorning.Checked = false;
                    }
                    else
                    {
                        DatabaseController.DeleteWorkShiftAvailability(_selectedEmployee.Id, _chosenDate, WorkShiftType.Morning);
                        DatabaseController.CreateWorkShift(_selectedEmployee.Id, _chosenDate, WorkShiftType.Morning, _currentUser.DepartmentId);
                    }
                }
            }
            cbMorning.CheckedChanged += cbMorning_CheckedChanged;
            PopulateListView();
            PopulateTextBoxes(_selectedEmployee);
        }

        private void cbAfternoon_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedEmployee is null)
            {
                return;
            }

            cbAfternoon.CheckedChanged -= cbAfternoon_CheckedChanged;
            if (cbAfternoon.Checked && double.Parse(tbxHoursLeft.Text) < 4.5)
            {
                MessageBox.Show($"Employee can work maximum {tbxHoursAllowed.Text} hours per week.");
                cbAfternoon.Checked = false;
                cbAfternoon.CheckedChanged += cbAfternoon_CheckedChanged;
                return;
            }

            if (!cbAfternoon.Checked)
            {
                if (cbMorning.Checked && cbEvening.Checked)
                {
                    MessageBox.Show("Employee can only have two shifts after each other.");
                    cbAfternoon.Checked = true;
                    cbAfternoon.CheckedChanged += cbAfternoon_CheckedChanged;
                    return;
                }
                DatabaseController.DeleteWorkShift(_selectedEmployee.Id, _chosenDate, WorkShiftType.Afternoon);
            }
            else
            {
                if (cbMorning.Checked && cbEvening.Checked)
                {
                    DatabaseController.DeleteWorkShiftAvailability(_selectedEmployee.Id, _chosenDate, WorkShiftType.Afternoon);
                    DatabaseController.CreateWorkShift(_selectedEmployee.Id, _chosenDate, WorkShiftType.Afternoon, _currentUser.DepartmentId);
                    MessageBox.Show("Warning: employee already has two shifts assigned for this day.");
                }
                else
                {
                    DatabaseController.DeleteWorkShiftAvailability(_selectedEmployee.Id, _chosenDate, WorkShiftType.Afternoon);
                    DatabaseController.CreateWorkShift(_selectedEmployee.Id, _chosenDate, WorkShiftType.Afternoon, _currentUser.DepartmentId);
                }
            }
            cbAfternoon.CheckedChanged += cbAfternoon_CheckedChanged;
            PopulateListView();
            PopulateTextBoxes(_selectedEmployee);
        }

        private void cbEvening_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedEmployee is null)
            {
                return;
            }

            cbEvening.CheckedChanged -= cbEvening_CheckedChanged;
            if (cbEvening.Checked && double.Parse(tbxHoursLeft.Text) < 4.5)
            {
                MessageBox.Show($"Employee can work maximum {tbxHoursAllowed.Text} hours per week.");
                cbEvening.Checked = false;
                cbEvening.CheckedChanged += cbEvening_CheckedChanged;
                return;
            }

            if (!cbEvening.Checked)
            {
                DatabaseController.DeleteWorkShift(_selectedEmployee.Id, _chosenDate, WorkShiftType.Evening);
            }
            else
            {
                if (cbAfternoon.Checked && cbMorning.Checked)
                {
                    DatabaseController.DeleteWorkShiftAvailability(_selectedEmployee.Id, _chosenDate, WorkShiftType.Evening);
                    DatabaseController.CreateWorkShift(_selectedEmployee.Id, _chosenDate, WorkShiftType.Evening, _currentUser.DepartmentId);
                    MessageBox.Show("Warning: employee already has two shifts assigned for this day.");
                }
                else
                {
                    if (cbMorning.Checked)
                    {
                        MessageBox.Show("Employee can only have two shifts after each other.");
                        cbEvening.Checked = false;
                    }
                    else
                    {
                        DatabaseController.DeleteWorkShiftAvailability(_selectedEmployee.Id, _chosenDate, WorkShiftType.Evening);
                        DatabaseController.CreateWorkShift(_selectedEmployee.Id, _chosenDate, WorkShiftType.Evening, _currentUser.DepartmentId);
                    }
                }
            }
            cbEvening.CheckedChanged += cbEvening_CheckedChanged;
            PopulateListView();
            PopulateTextBoxes(_selectedEmployee);
        }

        private void cbRegular_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedEmployee is null)
            {
                return;
            }

            if (cbEvening.Checked && double.Parse(tbxHoursLeft.Text) == 0)
            {
                MessageBox.Show($"Employee can work maximum {tbxHoursAllowed.Text} hours per week.");
                return;
            }

            if (!cbRegular.Checked)
            {
                DatabaseController.DeleteWorkShift(_selectedEmployee.Id, _chosenDate, WorkShiftType.Regular);
            }
            else
            {
                DatabaseController.DeleteWorkShiftAvailability(_selectedEmployee.Id, _chosenDate, WorkShiftType.Regular);
                DatabaseController.CreateWorkShift(_selectedEmployee.Id, _chosenDate, WorkShiftType.Regular, _currentUser.DepartmentId);
            }
            PopulateListView();
            PopulateTextBoxes(_selectedEmployee);
        }

        private void cbMorning_EnabledChanged(object sender, EventArgs e)
        {
            cbMorning.ForeColor = _formTheme == ColorTheme.Light ? ColorPalette.DarkGrey : ColorPalette.White;
        }

        private void cbAfternoon_EnabledChanged(object sender, EventArgs e)
        {
            cbAfternoon.ForeColor = _formTheme == ColorTheme.Light ? ColorPalette.DarkGrey : ColorPalette.White;
        }

        private void cbEvening_EnabledChanged(object sender, EventArgs e)
        {
            cbEvening.ForeColor = _formTheme == ColorTheme.Light ? ColorPalette.DarkGrey : ColorPalette.White;
        }

        private void cbRegular_EnabledChanged(object sender, EventArgs e)
        {
            cbRegular.ForeColor = _formTheme == ColorTheme.Light ? ColorPalette.DarkGrey : ColorPalette.White;
        }

        private void CheckWorkShiftsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            if (_previousForm == null)
            {
                _previousAutoForm.SetWeekSpan();
            }
            else
            {
                _previousForm.SetWeekSpan();
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
            if(_previousForm == null)
            {
                _previousAutoForm.Show();
                _previousAutoForm.SetWeekSpan();
            }
            else
            {
                _previousForm.Show();
                _previousForm.SetWeekSpan();
            }
            
            Close();
        }

        private void lvAvailability_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAvailability.SelectedItems.Count > 0)
            {
                int employeeId = int.Parse(lvAvailability.SelectedItems[0].SubItems[3].Text);
                foreach (Employee emp in cbxEmployees.Items)
                {
                    if (employeeId == emp.Id)
                    {
                        _selectedEmployee = emp;
                        break;
                    }
                }
                PopulateCheckBoxes(_selectedEmployee);
                PopulateTextBoxes(_selectedEmployee);
                cbxEmployees.SelectedItem = _selectedEmployee;
            }
        }
    }
}
