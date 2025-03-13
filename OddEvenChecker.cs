using System;

class OddEvenChecker{
    static void Main(){
        Console.WriteLine("Enter the first number:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int b = Convert.ToInt32(Console.ReadLine());

        if(a/b==0){
            Console.WriteLine("It is an Even number");

        }else{
            Console.WriteLine("It is an odd number");
        }
    }
}