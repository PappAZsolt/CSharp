using System;

class Test
{
    static void forEach()
    {
        int[] a = { 10, 20, 30 };
        foreach (int x in a)
            Console.Write(x + " ");
        Console.WriteLine();
        string[] st = { "UNU", "DOI", "TREI" };
        foreach (string s in st)
            Console.Write(s + " ");
    }
    
    static void forGol()
    {
        for (; ; )
            Console.Write("Ciclu infinit!\n");
    }

    static void Main()
    {
        forEach();
        forGol();
    }
}