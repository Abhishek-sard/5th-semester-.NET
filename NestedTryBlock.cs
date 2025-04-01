using System;

class NestedTryBlock{
    static void Main(){
        try{
            Console.WriteLine("Outer try block started.");
            try{
                Console.WriteLine("Inner try block startd.");
                int[] numbers = {10,20,30,40,50};
                Console.WriteLine(numbers[5]);
            }
            catch(IndexOutOfRangeException ex){
                Console.WriteLine("Inner catch: Index out of range.");
            }
            int num1 = 1, num2 = 0;
            int result = num1/ num2;
            Console.WriteLine($"Result: {result}");
        }
        catch(DivideByZeroException ex){
            Console.WriteLine("Outer catch : Cannot divide by zero.");
        }
        catch(Exception ex){
            Console.WriteLine($"Outer catch: Unexpected error - {ex.Message}");
        }
        finally{
            Console.WriteLine("Program execution completed.");
        }
    }
}