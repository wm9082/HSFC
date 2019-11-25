using System;
using System.Collections.Generic;
using System.Text;

namespace CoachProject
{
    class Coach
    {
        private Person[] contents;
        private int nextLocation;
        private int size;
        public Coach(int size)
        {
            contents = new Person[size];
        }

        public bool AddPerson(Person person)
        {
            if (nextLocation != size)
            {
                contents[nextLocation] = person;
                nextLocation++;
                return true;
            }
            return false;
        }

        public bool RemovePerson(Person person)
        {
            for (int i = 0; i < contents.Length; i++)
            {
                if (contents[i] == person)
                {
                    contents[nextLocation] = null;
                    nextLocation--;
                    return true;
                }
            }
            return false;
        }
        public int GetNumberOfPassengers()
        {
            
        }
    }
}
