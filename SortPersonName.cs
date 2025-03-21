using System;

class SortPersonName
{
    static void Main()
    {
        string[] names = new string[10];

        Console.WriteLine("Enter the names of 10 people:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Name {i + 1}: ");
            names[i] = Console.ReadLine();
        }

        Array.Sort(names);

        Console.WriteLine("\nSorted names in ascending order:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(names[i]);
        }
    }
}