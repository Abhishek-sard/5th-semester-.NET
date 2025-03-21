using System;

class SortPersonName
{
    static void Main()
    {
        // Array to store 10 names
        string[] names = new string[10];

        Console.WriteLine("Enter the names of 10 people:");

        // Input names from the user
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Name {i + 1}: ");
            names[i] = Console.ReadLine();
        }

        // Sort the names in ascending order
        Array.Sort(names);

        // Display the sorted names
        Console.WriteLine("\nSorted names in ascending order:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(names[i]);
        }
    }
}