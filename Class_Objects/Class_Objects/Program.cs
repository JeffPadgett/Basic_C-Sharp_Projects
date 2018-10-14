using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number to perform math operations on");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MathTools.addSix(userInput));
            Console.WriteLine(MathTools.multiplyByEight(userInput));
            Console.WriteLine(MathTools.divideByTwo(userInput));
            Console.ReadLine();

        }
    }
}
