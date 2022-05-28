using System;

namespace UH 
{
    class Program
    {
        static void Main(string[] args)
        {
            // || is 'or' operator
            // && is 'and' operator

            // this is a simple c# maths game

            Console.Title = "Simple Math Game!"; // sets title of console
            
            Console.WriteLine("(8*2)/2 = ?"); // first question
            int answer1 = Convert.ToInt32(Console.ReadLine());
            if (answer1 == 8)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }


            Console.WriteLine("(8+6+7) * 2 = ?"); //second question
            int answer2 = Convert.ToInt32(Console.ReadLine());
            if (answer2 == 42)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }

            Console.WriteLine("15 + 2 * 2"); // Last question
            int answer3 = Convert.ToInt32(Console.ReadLine());
            if (answer3 == 19)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }

            Console.Write("Well done!");
            Console.ReadLine();

        }
    }
}
