using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment8th2b
{
    internal class MathInterface
    {
        private MathOperations math;

        public MathInterface()
        {
            math = new MathOperations();
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\nChoose an operation:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                try
                {
                    Console.Write("Enter your choice: ");
                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 5)
                    {
                        Console.WriteLine("Exiting the program.");
                        break;
                    }

                    if (choice < 1 || choice > 4)
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                        continue;
                    }

                    Console.Write("Enter the first number: ");
                    double a = double.Parse(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    double b = double.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine($"Result: {math.Add(a, b)}");
                            break;
                        case 2:
                            Console.WriteLine($"Result: {math.Subtract(a, b)}");
                            break;
                        case 3:
                            Console.WriteLine($"Result: {math.Multiply(a, b)}");
                            break;
                        case 4:
                            try
                            {
                                Console.WriteLine($"Result: {math.Divide(a, b)}");
                            }
                            catch (DivideByZeroException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter numbers only.");
                }
            }
        }
    }
}
