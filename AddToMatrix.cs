using System;

class AddToMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rows and columns for the matrices:");
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        // Initialize two matrices
        int[,] matrix1 = new int[rows, cols];
        int[,] matrix2 = new int[rows, cols];
        int[,] resultMatrix = new int[rows, cols];

        // Input for matrix1
        Console.WriteLine("Enter elements for the first matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Element at [{i},{j}]: ");
                matrix1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Input for matrix2
        Console.WriteLine("Enter elements for the second matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Element at [{i},{j}]: ");
                matrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Add the two matrices
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        // Display the result matrix
        Console.WriteLine("Resultant matrix after addition:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(resultMatrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}