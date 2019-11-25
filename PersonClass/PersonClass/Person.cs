using System;
using System.Collections.Generic;
using System.Text;

namespace PersonClass
{
    public class Person
    {
        private String name = "";
        private int age = 0;
        private Address address;
        public String getName()
        {
            return name;
        }
        public Person(String name, int age, Address address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }
        public int getAge()
        {
            return age;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public override String ToString()
        {
            return getName() + " is aged " + getAge() + " and lives at " + getAddress();
        }
        public void setAddress(Address address)
        {
            this.address = address;
        }
        public Address getAddress()
        {
            return address;
        }
    }
}
