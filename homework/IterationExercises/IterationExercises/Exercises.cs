using System;

namespace IterationLib
{

    public class Program
    {
       
        public static void Main(string[] nums)
        {
            //ignore
        }
    }
    public class Exercises
    {
        // returns the lowest number in the array nums
        public static int Lowest(int[] nums)
        {
            
            if (nums.Length == 0)
            {
                return int.MaxValue;
            }
            else
            {
                int minVal = nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] < minVal)
                    {
                        minVal = nums[i];
                    }
                }
                return minVal;
            }

        }

        // returns the sum of all numbers between 1 and n inclusive that are divisible by either 2 or 5
        public static int SumEvenFive(int max)
        {
            int total = 0;
            for (int i = 0; i <= max; i++)
            {
                if(i % 5 == 0 || i % 2 == 0)
                {
                    total += i;
                }
            }
            return total;
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            input = input.ToUpper();
            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;
            
            foreach (char letter in input)
            {
                if(letter == 'A')
                {
                    A += 1;
                }
                if (letter == 'B')
                {
                    B += 1;
                }
                if (letter == 'C')
                {
                    C += 1;
                }
                if (letter == 'D')
                {
                    D += 1;
                }
            }
            string result = $"A:{A} B:{B} C:{C} D:{D}";
            return result;
        }
    }
}