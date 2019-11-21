using System;
using System.Collections.Generic;
using System.Text;

namespace PersonProject
{
    class Person
    {
        public Person(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person(String name, int age, Address address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        private String name = "";
        private int age = 0;
        private Address address;

        public String getName()
        {
            return name;
        }

        public int getAge()
        {
            return age;
        }

        public Address getAddress()
        {
            return address;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setAddress(Address address)
        {
            this.address = address;
        }

        public override String ToString()
        {
            return getName() + " is aged " + getAge() + " and lives at " + getAddress();
        }
    }
}
