using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsDemo
{
    class LoopsDemoExecutor
    {
        static void Main(string[] args) { 

            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int len = arr.Length;
            int i = 0;
            for (i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Add numbers in array arr using for loop
            int sum = 0;
            for(i = 0; i < len; i++)
            {
                sum += arr[i];

            }
            Console.WriteLine(sum);
            //Add numbers in array arr using foreach loop
            sum = 0;
            foreach(int number in arr)
            {
                sum += number;
            }
            Console.WriteLine(sum);
            //Add numbers in array arr using while loop
            sum = 0;
            i = 0;
            while (i < len)
            {
                sum += arr[i];
                i++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
            //Add numbers in array using do-while loop
        }
    }
}
