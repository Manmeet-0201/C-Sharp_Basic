using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class PartTimeEmployee : AbstractEmployee
    {
        public PartTimeEmployee(int ID, string Name) : base(ID, Name)
        {

        }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
        public override decimal GetMinimumSalary()
        {
            return 2000;
        }
    }
}
