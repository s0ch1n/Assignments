namespace ConsoleAppAssignment2nd6F
{
    internal class Program10
    {
        //Entry point
        static void Main(string[] args)
        {
            //Mathematical Operations
            int firstNumber, secondNumber = 0;
            char continueChoice = 'n';
            do
            {

                //get input from the user
                Console.Write("Enter the First Value: ");
                firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the Second Value: ");
                secondNumber = Convert.ToInt32(Console.ReadLine());

                //show the actions
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtration");
                Console.WriteLine("3. Division");
                Console.WriteLine("4. Multiplication");

                //Get choice
                Console.Write("Enter your choice (1-4): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                //Process output
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Sum is: " + (firstNumber + secondNumber));
                        break;
                    case 2:
                        Console.WriteLine("Sub is: " + (firstNumber - secondNumber));
                        break;
                    case 3:
                        Console.WriteLine("Div is: " + (firstNumber / secondNumber));
                        break;
                    case 4:
                        Console.WriteLine("Mul is: " + (firstNumber * secondNumber));
                        break;
                    default:
                        Console.WriteLine("Invalid Choice....!");
                        break;

                }

                Console.WriteLine("Do you want to continue y/n : ");
                continueChoice = Convert.ToChar(Console.ReadLine().ToLower());
                Console.Clear();
            } while (continueChoice == 'y');
            Console.WriteLine("Thank you for using the calculator!");
            // To keep the console window open
            Console.ReadKey();
        }
    }
}
