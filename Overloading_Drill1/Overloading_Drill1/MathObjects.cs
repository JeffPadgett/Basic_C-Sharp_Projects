using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Drill1
{
    class MathObjects
    {
        public static void AddUpToFourNums(int x, int y = 0, int z = 0, int a = 0)
        {
            int sum = x + y + z + a;
            Console.WriteLine(sum);
        }
    }
}
