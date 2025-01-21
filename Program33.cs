using ConsoleAppAssignment5th5E.Prime;
namespace ConsoleAppAssignment5th5E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instance
            prime primeCheck = new prime();

            //Using method
            primeCheck.DisplayPrime();

            // To keep the console window open
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
