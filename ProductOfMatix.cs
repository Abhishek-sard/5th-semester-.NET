using System;

class ProductOfMatrix
{
    static void Main()
    {
        int[,] matrix1 = {
            {1,2,3},
            {4,5,6}
        };
        int[,] matrix2 ={
            {7,8},
            {9,10},
            {11,12}
        };
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        if (cols1 != rows2)
        {
            Console.WriteLine("Matrix multiplication not possible:");
            return;
        }
        int[,] product = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                product[i, j] = 0;
                for (int k = 0; k < cols1; k++)
                {
                    product[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }

        }
        Console.WriteLine("product of the matrices:");
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                Console.Write(product[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}