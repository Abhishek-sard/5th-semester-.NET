using System;

class AreaofCircle{
    static void Main(){
        int π = 22/7;
        

        Console.WriteLine("Enter the value of radius");
        int r = Convert.ToInt32(Console.ReadLine());

        double Circle = π * r * r;
        Console.WriteLine("The Area of Circle is:" + Circle);
    }
}