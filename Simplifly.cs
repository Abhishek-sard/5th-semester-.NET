using System;

class Simplifly
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the operator (+, -, *, /):");
        char op = Console.ReadLine()[0]; 

        int result = 0;
        switch (op)
        {
            case '+':
                result = a + b;
                Console.WriteLine($"The sum of {a} and {b} is: {result}");
                break;
            case '-':
                result = a - b;
                Console.WriteLine($"The difference between {a} and {b} is: {result}");
                break;
            case '*':
                result = a * b;
                Console.WriteLine($"The product of {a} and {b} is: {result}");
                break;
            case '/':
                if (b != 0)
                {
                    result = a / b;
                    Console.WriteLine($"The division of {a} by {b} is: {result}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid operator. Please enter one of +, -, *, /.");
                break;
        }
    }
}