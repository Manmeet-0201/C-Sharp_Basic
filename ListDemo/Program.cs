using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListDemo;
namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EmployeeList = new List<Employee>();
            Employee Raju = new Employee("Raju",1);
            Employee Kishan = new Employee("Kishan", 2);
            EmployeeList.Add(Raju);
            EmployeeList.Add(Kishan);
            PrintElementsInEmployeeList(EmployeeList);
        }
        static void PrintElementsInEmployeeList(List<Employee> EmployeeList)
        {
            foreach(Employee Emp in EmployeeList)
            {
                Console.WriteLine(Emp);
            }
            Console.ReadKey();
        }

    }
}
