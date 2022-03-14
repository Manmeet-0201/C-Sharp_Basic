using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInClassDemo
{
    public class Teacher:AbstractPerson
    {
        public string Subject { get; set; }
        public override float ComputeGradeAverage()
        {
            return 0.0f;
        }
    }
}
