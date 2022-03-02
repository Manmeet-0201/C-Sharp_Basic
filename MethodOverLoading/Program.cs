using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(1, 2, 3));
            Console.WriteLine(Add(2, 9.0f));
        }
        static int Add(int a,int b)
        {
            return a + b;
        }
        static int Add(int a,int b,int c)
        {
            return a + b + c;
        }
        static float Add(int a,float b)
        {
            return a + b;
        }
    }
}
