using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PartialClasses;
namespace PartialClasses
{
    public partial class CustomerName
    {
        public string CustomerFirstName { set; get; }
        public string CustomerLastName { set; get; }
    }
    class PartialClassesExecutor
    {
        static void Main(string[] args)
        {
            CustomerName NameOfCustomer = new CustomerName();
            NameOfCustomer.CustomerFirstName = "Shane";
            NameOfCustomer.CustomerLastName = "smith";

            Console.WriteLine("Full name is {0}", NameOfCustomer.getFullName(NameOfCustomer.CustomerFirstName, NameOfCustomer.CustomerLastName));
            Console.ReadKey();
        }
    }
}
