using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    class StringDemoExecutor
    {
        static void Main(string[] args)
        {
            var testString = " aBcdefgh ";
            // Converting string to uppercase
            Console.WriteLine(testString.ToUpper());
            // Converting string to Lowercase
            Console.WriteLine(testString.ToLower());
            // Removing spaces from string
            Console.WriteLine(testString.Trim());
            // Getting the substring from a string
            Console.WriteLine(testString.Substring(4, 6));
            // Getting Length of the string
            Console.WriteLine(testString.Length);
            // Building string with stringbuilder
            var sb = new StringBuilder();
            // Appending new string to stringbuilder
            sb.Append("Hello");
            sb.Append("It was nice to meet you");
            // Appending new string to stringbuilder in new line
            sb.AppendLine("We will meet soon");
            Console.WriteLine(sb.ToString());
            //string formatters
            Console.WriteLine("{0}", testString);
            //parsing strings as numbers
            int result;
            int.TryParse("15,234", out result);
            Console.ReadKey();

        }
    }
}
