using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    public class Address
    {
        private String house;
        private String street;
        private String city;
        private String postcode;

        public Address(String house, String street, String city, String postcode)
        {
            this.house = house;
            this.street = street;
            this.city = city;
            this.postcode = postcode;
        }

        public void setHouse(String house)
        {
            this.house = house;
        }

        public void setStreet(String street)
        {
            this.street = street;
        }

        public void setCity(String city)
        {
            this.city = city;
        }

        public void setPostcode(String postcode)
        {
            this.postcode = postcode;
        }

        public String getHouse()
        {
            return house;
        }

        public String getStreet()
        {
            return street;
        }

        public String getCity()
        {
            return city;
        }

        public String getPostcode()
        {
            return postcode;
        }

        public override String ToString()
        {
            return getHouse() + " " + getStreet() + ", " + getCity() + ", " + getPostcode();
        }
    }
}
