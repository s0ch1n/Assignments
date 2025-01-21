using System.Security.Principal;
using ConsoleAppAssignment5th1A.Counter;
namespace ConsoleAppAssignment5th1A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instance
            counter counted = new counter();

            //Using method
            counted.DisplayCount();

            // To keep the console window open
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
