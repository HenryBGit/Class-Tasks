using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2_Tasks
{
    internal class Object
    {
        // Fields
        private string type;
        private int battery;
        private string brand;

        // Constructor
        public Object(string type, int battery, string brand)
        {
            this.type = type;
            this.battery = battery;
            this.brand = brand;
        }
        // Encapsulation
        public string Type { get => type; set => type = value; }
        public int Battery { get => battery; set => battery = value; }
        public string Brand { get => brand; set => brand = value; }
        // Method
        public void info()
        {
            Console.WriteLine("Phone Type: "+ type);
            Console.WriteLine("Phone Battery: " + battery +"%");
            Console.WriteLine("Phone Brand: " + brand);
        }
    }
}
