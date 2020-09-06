using System;
using System.Collections.Generic;

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
            Loops();
           
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

        // Loops
        //Code out a loop with the break keyword Code out a loop with the continue keyword Create a loop that outputs the numbers 1 to 300 to the screen.
        //For every 100th number, have the program output your name, a greeting, or anything else you want to the screen.
        //Same as the one above, but for every 5th, 105th, 205th, etc number.Count down from 50 to 0 and output the numbers to the screen.

        public static void Loops()
        {
            int i = 1;
            while(i <= 400)
            {
                if (i == 301)       
                {
                    break;
                }
                else if (i == 5 || i == 105 || i == 205)
                {          
                    Console.WriteLine($"{i}th");
                    i++;
                    continue;
                }
                else if(i % 100 == 0)
                {
                    Console.WriteLine("Hello I am Leo");
                    i++;
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                    i++;
                }            
            }

            for (int n = 50; n >= 0; n--)
            {
                Console.WriteLine(n);
            }
        }

        
    }
    //Prime Factors - Sum the prime factors of an integer input by the user
    public class Prime
    {
        public int SumOfPrime(int[] inputArray)
        {
            int result = 0;
            foreach (var num in inputArray)
            {
                result += GetPrime(num);
            }
            return result;
        }

        public int GetPrime(int num)
        {
            bool isPrime = true;
            for (int i = 2; i <= num; i++)
            {
                if (num != i && num % i == 0)
                {
                    isPrime = false;
                }
            }
            if (isPrime)
            {
                return num;
            }
            isPrime = true;
            return 0;
        }
    }

    // Return total of array items after passing through loops
    ///* Pass in array [10,11,15,25.. 
    /// While loop ==> add one to each number [11,12,16 Do..While loop ==> add 3 to each number [14,15,19.. 
    /// Foreach loop ==> double each number [28,30,38... Return the total *
    
    public class Loop
    {
        public int TestArrayLoops(int[] inputArray)
        {
            int total = 0;
            int i = 0;

            while (i < inputArray.Length)
            {
                inputArray[i] += 1;
                i++;
            }
            i = 0;
            do
            {
                inputArray[i] += 3;
                i++;
            } while (i < inputArray.Length);

            foreach(var num in inputArray)
            {
               total += num * 2;
            }
            return total;
        }
    }
    // Return total of ArrayList, Array, List, Queue, Stack, Dictionary

    /* Input numbers and put into an ArrayList, Create an Array, List, Queue, Stack, Dictionary. 
     * Move objects from Arraylist to each item and multiply each number by 4 each move. What's the total? */
    public class ArraylistArrayListQueueStackDictionarySum
    {
        public int TestArrayListArrayListQueueStackDictionarySum(int[] inputArray)
        {
            int total = 0;
            var dictionaryIndex = 1;
            int[] newArray = new int[inputArray.Length];
            List<int> newList = new List<int>();
            Queue<int> newQueue = new Queue<int>();
            Stack<int> newStack = new Stack<int>();
            Dictionary<int, int> newDictionary = new Dictionary<int, int>();

            // Into Array
            for (int i = 0; i < inputArray.Length; i++)
            {
                newArray[i] = inputArray[i] * 4;
            }

            // Stack
            foreach (var num in newArray)
            {
                newList.Add(num * 4);
            }

            // Queue
            foreach (var num in newList)
            {
                newQueue.Enqueue(num * 4);
            }

            // Stack
            foreach (var num in newQueue)
            {
                newStack.Push(num * 4);
            }

            // Dictionary
            foreach (var num in newStack)
            {

                newDictionary.Add(dictionaryIndex, num * 4);
                dictionaryIndex += 1;
            }

            // Total
            foreach (var num in newDictionary)
            {
                total += num.Value;
            }
            return total;
        }
    }

    // Return total of array, list, dictionary

    /* Iterate over the array, extract the numbers, square the numbers, 
     * and add to a List Iterate over the list, subtract 10, add to a Dictionary<int, int> Iterate over dictionary and return sum */
    public class ArrayListDictionarySum
    {
        public int TestArrayListDictionarySum(int[] inputArray) 
        {
            int total = 0;
            List<int> newList = new List<int>();
            Dictionary<int, int> newDictionary = new Dictionary<int, int>();
            foreach(var num in inputArray)
            {
                newList.Add((int)Math.Sqrt(num));
            }

            for (int i = 0; i < newList.Count; i++)
            {
                newDictionary.Add(i, newList[i] - 10);
            }

            foreach (var num in newDictionary)
            {
                total += num.Value;
            }
            return total; 
        }
    }    
}
