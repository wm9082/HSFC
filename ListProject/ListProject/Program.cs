using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProject
{
    class Program
    {

        public static void Main(String[] args)
        {
            ListExercises myList = new ListExercises();

            myList.AddNameToList("Adam");
            myList.AddNameToList("Bert");
            myList.AddNameToList("Dave");
            myList.AddNameToList("Ed");
            myList.AddNameToList("Fred");
            myList.AddNameToList("Henry");

            Console.WriteLine("Results are " + myList.GetListAsString());

            myList.AddNameToList("Carys");
            Console.WriteLine("Results are " + myList.GetListAsString());

            myList.AddNameToList("David");
            Console.WriteLine("Results are " + myList.GetListAsString());
            Console.ReadLine();
        }

    }

}