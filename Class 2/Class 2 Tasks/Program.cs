﻿namespace Class_2_Tasks
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("This is Task 1");
            Console.WriteLine("This task creates a class for an object in my case it is a for a phone\n");
            Object myObject = new Object("Samsung Galaxy A12", 92, "Samsung");
            myObject.info();
            Console.Write("\nPress [Enter] to continue: ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("This is Task 2");
            Console.WriteLine("This task creates a class with private fields and public properties and then displays 3 cars with their properties\n");
            Car myCar = new Car("Samsung Galaxy A12", "Hi", 1993);
            myCar.info();
            Car myCar1 = new Car("Car", "swoosh", 1993);
            myCar.info();
            Car myCar2 = new Car("Hyundai", "hmmm", 1993);
            myCar.info();
            Console.Write("\nPress [Enter] to continue: ");
            Console.ReadLine();
            Console.Clear();

        }
    }
}