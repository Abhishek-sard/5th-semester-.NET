using System;

class AscendingOrder
{
    static void Main()
    {
        Console.WriteLine("Enter the number of elements (n):");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        // Input numbers from the user
        Console.WriteLine($"Enter {n} numbers:");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Sorting the array in ascending order using Bubble Sort
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    // Swap numbers[j] and numbers[j + 1]
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        // Display the sorted array
        Console.WriteLine("Sorted numbers in ascending order:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }
}