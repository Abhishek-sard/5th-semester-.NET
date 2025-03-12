using System;

class AreaofRectangle{
    static void Main(){
        Console.WriteLine("Enter the Length value in CM");
        int length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the width value in CM");
        int width = Convert.ToInt32(Console.ReadLine());

        double AreaofRectangle = length * width;
        Console.WriteLine("The area of Rectangle is :" + AreaofRectangle);
    }
}