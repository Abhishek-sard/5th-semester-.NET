using System;

class SumOfArray
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        int sum = 0;
        
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"Sum of array elements: {sum}");
    }
}