using ConsoleAppAssignment5th6F.Adding;
namespace ConsoleAppAssignment5th6F
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instance
            adding addDigit = new adding();

            //Using method
            addDigit.DisplayDigitSum();

            // To keep the console window open
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
