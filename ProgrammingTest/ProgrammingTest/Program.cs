using System;

namespace ProgrammingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int weight = 0;
            double height = 0;
            double bmi = 0;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("What is your weight (kg)?");
            weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your height (m)?");
            height = Convert.ToDouble(Console.ReadLine());

            bmi = (weight / (height * height));

            Console.WriteLine("{0}, your BMI is: {1}", name, bmi);
            Console.ReadLine();
        }
    }
}
