using ConsoleAppAssignment5th2B.Additions;
namespace ConsoleAppAssignment5th2B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instance
            Sum adding = new Sum();

            //Using method
            adding.DisplaySum();

            // To keep the console window open
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
