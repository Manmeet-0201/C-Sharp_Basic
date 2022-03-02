using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Console.WriteLine("Enter any Five numbers");
            for(int i = 0; i < 5; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(AddAllNumbersInArray(array));
            Console.ReadKey();
        }
        static int AddAllNumbersInArray(int[] array)
        {
            int sum = 0;
            foreach(int numbers in array)
            {
                sum = sum + numbers;
            }
            return sum;

        }
    }
}
