using System;

namespace lab_18_iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop
            //for(int i = 100; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //while loop
            //int i = 0;
            ////while(i < 100)
            ////{
            ////    Console.WriteLine(i * 10);
            ////    i++;
            ////}

            //do while loop
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while(i < 10); //check the condition at the end

            //Exercise
            //int total = 0;
            //for (int i = 0; i <= 100; i++)
            //{

            //    Console.WriteLine(total += i);
            //}

            //string nish = "NISH IS KING";

            //for(int i = 0; i < nish.Length; i++)
            //{
            //    Console.WriteLine(nish.ToLower()[i]);
            //}

            //For loop break
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //    if(i == 5)
            //    {
            //        break;
            //    }
            // }

            //continue
            //int counter = 0;
            //while (counter < 10)
            //{
            //    counter++;
            //    Console.WriteLine(counter);
            //    if (counter < 4) continue;
            //    Console.WriteLine(counter * 4);
            //}

            //exercise

            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine(i);
                if(i % 15 == 0)
                {
                    break;
                }
            }
        }
    }
}
