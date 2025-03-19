using System;

class Factorial
{
    static void Main()
    {
        Console.Write("Enter a number to find its factorial: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
        else
        {
            long factorial = CalculateFactorial(number);
            Console.WriteLine($"The factorial of {number} is: {factorial}");
        }
    }

    static long CalculateFactorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1; // Base case: 0! and 1! are both 1
        }

        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}