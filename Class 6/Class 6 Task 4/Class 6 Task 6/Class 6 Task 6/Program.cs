namespace Class_6_Task_6
{
    internal class Program
    {
        enum Colour {Red =1, Green, Blue, Yellow};
        static void Main()
        {
            Console.WriteLine("Please select a color: ");
            Console.WriteLine("[1] Red \n[2] Green\n[3] Blue\n[4] Yellow");
            if (Enum.TryParse(Console.ReadLine(), true, out Colour colour))
            {
                switch (colour)
                {
                    case Colour.Red:
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("You selected Red with hex code #FF0000");
                        break;
                    case Colour.Green:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You selected Green with hex code #00FF00");
                        break;
                    case Colour.Blue:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You selected Blue with hex code #0000FF");
                        break;
                    case Colour.Yellow:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("You selected Yellow with hex code #FFFF00");
                        break;
                }
            }
        }
    }
}