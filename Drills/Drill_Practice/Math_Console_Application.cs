using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an input, and I will multiply it by 50: ");
            string numberMultiply = Console.ReadLine();
            int sum = Convert.ToInt32(numberMultiply) * 50;
            Console.WriteLine("Your number is : " + sum);

            Console.WriteLine("Enter a number and I will add 25 to it: ");
            string numberAdd = Console.ReadLine();
            int addSum = Convert.ToInt32(numberAdd) + 25;
            Console.WriteLine("Your number is : " + addSum);

            Console.WriteLine("Enter a number and I will divide it by 12.5: ");
            string numberDivide = Console.ReadLine();
            double divideSum = Convert.ToDouble(numberDivide) / 12.5;
            Console.WriteLine("Your number is : " + divideSum);

            Console.WriteLine("Enter a number and I will check if it is greater than 50: ");
            string numberCheck = Console.ReadLine();
            bool checkSum = Convert.ToInt32(numberCheck) >= 50;
            Console.WriteLine("Your number is : " + Convert.ToString(checkSum));

            Console.WriteLine("Enter a number and I will divide it by 7 and give you the remainder : ");
            string numberRemainder = Console.ReadLine();
            int remainderSum = Convert.ToInt32(numberRemainder) % 7;
            Console.WriteLine("Your remainder is : " + remainderSum);
            Console.ReadLine();

        }
    }
}
