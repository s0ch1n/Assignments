namespace ConsoleAppAssignment4th5E
{
    internal class Program
    {
        //To count the total number of alphabets, digits and special characters in a string.
        static void Main(string[] args)
        {
            Console.WriteLine("To count the total number of alphabets, digits and special characters in a string");
            //get input from the user
            Console.Write("Enter the string: ");
            string texts = Console.ReadLine();
            int countAlphab = 0;
            int countNumber = 0;
            int countSpecialChar = 0;
            //To count the number of alphabets, digits and special characters in a string
            for (int i = 0; i < texts.Length; i++)
            {
                if ((texts[i] >= 'a' && texts[i] <= 'z')||(texts[i] >= 'A' && texts[i] <= 'Z'))
                {
                    countAlphab += 1;
                }
                else if (texts[i] >= '0' && texts[i] <= '9')
                    { 
                        countNumber += 1;
                    }
                else if (texts[i] != ' ')
                {
                    countSpecialChar += 1;
                }

            }
            // To Display the number of alphabets, digits and special characters in a string
            Console.WriteLine("The number of Alphabets in the string is: " + countAlphab);
            Console.WriteLine("The number of Digits in the string is: " + countNumber);
            Console.WriteLine("The number of Special Characters in the string is: " + countSpecialChar);
            // To keep the console window open
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
