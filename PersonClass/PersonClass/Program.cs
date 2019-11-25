using System;

namespace PersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("9", "Geoffrey Avenue", "Hereford", "HR1 1BZ");
            Person p1 = new Person("Will Mason", 16, address);
            Console.WriteLine(p1);
            Console.ReadLine();  
        }
    }
}
