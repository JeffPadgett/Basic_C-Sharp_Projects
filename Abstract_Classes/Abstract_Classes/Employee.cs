using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    class Employee : Person
    {

        public override void SayName()
        {
            Console.WriteLine("Hello, my name is {0} {1}", firstName, lastName); 
        }
    }
}
