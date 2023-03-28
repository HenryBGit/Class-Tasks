namespace Class_6_Polymorphism
{
    internal class Program
    {
        static void Main()
        {
            int userchoice = 0;
            Console.WriteLine("Please Select a shape: \n[1] Rectangle \n[2] Circle");
            Console.Write("Please put in an input: ");
            userchoice = Convert.ToInt32(Console.ReadLine());
            if (userchoice==1)
            {
                Console.Write("Please enter in the length: ");
                double length = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter in the width: ");
                double width = Convert.ToInt32(Console.ReadLine());
                Rectangle rectangle = new Rectangle(length, width);
                Console.WriteLine(rectangle.CalculateArea());
            }
            else if (userchoice==2)
            {
                Console.Write("Please enter in the radius: ");
                double radius = Convert.ToInt32(Console.ReadLine());
                Circle circle = new Circle(radius);
                Console.WriteLine(circle.CalculateArea());

            }
            else
            {
                Console.WriteLine("\n\nI'm Sorry but that is not a valid option");
                Console.Write("Press [Enter to continue]: ");
                Console.ReadLine();
                Console.Clear();
                Main();
            }
            //Shape myShape = new Shape();
            //myShape.Calculatearea();

        }
    }
}