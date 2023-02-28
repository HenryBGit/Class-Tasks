using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2_Tasks
{
    internal class Customer
    {

        // Fields
        private string first_name;
        private string last_name;
        private string address;
        private int mobile_number;

        // Constructor
        public Customer(string first_name, string last_name, string address, int mobile_number)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.address = address;
            this.mobile_number = mobile_number;
        }

        // Encapsulation or properties
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Address { get => address; set => address = value; }
        public int Mobile_number { get => mobile_number; set => mobile_number = value; }

        // Method
        public void info()
        {
            Console.WriteLine("First Name: " + first_name);
            Console.WriteLine("Last Name: " + last_name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Mobile Number: " + mobile_number);
            Console.WriteLine("\n");

        }
    }
}
