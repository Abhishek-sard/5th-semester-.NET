using System;

class SumOfNumber{
    static void Main(){
        int sum = 0;

        for(int i=5; i<=100; i++){
            sum+=i;
        }
        Console.WriteLine("The sum of number from 5 to 100 is:"+ sum);
    }
}