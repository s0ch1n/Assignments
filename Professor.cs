using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppAssignment_7thD
{
    // Derived Class: Professor
    public class Professor : PersonName
    {
        public int EmpID { get; set; }
        public string Major { get; set; }

        public Professor(string name, int empID, string major)
            : base(name)
        {
            EmpID = empID;
            Major = major;
        }

        public void Teach()
        {
            Console.WriteLine($"{Name} is teaching in the {Major} department.");
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"EmpID: {EmpID}\nMajor: {Major}");
        }
    }
}
