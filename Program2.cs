namespace ConsoleAppAssignment2B
{
    internal class Program
    {
        //Entry point
        static void Main(string[] args)
        {
            int number, width;
            //Number as input
            Console.Write("Enter the number: ");
            int.TryParse(Console.ReadLine(), out number);
            //Width as input
            Console.Write("Enter the Width: ");
            int.TryParse(Console.ReadLine(), out width);
            //To generate the triangle pattern
            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            
            }
            // To Keep the console window open
            Console.ReadKey();

        }
    }
}
