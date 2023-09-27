using System;
using Database.Model.Enum;

namespace Database.Model
{
    public class WorkShift
    {
        private int _id;
        private int _employeeId;
        private DateTime _date;
        private WorkShiftType _type;
        private int _isShift;
        private int? _departmentId;

        public WorkShift(int shiftId, int employeeId, DateTime date, WorkShiftType type, int departmentId, int isShift = 1)
        {
            _id = shiftId;
            _employeeId = employeeId;
            _date = date;
            _type = type;
            _isShift = isShift;
            _departmentId = departmentId;
        }

        public int Id
        {
            get { return _id; }
        }
        public int EmployeeId
        {
            get { return _employeeId; }
        }
        public DateTime Date
        {
            get { return _date; }
        }
        public WorkShiftType Type
        {
            get { return _type; }
        }
        public int IsShift
        {
            get { return _isShift; } set { _isShift = value; }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
