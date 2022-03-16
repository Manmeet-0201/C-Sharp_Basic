using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicAccessDemo
{
    class PublicAccessDemoExecutor
    {
        static void Main(string[] args)
        {
            var p = new PointTest();
            // Direct access to public members.
            p.x = 10;
            p.y = 15;
            Console.WriteLine($"x = {p.x}, y = {p.y}");
        }
    }
}
