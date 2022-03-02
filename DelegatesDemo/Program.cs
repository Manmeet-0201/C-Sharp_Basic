using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public delegate void HelloFunction();
    class Program
    {
        static void Main(string[] args)
        {
            HelloFunction hellofunctiondelegate = new HelloFunction(Hello);
            hellofunctiondelegate();
        }
        static void Hello()
        {
            Console.WriteLine("Hello");
            Console.ReadKey();
        }
    }
}
