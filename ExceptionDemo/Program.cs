using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int Operand1 = Convert.ToInt32(Console.ReadLine());
            int Operand2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                float Quotient = Operand1 / Operand2;
            }
            catch (DivideByZeroException dve)
            {
                Console.WriteLine(dve.Message);
            }
            finally
            {
                Console.WriteLine("In finally");
                Console.ReadKey();
            }
        }
    }
}
