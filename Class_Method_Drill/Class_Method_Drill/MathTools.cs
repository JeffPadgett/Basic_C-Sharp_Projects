using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Drill
{
    class MathTools
    {
        public int MultiplyByThree(int input)
        {
            int sum = input * 3;
            return sum;

        }

        public int MultiplyByThree(decimal input)
        {

            int sum = Convert.ToInt32(input / 3);
            return sum;
        }

        public int MultiplyByThree(string input)
        {
            int convertedString = Convert.ToInt32(input);
            int sum = convertedString;
            return sum;

        }
    }
}
