using System;

class BreakReturn
{
    static void Main()
    {
        Console.WriteLine("Demonstrating 'break', 'continue', and 'return':");

       
        Console.WriteLine("\nUsing 'break' in a loop:");
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                Console.WriteLine("Breaking the loop at i = 5");
                break;
            }
            Console.WriteLine($"i = {i}");
        }

     
        Console.WriteLine("\nUsing 'continue' in a loop:");
        for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
            {
                Console.WriteLine("Skipping i = 3 using 'continue'");
                continue; 
            }
            Console.WriteLine($"i = {i}");
        }

      
        Console.WriteLine("\nUsing 'return' in a method:");
        int result = Multiply(5, 10);
        Console.WriteLine($"Result of multiplication: {result}");
    }

    static int Multiply(int a, int b)
    {
        if (a == 0 || b == 0)
        {
            Console.WriteLine("One of the inputs is zero. Returning 0.");
            return 0; 
        }
        return a * b; 
    }
}