using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment8th3c
{
    //Can I assign a derived class object to a base class reference? 
    //If yes, then which Read_Data method will be invoked?
    //Answer:
    //Yes, you can assign a derived class object to a base class reference. 
    //This is known as polymorphism.

    //If the Read_Data method is declared as virtual in the base class and override 
    //in the derived class, the derived class's implementation will be invoked. 
    //This is runtime polymorphism.
    //If the Read_Data method is not virtual, the base class's implementation will be 
    //invoked. This is compile-time binding.
    class BaseClasses
    {
        public virtual void Read_Data()
        {
            Console.WriteLine("Base class Read_Data method.");
        }
    }

    class DerivedClasses : BaseClasses
    {
        public override void Read_Data()
        {
            Console.WriteLine("Derived class Read_Data method.");
        }
    }
}
