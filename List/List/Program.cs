using System;
using System.Collections.Generic;

namespace Program
{
    class Project
    {
        static void Main()
        {
            int number;
            Console.Write("How many students are in your class: ");
            number =  Convert.ToInt32(Console.ReadLine());
            string[] kids = new string[number];

            for (int i = 0; i < number; i++)
            {
                kids[i] = Console.ReadLine();
            }
            
            Array.Sort(kids);
            Console.WriteLine();

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(kids[i]);
            }


        }
    }
}