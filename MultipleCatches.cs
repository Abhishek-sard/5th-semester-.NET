using System;

class MultipleCatches{
    static void Main(){
        try{
            Console.Write("Enter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            

            int result = num1/ num2;
            Console.WriteLine($"Result: {result}");

            int[] arr = {1,2,3,};
            Console.WriteLine(arr[5]);
        }
        catch(DivideByZeroException){
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch(FormatException){
            Console.Write("Error: Invalid input. Please enter a number.");
        }
    }
}