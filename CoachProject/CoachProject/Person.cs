using System;
using System.Collections.Generic;
using System.Text;

namespace CoachProject
{
    public class Person
    {
        public Person(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        private String name = "";
        private int age = 0;

        public String getName()
        {
            return name;
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
            return getName() + " is aged " + getAge();
        }
    }
}
