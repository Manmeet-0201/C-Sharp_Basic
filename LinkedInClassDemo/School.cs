using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInClassDemo
{
    public class School
    {
        public string SchoolName;
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        private string _twitterAddress;
        public string TwitterAddress
        {
            get { return _twitterAddress; }
            set {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }
                else
                {
                    throw new Exception("the twitter address must begin with @");
                }
            }
        }
        public School()
        {
            Name = "Untitled School";
            PhoneNumber = "555-1234";

        }
        public School(string schoolName,string schoolPhoneNumber)
        {
            Name = schoolName;
            PhoneNumber = schoolPhoneNumber;
        }
        public static float AverageThreeScores(float firstScore,float secondScore,float thirdScore)
        {
            var result = (firstScore + secondScore + thirdScore) / 3;
            return result;

        }
        public static int AverageThreeScores(int firstScore,int secondScore,int thirdScore)
        {
            var result = (firstScore + secondScore + thirdScore) / 3;
            return result;
        }
        public int AddThreeScores(int firstScore, int secondScore, int thirdScore) => firstScore + secondScore + thirdScore;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.Name);
            sb.AppendLine(this.Address);
            sb.AppendLine(this.City);
            sb.Append(", ");
            sb.Append(State);
            sb.Append("  ");
            sb.Append(Zip);
            return sb.ToString();
        }


    }
}
