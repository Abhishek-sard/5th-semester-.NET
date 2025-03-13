using System;

class DivisibleBy7{
    static void Main(){
        Console.WriteLine("Enter the first number:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int b = Convert.ToInt32(Console.ReadLine());

        if(a/b==7){
            Console.WriteLine("This number is divisible by 7");

        }else{
            Console.WriteLine("This number is not divisible by 7");
        }
    }
}