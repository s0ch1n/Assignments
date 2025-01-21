namespace ConsoleAppAssignment4th6F
{
    internal class Program28
    {
        //To extract a substring from a given string.
        static void Main(string[] args)
        {
            Console.WriteLine("To extract a substring from a given string");
            //get input from the user
            Console.Write("Enter the string: ");
            string texts = Console.ReadLine();

            // Getting starting position of the substring
            Console.Write("Enter the starting position (0 - based index): ");
            int startPosition;

            //validating
            while (!int.TryParse(Console.ReadLine(), out startPosition) || startPosition < 0 || startPosition >= texts.Length)
            {
                Console.WriteLine("Invalid input! Please enter a valid starting position within the string range.");
            }

            // Getting starting length of the substring

            Console.Write("Enter the length of the substring: ");
            int length;

            //validating
            while (!int.TryParse(Console.ReadLine(), out length) || length < 0 || startPosition + length > texts.Length)
            {
                Console.WriteLine("Invalid input! Please enter a valid length.");
            }

            // Extract substring
            char[] substring = new char[length];
            for (int i = 0; i < length; i++)
            {
                substring[i] = texts[startPosition + i];
            }

            // Displaying the result
            Console.Write("Extracted Substring: ");
            foreach (char sub in substring)
            {
                Console.Write(sub);
            }

            // To keep the console window open
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
