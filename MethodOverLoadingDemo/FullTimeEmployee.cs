using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MethodOverRidingDemo;
namespace MethodOverRidingDemo
{
    class FullTimeEmployee:Employee
    {
        float salary;
        public FullTimeEmployee(int ID, string Name, float salary) : base(Name, ID)
        {
            this.salary = salary;
        }
        public override float ComputeSalary()
        {
            return salary;
        }
    }
}
