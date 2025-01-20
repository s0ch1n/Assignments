namespace ConsoleAppAssignment4th4D
{
    internal class Program
    {
        //To compare two strings using string library functions.
        static void Main(string[] args)
        {
            Console.WriteLine("To compare two strings using string library functions ");
            //get input from the user
            Console.Write("Enter the first string: ");
            string text1 = Console.ReadLine();
            Console.Write("Enter the second string: ");
            string text2 = Console.ReadLine();
            //To compare the two strings
            if (text1 == text2)
            {
                Console.WriteLine("The two strings are equal ");
            }
            else 
            {
                Console.WriteLine("The two strings are not equal ");
            }
            // To keep the console window open
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
