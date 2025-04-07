using System;

class Pattern
{
    static void Main()
    {
        int[] starsPerLine = {1, 2, 1, 2, 3};

        foreach (int count in starsPerLine)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
