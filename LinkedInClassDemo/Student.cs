using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInClassDemo
{
    public class Student:AbstractPerson
    {
        public enum GradeLevels { Freshman,Sophomore,Junior,Senior}
        public GradeLevels GradeLevel { get; set; }
        public override float ComputeGradeAverage()
        {
            return 4.0f;
        }
        public override string SendMessage(string message)
        {
            var original = base.SendMessage(message);
            var sb = new StringBuilder();
            sb.AppendLine("This message is private and confidential.");
            return sb.ToString();
        }
    }
}
