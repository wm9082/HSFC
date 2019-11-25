using System;
using System.Collections.Generic;
using System.Text;

namespace PersonClass
{
    public class Address
    {
        private String house;
        private String street;
        private String city;
        private String postcode;

        public Address(String house, String street, String postcode, String city)
        {
            this.house = house;
            this.street = street;
            this.postcode = postcode;
            this.city = city;
        }
        public override string ToString()
        {
            return house + ", " + street + ", " + city + ", " + postcode;
        }
    }
}
