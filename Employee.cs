using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssigment7thC
{
    
    // Base class: Employee
    public class Employee
    {
        public int EmployeeNo { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public double BasicPay { get; set; }

        public Employee(int employeeNo, string name, string designation, double basicPay)
        {
            EmployeeNo = employeeNo;
            Name = name;
            Designation = designation;
            BasicPay = basicPay;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Employee No: {EmployeeNo}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Designation: {Designation}");
            Console.WriteLine($"Basic Pay: {BasicPay:C}");
        }
    }
}
