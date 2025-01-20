using System.ComponentModel.DataAnnotations;

namespace ConsoleAppAssignment4th1A
{
    internal class Program
    {
        //find the length of a string without using library function.
        static void Main(string[] args)
        {
            Console.WriteLine("To find the length of a string ");
            //get input from the user
            Console.Write("Enter the string: ");
            string texts = Console.ReadLine();
            int count = 0;
            //To count the characters of the string
            foreach (char text in texts)
            {
                count += 1;
            }
            // To Display the length of the string

            Console.WriteLine("The length of the entered string is: " + count);
            // To keep the console window open
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
