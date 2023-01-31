using System;

enum Note
{
    Mate = 10,
    Info = 9,
    Romana = 8
}

class TestEnum
{
    static void Main()
    {
        Console.Write("mate: {0}\ninfo: {1}\nromana: {2}", (int)Note.Mate, (int)Note.Info, (int)Note.Romana);
    }
}