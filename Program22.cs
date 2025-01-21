namespace ConsoleAppAssignment3rd11K
{
    internal class Program22
    {
        //Bubble sort
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
            // Sorting logic using bubble sort
            for (i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (numList[j] > numList[j + 1])
                    {
                        // Swap the elements
                        int temp = numList[j];
                        numList[j] = numList[j+1];
                        numList[j+1] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted elements of the array using bubble sort: ");
            for (i = 0; i < size; i++)
            {
                Console.Write(numList[i] + " ");
            }
        }
    }
}
