namespace ConsoleAppAssignment3rd6F
{
    internal class Program
    {
        //To delete an element at desired position from an array
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
                    if (numList[i] > numList[j])
                    {
                        // Swap the elements
                        int temp = numList[i];
                        numList[i] = numList[j];
                        numList[j] = temp;
                    }
                }
            }
            //To display the sorted elements
            Console.WriteLine("Sorted elements of the array: ");
            for (i = 0; i < size; i++)
            {
                Console.Write(numList[i] + " ");
            }
            //To enter the desired position for deleting the element
            Console.WriteLine("\nEnter the position of the element to be deleted (1-based index): ");
            int position = Convert.ToInt16(Console.ReadLine());

            if (position < 1 || position > size)
            {
                Console.WriteLine("Invalid position! Please enter a value between 1 and " + size);
            }
            else
            {
                // Shift elements to the left to overwrite the element at the given position
                for (i = position - 1; i < size - 1; i++)
                {
                    numList[i] = numList[i + 1];
                }

                size--; // Reduce the size of the array

                Console.WriteLine("Array after deleting the element at position " + position + ": ");
                for (i = 0; i < size; i++)
                {
                    Console.Write(numList[i] + " ");
                }
            }

            // Keep the console window open
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

        }
    }
}
