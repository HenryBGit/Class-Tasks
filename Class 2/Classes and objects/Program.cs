namespace Classes_and_objects
{
    internal class Program
    {
        static void Main()
        {
            Dog myDog = new Dog("Max", 3);
            myDog.Name = "Bob";
            Dog myDog1 = new Dog("Jane", 6);
            Dog myDog2 = new Dog("Harry", 7);
            Dog myDog3 = new Dog("Jules", 1);
            myDog.Bark();

        }
    }
}


