using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Class_Task_5_Inheritance
{
    internal class Car : Vechile
    {
        private int numOfDoors;

        public Car(string model, string brand, int year, int numOfDoors) : base(model, brand, year)
        {
            this.numOfDoors = numOfDoors;
        }

        public override void PrintDetails()
        {
            Console.WriteLine("Brand: " + Brand + "\nModel: " + Model + "\nYear: "+ Year  + "\nNumber Of Doors: "+ numOfDoors +"\n");
        }
    }
}
    
  
