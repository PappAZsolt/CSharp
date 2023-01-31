using System;

public class GoTo
{
    static void Main()
    {
        int x = 1;
    repeta:
        Console.Write(x + " ");
        x++;
        if (x <= 5)
            goto repeta;
        Console.WriteLine();
    }
}