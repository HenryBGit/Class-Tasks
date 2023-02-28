using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class_2_Tasks
{
    internal class Employee
    {


        // Fields
        private string name;
        private int age;
        private decimal salary;

        // Constructor
        public Employee(string name, int age, decimal salary)
        {
            this.name = name;
            this.age = age;
            if (salary < 0)
            {
                throw new InvalidOperationException("I'm sorry but that value is a negative number and will not be accepted"); //creates a new error message and displays it
            }
            else
            {
                this.salary = salary;
            }
        }

        // Encapsulation or properties
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public decimal Salary { get => salary; set => salary = value; }

        // Method
        public void info()
        {
            Console.WriteLine("Employee's Name: " + name);
            Console.WriteLine("Employee's Age: " + age);
            Console.WriteLine("Employee's Salary: " + salary);
            Console.WriteLine("\n");
        }

       

    }

}
