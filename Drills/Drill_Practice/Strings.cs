using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringOne = "This is stringOne";
            string stringTwo = "This is stringTwo";
            string stringThree = "This is stringThree";

            string stringAll = "This is " + stringOne + ", " + stringTwo + ", and " + stringThree + " all in one string";

            Console.WriteLine(" This is a string converted to uppercase : " + stringOne.ToUpper());

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jeff.");
            sb.Append(" I am now adding more onto this string statement.");
            sb.Append(" This is my very first time using a string builder object.");
            sb.Append(" But I am glad that I am taking this course and learning valuable technqiues such as these. ");

            Console.WriteLine(sb);

            Console.ReadLine();

        }
    }
}
