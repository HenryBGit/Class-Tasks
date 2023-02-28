using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2_Tasks
{
    internal class Movie
    {

        // Fields
        private string name;
        private string description;
        private int price;
        private int stock;

        // Constructor
        public Movie(string name, string description, int price, int stock)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.stock = stock;
        }

        // Encapsulation or properties
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Price { get => price; set => price = value; }
        public int Stock { get => stock; set => stock = value; }

        


        // Method
        public void info()
        {
            Console.WriteLine("Movie Name: " + name);
            Console.WriteLine("Movie Description: " + description);
            Console.WriteLine("Movie Price: " + price);
            Console.WriteLine("Movie Stock: " + stock);
            Console.WriteLine("\n");

        }
    }
}
