using System;

namespace PersonProject
{
    class Program
    {
        static void Main(string[] args)
        {   
            // House number, street name, city/town, postcode.
            Address address = new Address("21", "Foly Lane", "Hereford", "HE14 EJG");

            // Name, age, address.
            Person p1 = new Person("Dan Williams", 16, address);

            Console.WriteLine(p1);
            Console.ReadLine();
        }
    }
}
