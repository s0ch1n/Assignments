using ConsoleAppAssignment5th4D.Fibonacci;
namespace ConsoleAppAssignment5th4D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instance
            fibonacci fibonacciSeq = new fibonacci();

            //Using method
            fibonacciSeq.DisplayFibonacci();

            // To keep the console window open
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
