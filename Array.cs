using System;
using System.Linq;

class ArrayInspector
{
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap elements
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] arr, string message)
    {
        Console.WriteLine(message);
        foreach (int num in arr)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // Initialize an example array
        int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

        // Print original array
        PrintArray(numbers, "\nOriginal array:");

        // Create a copy for bubble sort
        int[] bubbleSortArray = (int[])numbers.Clone();
        BubbleSort(bubbleSortArray);
        PrintArray(bubbleSortArray, "\nArray sorted using Bubble Sort:");

        // Using built-in Array.Sort()
        int[] builtInSortArray = (int[])numbers.Clone();
        Array.Sort(builtInSortArray);
        PrintArray(builtInSortArray, "\nArray sorted using Built-in Sort:");

        // Using LINQ OrderBy
        int[] linqSortArray = numbers.OrderBy(x => x).ToArray();
        PrintArray(linqSortArray, "\nArray sorted using LINQ OrderBy:");

        // --- Fruit array example ---
        string[] fruits = { "Apple", "Kiwi", "Mango", "Pineapple", "Fig", "Banana", "Lime", "Grapes", "Guava", "Apricot" };
        var fruitsWithI = fruits.Where(f => f.ToLower().Contains('i')).ToArray();

        Console.WriteLine("\nFruits containing the letter 'i':");
        foreach (var fruit in fruitsWithI)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
} 