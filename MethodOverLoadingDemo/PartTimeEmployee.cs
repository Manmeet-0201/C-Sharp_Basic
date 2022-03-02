using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MethodOverRidingDemo;
namespace MethodOverRidingDemo
{
    class PartTimeEmployee:Employee
    {
        float DailyWage;
        int NumberOfDays;
        public PartTimeEmployee(int Id,string Name,float DailyWage,int NumberOfDays) : base(Name, Id)
        {
            this.DailyWage = DailyWage;
            this.NumberOfDays = NumberOfDays;
        }
        public override float ComputeSalary()
        {
            return DailyWage * NumberOfDays;
        }
    }
}
