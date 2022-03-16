using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateAccessDemo
{
    class Employee2
    {
        private readonly string _name = "FirstName, LastName";
        private readonly double _salary = 100.0;

        public string GetName()
        {
            return _name;
        }

        public double Salary
        {
            get { return _salary; }
            //set { _salary = value; }
        }
    }

    class PrivateAccessDemoExecutor
    {
        static void Main()
        {
            var e = new Employee2();

            // The data members are inaccessible (private), so
            // they can't be accessed like this:
            //    string n = e._name;
            //    double s = e._salary;

            // '_name' is indirectly accessed via method:
            string n = e.GetName();

            // '_salary' is indirectly accessed via property
            double s = e.Salary;
        }
    }
}
