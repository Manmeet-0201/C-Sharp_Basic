using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MethodHidingDemo;
namespace MethodHidingDemo
{
    

    
    class MethodHidingDemoExecutor
    {
        static void Main(string[] args)
        {
            Base obj = new Derived();
            obj.print();
            Console.ReadKey();
        }
    }
}
