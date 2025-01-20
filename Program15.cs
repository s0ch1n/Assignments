namespace ConsoleAppAssignment3rd4D
{
    internal class Program
    {
        //To sort the array elements in descesnding order.
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
            // Sorting logic using indices
            for (i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (numList[i] < numList[j])
                    {
                        // Swap the elements
                        int temp = numList[i];
                        numList[i] = numList[j];
                        numList[j] = temp;
                    }
                }
            }
            //To display the sorted elements
            Console.WriteLine("Sorted elements of the array in descending order: ");
            for (i = 0; i < size; i++)
            {
                Console.Write(numList[i] + " ");
            }

            // To keep the console window open
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
