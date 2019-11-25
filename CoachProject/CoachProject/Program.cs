using System;

namespace CoachProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Coach myCoach = new Coach(52);
            for (int i = 0; i < 52; i++)
            {
                Person p = new Person("unset", 0);
                Console.WriteLine("Enter name");
                p.setName(Console.ReadLine());
                if (myCoach.AddPerson(p) == true)
                {
                    Console.WriteLine("success");
                }
                else
                {
                    Console.WriteLine("Failure");
                }            
            }
        }
    }
}
