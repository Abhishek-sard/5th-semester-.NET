using System;

class DivisibleBy5and10{
    static void Main(){
        Console.WriteLine("Enter the first number:");
        int a = Convert.ToInt32(Console.ReadLine());
        

        if(a % 5 == 0 && a % 10 == 0){
            Console.WriteLine("This number is  divisible by 5 and 10");

        }else if(a % 5==0){
            Console.WriteLine("This number is  divisible by 5");
        }else if(a% 10 ==0){
            Console.WriteLine("This number is divisible by 10");
        }else {
            Console.WriteLine("The number is not divisible by 5 and 10");
        }
    }
}