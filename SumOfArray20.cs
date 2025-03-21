using System;

class SumOfArray20
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;

        }
        Console.WriteLine($"Sum of array elements: {sum}");

    }
}