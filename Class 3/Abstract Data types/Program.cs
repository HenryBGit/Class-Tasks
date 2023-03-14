using System.Collections;
using System.Collections.Generic;

namespace Debugging
{
    internal class Program
    {


        static void Main()
        {

            List<string> progLangOne = new List<string>() { "C#", "JavaScript", "Kotlin", "Python"};
            List<string> progLangTwo = new List<string>() { "C++", "Go", "Swift", "TypeScript" };
            string[] newproglang = { "Rust" }; //creates a new list that can hold strings
            progLangOne.AddRange(newproglang);//adds the created list to proglangone
            
            //progLangOne.Add("Rust");//this method adds in one item at a time instead of multiple items
            
            progLangTwo.AddRange(progLangOne);//adds in all the items from proglangone into prolangtwo
            List<string> allProgLaguages = progLangTwo;
            allProgLaguages.Remove(progLangTwo[2]);//removes the 3rd item in programing two

            // foreach loop
            foreach (var item in allProgLaguages)
            {
                Console.WriteLine(item);
            }
            Console.Write("Press [Enter] to continue: ");
            Console.ReadLine();
            Console.Clear();
            Map myMap = new Map();
            myMap.Add("ID511001", 1);
            myMap.Add("ID607001", 2);
            myMap.Add("ID608001", 3);
            myMap.Add("ID721001", 4);
            myMap.Add("ID737001", 5);
            myMap.Lookup("ID721001");
            myMap.Remove("ID607001");
            //myMap.Lookup("2");
            Console.Write("Press [Enter] to continue: ");
            Console.ReadLine();
            Console.Clear();
            Stack myStack = new Stack(10);
            myStack.Push("Programming 2");
            myStack.Push("Introductory Application Development Concepts");
            myStack.Push("Intermediate Application Development Concepts");=
            Console.Write("Press [Enter] to continue: ");
            Console.ReadLine();
            Console.Clear();
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("\nProgramming 2\n");
            myQueue.Enqueue("Introductory Application Development Concepts\n");
            myQueue.Enqueue("Intermediate Application Development Concepts");

        }
    }
}
