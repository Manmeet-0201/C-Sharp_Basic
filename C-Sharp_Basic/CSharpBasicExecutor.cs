using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Sharp_Basic;
namespace C_Sharp_Basic
{
    class CSharpBasicExecutor
    {
        static void Main(string[] args)
        {
            OperatorDemo operatordemo = new OperatorDemo(1, 2);
            Console.WriteLine(operatordemo.AddOperands());
            Console.WriteLine(operatordemo.SubtractOperands());
            Console.WriteLine(operatordemo.MultiplyOperands());
            Console.WriteLine(operatordemo.DivideOperands());
            Console.ReadLine();
        }
    }
}
