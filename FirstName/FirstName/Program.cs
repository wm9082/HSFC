using System;

namespace FirstName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            Console.WriteLine("What's your name?");

            name = Console.ReadLine();

            Console.WriteLine("Hello {0}, how are you?", name);
            Console.ReadLine();
        }
    }
}
