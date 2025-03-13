using System;

class DivisibleBy7Not13
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 7 == 0 && number % 13 != 0)
        {
            Console.WriteLine("This number is divisible by 7 but not by 13.");
        }
        else
        {
            Console.WriteLine("This number does not meet the condition (divisible by 7 but not by 13).");
        }
    }
}