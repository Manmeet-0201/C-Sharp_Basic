using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverRidingDemo
{
    abstract class Employee
    {
        string Name;
        int ID;
        public Employee(string Name,int ID)
        {
            this.Name = Name;
            this.ID = ID;
        }
        public abstract float ComputeSalary();
    }
}
