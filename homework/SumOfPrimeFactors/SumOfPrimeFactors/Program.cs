using System;

namespace SumOfPrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPrimeFactors(24));
        }

        static int GetPrimeFactors(int number)
        {
            int total = 0;
            for (int i = 2; i <= number; i++)
            {
                while(PrimeChecker(i) == true)
                {
                    if (number % i == 0 && PrimeChecker(i) == true)
                    {
                        Console.WriteLine(i);
                        Console.WriteLine(number);
                        total += i;
                        number /= i;
                        
                    }
                }
                

            }
            return total;
        }

        static bool PrimeChecker(int number)
        {
            int isPrime = 0;
            for (int i = 2; i <= number; i++)
            {
                if(number % i == 0)
                {
                    Console.WriteLine("Check prim" + i);
                    isPrime += 1;
                }
            }
            if (isPrime == 1) return true;
            else return false;
        }
    }
}
