using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceDemo;
namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Ishape Rectangleshape = new Rectangle();
            Ishape SquareShape = new Square();
            Rectangleshape.PrintShape();
            SquareShape.PrintShape();
            Console.ReadKey();
        }
    }
}
