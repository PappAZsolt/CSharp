using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGen = new Random();

            int roll = 0;
            int roll2 = 1;
             int attempts = 0;

            Console.WriteLine("Press enter to roll a die");

            while (roll != roll2)
            {
                Console.ReadKey();
                roll = numberGen.Next(1, 5);
                roll2 = numberGen.Next(1, 5);
                Console.WriteLine("You rolled: " + roll);
                Console.WriteLine("You rolled: " + roll2 + "\n");
                attempts++;
            }

            Console.WriteLine("It took you " + attempts + " attempts");

            Console.ReadKey();
        }
    }
}