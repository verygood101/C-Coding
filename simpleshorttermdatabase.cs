using System;

namespace Array_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("How many students do you have?");

            int noOfStudents = Convert.ToInt32(Console.ReadLine());

            string[] studentNames = new string[noOfStudents];


            Console.WriteLine("Please enter the name of the students:");
            for(int i = 0; i < studentNames.Length; i++)
            {
                studentNames[i] = Console.ReadLine();
            }


            Console.WriteLine("-------------");
            Array.Sort(studentNames);

            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Here they are alphabetically");

            for(int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine(studentNames[i]);
            }

            // waits before closing 
            Console.ReadKey();
        }
    }
}
