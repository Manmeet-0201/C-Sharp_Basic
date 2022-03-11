using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceImplementation
{
    #region commented code
    //public class SampleClass : IControl, ISurface
    //{
    //    // Both ISurface.Paint and IControl.Paint call this method.
    //    public void Paint()
    //    {
    //        Console.WriteLine("Paint method in SampleClass");
    //    }
    //}
    #endregion
    public class SampleClass : IControl, ISurface
    {
        void IControl.Paint()
        {
            System.Console.WriteLine("IControl.Paint");
        }
        void ISurface.Paint()
        {
            System.Console.WriteLine("ISurface.Paint");
        }
    }
}
