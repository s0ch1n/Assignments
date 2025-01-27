﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment8th3c
{
    //Is the base class constructor being called when a derived class object is 
    //being created? If yes, in what order?
    //Answer:
    //Yes, the base class constructor is called when a derived class object is 
    //created.The order of constructor calls is as follows:

    //The base class constructor is called first.
    //Then the derived class constructor is called.
    class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("Base class constructor called.");
        }
    }

    class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            Console.WriteLine("Derived class constructor called.");
        }
    }
}
