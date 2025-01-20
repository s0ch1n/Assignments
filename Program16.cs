namespace ConsoleAppAssignment3rd5E
{
    internal class Program
    {
        //To insert new value in the sorted array list
        static void Main(string[] args)
        {
            // Read the size of the array
            Console.Write("Enter the size of the Array: ");
            int size = Convert.ToInt16(Console.ReadLine());

            int[] numList = new int[size + 1];
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
            Console.WriteLine("Sorted elements of the array: ");
            for (i = 0; i < size; i++)
            {
                Console.Write(numList[i] + " ");
            }
            Console.Write("\n Enter the new value to insert: ");
            int newValue = Convert.ToInt16(Console.ReadLine());

            // Insert the new value into the correct position
            int pos = size; // Assume the new value is the largest
            for (i = 0; i < size; i++)
            {
                if (newValue < numList[i])
                {
                    pos = i;
                    break;
                }
            }

            // Shift elements to the right to make space for the new value
            for (i = size; i > pos; i--)
            {
                numList[i] = numList[i - 1];
            }

            // Insert the new value
            numList[pos] = newValue;
            //To display the result
            Console.WriteLine("Array after inserting the new value: ");
            for (i = 0; i <= size; i++)
            {
                Console.Write(numList[i] + " ");
            }

            // To keep the console window open
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
