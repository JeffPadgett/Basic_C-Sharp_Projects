using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Drill1
{
    class Program
    {
        static void Main(string[] args)
        {
            MathObjects.AddUpToFourNums(5, 3, 2, 1);
            MathObjects.AddUpToFourNums(2, 19);
            MathObjects.AddUpToFourNums(9);
            MathObjects.AddUpToFourNums(19903, 16);
            Console.ReadLine();
        }
    }
}
