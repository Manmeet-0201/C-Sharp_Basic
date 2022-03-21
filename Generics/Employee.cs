using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Employee
    {
        public long EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double HourlySalary { get; set; }

        public Employee(long number = 0, string fName = "John",
                        string lName = "Doe", double salary = 12.05D)
        {
            EmployeeNumber = number;
            FirstName = fName;
            LastName = lName;
            HourlySalary = salary;
        }

        public override string ToString()
        {
            base.ToString();

            return string.Format(
                                 "Employee Record\n" +
                                 "--------------------------------\n" +
                                 "Employee #:    {0}\nFirst Name:    {1}\n" +
                                 "Last Name:     {2}\nHourly Salary: {3}",
                                 EmployeeNumber, FirstName,
                                 LastName, HourlySalary);
        }
    }
}
