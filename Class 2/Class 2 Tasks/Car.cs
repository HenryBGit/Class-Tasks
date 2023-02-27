using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2_Tasks
{
    internal class Car
    {
        
        // Fields
        private string make;
        private string model;
        private int year;

        // Constructor
        public Car(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }
        // Encapsulation or properties
        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }

        
        // Method
        public void info()
        {
            Console.WriteLine("Car Make: " + make);
            Console.WriteLine("Car Model: " + model);
            Console.WriteLine("Car Year: " + year);
        }

    }
}
