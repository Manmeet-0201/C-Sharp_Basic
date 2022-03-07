using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MethodHidingDemo;
namespace MethodHidingDemo
{
    class Derived : Base
    {
        public new void print()
        {
            Console.WriteLine("Derived method is called");
        }
    }
}
