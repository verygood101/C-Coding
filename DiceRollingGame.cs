using System;

namespace Loops_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Random roll1Random = new Random();
            Random roll2Random = new Random();

            int noOfTries = 0;
            int roll1 = roll2Random.Next(1,7);
            int roll2 = roll1Random.Next(1,7);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press enter to roll dice!");

            // this loop will not work if both values are 0.
            // since the program thinks that both values are 0, so the loop musn't run.
            // u r stupid if u assigning 0 to both values
            // i did roll1 and roll2 equalling to random number
            while(roll1 != roll2)
            {
                Console.ReadKey();

                roll1 = roll1Random.Next(1,7);
                roll2 = roll2Random.Next(1,7);

                Console.WriteLine($"Roll 1: {roll1}");
                Console.WriteLine($"Roll 2: {roll2}");

                noOfTries++;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"That took {noOfTries} turns");


            Console.ReadKey(); 
        }
    }
}
