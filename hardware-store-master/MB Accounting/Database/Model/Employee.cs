using System;
using Database.Model.Enum;
using System.Collections.Generic;
using System.Linq;

namespace Database.Model
{
    public class Employee
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;
        private Gender _gender;
        private string _city;
        private string _address;
        private string _phoneNumber;
        private DateTime _contractStartDate;
        private DateTime _contractExpirationDate;
        private int _availableVacationDays = 30;
        private int _departmentId;
        private Position _position;
        private string _email;
        private string _passwordHash;
        private double _salary;
        private List<Contract> _contracts;

        public Employee()
        {
            _contracts = new List<Contract>();
        }
        //TODO: Address, Full Name, Emergency Contact, Contract props
        public Employee(int Id, string firstName, string lastName, DateTime birthDate,
            Gender gender, string city, string address, string phoneNumber, DateTime contractStartDate,
            DateTime contractExpirationDate, int departmentId,
            Position position, string email, string passwordHash, double salary)
        {
            _id = Id;
            _firstName = firstName;
            _lastName = lastName;
            _birthDate = birthDate;
            _gender = gender;
            _city = city;
            _address = address;
            _phoneNumber = phoneNumber;
            _departmentId = departmentId;
            _position = position;
            _email = email;
            _passwordHash = passwordHash;
            _salary = salary; 
            _contracts = new List<Contract>();
            Contract c = new Contract();
            c.StartDate = contractStartDate;
            c.ExpirationDate = contractExpirationDate;
            _contracts.Add(c);
        }
        public void EditEmergencyContact(EmergencyContact c) 
        {
            this.EmergencyContact = c;
        }
            
        public void AddContract(Contract contract)
        {
            if (this._contracts.Count >= 3)
            {
                contract.IsTemporary = false;
            }
            this._contracts.Add(contract);
        }
        public Contract GetCurrentContract => this._contracts.First(c => c.ExpirationDate < DateTime.Now && ContractStartDate < DateTime.Now);
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string FullName => $"{FirstName} {LastName}";
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }
        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public string City
        {
            get{ return _city; }
            set { _city = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        public DateTime ContractStartDate
        {
            get { return _contractStartDate; }
            set { _contractStartDate = value; }
        }
        public DateTime ContractExpirationDate
        {
            get { return _contractExpirationDate; }
            set { _contractExpirationDate = value; }
        }
        public int AvailableVacationDays
        {
            get { return _availableVacationDays; }
            set { _availableVacationDays = value; }
        }
        public int DepartmentId
        {
            get { return _departmentId; }
            set { _departmentId = value; }
        }
        public Position Position
        {
            get { return _position; }
            set { _position = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string PasswordHash
        {
            get { return _passwordHash; }
            set { _passwordHash = value; }
        }
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public EmergencyContact EmergencyContact { get; set; }
        public override string ToString()
        {
            return $"{_firstName} {_lastName} - {_email}";
        }
    }
}
