using System;

namespace Number_Game_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int Number;
            int Guess;
            

            Number = rnd.Next(0, 101);
            do
            {
                Console.WriteLine("Please enter your guess between 1 and 100");
                Guess = Convert.ToInt32(Console.ReadLine());
                if (Guess > Number) 

                {
                    Console.WriteLine("Too High, try again");
                }

                if (Guess < Number) 

                {
                    Console.WriteLine("Too Low, try again.");
                }
            } while (Guess != Number);


            Console.WriteLine("Well done that is correct");
            Console.ReadLine();

        }
    }
}
