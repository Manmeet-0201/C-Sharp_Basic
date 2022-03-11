using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProtectedAccessDemo
{
    class DerivedPoint:Point
    {
        static void Main(string[] args)
        {

            var dpoint = new DerivedPoint();

            // Direct access to protected members.
            dpoint.x = 10;
            dpoint.y = 15;
            Console.WriteLine($"x = {dpoint.x}, y = {dpoint.y}");
        }
    }
}
