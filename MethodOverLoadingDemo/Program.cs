using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MethodOverRidingDemo;
namespace MethodOverRidingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee FTE = new FullTimeEmployee(1, "Ramesh", 70000);
            Employee PTE = new PartTimeEmployee(1, "Suresh", 900, 29);
            Console.WriteLine(FTE.ComputeSalary());
            Console.ReadKey();
        }
    }
}
