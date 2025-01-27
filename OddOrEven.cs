using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment5th8H
{
    public class OddOrEven
    {
        public void OddEven()
        {
            int start, end;
            Console.WriteLine("Enter the range of numbers to display even and odd numbers");
            Console.Write("Enter the start of the range: ");
            while (!int.TryParse(Console.ReadLine(), out start) || start < 0)
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }
            Console.Write("Enter the end of the range: ");
            while (!int.TryParse(Console.ReadLine(), out end) || end < 0 || end < start)
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }

            Console.WriteLine($"Even numbers between {start} and {end}:");
            PrintEven(start, end);// Call the method to print even numbers

            Console.WriteLine($"\nOdd numbers between {start} and {end}:");
            PrintOdd(start, end);// Call the method to print odd numbers

            Console.WriteLine("\n----------------------------------------------");
            Console.WriteLine("Enter any key to continue to Menu");
            Console.ReadKey();
            Console.Clear();

        }
    

    static void PrintEven(int start, int end)
        {
            // starts only if it is greater than the end
            if (start > end)
            {
                return;
            }
            // To Check if the number is even
            if (start % 2 == 0)
            {
                Console.Write(start + " ");
            }
            PrintEven(start + 1, end);// Recursive call to the method
        }

        static void PrintOdd(int start, int end)
        {
            // starts only if it is greater than the end
            if (start > end)
            {
                return;
            }
            // Check if the number is odd
            if (start % 2 != 0)
            {
                Console.Write(start + " ");
            }
            PrintOdd(start + 1, end);// Recursive call to the method
        }
    }
}
