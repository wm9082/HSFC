using System;

namespace Multiplication_game
{
    class Program
    {
        class Utilities
        {
            public Random rnd = new Random();

            public void displayMenu()

            {
                Console.WriteLine("What would you like to do now? ");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Division");
                Console.WriteLine("4. Multiplication");
                Console.WriteLine("5. Change Level");
                Console.WriteLine("6. See your score");
                Console.WriteLine("7. Exit the program.");
                Console.WriteLine("");
            }
        }

        static void Main(string[] args)
        {
            Utilities Myutils = new Utilities();
            Myutils.displayMenu();
            int points = 0;
            for (int count = 0; count < 100; count++)
            {
                Console.WriteLine("Enter your choice");

                int choice = Convert.ToInt32(Console.ReadLine());
                Random rnd = new Random();
                int first = rnd.Next(1, 10);
                int second = rnd.Next(1, 10);
                switch (choice)

                {

                    case 1:
                        int answer = first + second;
                        Console.WriteLine(" What is the product of {0} + {1}?", first, second);
                        if (Convert.ToInt32(Console.ReadLine()) == answer)
                        {
                            Console.WriteLine("Well done that is correct + 1!");
                            points++;
                        }
                        else
                        {
                            Console.WriteLine("Wrong answer");
                        }
                        break;

                    case 2:
                        int subanswer = first - second;
                        Console.WriteLine(" What is the product of {0} - {1}?", first, second);
                        if (Convert.ToInt32(Console.ReadLine()) == subanswer)
                        {
                            Console.WriteLine("Well done that is correct + 1!");
                            points++;
                        }
                        else
                        {
                            Console.WriteLine("Wrong answer");
                        }
                        break;

                    case 3:
                        int divanswer = first / second;
                        Console.WriteLine(" What is the product of {0} / {1}?", first, second);
                        if (Convert.ToInt32(Console.ReadLine()) == divanswer)
                        {
                            Console.WriteLine("Well done that is correct + 1!");
                            points++;
                        }
                        else
                        {
                            Console.WriteLine("Wrong answer");
                        }
                        break;

                    case 4:
                        int mulanswer = first * second;
                        Console.WriteLine(" What is the product of {0} * {1}?", first, second);
                        if (Convert.ToInt32(Console.ReadLine()) == mulanswer)
                        {
                            Console.WriteLine("Well done that is correct + 1!");
                            points++;
                        }
                        else
                        {
                            Console.WriteLine("Wrong answer");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Which skill level would you like to play 1-10");
                        Console.ReadLine();



                        break;
                    case 6:
                        Console.WriteLine("Well done you scored {0} points", points);
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("Closing program now");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Illegal option entered");
                        break;
                }
            }    
        }
    }
}
