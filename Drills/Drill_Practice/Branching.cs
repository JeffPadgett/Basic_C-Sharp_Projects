using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wecome to Package Express. Please follow the instructions below");
            Console.WriteLine("Please enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight >= 50)
            {
                Console.WriteLine("Package too heavy to be shipped by package express, have a good day ");
                
            }
            else
            {
                Console.WriteLine("Please enter the package height: ");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length: ");
                int length = Convert.ToInt32(Console.ReadLine());

                int total = height + length;
                float totalDimensions = (total * 100) / weight;

                if (total >= 50 )
                {
                    Console.WriteLine("Package too big to be shipped" );
                }

                else
                {
                    Console.WriteLine(" Your estimated total for shipping this package is: $" + totalDimensions);
                }
            }
            Console.ReadLine();
        }
    }
}
