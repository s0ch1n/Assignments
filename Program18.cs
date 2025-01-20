namespace ConsoleAppAssignment3rd7G
{
    internal class Program
    {
        //To find the second smallest element in an array
        static void Main(string[] args)
        {
            // Read the size of the array
            Console.Write("Enter the size of the Array: ");
            int size = Convert.ToInt16(Console.ReadLine());

            int[] numList = new int[size];
            int i;
            Console.WriteLine("Enter the Array elements: ");
            // Populate the array with user input
            for (i = 0; i < size; i++)
            {
                numList[i] = Convert.ToInt16(Console.ReadLine());
            }
            // Initialize the smallest and second smallest variables
            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;

            foreach (int num in numList)
            {
                if (num < smallest)
                {
                    secondSmallest = smallest; // Update second smallest
                    smallest = num;           // Update smallest
                }
                else if (num < secondSmallest && num != smallest)
                {
                    secondSmallest = num; // Update second smallest if smaller than current secondSmallest
                }
            }
            //To display the second smallest element
            if (secondSmallest == int.MaxValue)
            {
                Console.WriteLine("There is no distinct second smallest element.");
            }
            else
            {
                Console.WriteLine("The second smallest element is: " + secondSmallest);
            }

            // Keep the console window open
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
