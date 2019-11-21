using System;
using System.Collections.Generic;
using System.Text;

namespace CoachProject
{
    public class Passenger : Person
    {
        private int seat;

        public Passenger(String theName, int theAge, int theSeat) : base(theName, theAge)
        {
            seat = theSeat;
        }

        public int getSeat()
        {
            return seat;
        }

        public void setSeat(int seat)
        {
            this.seat = seat;
        }
    }
}