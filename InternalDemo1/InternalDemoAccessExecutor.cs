using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternalDemo;
namespace InternalDemoAccess { 
    class InternalDemoAccessExecutor:Class1
    {
        static void Main(string[] args)
        {
            Class1 Class1Object = new Class1();
            //Class1.x;
            //Above statement gives us error
            Console.WriteLine(new InternalDemoAccessExecutor()._y);
        }
    }
}
