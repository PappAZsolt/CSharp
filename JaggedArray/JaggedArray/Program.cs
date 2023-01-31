using System;

class JagArray
{
    static void Main()
    {
        int[][] a =
        {
            new int[] { 1, 4 },
            new int[] { 5, 9, 0, 7, 2 },
            new int[] { 6, 8, 3 }
        };
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
                Console.Write(a[i][j] + " ");
            Console.WriteLine();
        }
}}