using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractClassesDemo;
namespace AbstractClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PartTImeEmployee Ramesh = new PartTImeEmployee("Ramesh", 1, 1000, 28);
            Console.WriteLine(Ramesh.ComputeSalary());
            Console.ReadKey();
        }
    }
}
