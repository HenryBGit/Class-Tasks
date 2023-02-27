using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_objects
{
    public class Dog
    {
        // fields
        private string name;
        private int age;

        // constructor
        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name { get => name; set => name = value; }
        //get => name is read access, set =>name = value is writing access
        public int Age { get => age; set => age = value; }

        // methods
        public void Bark()
        {
            Console.WriteLine("Dogs Name: " + name);
            Console.WriteLine("Dogs Age: " + age);
            Console.WriteLine("Woof woof!");
        }
       
    }
}
