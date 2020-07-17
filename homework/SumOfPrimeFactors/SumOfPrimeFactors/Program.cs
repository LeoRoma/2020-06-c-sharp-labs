using System;

namespace SumOfPrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrimeChecker(24));
        }

        static bool PrimeChecker(int number)
        {
            int isPrime = 0;
            for (int i = 2; i <= number; i++)
            {
                if(number % i == 0)
                {
                    isPrime += 1;
                }
            }
            if (isPrime == 2) return true;
            else return false;
        }
    }
}
