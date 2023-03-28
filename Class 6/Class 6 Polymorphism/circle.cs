using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6_Polymorphism
{
  //public static void circle()
        //{
        //    Console.WriteLine("test circle");
        //    Console.WriteLine("You have selected circle");
        //    Console.Write("Please enter in the radius: ");
        //    double radius = Convert.ToInt32(Console.ReadLine());
        //    double area= radius * radius * Math.PI;
        //    Console.WriteLine($"The area of a circle is {area}");
        //}
        public class Circle : Shape
        {
            private double radius;

            public Circle(double radius)
            {
                this.radius = radius;

            }

            public override double CalculateArea()
            {
                return radius * radius * Math.PI;
            }
        }
    } 

