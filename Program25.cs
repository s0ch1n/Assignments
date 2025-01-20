namespace ConsoleAppAssignment4th3C
{
    internal class Program
    {
        //To count the total number of words in a string.
        static void Main(string[] args)
        {
            Console.WriteLine("To count the total number of words in a string");
            //get input from the user
            Console.Write("Enter the string: ");
            string texts = Console.ReadLine();
            int count = 0;
            //To count the words in a string
            for (int i = 0; i<texts.Length; i++)
            {
                if (texts[i] == ' ')
                {
                    count += 1;
                }
                
            }
            // To Display the length of the string
            count += 1;
            Console.WriteLine("The number of words in a string is: " + count);
            // To keep the console window open
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
