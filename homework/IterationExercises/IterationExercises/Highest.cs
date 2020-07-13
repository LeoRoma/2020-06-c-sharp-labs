using System;

namespace IterationLib
{
    public class Highest
    {
        public static int HighestWhileLoop(int[] nums)
        {
            // this method should use a while loop
            int i = 0;
            int maxVal = nums[0];
            while (i < nums.Length)
            {
                if (nums[i] > maxVal)
                {
                    maxVal = nums[i];
                }
                i++;
            }
            return maxVal;
        }

        public static int HighestForLoop(int[] nums)
        {
            // this method should use a for loop
            int maxVal = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > maxVal)
                {
                    maxVal = nums[i];
                }
            }
            return maxVal;
        }

        public static int HighestForEachLoop(int[] nums)
        {
            int maxVal = nums[0];
            foreach (int num in nums)
            {
                if (num > maxVal)
                {
                    maxVal = num;
                }
            }
            return maxVal;
        }

        public static int HighestDoWhileLoop(int[] nums)
        {
            // this method should use a do-while loop
            int i = 0;
            int maxVal = nums[0];
            do
            {
                if (nums[i] > maxVal)
                {
                    maxVal = nums[i];
                }
                i++;

            } while (i < nums.Length);


            return maxVal;
        }
    }
}