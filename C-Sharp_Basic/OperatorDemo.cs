using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic
{
    class OperatorDemo
    {
        int operand1;
        int operand2;
        public OperatorDemo(int x,int y)
        {
            operand1 = x;
            operand2 = y;
        }
        public int AddOperands()
        {
            return operand1 + operand2;
        }
        public int SubtractOperands()
        {
            return operand1 - operand2;
        }
        public int MultiplyOperands()
        {
            return operand1 * operand2;
        }
        public int DivideOperands()
        {
            try
            {
                return operand1 / operand2;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return -1;
        }
    }
}
