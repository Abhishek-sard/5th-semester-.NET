using System;

class PatternSub
{
    static void Main()
    {
        int[] pattern = {3, 2, 1, 2, 1};

        foreach (int stars in pattern)
        {
            for (int i = 0; i < stars; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
