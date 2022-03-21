using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class IndexersExecutor
    {
        static void Main(string[] args)
        {
            Company c = new Company();
            Console.WriteLine(c[1]);
            Console.ReadKey();
        }
    }
}
