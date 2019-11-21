using System;

namespace BinaryConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                displayMenu();
                switch(Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Enter your number");
                        Console.WriteLine(binaryToDecimal(Console.ReadLine()));
                        break;
                    case 2:
                        Console.WriteLine("Enter your number");
                        Console.WriteLine(decimalToBinary(Convert.ToInt32(Console.ReadLine())));
                        break;
                    case 3:
                        Console.WriteLine("Enter your number");
                        Console.WriteLine(binaryToHexadecimal(Console.ReadLine()));
                        break;
                    case 4:
                        Console.WriteLine("Enter your number");
                        Console.WriteLine(hexadecimalToBinary(Console.ReadLine()));
                        break;
                    default:
                        break;
                    
                }
                

            }
            Console.ReadLine();


            String decimalToBinary(int value)
            {
                return Convert.ToString(value, 2);
            }

            int binaryToDecimal(String value)
            {
                return Convert.ToInt32(value, 2);
            }

            String binaryToHexadecimal(String value)
            {
                return Convert.ToInt32(value, 2).ToString("X");
            }

            String hexadecimalToBinary(String value)
            {
                return Convert.ToString(Convert.ToInt32("FF", 16), 2);
            }

            void displayMenu()
            {
                Console.WriteLine("");
                Console.WriteLine("Which function would you like to use?");
                Console.WriteLine("(1) Binary -> Decimal");
                Console.WriteLine("(2) Decimal -> Binary");
                Console.WriteLine("");
                Console.WriteLine("(3) Binary -> Hexadecimal");
                Console.WriteLine("(4) Hexadecimal -> Binary");
                Console.WriteLine("");
            }
        }
    }
}
