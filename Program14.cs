namespace ConsoleAppAssignment3rd3C
{
    internal class Program
    {
        //To separate odd and even integers in separate arrays.

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
            //Declare 2 arrays for storing Odd and Even numbers 
            int[] oddNumbers = new int[size];
            int[] evenNumbers = new int[size];
            int evenCount = 0;
            int oddCount = 0;
            for (i = 0; i < size; i++)
            {
                if (numList[i] %2 == 0)
                {
                    evenNumbers[i] = numList[i];
                    evenCount++;
                }
                else 
                { 
                    oddNumbers[i] = numList[i];
                    oddCount++;
                }
            }

            Console.WriteLine("Even numbers in the array are: ");
            for (i = 0; i < evenCount; i++)
            {
                Console.Write(evenNumbers[i] +" ");
            }
            Console.WriteLine("\n Odd numbers in the array are: ");
            for (i = 0; i < oddCount; i++)
            {
                Console.Write(oddNumbers[i] + " ");
            }

            // To keep the console window open
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
