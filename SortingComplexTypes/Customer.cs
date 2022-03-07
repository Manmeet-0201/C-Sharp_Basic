using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingComplexTypes
{
    class Customer : IComparable<Customer>
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public int salary { set; get; }

        public int CompareTo(Customer customer)
        {
            if (this.salary > customer.salary)
            {
                return 1;
            }
            else if (this.salary < customer.salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
