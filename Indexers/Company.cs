using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class Company
    {
        private List<Employee> listEmployee;
        public Company()
        {
            listEmployee = new List<Employee>();
            listEmployee.Add(new Employee() { EmployeeId = 1, Name = "Mark", Gender = "Male" });
            listEmployee.Add(new Employee() { EmployeeId = 2, Name = "Rani", Gender = "Female" });

        }

        public string this[int employeeId]
        {
            get
            {
                return listEmployee.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name;
            }
            set
            {
                listEmployee.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name = value;
            }
        }
    }
}
