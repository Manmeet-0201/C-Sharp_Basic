using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> StackVariable = new Stack<int>();
            StackVariable.Push(1);
            StackVariable.Push(2);
            StackVariable.Push(3);
            StackVariable.Push(4);
            //Removing the top element in stack
            Console.WriteLine(StackVariable.Pop());
            Console.WriteLine(StackVariable.Pop());
            //getting top element from stack
            Console.WriteLine(StackVariable.Peek());
        }
    }
}
