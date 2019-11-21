using System;
using System.Collections.Generic;
using System.Text;

namespace CoachProject
{
    class Coach
    {
        private Passenger[] contents;

        public Coach(int size)
        {
            contents = new Passenger[size];
        }

        public bool addPassenger(Passenger passenger)
        {
            if (contents[passenger.getSeat()] == null)
            {
                contents[passenger.getSeat()] = passenger;
                return true;
            }
            return false;
        }

        public bool removePassenger(Passenger passenger)
        {
            if (contents[passenger.getSeat()] != null)
            {
                contents[passenger.getSeat()] = null;
                return true;
            }
            return false;
        }

        public Passenger[] getPassengers()
        {
            return contents;
        }
    }
}
