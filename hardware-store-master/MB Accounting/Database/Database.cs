using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Windows.Forms;
using System.Configuration;
using Database.Model;
using Database.Model.Enum;
using System.Globalization;

namespace Database
{
    /// <summary> Represents all communications with the MySQL database </summary>
    public static class DatabaseController
    {
        private static readonly string _connectionString = GetConnectionString();

        public static string ConnectionString
        {
            get { return _connectionString; }
        }

        /// <summary> Get connection string from config </summary>
        /// <returns> Connection string to database, otherwise <see langword="null"/> </returns>
        private static string GetConnectionString()
        {
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings["DatabaseConnectionString"];
            string stringValue = null;
            if (settings != null)
            {
                stringValue = settings.ConnectionString;
            }
            return stringValue;
        }

        // Department
        /// <summary> Retrieve department name by department id </summary>
        /// <returns> The department name, otherwise <see langword="null"/> </returns>
        public static string GetDepartment(int departmentId)
        {
            string result = null;
            try
            {
                string query = "SELECT departmentName FROM departments WHERE departmentId = @departmentId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@departmentId", departmentId);
                    connection.Open();
                    result = command.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        /// <summary> Retrieve all departments </summary>
        /// <returns> A list of all <see cref="Department"/>s, otherwise <see langword="null"/> </returns>
        public static List<Department> GetDepartments()
        {
            List<Department> departments = null;
            try
            {
                string query = "SELECT * FROM departments WHERE departmentName != 'none';";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        departments = new List<Department>();
                        while (reader.Read())
                        {
                            departments.Add(new Department(reader.GetInt32(0), reader.GetString(1)));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return departments;
        }

        /// <summary> Retrieve department id by department name </summary>
        /// <returns> The id of the department, otherwise <b>-1</b> </returns>
        public static int GetDepartmentId(string departmentName)
        {
            int departmentId = -1;
            try
            {
                string query = "SELECT departmentId FROM departments WHERE departmentName = @departmentName;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@departmentName", departmentName);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result is object)
                    {
                        departmentId = (int)result;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return departmentId;
        }

        /// <summary> Insert new department</summary>
        /// <returns> <see langword="true"/> if the operation is successful, otherwise <see langword="false"/> </returns>
        public static bool CreateDepartment(string departmentName)
        {
            bool success = false;
            try
            {
                string query = "INSERT INTO `departments` (`departmentName`) VALUES (@departmentName);";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@departmentName", departmentName);
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        /// <summary> Delete department by department name </summary>
        /// <returns> <see langword="true"/> if the operation is successful, otherwise <see langword="false"/> </returns>
        public static bool DeleteDepartment(string departmentName)
        {
            bool success = false;
            try
            {
                string query = "DELETE FROM `departments` WHERE departmentName = @departmentName;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@departmentName", departmentName);
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        /// <summary> Replace all employees' department with a new one </summary>
        /// <returns> <see langword="true"/> if the operation is successful, otherwise <see langword="false"/> </returns>
        public static bool ReplaceEmployeesDepartment(int currentDepartmentId, int newDepartmentId)
        {
            bool success = false;
            try
            {
                string query = "UPDATE `employees` SET `departmentId`= @newDepartmentId WHERE departmentId = @currentDepartmentId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@newDepartmentId", newDepartmentId);
                    command.Parameters.AddWithValue("@currentDepartmentId", currentDepartmentId);
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        // Product
        /// <summary> Retrieve product by product id </summary>
        /// <returns> <see cref="Product"/> object, otherwise <see langword="null"/> </returns>
        public static Product GetProduct(int productId)
        {
            Product product = null;
            try
            {
                string query = "SELECT * FROM stock WHERE stockId = @productId";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productId", productId);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            product = new Product(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3),
                                reader.GetDouble(4), reader.GetDouble(5), reader.GetDouble(6), reader.GetDouble(7), reader.GetDouble(8),
                                reader.GetInt32(9), reader.GetInt32(10), reader.GetInt32(11), reader.GetInt32(12), reader.GetInt32(13), reader.GetString(14));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return product;
        }

        /// <summary> Retrieve product id by product name </summary>
        /// <returns> The id of the product, otherwise <b>-1</b> </returns>
        public static int GetProductId(string productName)
        {
            int productId = -1;
            try
            {
                string query = "SELECT stockId FROM stock WHERE name = @productName;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productName", productName);
                    connection.Open();
                    productId = (int)command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return productId;
        }

        public static List<Product> GetProductsByName(string name)
        {
            List<Product> products = null;
            try
            {
                string query = @"SELECT * 
                                FROM stock 
                                WHERE name LIKE '%@name%';";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        products = new List<Product>();
                        while (reader.Read())
                        {
                            products.Add(new Product(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3),
                                reader.GetDouble(4), reader.GetDouble(5), reader.GetDouble(6), reader.GetDouble(7), reader.GetDouble(8),
                                reader.GetInt32(9), reader.GetInt32(10), reader.GetInt32(11), reader.GetInt32(12), reader.GetInt32(13), reader.GetString(14)));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return products;
        }

        /// <summary> Retrieve all products </summary>
        /// <returns> A list of all <see cref="Product"/>s, otherwise <see langword="null"/> </returns>
        public static List<Product> GetProducts()
        {
            List<Product> products = null;
            try
            {
                string query = "SELECT * FROM stock";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        products = new List<Product>();
                        while (reader.Read())
                        {
                            products.Add(new Product(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3),
                                reader.GetDouble(4), reader.GetDouble(5), reader.GetDouble(6), reader.GetDouble(7), reader.GetDouble(8),
                                reader.GetInt32(9), reader.GetInt32(10), reader.GetInt32(11), reader.GetInt32(12), reader.GetInt32(13), reader.GetString(14)));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return products;
        }

        /// <summary> Retrieve all products by department id</summary>
        /// <returns> A list of all <see cref="Product"/>s in the provided department, otherwise <see langword="null"/> </returns>
        public static List<Product> GetProductsByDepartment(int departmentId)
        {
            List<Product> products = null;
            try
            {
                string query = "SELECT * FROM stock WHERE department = @departmentId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@departmentId", departmentId);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        products = new List<Product>();
                        while (reader.Read())
                        {
                            products.Add(new Product(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3),
                                reader.GetDouble(4), reader.GetDouble(5), reader.GetDouble(6), reader.GetDouble(7), reader.GetDouble(8),
                                reader.GetInt32(9), reader.GetInt32(10), reader.GetInt32(11), reader.GetInt32(12), reader.GetInt32(13), reader.GetString(14)));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return products;
        }

        /// <summary> Insert new product </summary>
        /// <returns> <see langword="true"/> if the operation is successful, otherwise <see langword="false"/> </returns>
        public static bool CreateProduct(string productName, string manufacturer, double productBoughtPrice, double productSellingPrice,
            double weight, double height, double width, double depth, int productDepartmentId, int storeIsle, int warehouseIsle, string description)
        {
            bool success = false;
            try
            {
                string query = "INSERT INTO `stock`( `name`, `manufacturer`, `priceBought`, `priceSelling`, `weight`, `height`, `width`, `depth`, `department`, `storeIsle`, `warehouseIsle`, `description`) " +
                    "VALUES (@productName, @manufacturer, @productBoughtPrice, @productSellingPrice, @weight, @height, @width, @depth, @productDepartmentId, @storeIsle, @warehouseIsle, @description);";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productName", productName);
                    command.Parameters.AddWithValue("@manufacturer", manufacturer);
                    command.Parameters.AddWithValue("@productBoughtPrice", productBoughtPrice);
                    command.Parameters.AddWithValue("@productSellingPrice", productSellingPrice);
                    command.Parameters.AddWithValue("@weight", weight);
                    command.Parameters.AddWithValue("@height", height);
                    command.Parameters.AddWithValue("@width", width);
                    command.Parameters.AddWithValue("@depth", depth);
                    command.Parameters.AddWithValue("@productDepartmentId", productDepartmentId);
                    command.Parameters.AddWithValue("@storeIsle", storeIsle);
                    command.Parameters.AddWithValue("@warehouseIsle", warehouseIsle);
                    command.Parameters.AddWithValue("@description", description);
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        /// <summary> Delete product by product id </summary>
        /// <returns> <see langword="true"/> if the operation is successful, otherwise <see langword="false"/> </returns>
        public static bool DeleteProduct(int productId)
        {
            bool success = false;
            try
            {
                string query = "DELETE FROM `stock` WHERE stockId = @productId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productId", productId);
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        /// <summary> Delete products by department id </summary>
        /// <returns> <see langword="true"/> if the operation is successful, otherwise <see langword="false"/> </returns>
        public static bool DeleteProductsByDepartment(int departmentId)
        {
            bool success = false;
            try
            {
                string query = "DELETE FROM `stock` WHERE department = @departmentId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@departmentId", departmentId);
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        /// <summary> Check whether a product exists </summary>
        /// <returns> <see langword="true"/> if product exists, otherwise <see langword="false"/> </returns>
        public static bool CheckIfProductExists(string productName, int departmentId)
        {
            bool success = false;
            try
            {
                string query = "SELECT * FROM `stock` WHERE department = @departmentId AND name = @productName;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@departmentId", departmentId);
                    command.Parameters.AddWithValue("@productName", productName);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result is object)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        // Employee
        /// <summary> Insert new employee </summary>
        /// <returns> <see langword="true"/> if the operation is successful, otherwise <see langword="false"/> </returns>
        public static bool CreateEmployee(string firstName, string lastName, string hashedPassword,
            string email, int departmentId, DateTime bd, string gender, string city,
            string address, string phoneNr,
            Position position)
        {
            //TODO: Create a contract for the new employee and add it to the database
            bool success = false;
            try
            {
                string query = "INSERT INTO `employees`( `FirstName`, `LastName`, `PasswordHash`, `Email`, `DepartmentId`, `Birthdate`, `Gender`, `City`, `Address`, `PhoneNr`, `ContractStartDate`, `ContractExpirationDate`, `VacationDays`, `Position`) VALUES ( @firstName, @lastName, @hashedPassword, @email, @departmentId, @bd, @gender, @city, @address, @phoneNr, @now, @contractExpirationDate, @vacationDays, @position );";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@hashedPassword", hashedPassword);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@departmentId", departmentId);
                    command.Parameters.AddWithValue("@bd", bd.ToString("MM-dd-yyyy"));
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@phoneNr", phoneNr);
                    command.Parameters.AddWithValue("@now", DateTime.Now.ToString("MM-dd-yyyy"));
                    command.Parameters.AddWithValue("@contractExpirationDate", DateTime.Now.ToString("MM-dd-yyyy"));
                    command.Parameters.AddWithValue("@vacationDays", 30);
                    command.Parameters.AddWithValue("@position", position.ToString());
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        /// <summary> Update employee personal information </summary>
        /// <returns> <see langword="true"/> if the operation is successful, otherwise <see langword="false"/> </returns>
        private static bool PreContractUpdate(int empId, double salary, DateTime contractExpirationDate)
        {
            bool success = false;
            try
            {
                string query = "UPDATE employees SET Salary = @salary, ContractExpirationDate = @contractExpirationDate WHERE Id = @empId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@contractExpirationDate", contractExpirationDate.ToString("MM-dd-yyyy"));
                    command.Parameters.AddWithValue("@empId", empId);
                    command.Parameters.AddWithValue("@salary", salary);
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        /// <summary> Insert new employee </summary>
        /// <returns> <see langword="true"/> if the operation is successful, otherwise <see langword="false"/> </returns>
        public static bool AddContract(int empId, double salary, Contract c)
        {
            bool success = false;
            try
            {
                string query = "INSERT INTO `contracts` (`empId`, `startDate`, `expirationDate`, `temporary`, `fte`) VALUES (@empId, @startDate, @expirationDate, @temporary, @fte);";
                PreContractUpdate(empId, salary, c.ExpirationDate);
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@empId", empId);
                    command.Parameters.AddWithValue("@startDate", c.StartDate.ToString("MM-dd-yyyy"));
                    if (c.IsTemporary)
                    {
                        command.Parameters.AddWithValue("@expirationDate", c.ExpirationDate.ToString("MM-dd-yyyy"));
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@expirationDate", "NULL");
                    }
                    command.Parameters.AddWithValue("@temporary", c.IsTemporary);
                    command.Parameters.AddWithValue("@fte", c.FTE);

                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        /// <summary> Retrieve all employees </summary>
        /// <returns> A list of all <see cref="Employee"/>s, otherwise <see langword="null"/> </returns>
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = null;
            try
            {
                string query = "SELECT e.Id, e.FirstName, e.LastName, e.PasswordHash, e.Email, e.DepartmentId, e.Salary, e.Birthdate, e.Gender, e.City,  e.Address, e.PhoneNr, e.ContractStartDate, e.ContractExpirationDate, e.VacationDays, e.Position FROM employees AS e";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        employees = new List<Employee>();
                        while (reader.Read())
                        {
                            Employee employee = new Employee();
                            employee.Id = reader.GetInt32(0);
                            employee.FirstName = reader.GetString(1);
                            employee.LastName = reader.GetString(2);
                            employee.Email = reader.GetString(4);
                            employee.DepartmentId = reader.GetInt32(5);
                            employee.Salary = reader.GetDouble(6);
                            employee.BirthDate = DateTime.ParseExact(reader.GetString(7), "MM-dd-yyyy", null);
                            Enum.TryParse(reader.GetString(8), out Gender empGender);
                            employee.Gender = empGender;
                            employee.City = reader.GetString(9);
                            employee.Address = reader.GetString(10);
                            employee.PhoneNumber = reader.GetString(11);
                            employee.ContractStartDate = DateTime.ParseExact(reader.GetString(12), "MM-dd-yyyy", null);
                            employee.ContractExpirationDate = DateTime.ParseExact(reader.GetString(13), "MM-dd-yyyy", null);
                            employee.AvailableVacationDays = reader.GetInt32(14);
                            Enum.TryParse(reader.GetString(15), out Position empPosition);
                            employee.Position = empPosition;
                            employees.Add(employee);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return employees;
        }

        /// <summary> Retrieve all employees by department id </summary>
        /// <returns> A list of all <see cref="Employee"/>s in provided department, otherwise <see langword="null"/> </returns>
        public static List<Employee> GetEmployees(int departmentId)
        {
            List<Employee> employees = null;
            try
            {
                string query = "SELECT e.Id, e.FirstName, e.LastName, e.PasswordHash, e.Email, e.DepartmentId, e.Salary, e.Birthdate, e.Gender, e.City, e.Address, e.PhoneNr, e.ContractStartDate, e.ContractExpirationDate, e.VacationDays, e.Position FROM employees AS e WHERE e.DepartmentId = @departmentId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@departmentId", departmentId);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        employees = new List<Employee>();
                        while (reader.Read())
                        {
                            Employee employee = new Employee();
                            employee.Id = reader.GetInt32(0);
                            employee.FirstName = reader.GetString(1);
                            employee.LastName = reader.GetString(2);
                            employee.Email = reader.GetString(4);
                            employee.DepartmentId = reader.GetInt32(5);
                            employee.Salary = reader.GetDouble(6);
                            employee.BirthDate = DateTime.ParseExact(reader.GetString(7), "MM-dd-yyyy", null);
                            Enum.TryParse(reader.GetString(8), out Gender empGender);
                            employee.Gender = empGender;
                            employee.City = reader.GetString(9);
                            employee.Address = reader.GetString(10);
                            employee.PhoneNumber = reader.GetString(11);
                            employee.ContractStartDate = DateTime.ParseExact(reader.GetString(12), "MM-dd-yyyy", null);
                            employee.ContractExpirationDate = DateTime.ParseExact(reader.GetString(13), "MM-dd-yyyy", null);
                            employee.AvailableVacationDays = reader.GetInt32(14);
                            Enum.TryParse(reader.GetString(15), out Position empPosition);
                            employee.Position = empPosition;
                            employees.Add(employee);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return employees;
        }

        /// <summary> Retrieve employee by email </summary>
        /// <returns> <see cref="Employee"/> object, otherwise <see langword="null"/> </returns>
        public static Employee GetEmployee(string email)
        {
            Employee employee = null;
            try
            {
                string query = "SELECT e.Id, e.FirstName, e.LastName, e.PasswordHash, e.Email, e.DepartmentId, e.Salary, e.Birthdate, e.Gender, e.City, e.Address, e.PhoneNr, e.ContractStartDate, e.ContractExpirationDate, e.VacationDays, e.Position FROM employees As e WHERE Email = @email;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        employee = new Employee();
                        while (reader.Read())
                        {
                            employee.Id = reader.GetInt32(0);
                            employee.FirstName = reader.GetString(1);
                            employee.LastName = reader.GetString(2);
                            employee.PasswordHash = reader.GetString(3);
                            employee.Email = reader.GetString(4);
                            employee.DepartmentId = reader.GetInt32(5);
                            employee.Salary = reader.GetDouble(6);
                            employee.BirthDate = DateTime.ParseExact(reader.GetString(7), "MM-dd-yyyy", null);
                            Enum.TryParse(reader.GetString(8), out Gender empGender);
                            employee.Gender = empGender;

                            employee.City = reader.GetString(9);
                            employee.Address = reader.GetString(10);
                            employee.PhoneNumber = reader.GetString(11);
                            employee.ContractStartDate = DateTime.ParseExact(reader.GetString(12), "MM-dd-yyyy", null);
                            employee.ContractExpirationDate = DateTime.ParseExact(reader.GetString(13), "MM-dd-yyyy", null);
                            employee.AvailableVacationDays = reader.GetInt32(14);
                            Enum.TryParse(reader.GetString(15), out Position empPosition);
                            employee.Position = empPosition;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return employee;
        }

        /// <summary> Retrieve employee by employee id </summary>
        /// <returns> <see cref="Employee"/> object, otherwise <see langword="null"/> </returns>
        public static Employee GetEmployee(int employeeId)
        {
            Employee employee = null;
            try
            {
                string query = "SELECT e.Id, e.FirstName, e.LastName, e.PasswordHash, e.Email, e.DepartmentId, e.Salary, e.Birthdate, e.Gender, e.City, e.Address, e.PhoneNr, e.ContractStartDate, e.ContractExpirationDate, e.VacationDays, e.Position FROM employees As e WHERE Id = @employeeId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        employee = new Employee();
                        while (reader.Read())
                        {
                            employee.Id = reader.GetInt32(0);
                            employee.FirstName = reader.GetString(1);
                            employee.LastName = reader.GetString(2);
                            employee.Email = reader.GetString(4);
                            employee.DepartmentId = reader.GetInt32(5);
                            employee.Salary = reader.GetDouble(6);
                            employee.BirthDate = DateTime.ParseExact(reader.GetString(7), "MM-dd-yyyy", null);
                            Enum.TryParse(reader.GetString(8), out Gender empGender);
                            employee.Gender = empGender;
                            employee.City = reader.GetString(9);
                            employee.Address = reader.GetString(10);
                            employee.PhoneNumber = reader.GetString(11);
                            employee.ContractStartDate = DateTime.ParseExact(reader.GetString(12), "MM-dd-yyyy", null);
                            employee.ContractExpirationDate = DateTime.ParseExact(reader.GetString(13), "MM-dd-yyyy", null);
                            employee.AvailableVacationDays = reader.GetInt32(14);
                            Enum.TryParse(reader.GetString(15), out Position empPosition);
                            employee.Position = empPosition;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return employee;
        }

        /// <summary> Check whether an employee exists </summary>
        /// <returns> <see langword="true"/> if employee exists, otherwise <see langword="false"/> </returns>
        public static bool CheckIfEmployeeExists(string email)
        {
            bool success = false;
            try
            {
                string query = "SELECT * FROM employees WHERE Email = @email;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result is object)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        /// <summary> Update employee address, phone number and email </summary>
        /// <returns> <see langword="true"/> if the operation is successful, otherwise <see langword="false"/> </returns>
        public static bool UpdateEmployeePersonalInfo(int employeeId, string employeeAddress,
            string employeePhoneNumber, string employeeEmail)
        {
            bool success = false;
            try
            {
                string query = "UPDATE employees SET Address = @employeeAddress, PhoneNr = @employeePhoneNumber, Email = @employeeEmail  WHERE Id = @employeeId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(@"employeeAddress", employeeAddress);
                    command.Parameters.AddWithValue(@"employeePhoneNumber", employeePhoneNumber);
                    command.Parameters.AddWithValue(@"employeeEmail", employeeEmail);
                    command.Parameters.AddWithValue(@"employeeId", employeeId);
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        /// <summary> Update employee password </summary>
        /// <returns> <see langword="true"/> if the operation is successful, otherwise <see langword="false"/> </returns>
        public static bool UpdateEmployeePassword(int employeeId, string passwordHash)
        {
            bool success = false;
            try
            {
                string query = "UPDATE employees SET PasswordHash = @passwordHash WHERE Id = @employeeId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@passwordHash", passwordHash);
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    connection.Open();
                    command.ExecuteNonQuery();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        /// <summary> Update employee vacation days </summary>
        /// <returns> <see langword="true"/> if the operation is successful, otherwise <see langword="false"/> </returns>
        public static bool UpdateEmployeeVacationDays(int employeeId, int newVacationDays)
        {
            bool success = false;
            try
            {
                string query = "UPDATE employees SET VacationDays = @newVacationDays WHERE Id = @employeeId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@newVacationDays", newVacationDays);
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        /// <summary> Delete employee by employee id </summary>
        /// <returns> <see langword="true"/> if the operation is successful, otherwise <see langword="false"/> </returns>
        public static bool DeleteEmployee(int employeeId)
        {
            bool success = false;
            try
            {
                string query = "DELETE FROM employees WHERE Id = @employeeId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        /// <summary> Retrieve employee salary </summary>
        /// <returns> Salary, otherwise <b>-1</b> </returns>
        public static double GetEmployeeSalary(int empId)
        {
            double salary = -1;
            try
            {
                string query = "SELECT Salary FROM employees WHERE Id = @empId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@empId", empId);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            salary = reader.GetDouble(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return salary;
        }

        /// <summary> Update employee salary and position and add a new contract </summary>
        /// <returns> <see langword="true"/> if the operation is successful, otherwise <see langword="false"/> </returns>
        public static bool PromoteEmployee(int empId, double newSalary, Position newPosition, Contract newContract)
        {
            //TODO: Create a new contract in the database with the empId
            bool success = false;
            try
            {
                string query = "UPDATE employees SET Salary = @newSalary, Position = @newPosition WHERE Id = @empId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@newSalary", newSalary);
                    command.Parameters.AddWithValue("@newPosition", newPosition);
                    command.Parameters.AddWithValue("@empId", empId);
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                        AddContract(empId, newSalary, newContract);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        /// <summary> Update employee personal information </summary>
        /// <returns> <see langword="true"/> if the operation is successful, otherwise <see langword="false"/> </returns>
        public static bool UpdateEmployeeInformation(int empId, string firstName,
            string lastName, string city, string address, string phoneNumber, int departmentId,
            string gender, DateTime contractExpirationDate)
        {
            bool success = false;
            try
            {
                string query = "UPDATE employees SET FirstName = @firstName, LastName = @lastName, City = @city, Address = @address, PhoneNr = @phoneNumber, DepartmentId = @departmentId, Gender = @gender, ContractExpirationDate = @contractExpirationDate WHERE Id = @empId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@departmentId", departmentId);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@contractExpirationDate", contractExpirationDate.ToString("MM-dd-yyyy"));
                    command.Parameters.AddWithValue("@empId", empId);
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        public static string GetEmployeePassword(int employeeId)
        {
            string password = null;
            try
            {
                string query = "SELECT PasswordHash FROM employees WHERE Id = @employeeId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            password = reader.GetString(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return password;
        }

        // Stock request
        /// <summary> Insert new stock request </summary>
        /// <returns> <see langword="true"/> if the operation is successful, otherwise <see langword="false"/> </returns>
        public static bool CreateStockRequest(int productId, int quantity, string description, int departmentId)
        {
            bool success = false;
            try
            {
                string query = "INSERT INTO `stock_request` (`stockId`, `quantity`, `description`, `departmentId`) VALUES (@productId, @quantity, @description, @departmentId);";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productId", productId);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@departmentId", departmentId);
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        /// <summary> Retrieve all stock requests by department id </summary>
        /// <returns> A list of all <see cref="StockRequest"/>s in given department, otherwise <see langword="null"/> </returns>
        public static List<StockRequest> GetStockRequests(int departmentId)
        {
            List<StockRequest> requests = null;
            try
            {
                string query = "SELECT * FROM `stock_request` WHERE departmentId = @departmentId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@departmentId", departmentId);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        requests = new List<StockRequest>();
                        while (reader.Read())
                        {
                            requests.Add(new StockRequest(reader.GetInt32(0),
                                reader.GetInt32(1),
                                reader.GetInt32(2),
                                reader.GetString(3),
                                reader.GetInt32(4),
                                reader.GetDateTime(5),
                                reader.GetBoolean(6)));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return requests;
        }

        public static List<StockRequest> GetApprovedStockRequests(int departmentId, DateTime start, DateTime end)
        {
            List<StockRequest> requests = null;
            try
            {
                string query = @"SELECT `id`, `stockId`, SUM(quantity), `description`,`departmentId`, `date`, `approved` 
                                FROM `stock_request` 
                                WHERE departmentId = @departmentId
                                AND (date BETWEEN DATE(@start) AND DATE(@end)) 
                                AND approved != 0 
                                GROUP BY stockId
                                ORDER BY stockId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@departmentId", departmentId);
                    command.Parameters.AddWithValue("@start", start);
                    command.Parameters.AddWithValue("@end", end);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        requests = new List<StockRequest>();
                        while (reader.Read())
                        {
                            requests.Add(new StockRequest(reader.GetInt32(0),
                                reader.GetInt32(1),
                                reader.GetInt32(2),
                                reader.GetString(3),
                                reader.GetInt32(4),
                                reader.GetDateTime(5),
                                reader.GetBoolean(6)));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return requests;
        }

        /// <summary> Update product quantity and restocked </summary>
        /// <returns> <see langword="true"/> if the operation is successful, otherwise <see langword="false"/> </returns>
        public static bool ApproveStockRequest(int productId, int quantity, int stockRequestId)
        {
            bool success = false;
            try
            {
                string query = "UPDATE `stock` SET quantity = quantity + @quantity, restocked = restocked + @quantity WHERE stockId = @productId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productId", productId);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }


                query = "UPDATE `stock_request` SET `approved` = '1' WHERE `stock_request`.`id` = @stockRequestId; ";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@stockRequestId", stockRequestId);
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        /// <summary> Delete stock request by request id </summary>
        /// <returns> <see langword="true"/> if the operation is successful, otherwise <see langword="false"/> </returns>
        public static bool DeleteStockRequest(int requestId)
        {
            bool success = false;
            try
            {
                string query = "DELETE FROM `stock_request` WHERE id = @requestId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@requestId", requestId);
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        /// <summary> Delete stock requests by department id </summary>
        /// <returns> <see langword="true"/> if the operation is successful, otherwise <see langword="false"/> </returns>
        public static bool DeleteStockRequestsByDepartment(int departmentId)
        {
            bool success = false;
            try
            {
                string query = "DELETE FROM `stock_request` WHERE departmentId = @departmentId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@departmentId", departmentId);
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        // Work shift
        /// <summary> Retrieve all work shifts in given department in a given week </summary>
        /// <returns> A list of all <see cref="WorkShift"/>s in given department in a given week, otherwise <see langword="null"/> </returns>
        public static List<WorkShift> GetWorkShifts(int departmentId, DateTime startOfWeek, DateTime endOfWeek)
        {
            List<WorkShift> workShifts = null;
            try
            {
                string query = @"SELECT ws.shift_id, ws.employee_id, ws.shift_date, ws.shift_time, ws.is_shift, ws.departmentId
                                    FROM `work_shift` AS ws
                                    INNER JOIN employees AS e
                                    ON ws.employee_id = e.Id
                                    WHERE(ws.shift_date BETWEEN @startOfWeek AND @endOfWeek) AND ws.departmentId = @departmentId
                                    ORDER BY ws.shift_date, ws.shift_time";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@departmentId", departmentId);
                    command.Parameters.AddWithValue("@startOfWeek", startOfWeek);
                    command.Parameters.AddWithValue("@endOfWeek", endOfWeek);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        workShifts = new List<WorkShift>();
                        while (reader.Read())
                        {
                            workShifts.Add(new WorkShift(reader.GetInt32(0),
                                reader.GetInt32(1),
                                reader.GetDateTime(2),
                                (WorkShiftType)reader.GetInt32(3),
                                reader.GetInt32(5),
                                reader.GetInt32(4)));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return workShifts;
        }
        
        /// <summary> Retrieve all work shifts in given department on a given day </summary>
        /// <returns> A list of all <see cref="WorkShift"/>s in given department on given day, otherwise <see langword="null"/> </returns>
        public static List<WorkShift> GetWorkShifts(int departmentId, DateTime day)
        {
            List<WorkShift> workShifts = null;
            try
            {
                string query = @"SELECT ws.shift_id, ws.employee_id, ws.shift_date, ws.shift_time, ws.is_shift, ws.departmentId 
                                    FROM `work_shift` AS ws
                                    INNER JOIN employees AS e
                                    ON ws.employee_id = e.Id
                                    WHERE ws.departmentId = @departmentId AND ws.shift_date = DATE(@day)
                                    ORDER BY ws.shift_date, ws.is_shift DESC, ws.shift_time";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@departmentId", departmentId);
                    command.Parameters.AddWithValue("@day", day);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        workShifts = new List<WorkShift>();
                        while (reader.Read())
                        {
                            workShifts.Add(new WorkShift(reader.GetInt32(0),    
                                reader.GetInt32(1),
                                reader.GetDateTime(2),
                                (WorkShiftType)reader.GetInt32(3),
                                reader.GetInt32(5),
                                reader.GetInt32(4)));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return workShifts;
        }

        /// <summary> Retrieve work shift for employee on given day </summary>
        /// <returns> <see cref="WorkShift"/> object, otherwise <see langword="null"/> </returns>
        public static WorkShift GetWorkShift(int employeeId, DateTime day)
        {
            WorkShift shift = null;
            try
            {
                
                string query = @"SELECT ws.shift_id, ws.employee_id, ws.shift_date, ws.shift_time, ws.departmentId
                                FROM `work_shift` AS ws
                                WHERE employee_id = @employeeId 
                                AND (ws.shift_date = DATE(@date))";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    command.Parameters.AddWithValue("@date", day.ToString("yyyy-MM-dd"));
                    string ss = day.ToString("yyyy-MM-dd");
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            shift = new WorkShift(reader.GetInt32(0),
                                reader.GetInt32(1),
                                reader.GetDateTime(2),
                                (WorkShiftType)reader.GetInt32(3),
                                reader.GetInt32(4));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);  
            }
            return shift;
        }

        /// <summary> Retrieve all work shifts of a given employee on given day </summary>
        /// <returns> A list of all <see cref="WorkShift"/>s of given employee on given day, otherwise <see langword="null"/> </returns>
        public static List<WorkShift> GetEmployeeWorkShifts(int employeeId, DateTime day)
        {
            List<WorkShift> employeeShifts = null;
            try
            {
                string query = @"SELECT shift_id, employee_id, shift_date, shift_time, is_shift
                                    FROM `work_shift`
                                    WHERE employee_id = @employeeId AND (shift_date = DATE(@day))
                                    ORDER BY shift_date, shift_time; ";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    command.Parameters.AddWithValue("@day", day);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        employeeShifts = new List<WorkShift>();
                        while (reader.Read())
                        {
                            employeeShifts.Add(new WorkShift(reader.GetInt32(0),
                                reader.GetInt32(1),
                                reader.GetDateTime(2),
                                (WorkShiftType)reader.GetInt32(3),
                                reader.GetInt32(4)));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return employeeShifts;
        }

        /// <summary> Insert new work shift </summary>
        /// <returns> <see langword="true"/> if the operation is successful, otherwise <see langword="false"/> </returns>
        public static bool CreateWorkShift(int employeeId, DateTime day, WorkShiftType shiftType, int deparmentId)
        {
            bool success = false;
            try
            {
                string query = @"INSERT INTO `work_shift`
                                    (shift_id, employee_id, shift_date, shift_time, departmentId)
                                    VALUES (NULL, @employeeId, DATE(@day), @shiftType, @departmentId);";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    command.Parameters.AddWithValue("@day", day);
                    command.Parameters.AddWithValue("@shiftType", (int)shiftType);
                    command.Parameters.AddWithValue("@departmentId", deparmentId);
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        /// <summary> Delete work shift by shift id </summary>
        /// <returns> <see langword="true"/> if the operation is successful, otherwise <see langword="false"/> </returns>
        public static bool DeleteWorkShift(int shiftId)
        {
            bool success = false;
            try
            {
                string query = "DELETE FROM `work_shift` WHERE shift_id = @shiftId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@shiftId", shiftId);
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        /// <summary> Delete work shift by employee id, digen day and shift type </summary>
        /// <returns> <see langword="true"/> if the operation is successful, otherwise <see langword="false"/> </returns>
        public static bool DeleteWorkShift(int employeeId, DateTime day, WorkShiftType shiftType)
        {
            bool success = false;
            try
            {
                string query = @"DELETE FROM `work_shift` WHERE employee_id = @employeeId
                                    AND shift_date = DATE(@day)
                                    AND shift_time = @shiftType
                                    AND is_shift = 1;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    command.Parameters.AddWithValue("@day", day);
                    command.Parameters.AddWithValue("@shiftType", (int)shiftType);
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }
        public static bool DeleteWorkShiftAvailability(int employeeId, DateTime day, WorkShiftType shiftType)
        {
            bool success = false;
            try
            {
                string query = @"DELETE FROM `work_shift` WHERE employee_id = @employeeId
                                    AND shift_date = DATE(@day)
                                    AND shift_time = @shiftType
                                    AND is_shift = 0;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    command.Parameters.AddWithValue("@day", day);
                    command.Parameters.AddWithValue("@shiftType", (int)shiftType);
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        /// <summary> Retieve the amount of shifts the employee has worked for the week in the provided date </summary>
        /// <returns> The amount of shifts for current week, otherwise <b>-1</b> </returns>
        public static int GetAmountOfShiftsForCurrentWeek(int employeeId, DateTime chosenDate)
        {
            int hoursWorkedForPastWeek = -1;
            try
            {
                var culture = System.Threading.Thread.CurrentThread.CurrentCulture;
                var diff = chosenDate.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;
                if (diff < 0)
                {
                    diff += 7;
                }
                DateTime fdowDate = chosenDate.AddDays(-diff).Date;
                string query = @"SELECT COUNT(*)
                                    FROM work_shift
                                    WHERE shift_date BETWEEN DATE(@firstDayOfWeek) AND DATE_SUB(@firstDayOfWeek, INTERVAL -1 WEEK)
                                    AND employee_id = @employeeId
                                    AND is_shift = 1;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    command.Parameters.AddWithValue("@firstDayOfWeek", fdowDate);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            hoursWorkedForPastWeek = reader.GetInt32(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return hoursWorkedForPastWeek;
        }

        // Vacation application
        /// <summary> Insert new vacation application </summary>
        /// <returns> <see langword="true"/> if the operation is successful, otherwise <see langword="false"/> </returns>
        public static bool CreateVacationApplication(int employeeId, DateTime startDate, DateTime endDate, string message)
        {
            bool success = false;
            try
            {
                string query = $"INSERT INTO `vacation_applications` (`applicationId`, `employeeId`, `startDate`, `endDate`, `message`) VALUES (NULL, @employeeId, @startDate, @endDate, @message);";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    command.Parameters.AddWithValue("@startDate", startDate.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@endDate", endDate.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@message", message);
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        /// <summary> Retrieve all vacation applications in a deparment </summary>
        /// <returns> A list of all <see cref="VacationApplication"/>s, otherwise <see langword="null"/> </returns>
        public static List<VacationApplication> GetVacationApplications(int departmentId)
        {
            List<VacationApplication> applications = null;
            try
            {
                string query = @"SELECT *
                                FROM vacation_applications
                                INNER JOIN employees
                                ON vacation_applications.employeeId = employees.Id
                                WHERE employees.DepartmentId = @departmentId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@departmentId", departmentId);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        applications = new List<VacationApplication>();
                        while (reader.Read())
                        {
                            applications.Add(new VacationApplication(reader.GetInt32(0), reader.GetInt32(1),
                                reader.GetDateTime(2), reader.GetDateTime(3), reader.GetString(4)));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return applications;
        }

        /// <summary> Retrieve vacation application by application id </summary>
        /// <returns> <see cref="VacationApplication"/> object, otherwise <see langword="null"/> </returns>
        public static VacationApplication GetVacationApplication(int applicationId)
        {
            VacationApplication application = null;
            try
            {
                string query = "SELECT * FROM `vacation_applications` WHERE applicationId = @applicationId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@applicationId", applicationId);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            application = new VacationApplication(reader.GetInt32(0), reader.GetInt32(1),
                                reader.GetDateTime(2), reader.GetDateTime(3), reader.GetString(4));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return application;
        }

        /// <summary> Delete vacation application by application id </summary>
        /// <returns> <see langword="true"/> if the operation is successful, otherwise <see langword="false"/> </returns>
        public static bool DeleteVacationApplication(int applicationId)
        {
            bool success = false;
            try
            {
                string query = "DELETE FROM `vacation_applications` WHERE applicationId = @applicationId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@applicationId", applicationId);
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        public static bool ApproveVacationApplication(int employeeId, DateTime date)
        {
            bool success = false;
            try
            {
                string query = @"INSERT INTO `work_shift`
                                    (shift_id, employee_id, shift_date, shift_time, is_shift)
                                    VALUES (NULL, @employeeId, DATE(@day), 0, 0);";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    command.Parameters.AddWithValue("@day", date);
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        // Contract
        public static double GetEmployeeCurrentFTE(int employeeId)
        {
            double currentEmployeeFTE = 0;
            try
            {
                string query = "SELECT fte FROM contracts WHERE empId = @employeeId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            currentEmployeeFTE = reader.GetDouble(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return currentEmployeeFTE;
        }

        // Util
        /// <summary> Checks if an email is valid </summary>
        /// <returns> <see langword="true"/> if email is valid, otherwise <see langword="false"/> </returns>
        public static bool IsEmailValid(string email)
        {
            try
            {
                MailAddress addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        /// <summary> Clears the connection pool so the database does not get flooded with connections </summary>
        public static void ClearAllPools()
        {
            MySqlConnection.ClearAllPools();
        }

        //Emergency Contact

        /// <summary> Modifies the employee's emergency contact </summary>
        /// <returns></returns>
        public static bool ModifyEmergencyContact(Employee emp, EmergencyContact newEC)
        {
            bool success = false;
            try
            {
                string query = "UPDATE `employees` SET `ECName`= @newECName, `ECInfo` = @newECPhoneNumber, `ECRelationship` = @newEcRelationship WHERE Id = @userId;";
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@newECName", newEC.Name);
                    command.Parameters.AddWithValue("@newECPhoneNumber", newEC.PhoneNumber);
                    command.Parameters.AddWithValue("@newEcRelationship", newEC.Relationship.ToString());
                    command.Parameters.AddWithValue("@userId", emp.Id);
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }
    }
}
