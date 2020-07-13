using System;

namespace lab_19_loop_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Loop();
        }

        static void Loop()
        {
            int digit = 5;
            for (int n = 1; n <= 300; n++)
            {
                if(n % 100 == 0)
                {
                    Console.WriteLine("Hi I am Leo");
                }
                else if (n == digit || isDigitPresent())
                {
                    Console.Write($"{n}th");
                }
                Console.WriteLine(n);
                
            }
        }

        static bool isDigitPresent()
        {
            int digit = 5;
            int x = 1;
            while (x < 300)
            {
                if (x % 10 == digit)
                    break;

                x = x / 10;
            }

            // If loop broke 
            return (x > 0);

        }
    }
}
