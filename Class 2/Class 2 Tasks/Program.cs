namespace Class_2_Tasks
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
            Console.WriteLine("This is task 3");
            Console.WriteLine("This task will show a student enrollment system\n");
            Console.WriteLine("Skipped this one, will come back to it");
            Console.Write("\nPress [Enter] to continue: ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("This is task 4");
            Console.WriteLine("This task will display Employee's status and tell the user when they have inputed a negative number\n");
            Employee myEmployee = new Employee("Henry", 18, 25000);
            Employee myEmployee1 = new Employee("Smith", 22, 40000);
            Employee myEmployee2 = new Employee("Samantha", 34, 25000);
            myEmployee.info();
            myEmployee1.info();
            myEmployee2.info();
            Console.Write("\nPress [Enter] to continue: ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("This is task 5");
            Console.WriteLine("I skipped this task accidentally, will come back to it");
            Console.Write("\nPress [Enter] to continue: ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("This is task 6\n");
            Customer mycustomer = new Customer("Henry", "Brookland", "6th candlane avenue", "0276632165");
            Customer mycustomer1 = new Customer("Smith", "Robin", "7th cheeseview street", "0276632165");
            Customer mycustomer2 = new Customer("Samantha", "Hayes", "6th Monroe street", "0276632165");
            mycustomer.info();
            mycustomer1.info();
            mycustomer2.info();
            Movie myMovie = new Movie("Deceptive Dog", "dog gone rouge", 12.50, 5);
            Console.WriteLine("Movies Available");
            myMovie.info();

        }
    }
}