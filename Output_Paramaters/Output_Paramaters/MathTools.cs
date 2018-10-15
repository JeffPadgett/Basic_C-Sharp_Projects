using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output_Paramaters
{
    class MathTools
    {
        public static void DivTwo (int userInput)
        {
            
           int sum = userInput / 2;
            Console.WriteLine("The result of your entry is: " + sum);
        }

        public static void DivTwo (int userInput, out int storedNumber)
        {
            
            storedNumber = userInput / 2;
            Console.WriteLine("The result of your number is: " + storedNumber);
            
        }
    }
}
