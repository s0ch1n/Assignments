namespace ConsoleAppAssignment4D
{
    internal class Program
    {
        //Entry point
        static void Main(string[] args)
        {
            Console.Write("To display certain values for function x = y^2 + 2y + 1");
            //iterates the value of y from -5 to 5
            for (int y = -5; y <= 5; y++)
            {
                //calculates the function
                int x = (y ^ 2) + (2 * y) + 1;
                //Display the corresponding values
                Console.Write($"\nFor y = {y}, x = {x}");
            }
            // To Keep the console window open
            Console.ReadKey();
        }
    }
}
