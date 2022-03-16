using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new DaysInMonthCollection();

            foreach (var days in collection)
            {
                Console.WriteLine($"Days in {days.Date} - {days.Days}");
            }
        }
    }   
}
