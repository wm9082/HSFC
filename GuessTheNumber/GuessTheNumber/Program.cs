using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int intNumber, intGuess, intCount = 0;
            intNumber = rnd.Next(1, 11);

            do {
                Console.WriteLine("Enter your guess between 1 and 10");
                intGuess = Convert.ToInt32(Console.ReadLine());
                intCount += 1;

                if (intGuess > intNumber)
                {
                    Console.WriteLine("Guess is too high.");
                }
                if (intGuess < intNumber)
                {
                    Console.WriteLine("Guess is too low.");
                }
                if (intGuess == intNumber)
                {
                    Console.WriteLine("You got it in {0} guesses!", intCount);
                }
            } while (intGuess != intNumber);

            Console.ReadLine();
        }
    }
}
