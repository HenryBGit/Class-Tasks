using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2_Tasks
{
    internal class Order
    {


        // Fields
        private string first_name;
        private string last_name;
        private string movie_name;
        private int order_date;

        // Constructor
        public Order(string first_name, string last_name, string movie_name, int order_date)
        {
            this.first_name = first_name;//need to pull these from customer
            this.last_name = last_name;
            this.movie_name = movie_name;
            this.order_date = order_date;
        }

        // Encapsulation or properties
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Movie_name { get => movie_name; set => movie_name = value; }
        public int Order_date { get => order_date; set => order_date = value; }

        // Method
        public void info()
        {
            Console.WriteLine("First Name: " + first_name);
            Console.WriteLine("Last Name: " + last_name);
            Console.WriteLine("Movie Title: " + movie_name);
            Console.WriteLine("Day of Purchase: " + order_date);
            Console.WriteLine("\n");
        }
    }
}
