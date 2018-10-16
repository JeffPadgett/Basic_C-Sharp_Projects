﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    class Employee : Person, IQuittable
    {

        public override void SayName()
        {
            Console.WriteLine("Hello, my name is {0} {1}", firstName, lastName); 
        }

        public void Quit()
        {
            Console.WriteLine("This employee has quit, their information is now removed" );
            this.firstName = "";
            this.lastName = "";
        }
    }
}
