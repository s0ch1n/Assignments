using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment5th7G
{
    public class DisplayIndividualDigits
    {
        public void DisplayDigits()
        {
            int sum = 0, num = 0;
            Console.Write("Enter the Number: ");
            while (!int.TryParse(Console.ReadLine(), out num) || num < 0)
            {
                Console.Write("Enter a valid Number: ");
            }
            Console.Write("The individual digits are: ");
            DisplayDigits(num);
            Console.WriteLine("\n Enter any key to continue to Menu");
            Console.ReadKey();
            Console.Clear();

        }
        public void DisplayDigits(int num)
        {
            // It Doesn't return until the value of number is 0
            if (num == 0)
            {
                return;
            }
            // Calling the method recursively with the number divided by 10
            DisplayDigits(num / 10);
            // To print the last digit of the number
            Console.Write($" {num % 10}");
        }
    }
}
