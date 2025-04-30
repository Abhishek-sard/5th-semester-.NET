using System;

class IntIndexer
{
    private string[] myData;

    // Constructor
    public IntIndexer(int size)
    {
        myData = new string[size];
        for (int i = 0; i < size; i++)
        {
            myData[i] = "empty";
        }
    }

    // Indexer
    public string this[int pos]
    {
        get
        {
            return myData[pos];
        }
        set
        {
            myData[pos] = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int size = 10;
        IntIndexer myInd = new IntIndexer(size);
        myInd[9] = "some value";
        myInd[3] = "another value";
        myInd[5] = "any value";

        Console.WriteLine("\nIndexer Output\n");

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("myInd[{0}]: {1}", i, myInd[i]);
        }
    }
}
