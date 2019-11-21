using System;

namespace AverageArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your ten numbers: ");
            int[] integers = new int[10];

            int total = 0;

            for (int i = 0; i < 10; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());

                integers[i] = input;
                total = total + input; 
            }

            int average = total / 10;
            int less = 0;

            for (int i = 0; i < 10; i++)
            {
                if (integers[i] < average)
                {
                    less++;
                }
            }

            Console.WriteLine("Average is " + average);
            Console.WriteLine("Numbers less than average is " + less);
            Console.ReadLine();
        }
    }
}