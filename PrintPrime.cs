//print prime number form 1 to 100
using System;
class PrintPrime{
    static void Main(){
        int i, num, count;

        //checking for prime number
        for(num =1; num<=100; num++){
            count = 0;
            for(i =2; i<=num/2;i++){
                if(num % i ==0){
                    count++;
                    break;
                }
            }
            //checking and printing prime number
            if(count == 0 && num!=1){
                Console.WriteLine("%d\n",num);
            }
        }

    }
}