using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Task_5_Inheritance
{
    internal class Vechile
    {
        //Fields
        private string brand;
        private string model;
        private int year;

        //Constructor
        public Vechile(string brand, string model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
        }

        //Encapsulation or properties
        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }

        //Methods
        public virtual void PrintDetails()
        {
            Console.WriteLine(brand + model + year);
        }

    }
}
