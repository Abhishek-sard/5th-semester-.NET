using System;

class PrimeOrNot{
    static void Main(){

        Console.WriteLine("Enter the number:");
        int number = int.Parse(Console.ReadLine());

        if(IsPrime(number)){
            Console.WriteLine($"{number} is a prime number.");

        }else{
            Console.WriteLine($"{number} is not a prime number.");
        }


    }
    static bool IsPrime(int n){
        if(n<2){
            return false;
        }

        for(int i =2; i<=Math.Sqrt(n); i++){
            if(n% i ==0){
                return false;
            }
        }
        return true;
    }
}