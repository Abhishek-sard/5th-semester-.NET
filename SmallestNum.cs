using System;

class SmallestNumber{
    static void Main(){
        Console.WriteLine("Enter the first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if(num1<num2){
            Console.WriteLine($"{num1} is the Smallest number.");

        }else if(num2<num1){
            Console.WriteLine($"{num2} is the Smallest number.");

        }else{
            Console.WriteLine("Both number are equal.");
        }
    }
}