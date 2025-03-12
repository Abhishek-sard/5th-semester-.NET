using System;

class SimpleIntrest
{
    static void Main()
    {
        Console.WriteLine("Enter the value of P");
        int p = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of T");
        int t = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of R");
        int r = Convert.ToInt32(Console.ReadLine());
        double simpleInterest = (p * t * r) / 100.0;

        Console.WriteLine("The value of Simple interest is:" + simpleInterest);
    }
}