using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Task_5_Inheritance
{
    public class Dog : Animal
    {
        // Adding a new field
        private string colour;

        public Dog(string name, int age, string colour) : base(name, age) // The base class's constructor
        {
            this.colour = colour;
        }

        // Overriding the base class's implementation
        public override void Eat() { /*...*/ }

        // Its own class method
        public void Bark() { /*...*/ }

        public override string Name { get => name; set => name = value; }
        public string Colour { get => colour; set => colour = value; }
    }
}
