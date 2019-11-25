using System;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int weight = 0;
            double height = 0;
            double BMI = 0;

            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your height.");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your weight.");
            weight = Convert.ToInt32(Console.ReadLine());

            BMI = (weight / (height * height));

            Console.WriteLine("{0}, your BMI is {1}", name, BMI);
            Console.ReadLine();
        }
    }
}
