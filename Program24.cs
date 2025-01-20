namespace ConsoleAppAssignment4th2B
{
    internal class Program
    {
        //To print individual characters of a string in reverse order.
        static void Main(string[] args)
        {
            Console.WriteLine("To print individual characters of a string in reverse order. ");
            //get input from the user
            Console.Write("Enter the string: ");
            string texts = Console.ReadLine();
            
            //To reverse the characters of the string
            for (int i = texts.Length-1; i >= 0; i--)
            {
                Console.WriteLine(texts[i]);
            }
            // To keep the console window open
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
