using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProject
{
    class ListExercises
    {
        private string[] names = new string[100];
        private int nextFreeLocation = 0;

        // addName takes in a name, adds it to the list maintaining the order
        // passes back an integer (-1 if error), giving inserted location
        public int AddNameToList(string theName)
        {
            if (nextFreeLocation > names.Length) return -1;
            int position = 0;
            while ((position < nextFreeLocation) && (theName.CompareTo(names[position]) > 0))
            {
                position = position + 1;
            }
            for (int i = nextFreeLocation; i > position; i--)
            {
                names[i] = names[i - 1];
            }
            names[position] = theName;
            nextFreeLocation++;
            return -1;
        }
        // FindPositionOfName locates a name in the list
        // passes back an integer (-1 if error), giving inserted location
        public int FindPositionOfName(string theName)
        {
            return -1;
        }
        public bool RemoveByPosition(int thePosition)
        {
            // 1) Make sure number inserted is within the range 0 to nextfreelocation –1 
            // if not, return false 
            //  2) to remove a name, go from position  to nextFreeLocation - 1 
            //  shunt all the other items up (names[i] = names[i+1]) 
            // Reduce next free location by 1  
            return true;
        }
        // GetListAsString just returns a formatted string of List
        public String GetListAsString()
        {
            string temp = "";
            for (int i = 0; i < nextFreeLocation; i++)
            {
                temp = temp + names[i] + "\n";
            }
            return temp;
        }
    }
}

