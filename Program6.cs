namespace ConsoleAppAssignment2nd1A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eligibility check for Vote");
            Console.Write("Enter the age of candidate: ");
            int userAge;

            while (!int.TryParse(Console.ReadLine(), out userAge))
            {
                Console.Write("Invalid input. Please enter a valid age: ");
            }

            if (userAge>=18)
            {
                Console.WriteLine("Candidate is eligible for vote");
            }
            else
            {
                Console.WriteLine("Candidate is not eligible for vote");
            }

            // To keep the console window open
            Console.ReadKey();
        }
    }
}
