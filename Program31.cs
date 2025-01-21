using ConsoleAppAssignment5th3C.Swap;
namespace ConsoleAppAssignment5th3C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instance
            swap numSwap = new swap();

            //Using method
            numSwap.DisplaySwap();

            // To keep the console window open
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }
    }
}
