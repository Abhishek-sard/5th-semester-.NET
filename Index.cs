//indexer

using System;
using System.Drawing;
class Indexer
{

    private string [] myData;
    public IntIndexer(int size)
        myData = new String[Size];

    for(int i=0; i<Size; i++){
        myData[i] = "empty";
    }
}

public String this[int pos]
{
    get
    {
        return myData[pos] = Value;
    }
}
static void Main(String[] args{
    int size = 10;
IntIndexer myInd = new IntIndexer(size);
myInd[9] = "some value";
myInd[3] = "another value";
myInd[5] = "any value";

Console.WriteLine("\n Indexer Output \n");

for (int i = 0; i < Size; i++)
{
    Console.WriteLine("myInd[{0}]:{1}", i, myInd[i]);
}
})