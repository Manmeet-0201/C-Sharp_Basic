using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Employee
    {
        string Name;
        int ID;
        public Employee(string Name, int ID)
        {
            this.Name = Name;
            this.ID = ID;
        }
        public override string ToString()
        {
            return Name + "-" + ID;
        }
    }
}
