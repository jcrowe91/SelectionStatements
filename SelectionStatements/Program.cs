using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets play a game! Choose a number 1-100!");
            int userInput = int.Parse(Console.ReadLine());

            var r = new Random();
            var favNumber = r.Next(1, 100);

            if (userInput < favNumber)
            {
                Console.WriteLine("Too Low!");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("Correct!");
            }

            Console.WriteLine($"The answer was {favNumber}!");


        }
    }
}
