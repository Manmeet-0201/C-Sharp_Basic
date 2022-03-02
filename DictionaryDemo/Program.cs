using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DictionaryDemo;
namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Customer> customer_dict = new Dictionary<int, Customer>();
            customer_dict.Add(1, new Customer("Raj", 1));
            customer_dict.Add(2, new Customer("Kishan", 2));
            customer_dict.Add(3, new Customer("Jadhav", 3));
            Customer temp = FindCustomerByID(2, customer_dict);
            Console.Write(temp.ToString());
            Console.WriteLine();
            PrintCustomerDictionary(customer_dict);
            Console.ReadKey();
        }
        static  Customer FindCustomerByID(int ID,Dictionary<int,Customer> customer_dict)
        {
            return customer_dict[ID];
        }
        static void PrintCustomerDictionary(Dictionary<int,Customer> customer_dict)
        {
            foreach(KeyValuePair<int,Customer> DictionaryEntry in customer_dict)
            {
                Console.WriteLine(DictionaryEntry.Key + " " + DictionaryEntry.Value);
            }
        }
    }
}
