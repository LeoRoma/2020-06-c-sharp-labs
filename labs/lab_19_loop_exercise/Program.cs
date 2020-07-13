using System;

namespace lab_19_loop_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an option to run a loop");
            Console.WriteLine("1: prints from 1 to 300");
            Console.WriteLine("2: for every 100 shows my name");
            Console.WriteLine("3: each 5 show with 'th'");
            Console.WriteLine("4: countdown from 50 to 0");

            int userInput = Console.ReadLine();
            Loop();
        }

        static void Loop()
        {
            for (int i = 1; i <= 300; i++)
            {
                long lastDigit = i % (10);
                if (i % 100 == 0)
                {
                    Console.WriteLine("Hi I am Leo");
                }
                else if (i == 5 || i == 105 || i == 205)
                {
                    Console.WriteLine($"{i}th");
                }
                Console.WriteLine(i);
            }
        }

    }
}
