using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            ListExercises myList = new ListExercises();
            string currentWord = "";
            Console.WriteLine("Enter your poem, one word per line then input STOP when finished:");
            while (currentWord != "STOP")
            {
                currentWord = Console.ReadLine();
                if (currentWord != "STOP")
                {
                    myList.AddNameToList(currentWord);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Results are " + myList.GetListAsString());
            Console.ReadLine();
        }
    }
}
