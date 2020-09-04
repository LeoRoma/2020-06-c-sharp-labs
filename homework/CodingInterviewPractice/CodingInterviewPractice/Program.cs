using System;

namespace CodingInterviewPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzz(i));
            }
           
        }

        // Fizzbuzz
        public static string FizzBuzz(int num)
        {
            if(num % 15 == 0)
            {
                return "Fizzbuzz";
            }
            else if(num % 5 == 0)
            {
                return "Buzz";
            }
            else if(num % 3 == 0)
            {
                return "Fizz";
            }
            else
            {
                return num.ToString();
            }
        }
    }
}
