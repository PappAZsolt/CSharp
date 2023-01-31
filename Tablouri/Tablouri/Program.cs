using System;

class TabBidim
{
    static void Main()
    {
        int[,] x;
        x = new int[,] { { 1, 2, 3 }, { 2, 3, 0 } };
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write(x[i, j] + " ");
            Console.WriteLine();
        }
    }
}