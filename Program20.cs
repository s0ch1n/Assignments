using System.Drawing;

namespace ConsoleAppAssignment3rd9I
{
    internal class Program
    {
        //Multiplication of two square matrices 
        static void Main(string[] args)
        {
            // Get the number of rows and columns of the matrix from the user
            Console.WriteLine("Enter the same number for rows and columns  ");
            Console.Write("Enter the number of rows: ");
            int rows = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int columns = Convert.ToInt16(Console.ReadLine());

            // Declaring two matrices and the result matrix
            int[,] matrix1 = new int[rows, columns];
            int[,] matrix2 = new int[rows, columns];
            int[,] resultMatrix = new int[rows, columns];

            // Get values for the first matrix
            Console.WriteLine("Enter the elements of the first matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Element [{i + 1},{j + 1}]: ");
                    matrix1[i, j] = Convert.ToInt16(Console.ReadLine());

                }
            }

            // Get values for the second matrix
            Console.WriteLine("Enter the elements of the second matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Element [{i + 1},{j + 1}]: ");
                    matrix2[i, j] = Convert.ToInt16(Console.ReadLine());

                }
            }

            // Perform matrix multiplication
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    resultMatrix[i, j] = 0; // Initialize result cell
                    for (int k = 0; k < rows; k++)
                    {
                        resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            // Display the result matrix
            Console.WriteLine("\nThe result after addition of two matrices is:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(resultMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
