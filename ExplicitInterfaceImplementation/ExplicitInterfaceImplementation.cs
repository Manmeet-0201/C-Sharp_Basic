using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceImplementation
{
    class ExplicitInterfaceImplementation
    {
        static void Main(string[] args)
        {
            #region commented code
            //SampleClass sample = new SampleClass();
            //IControl control = sample;
            //ISurface surface = sample;

            // The following lines all call the same method.
            //sample.Paint();
            //control.Paint();
            //surface.Paint();

            // Output:
            // Paint method in SampleClass
            // Paint method in SampleClass
            // Paint method in SampleClass
            #endregion 

            SampleClass sample = new SampleClass();
            IControl control = sample;
            ISurface surface = sample;

            // The following lines all call the same method.
            //sample.Paint(); // Compiler error.
            control.Paint();  // Calls IControl.Paint on SampleClass.
            surface.Paint();  // Calls ISurface.Paint on SampleClass.

            // Output:
            // IControl.Paint
            // ISurface.Paint

        }
    }
}
