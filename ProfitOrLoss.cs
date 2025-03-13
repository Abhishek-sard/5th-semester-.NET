using System;

class ProfitOrLoss
{
    static void Main()
    {
        Console.WriteLine("Enter the Cost Price (CP):");
        double cp = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Selling Price (SP):");
        double sp = Convert.ToDouble(Console.ReadLine());

        if (sp > cp)
        {
            double profit = sp - cp;
            Console.WriteLine($"Profit Amount: {profit}");
        }
        else if (cp > sp)
        {
            double loss = cp - sp;
            Console.WriteLine($"Loss Amount: {loss}");
        }
        else
        {
            Console.WriteLine("No Profit, No Loss.");
        }
    }
}