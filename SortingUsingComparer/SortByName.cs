using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingUsingComparer;
namespace SortingUsingComparer
{
    class SortByName : IComparer<Customer>
    {
        public int Compare(Customer cust1, Customer cust2)
        {
            return cust1.Name.CompareTo(cust2.Name);
        }

    }
}
