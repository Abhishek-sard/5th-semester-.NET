using System;

struct Calculator
{
    public static void Calculate(int a, int b, out int sum, out int product) => (sum, product) = (a + b, a * b);
    public static int SumAll(params int[] numbers) => numbers.Length == 0 ? 0 : numbers[0] + SumAll(numbers[1..]);
}

class UsingStruck
{
    static void Main()
    {
        int sum, product;
        Calculator.Calculate(10, 5, out sum, out product);
        Console.WriteLine($"Sum: {sum}, Product: {product}");
        Console.WriteLine($"Total Sum: {Calculator.SumAll(1, 2, 3, 4, 5)}");
    }
}
