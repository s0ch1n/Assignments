using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppAssignment_7thD
{
    // Derived Class: Student
    public class Student : PersonName
    {
        public int StudentID { get; set; }
        public string Major { get; set; } // Differentiates between Graduate and Post Graduate

        public Student(string name, int studentID, string major)
            : base(name)
        {
            StudentID = studentID;
            Major = major;
        }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying in the {Major} program.");
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Student ID: {StudentID}\nMajor: {Major}");
        }
    }

}
