using System;

class Multiplication
{
    static void Main()
    {
        int start = 1;
        int end = 10;

        Console.WriteLine("Multiplication Table from 1 to 10:");

        // Print the header row
        Console.Write("   |");
        for (int i = start; i <= end; i++)
        {
            Console.Write($"{i,4}");
        }
        Console.WriteLine();
        Console.WriteLine(new string('-', 4 * (end + 1)));

        // Generate the multiplication table
        for (int i = start; i <= end; i++)
        {
            Console.Write($"{i,2} |");
            for (int j = start; j <= end; j++)
            {
                Console.Write($"{i * j,4}");
            }
            Console.WriteLine();
        }
    }
}