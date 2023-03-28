namespace Class_6_Task_4
{
    internal class Program
    {
        enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
        static void Main()
        {
            Console.WriteLine("Please enter your favorite day of the week: ");
            if (Enum.TryParse(Console.ReadLine(), true, out Days days))
            {
                switch (days)
                {
                    case Days.Monday:
                        Console.WriteLine("You like Monday");
                        break;
                    case Days.Tuesday:
                        Console.WriteLine("You like Tuesday");
                        break;
                    case Days.Wednesday:
                        Console.WriteLine("You like Wednesday");
                        break;
                    case Days.Thursday:
                        Console.WriteLine("You like Thursday");
                        break;
                    case Days.Friday:
                        Console.WriteLine("You like Friday");
                        break;
                    case Days.Saturday:
                        Console.WriteLine("You like Saturday");
                        break;
                    case Days.Sunday:
                        Console.WriteLine("You like Sunday");
                        break;
                }
            }
        }
    }
}