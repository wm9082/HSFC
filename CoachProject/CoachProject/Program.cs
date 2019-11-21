using System;

namespace CoachProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Coach myCoach = new Coach(52);


            Passenger pass = new Passenger("Fred Bloggs", 54, 12);
            Passenger pass2 = new Passenger("Dave Bloggs", 34, 13);


            if (myCoach.addPassenger(pass))
            {
                Console.WriteLine(pass.getName());
            }

            if (myCoach.addPassenger(pass2))
            {
                Console.WriteLine("Okay");
            }

            //Outputs the passengers on myCoach.
            for (int i = 0; i < 52; i++)
            {
                if (myCoach.getPassengers()[i] == null) continue;
                Console.WriteLine(myCoach.getPassengers()[i].getName());
            }

            Console.ReadLine();
        }
    }
}