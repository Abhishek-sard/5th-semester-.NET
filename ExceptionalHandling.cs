using System;

class ExceptionHandlingDemo{
    static void Main(){
        try{
            Console.Write("Enter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1/num2;
            Console.WriteLine($"Result: {result}");
        }
        catch(DivideByZeroException ex){
            Console.WriteLine("Error: Cannot devide by zero.");
        }
        catch(FormatException ex){
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
        finally{
            Console.WriteLine("Execution completed.");
        }
    }
}