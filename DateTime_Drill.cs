using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime thisTime = DateTime.Now;
            Console.WriteLine(thisTime);
            Console.WriteLine("Please enter in a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("It will be " + thisTime.AddHours(userInput) + " in {0} hours",userInput);
            Console.ReadLine();
            

            

        }
    }
}
