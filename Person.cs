using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment_7thD
{
    // Base Class: PersonName
    public class PersonName
    {
        public string Name { get; set; }

        public PersonName(string name)
        {
            Name = name;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }

}
