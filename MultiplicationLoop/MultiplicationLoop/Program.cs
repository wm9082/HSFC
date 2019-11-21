using System;

namespace MultiplicationLoop
{
    class Program
    {
        enum Operator {Addition, Subtraction, Multiplication, Division, Modulas}
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int level = 1;
            int score = 0;

            bool cont = true;
            while (cont) {
                displayMenu();

                int first = getNumber();
                int second = getNumber();

                Console.WriteLine("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        processChoice(Operator.Addition, first, second);
                        break;
                    case 2:
                        processChoice(Operator.Subtraction, first, second);
                        break;
                    case 3:
                        processChoice(Operator.Division, first, second);
                        break;
                    case 4:
                        processChoice(Operator.Multiplication, first, second);
                        break;
                    case 5:
                        processChoice(Operator.Modulas, first, second);
                        break;
                    case 6:
                        Console.WriteLine("Skill level 1 (Numbers 1 to 10) or level 2 (Numbers 1 - 100)?");
                        level = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("Your current score is {0}.", score);
                        break;
                    case 8:
                        Console.WriteLine("Exiting the program...");
                        cont = false;
                        break;
                    default:
                        break;
                }
            }

            int getNumber()
            {
                if (level == 2) return rnd.Next(1, 100);
                else return rnd.Next(1, 10);
            }

            void displayMenu()
            {
                Console.WriteLine(" ");
                Console.WriteLine("What would you like to do now? ");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Division");
                Console.WriteLine("4. Multiplication");
                Console.WriteLine("5. Modulas");
                Console.WriteLine("6. Change Skill Level");
                Console.WriteLine("7. See your current score");
                Console.WriteLine("8. Exit the program.");
                Console.WriteLine(" ");
            }

            int getAnswer(Operator op, int num1, int num2)
            {
                if (op == Operator.Addition) return num1 + num2;
                else if (op == Operator.Subtraction) return num1 - num2;
                else if (op == Operator.Multiplication) return num1 * num2;
                else if (op == Operator.Division) return num1 / num2;
                else return num1 % num2;
            }

            char getSymbol(Operator op)
            {
                if (op == Operator.Addition) return '+';
                else if (op == Operator.Subtraction) return '-';
                else if (op == Operator.Multiplication) return '*';
                else if (op == Operator.Division) return '/';
                else return '%';
            }

            void processChoice(Operator op, int first, int second)
            {
                Console.WriteLine("What is {0} {1} {2}?", first, getSymbol(op), second);
                if (Convert.ToInt32(Console.ReadLine()) == getAnswer(op, first, second))
                {
                    Console.WriteLine("Correct! +1 point");
                    score++;
                }
                else Console.WriteLine("Incorrect!");
            }
        }
    }
}