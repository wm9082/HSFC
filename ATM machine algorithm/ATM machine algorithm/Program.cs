using System;

namespace ATM_machine_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int month;
            Console.WriteLine("Please input the number of your month");
            month = Convert.ToInt32(Console.ReadLine());
            if((month==4)|(month==9))
            { Console.WriteLine("30 days")}
        }
    }
}
