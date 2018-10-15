using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output_Paramaters
{
    class Program
    {
        static void Main(string[] args)
        {

            int savedNumber;
            Console.WriteLine("Please enter a number. It will be divided by 2.: ");
            int selectedNumber = Convert.ToInt32(Console.ReadLine());
            MathTools.DivTwo(selectedNumber,out savedNumber);
            Console.WriteLine("We are going to store it for you " + savedNumber);
            Console.ReadLine();


        }
    }
}
