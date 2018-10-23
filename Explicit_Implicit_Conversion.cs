using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_Explicit_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // implicit conversion
            int num = 121324;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;

            //------------------------------------


            double myDouble = 13.37;
            int myInt;

            // cast double to int;

            myInt = (int)myDouble; //Explicit Conversion!

            //---------------------------------------

            //typeConversion
            string myString = myDouble.ToString(); //"13.37"   You can do this with doubles, ints, longs, so forth. 
            string challengeString = myFloat.ToString();
            bool sunIsShining = false;
            string myBoolString = sunIsShining.ToString();







        }
    }
}
