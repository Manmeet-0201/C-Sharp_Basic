using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericsExecutor
    {
        static void Main(string[] args)
        {
            #region DataStore Generic
            //DataStore<string> cities = new DataStore<string>();
            //cities.AddOrUpdate(0, "Mumbai");
            //cities.AddOrUpdate(1, "Chicago");
            //cities.AddOrUpdate(2, "London");
            //Console.WriteLine(cities.GetData(0));
            //DataStore<int> empIds = new DataStore<int>();
            //empIds.AddOrUpdate(0, 50);
            //empIds.AddOrUpdate(1, 65);
            //empIds.AddOrUpdate(2, 89);
            //Console.WriteLine(empIds.GetData(1));
            //Console.ReadKey();
            #endregion
            IPersons<Employee> employees = new People<Employee>();

            Employee empl = null;

            empl = new Employee();
            empl.EmployeeNumber = 253055;
            empl.FirstName = "Joseph";
            empl.LastName = "Denison";
            empl.HourlySalary = 12.85;
            employees.Add(empl);

            empl = new Employee();
            empl.EmployeeNumber = 204085;
            empl.FirstName = "Raymond";
            empl.LastName = "Ramirez";
            empl.HourlySalary = 9.95;
            employees.Add(empl);

            empl = new Employee();
            empl.EmployeeNumber = 970044;
            empl.FirstName = "Christian";
            empl.LastName = "Riley";
            empl.HourlySalary = 14.25;
            employees.Add(empl);

            for (int i = 0; i < employees.Count; i++)
            {
                Employee staff = employees.Get(i);
                Console.WriteLine(staff);
                #region print statements
                //Console.WriteLine("--------------------------------");
                //Console.WriteLine("Employee #:    {0}", staff.EmployeeNumber);
                //Console.WriteLine("First Name:    {0}", staff.FirstName);
                //Console.WriteLine("Last Name:     {0}", staff.LastName);
                //Console.WriteLine("Hourly Salary: {0}", staff.HourlySalary);
                #endregion
            }
            Console.ReadKey();
        }
    }
}
