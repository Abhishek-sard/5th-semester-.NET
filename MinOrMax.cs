using System;
using System.Linq;

class MinOrMax
{
    static void Main(string[] args)
    {
       
        int[] numbers = { 10, 20, 30, 40, 50 };

       
        Console.WriteLine("Array elements are:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Element at index {i}: {numbers[i]}");
        }

     
        
        int min = numbers[0];  
        int max = numbers[0]; 

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
                min = numbers[i];
            if (numbers[i] > max)
                max = numbers[i];
        }

        Console.WriteLine($"\nMinimum value in array: {min}");
        Console.WriteLine($"Maximum value in array: {max}");



        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
} 
