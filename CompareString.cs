using System;

class CompareString
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();
        
        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();
        
        int result = string.Compare(str1, str2, StringComparison.Ordinal);
        
        if (result < 0)
            Console.WriteLine("First string is smaller than second string.");
        else if (result > 0)
            Console.WriteLine("First string is greater than second string.");
        else
            Console.WriteLine("Both strings are equal.");
    }
}
