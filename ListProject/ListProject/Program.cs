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
            Console.WriteLine("Enter your poem:");
            ListExercises myList = new ListExercises();
            string [] currentWord = Console.ReadLine().Split(' ');            
            for (int i = 0; i < currentWord.Length; i++)
            {
                myList.AddNameToList(currentWord[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Results are " + myList.GetListAsString());
            Console.ReadLine();
        }
    }
}
