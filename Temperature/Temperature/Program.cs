using System;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            Console.WriteLine("Enter your temperature in fahrenheit: ");
            temp = Convert.ToInt32(Console.ReadLine());

            int centigrade = ((temp - 32) * (5 / 9));
            Console.WriteLine("{0} to centigrade = {1}", temp, centigrade);
            Console.ReadLine();
        }
    }
}
