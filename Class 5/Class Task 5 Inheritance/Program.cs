namespace Class_Task_5_Inheritance
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("This is task 1");
            Console.WriteLine("This task will create a parent class and a child class and then add them together \n");
            Car myVechile = new Car("Honda", "Generation 6", 2012, 2);
            myVechile.PrintDetails();
            Car myVechile2 = new Car("Swift", "Suzuki", 2014, 4);
            myVechile2.PrintDetails();
            Console.Write("Press [Enter] to continue: ");
            Console.ReadLine();
            Console.Clear();
            Animal myCat = new Animal("Swift", "Suzuki", 2014, 4);
            myCat.PrintDetails();



        }
    }
}
