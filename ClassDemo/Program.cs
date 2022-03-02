using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Rahul = new Student(1, "rahul");
            Rahul.SetName("rahul kumar");
            Rahul.SetRollNo(2);
            Console.WriteLine(Rahul.GetName());
            Console.WriteLine(Rahul.GetRollNo());
        }
    }
}
