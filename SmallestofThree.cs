using System;

class SmallestOfThree
{
    static void Main()
    {
       
        Console.WriteLine("Enter the first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

       
        Console.WriteLine("Enter the second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

       
        Console.WriteLine("Enter the third number:");
        int num3 = Convert.ToInt32(Console.ReadLine());

        
        if (num1 < num2 && num1 < num3)
        {
            Console.WriteLine($"{num1} is the smallest number.");
        }
        else if (num2 < num1 && num2 < num3)
        {
            Console.WriteLine($"{num2} is the smallest number.");
        }
        else if (num3 < num1 && num3 < num2)
        {
            Console.WriteLine($"{num3} is the smallest number.");
        }
        else
        {
            Console.WriteLine("All numbers are equal.");
        }
    }
}