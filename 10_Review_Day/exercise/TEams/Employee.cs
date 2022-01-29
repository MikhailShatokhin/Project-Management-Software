using System;
using System.Collections.Generic;
using System.Text;

namespace TEams
{
    class Employee
    {
        //Properties
        public long EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; } = 60000;
        public Department Department { get; set; }
        public string HireDate { get; set; }
        public string FullName 
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
        //Constructors
        public Employee(long employeeId, string firstName, string lastName, string email, Department department, string hireDate)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Department = department;
            HireDate = hireDate;
        }
        public Employee()
        {

        }
        //Methods
        public double RaiseSalary(double percent)
        {
            return Salary = (Salary * (percent/100)) + Salary;
        }


    }
}
