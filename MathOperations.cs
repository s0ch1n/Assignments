using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment8th2b
{
    public class MathOperations
    {
        
        // Returns the sum of two numbers.
        
        public double Add(double a, double b)
        {
            return a + b;
        }

      
        // Returns the difference between two numbers.
       
        public double Subtract(double a, double b)
        {
            return a - b;
        }

    
        // Returns the product of two numbers.
    
        public double Multiply(double a, double b)
        {
            return a * b;
        }

     
        // Returns the division of two numbers. Throws an exception if division by zero is attempted.
       
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return a / b;
        }
    }
}
