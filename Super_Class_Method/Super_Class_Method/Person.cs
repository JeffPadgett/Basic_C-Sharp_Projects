﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Class_Method
{
    class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public void SayName ()
        {
            Console.WriteLine("Name: {0} {1}",firstName,lastName);
        }
    }
}
