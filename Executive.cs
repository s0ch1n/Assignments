using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssigment7thC
{
    // Derived class: Executive
    public class Executive : Employee
    {
        public Executive(int employeeNo, string name, string designation, double basicPay)
            : base(employeeNo, name, designation, basicPay)
        {
            if (basicPay <= 10000)
            {
                Console.Write("Basic pay for an Executive must be greater than Rs.10,000.");
            }
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("Executive Details:");
            base.DisplayDetails();
        }
    }
}
