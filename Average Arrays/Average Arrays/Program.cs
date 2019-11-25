using System;

namespace Average_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert your ten numbers.");
            int[] integers = new int[10];
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                int input = (Convert.ToInt32(Console.ReadLine()));

                integers[i] = input;

                total = total + input;
            }
            int average = total / 10;
            int lower = 0;
            for (int i = 0; i < 10; i++)
            {
                if (integers[i] < average)
                {
                    lower++;
                }
            }
            Console.WriteLine("The mean of your numbers is {0}.", average);
            Console.WriteLine("The amount of numbers less than your avergae is " + lower);
            Console.ReadLine();
        }
    }
}
