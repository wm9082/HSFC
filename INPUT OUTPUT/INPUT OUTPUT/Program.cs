using System;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            int first;
            int second;
            int third;

            Console.WriteLine("Calculating sum, please proceed to enter your three numbers");

            first = Convert.ToInt32(Console.ReadLine());
            second = Convert.ToInt32(Console.ReadLine());
            third = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("The sum of the numbers is: " + (first + second + third));
            Console.WriteLine("Your average test marks are: " + ((first + second + third) / 3));
            Console.WriteLine("Volume in litres: " + ((first * second * third) / 1000));
            Console.WriteLine("Volume in gallons: " + ((first * second * third) / 1000) * 4.546);
            Console.ReadLine();
        }
    }
}
