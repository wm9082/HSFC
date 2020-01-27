using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            QueueShunt queue = new QueueShunt(50);
            while (running)
            { 
                // V1) Creeps
                Console.WriteLine("Queue Program.");
                Console.WriteLine("1) Add to queue");
                Console.WriteLine("2) Remove from queue");
                Console.WriteLine("3) Display length");
                Console.WriteLine("4) Display queue");
                Console.WriteLine("5) Quit");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Input object to be added: ");
                        queue.Add(Console.ReadLine());
                        break;
                    case "2":
                        Console.WriteLine(queue.Remove());
                        break;
                    case "3":
                        Console.WriteLine(queue.GetLength());
                        break;
                    case "4":
                        Console.WriteLine(queue);
                        break;
                    case "5":
                        running = false;
                        break;
                }
            }
        }
    }
}
