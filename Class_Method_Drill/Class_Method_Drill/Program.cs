using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            MathTools variableNumber = new MathTools();
            int storedNumber = 12;
            storedNumber = variableNumber.MultiplyByThree(storedNumber);
            Console.WriteLine(storedNumber);
            Console.ReadLine();

            MathTools decNumber = new MathTools();
            decimal storedDec = 12.20m;
            storedDec = decNumber.MultiplyByThree(storedDec);
            Console.WriteLine(storedDec);
            Console.ReadLine();

            MathTools addSix = new MathTools();
            string stringNumber = "10";
            int processedNumber;
            processedNumber = addSix.MultiplyByThree(stringNumber);
            Console.WriteLine(processedNumber);
            Console.ReadLine();
        }
    }
}
