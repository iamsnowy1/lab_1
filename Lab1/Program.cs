using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
   
    public class Address
    {
       
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;

        
        public string Index
        {
            get { return index; }
            set { index = value; }
        }
       
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        
        public string City
        {
            get { return city; }
            set { city = value; }
        }
       
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string House
        {
            get { return house; }
            set { house = value; }
        }
      
        public string Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }       
        public Address(string index, string country, string city, string street, string house, string apartment)
        {
            this.index = index;
            this.country = country;
            this.city = city;
            this.street = street;
            this.house = house;
            this.apartment = apartment;
        }
        public void DisplayAddress()
        {
            Console.WriteLine($"Index: {index}");
            Console.WriteLine($"Country: {country}");
            Console.WriteLine($"City: {city}");
            Console.WriteLine($"Street: {street}");
            Console.WriteLine($"House: {house}");
            Console.WriteLine($"Apartment: {apartment}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Address myAddress = new Address("03148", "Україна", "Київ", "вулиця Василя Верховинця", "10", "Apt 4B");

            
            myAddress.DisplayAddress();
        }
    }
}
