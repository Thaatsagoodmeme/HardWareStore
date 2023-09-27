using System;

namespace Database.Model
{
    public class VacationApplication
    {
        private int _id;
        private int _employeeId;
        private DateTime _startDate;
        private DateTime _endDate;
        private string _message;

        public VacationApplication(int applicationId, int employeeId, DateTime startDate, DateTime endDate, string message)
        {
            _id = applicationId;
            _employeeId = employeeId;
            _startDate = startDate;
            _endDate = endDate;
            _message = message;
        }

        public int Id
        {
            get { return _id; }
        }
        public int EmployeeId
        {
            get { return _employeeId; }
        }
        public DateTime StartDate
        {
            get { return _startDate; }
        }
        public DateTime EndDate
        {
            get { return _endDate; }
        }
        public string Message
        {
            get { return _message; }
        }

        public override string ToString()
        {
            Employee employee =  DatabaseController.GetEmployee(_employeeId);
            return $"{_id} | {employee.FirstName} {employee.LastName} | {_message}";
        }
    }
}
