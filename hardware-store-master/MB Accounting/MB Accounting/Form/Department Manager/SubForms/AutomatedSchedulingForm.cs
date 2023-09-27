using Database;
using Database.Model;
using Database.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB_Accounting
{
    public partial class AutomatedSchedulingForm : Form
    {
        private ColorTheme _formTheme;
        private Employee _currentUser;
        private DepartmentManagerForm _previousForm;
        private DateTime _firstDayDate;
        private DateTime _lastDayDate;
        private List<WorkShift> _chosenWeekShifts;
        private List<WorkShift> _prevWeekShifts;
        private List<WorkShift> _differentDeptAvailability;
        public AutomatedSchedulingForm(Employee currentUser, DepartmentManagerForm previousForm, DateTime firstDayDate, DateTime lastDayDate)
        {
            InitializeComponent();
            SetMontserratFont();
            this._currentUser = currentUser;
            this._firstDayDate = firstDayDate;
            this._lastDayDate = lastDayDate;
            this._differentDeptAvailability = new List<WorkShift>();
            this._chosenWeekShifts = DatabaseController.GetWorkShifts(this._currentUser.DepartmentId, firstDayDate, lastDayDate);
            this._prevWeekShifts = DatabaseController.GetWorkShifts(this._currentUser.DepartmentId, firstDayDate.AddDays(-7), lastDayDate.AddDays(-7));
            SetWeekSpan();
            reduceListLastWeek();
            // Set color mode
            this._previousForm = previousForm;
            this._formTheme = previousForm.FormTheme;
            switch (_formTheme)
            {
                case ColorTheme.Light:
                    SetLightTheme();
                    break;
                case ColorTheme.Dark:
                    SetDarkTheme();
                    break;
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
        public ColorTheme FormTheme
        {
            get { return _formTheme; }
        }

        private void SetLightTheme()
        {
            // White 
            rbtSuggest.ForeColor =
                ColorPalette.White;
            // Pink
            rbtSuggest.Inactive1 =
            rbtSuggest.Inactive2 =
                ColorPalette.Pink;
            // Darker ink
            rbtSuggest.Active1 =
            rbtSuggest.Active2 =
                ColorPalette.DarkerPink;
        }

        private void SetDarkTheme()
        {

        }

        // Set Montserrat font to controls
        private void SetMontserratFont()
        {

        }

        private void GoBack()
        {
            _previousForm.SetWeekSpan();
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

        private void btnApplySuggestions_Click(object sender, EventArgs e)
        {

        }

        private void LoadSuggestionsFromAvailability(WorkShift[] availabilitiesCopy, DateTime firstDayDate, ref int morningShifts, ref int afternoonShifts, ref int eveningShifts)
        {
            Employee currentEmployee;
            List<WorkShift> availabelWorkshifts = new List<WorkShift>();
            availabelWorkshifts.AddRange(availabilitiesCopy);

            double hoursAllowed, hoursWorkedForCurrentWeek, hoursLeft;
            foreach (WorkShift shift in availabelWorkshifts)
            {
                if (lvMonday.Items.Count == 9 && lvTuesday.Items.Count == 9 && lvWednesday.Items.Count == 9 &&
                    lvThursday.Items.Count == 9 && lvFriday.Items.Count == 9 && lvSaturday.Items.Count == 9 && lvSunday.Items.Count == 9)
                {
                    break;
                }
                if (shift.Date != firstDayDate)
                {
                    continue;
                }
                currentEmployee = DatabaseController.GetEmployee(shift.EmployeeId);
                hoursAllowed = DatabaseController.GetEmployeeCurrentFTE(currentEmployee.Id) * 40;
                hoursWorkedForCurrentWeek = DatabaseController.GetAmountOfShiftsForCurrentWeek(currentEmployee.Id, firstDayDate);
                if (currentEmployee.Position == Position.Salesman)
                {
                    hoursWorkedForCurrentWeek *= 4.5;
                }
                else
                {
                    hoursWorkedForCurrentWeek *= 8;
                }
                hoursLeft = hoursAllowed - hoursWorkedForCurrentWeek;

                if (hoursLeft < 4.5 || shift.IsShift != 0)
                {
                    continue;
                }

                if (shift.Type == WorkShiftType.Morning && morningShifts >= 3)
                {
                    continue;
                }
                else if (shift.Type == WorkShiftType.Afternoon && afternoonShifts >= 3)
                {
                    continue;
                }
                else if (shift.Type == WorkShiftType.Evening && eveningShifts >= 3)
                {
                    continue;
                }

                _chosenWeekShifts.Remove(shift);
                AssignShifts(shift, firstDayDate, currentEmployee, ref morningShifts, ref afternoonShifts, ref eveningShifts);

            }
        }
        private void LoadShiftsFromLastWeek(DateTime firstDay, ref int morningShifts, ref int afternoonShifts, ref int eveningShifts)
        {
            Employee currentEmployee;
            double hoursAllowed, hoursWorkedForCurrentWeek, hoursLeft;
            foreach (WorkShift shift in _prevWeekShifts)
            {
                if (lvMonday.Items.Count == 9 && lvTuesday.Items.Count == 9 && lvWednesday.Items.Count == 9 &&
                    lvThursday.Items.Count == 9 && lvFriday.Items.Count == 9 && lvSaturday.Items.Count == 9 && lvSunday.Items.Count == 9)
                {
                    break;
                }
                if (shift.Date != firstDay)
                {
                    continue;
                }
                currentEmployee = DatabaseController.GetEmployee(shift.EmployeeId);
                hoursAllowed = DatabaseController.GetEmployeeCurrentFTE(currentEmployee.Id) * 40;
                hoursWorkedForCurrentWeek = DatabaseController.GetAmountOfShiftsForCurrentWeek(currentEmployee.Id, _firstDayDate);
                if (currentEmployee.Position == Position.Salesman)
                {
                    hoursWorkedForCurrentWeek *= 4.5;
                }
                else
                {
                    hoursWorkedForCurrentWeek *= 8;
                }
                hoursLeft = hoursAllowed - hoursWorkedForCurrentWeek;

                if (hoursLeft < 4.5 || shift.IsShift != 1 || currentEmployee.DepartmentId != _currentUser.DepartmentId)
                {
                    continue;
                }

                if (shift.Type == WorkShiftType.Morning && morningShifts >= 3)
                {
                    continue;
                }
                else if (shift.Type == WorkShiftType.Afternoon && afternoonShifts >= 3)
                {
                    continue;
                }
                else if (shift.Type == WorkShiftType.Evening && eveningShifts >= 3)
                {
                    continue;
                }
                if (!checkShiftExists(shift))
                {
                    AssignShifts(shift, firstDay, currentEmployee, ref morningShifts, ref afternoonShifts, ref eveningShifts, 7);
                }


            }
        }
        private void AssignShiftsToEmployeesWithLeftHours(DateTime date, ref int morningShifts, ref int afternoonShifts, ref int eveningShifts)
        {
            bool existsMorning = false;
            bool existsAfternoon = false;
            bool existsEvening = false;
            double hoursAllowed, hoursWorkedForCurrentWeek, hoursLeft;
            List<Employee> allEmployeesForDepartment = DatabaseController.GetEmployees(_currentUser.DepartmentId);
            foreach (Employee employee in allEmployeesForDepartment)
            {
                existsMorning = false;
                existsAfternoon = false;
                existsEvening = false;
                if (lvMonday.Items.Count == 9 && lvTuesday.Items.Count == 9 && lvWednesday.Items.Count == 9 &&
                    lvThursday.Items.Count == 9 && lvFriday.Items.Count == 9 && lvSaturday.Items.Count == 9 && lvSunday.Items.Count == 9)
                {
                    break;
                }

                hoursAllowed = DatabaseController.GetEmployeeCurrentFTE(employee.Id) * 40;
                hoursWorkedForCurrentWeek = DatabaseController.GetAmountOfShiftsForCurrentWeek(employee.Id, _firstDayDate);
                if (employee.Position == Position.Salesman)
                {
                    hoursWorkedForCurrentWeek *= 4.5;
                }
                else
                {
                    hoursWorkedForCurrentWeek *= 8;
                }
                hoursLeft = hoursAllowed - hoursWorkedForCurrentWeek;

                if (hoursLeft < 4.5)
                {
                    continue;
                }

                List<WorkShift> checkShifts = DatabaseController.GetEmployeeWorkShifts(employee.Id, date);
                foreach (WorkShift shiftsForDay in checkShifts)
                {

                    if (shiftsForDay.Type == WorkShiftType.Morning)
                    {
                        if (!_chosenWeekShifts.Contains(shiftsForDay))
                        {
                            _chosenWeekShifts.Add(shiftsForDay);
                        }
                        existsMorning = true;
                    }
                    else if (shiftsForDay.Type == WorkShiftType.Afternoon)
                    {
                        if (!_chosenWeekShifts.Contains(shiftsForDay))
                        {
                            _chosenWeekShifts.Add(shiftsForDay);
                        }
                        existsAfternoon = true;
                    }
                    else if (shiftsForDay.Type == WorkShiftType.Evening)
                    {
                        if (!_chosenWeekShifts.Contains(shiftsForDay))
                        {
                            _chosenWeekShifts.Add(shiftsForDay);
                        }
                        existsEvening = true;
                    }

                }
                WorkShift shift = null;
                if (morningShifts < 3 && !existsMorning && hoursLeft > 4.5)
                {
                    
                    DatabaseController.CreateWorkShift(employee.Id, date, WorkShiftType.Morning, _currentUser.DepartmentId);
                    shift = DatabaseController.GetWorkShift(employee.Id, date);
                    _chosenWeekShifts.Add(shift);
                    morningShifts++;
                    hoursLeft -= 4.5;
                }
                if (afternoonShifts < 3 && !existsAfternoon && hoursLeft > 4.5)
                {
                    DatabaseController.CreateWorkShift(employee.Id, date, WorkShiftType.Afternoon, _currentUser.DepartmentId);
                    shift = DatabaseController.GetWorkShift(employee.Id, date);
                    _chosenWeekShifts.Add(shift);
                    afternoonShifts++;
                    hoursLeft -= 4.5;
                }
                if (eveningShifts < 3 && !existsEvening && hoursLeft > 4.5)
                {
                    DatabaseController.CreateWorkShift(employee.Id, date, WorkShiftType.Evening, _currentUser.DepartmentId);
                    shift = DatabaseController.GetWorkShift(employee.Id, date);
                    _chosenWeekShifts.Add(shift);
                    eveningShifts++;
                    hoursLeft -= 4.5;
                }


            }
        }
        private void AssignShifts(WorkShift shift, DateTime firstDayDate, Employee currentEmployee, ref int morningShifts, ref int afternoonShifts, ref int eveningShifts, int forPrevWeek = 0)
        {
            bool added = false;

            if (shift.Date == firstDayDate && lvMonday.Items.Count < 9)
            {
                DatabaseController.DeleteWorkShiftAvailability(currentEmployee.Id, shift.Date, shift.Type);
                DatabaseController.CreateWorkShift(currentEmployee.Id, shift.Date.AddDays(forPrevWeek), shift.Type, _currentUser.DepartmentId);
                added = true;
            }
            else if (shift.Date == firstDayDate.AddDays(1) && lvTuesday.Items.Count < 9)
            {
                DatabaseController.DeleteWorkShiftAvailability(currentEmployee.Id, shift.Date, shift.Type);
                DatabaseController.CreateWorkShift(currentEmployee.Id, shift.Date.AddDays(forPrevWeek), shift.Type, _currentUser.DepartmentId);
                added = true;
            }
            else if (shift.Date == firstDayDate.AddDays(2) && lvWednesday.Items.Count < 9)
            {
                DatabaseController.DeleteWorkShiftAvailability(currentEmployee.Id, shift.Date, shift.Type);
                DatabaseController.CreateWorkShift(currentEmployee.Id, shift.Date.AddDays(forPrevWeek), shift.Type, _currentUser.DepartmentId);
                added = true;
            }
            else if (shift.Date == firstDayDate.AddDays(3) && lvThursday.Items.Count < 9)
            {
                DatabaseController.DeleteWorkShiftAvailability(currentEmployee.Id, shift.Date, shift.Type);
                DatabaseController.CreateWorkShift(currentEmployee.Id, shift.Date.AddDays(forPrevWeek), shift.Type, _currentUser.DepartmentId);
                added = true;
            }
            else if (shift.Date == firstDayDate.AddDays(4) && lvFriday.Items.Count < 9)
            {
                DatabaseController.DeleteWorkShiftAvailability(currentEmployee.Id, shift.Date, shift.Type);
                DatabaseController.CreateWorkShift(currentEmployee.Id, shift.Date.AddDays(forPrevWeek), shift.Type, _currentUser.DepartmentId);
                added = true;
            }
            else if (shift.Date == firstDayDate.AddDays(5) && lvSaturday.Items.Count < 9)
            {
                DatabaseController.DeleteWorkShiftAvailability(currentEmployee.Id, shift.Date, shift.Type);
                DatabaseController.CreateWorkShift(currentEmployee.Id, shift.Date.AddDays(forPrevWeek), shift.Type, _currentUser.DepartmentId);
                added = true;
            }
            else if (shift.Date == firstDayDate.AddDays(6) && lvSunday.Items.Count < 9)
            {
                DatabaseController.DeleteWorkShiftAvailability(currentEmployee.Id, shift.Date, shift.Type);
                DatabaseController.CreateWorkShift(currentEmployee.Id, shift.Date.AddDays(forPrevWeek), shift.Type, _currentUser.DepartmentId);
                added = true;
            }
            if (added)
            {
                if (morningShifts < 3 && shift.Type == WorkShiftType.Morning)
                {
                    morningShifts++;
                }
                else if (afternoonShifts < 3 && shift.Type == WorkShiftType.Afternoon)
                {
                    afternoonShifts++;
                }
                else if (eveningShifts < 3 && shift.Type == WorkShiftType.Evening)
                {
                    eveningShifts++;
                }
                shift.IsShift = 1;
                _chosenWeekShifts.Add(shift);
            }
        }




        private ListViewItem CreateListViewItem(WorkShift workShift)
        {
            Employee employee = DatabaseController.GetEmployee(workShift.EmployeeId);
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

        private void rbtSuggest_Click(object sender, EventArgs e)
        {
            SuggestAsync();
        }

        private async void SuggestAsync()
        {
            pbxSpinner.Visible = true;
            await Task.Run(() => Suggest());
            pbxSpinner.Visible = false;
            SetWeekSpan();
        }
        private void Suggest()
        {
            _differentDeptAvailability.RemoveRange(0, _differentDeptAvailability.Count);
            for (int day = 0; day < 7; day++)
            {
                if(day == 0 && lvMonday.Items.Count == 9)
                {
                    continue;
                }
                else if (day == 1 && lvTuesday.Items.Count == 9)
                {
                    continue;
                }
                else if (day == 2 && lvWednesday.Items.Count == 9)
                {
                    continue;
                }
                else if (day == 3 && lvThursday.Items.Count == 9)
                {
                    continue;
                }
                else if (day == 4 && lvFriday.Items.Count == 9)
                {
                    continue;
                }
                else if (day == 5 && lvSaturday.Items.Count == 9)
                {
                    continue;
                }
                else if (day == 6 && lvSunday.Items.Count == 9)
                {
                    continue;
                }

                WorkShift[] shiftCoppies = _chosenWeekShifts.ToArray();
                int morningShifts = 0;
                int afternoonShifts = 0;
                int eveningShifts = 0;
                LoadSuggestionsFromAvailability(shiftCoppies, _firstDayDate.AddDays(day), ref morningShifts, ref afternoonShifts, ref eveningShifts);
                LoadShiftsFromLastWeek(_firstDayDate.AddDays(-7 + day), ref morningShifts, ref afternoonShifts, ref eveningShifts);
                AssignShiftsToEmployeesWithLeftHours(_firstDayDate.AddDays(day), ref morningShifts, ref afternoonShifts, ref eveningShifts);
            }

            List<Department> allDepartments = DatabaseController.GetDepartments();
            List<WorkShift> shiftsOfOtherDept;
            foreach (Department department in allDepartments)
            {
                if (department.Id != _currentUser.DepartmentId)
                {
                    shiftsOfOtherDept = DatabaseController.GetWorkShifts(department.Id, _firstDayDate, _lastDayDate);
                    if (shiftsOfOtherDept == null)
                    {
                        continue;
                    }
                    reduceListAvailableOtherDept(ref shiftsOfOtherDept);
                }
            }

        }

        private void reduceListAvailableOtherDept(ref List<WorkShift> selectedList)
        {
            for (int i = 0; i < selectedList.Count; i++)
            {
                WorkShift[] otherDeptCopy = _differentDeptAvailability.ToArray();
                bool exists = false;
                if (selectedList[i].IsShift == 1)
                {
                    selectedList.RemoveAt(i);
                    i--;
                }
                else
                {
                    if (_differentDeptAvailability.Count == 0)
                    {
                        _differentDeptAvailability.Add(selectedList[i]);
                        continue;
                    }
                    foreach (WorkShift item in otherDeptCopy)
                    {
                        exists = false;
                        if (item.EmployeeId == selectedList[i].EmployeeId && item.Type == selectedList[i].Type && item.Date == selectedList[i].Date)
                        {
                            exists = true;
                        }
                        if (!exists && !_differentDeptAvailability.Contains(selectedList[i]))
                        {

                            _differentDeptAvailability.Add(selectedList[i]);
                        }
                    }
                    

                }
            }
        }

        private void reduceListLastWeek()
        {
            for (int i = 0; i < _prevWeekShifts.Count; i++)
            {
                if (_prevWeekShifts[i].IsShift == 0)
                {
                    _prevWeekShifts.RemoveAt(i);
                    i--;
                }
            }
        }
        public void SetWeekSpan()
        {
            lvMonday.Items.Clear();
            lvTuesday.Items.Clear();
            lvWednesday.Items.Clear();
            lvThursday.Items.Clear();
            lvFriday.Items.Clear();
            lvSaturday.Items.Clear();
            lvSunday.Items.Clear();
            this._chosenWeekShifts = DatabaseController.GetWorkShifts(this._currentUser.DepartmentId, _firstDayDate, _lastDayDate);
            foreach (WorkShift shift in _chosenWeekShifts)
            {
                // Avoid availability and show just shifts
                if (shift.IsShift == 0)
                {
                    continue;
                }

                if (shift.Date == _firstDayDate)
                {
                    lvMonday.Items.Add(CreateListViewItem(shift));
                }
                else if (shift.Date == _firstDayDate.AddDays(1))
                {
                    lvTuesday.Items.Add(CreateListViewItem(shift));
                }
                else if (shift.Date == _firstDayDate.AddDays(2))
                {
                    lvWednesday.Items.Add(CreateListViewItem(shift));
                }
                else if (shift.Date == _firstDayDate.AddDays(3))
                {
                    lvThursday.Items.Add(CreateListViewItem(shift));
                }
                else if (shift.Date == _firstDayDate.AddDays(4))
                {
                    lvFriday.Items.Add(CreateListViewItem(shift));
                }
                else if (shift.Date == _firstDayDate.AddDays(5))
                {
                    lvSaturday.Items.Add(CreateListViewItem(shift));
                }
                else if (shift.Date == _lastDayDate)
                {
                    lvSunday.Items.Add(CreateListViewItem(shift));
                }
            }
        }

        private bool checkShiftExists(WorkShift shift)
        {
            foreach (WorkShift currentShift in _chosenWeekShifts)
            {
                if (shift.EmployeeId == currentShift.EmployeeId && shift.Date.AddDays(7) == currentShift.Date && shift.Type == currentShift.Type)
                {
                    return true;
                }
            }
            return false;
        }
        private void OpenMondayShifts()
        {
            DateTime day = _firstDayDate;
            OpenWorkShifts(day);
        }

        private void OpenTuesdayShifts()
        {
            DateTime day = _firstDayDate.AddDays(1);
            OpenWorkShifts(day);
        }

        private void OpenWednesdayShifts()
        {
            DateTime day = _firstDayDate.AddDays(2);
            OpenWorkShifts(day);
        }

        private void OpenThursdayShifts()
        {
            DateTime day = _firstDayDate.AddDays(3);
            OpenWorkShifts(day);
        }

        private void OpenFridayShifts()
        {
            DateTime day = _firstDayDate.AddDays(4);
            OpenWorkShifts(day);
        }

        private void OpenSaturdayShifts()
        {
            DateTime day = _firstDayDate.AddDays(5);
            OpenWorkShifts(day);
        }

        private void OpenSundayShifts()
        {
            DateTime day = _firstDayDate.AddDays(6);
            OpenWorkShifts(day);
        }
        private void OpenWorkShifts(DateTime day)
        {
            Hide();
            CheckWorkShiftsForm form = new CheckWorkShiftsForm(_currentUser, this, day);
            form.PopulateListViewOtherDepts(_differentDeptAvailability);
            form.ShowDialog();

        }

        private void lvMonday_MouseDown(object sender, MouseEventArgs e)
        {
            OpenMondayShifts();
        }

        private void lvTuesday_MouseDown(object sender, MouseEventArgs e)
        {
            OpenTuesdayShifts();
        }

        private void lvWednesday_MouseDown(object sender, MouseEventArgs e)
        {
            OpenWednesdayShifts();
        }

        private void lvThursday_MouseDown(object sender, MouseEventArgs e)
        {
            OpenThursdayShifts();
        }

        private void lvFriday_MouseDown(object sender, MouseEventArgs e)
        {
            OpenFridayShifts();
        }

        private void lvSaturday_MouseDown(object sender, MouseEventArgs e)
        {
            OpenSaturdayShifts();
        }

        private void lvSunday_MouseDown(object sender, MouseEventArgs e)
        {
            OpenSundayShifts();
        }
    }
}
