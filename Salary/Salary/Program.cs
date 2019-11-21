using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours;
            Double pay;
            Double gpay = 0;

            Console.WriteLine("Enter the number of hours worked this week");
            hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your hourly rate of pay");
            pay = Convert.ToInt32(Console.ReadLine());
            if (0 > hours || hours > 60)
            {
                Console.WriteLine("It is not in the hours worked range");
            } else
            {
                gpay = hours * pay;
            }

            if (hours > 40)
            {
                gpay = gpay + (hours - 40) * (1.5 * pay);
            }

            Console.WriteLine("Pay: " + Convert.ToString(gpay));
            Console.ReadLine();
        }
    }
}
