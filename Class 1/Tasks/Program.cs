namespace Classroom_Tasks
{
    internal class Program
    {


        static void Main()
        {
            Console.WriteLine("Task 2");
            Console.WriteLine("Task 2 will get the user to enter in a number and check if it is a multiple of 3 and 5");
            for (int i = 1; i < 16; i += 2)
            {
                Console.WriteLine(i);
                FizzBuzz(i);

            }

        }

        static void FizzBuzz(int num)
        //3=fizz,5=buzz,9=fizz,15=fizzbuzz
        {

            if (num % 3 == 0 && num % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (num % 3 == 0)
                Console.WriteLine("Fizz");
            else if (num % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine("not a multiple of 3 or 5");


            Console.WriteLine("This is the end of Task 2");
            Console.WriteLine("Press enter to Continue to the next task: ");
            Console.Clear();

            //start of task 3
            int[] nums = { 21, 19, 68, 55, 42, 12 };
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 1)
                {
                    Console.WriteLine("Number " + nums[i] + " is odd");
                }


            }
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);

            }
            Console.Write("Press 'Enter' to continue: ");
            Console.ReadLine();
            Console.Clear();


            {
                Console.WriteLine("Hi");
            }

            Console.ReadLine();
        }

        
        
    }
}
