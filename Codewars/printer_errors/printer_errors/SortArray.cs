using System;
using System.Collections.Generic;
using System.Text;

namespace Katas
{
    public class SortArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SortArr(new int[] { 5, 3, 2, 8, 1, 4 }));
        }

        //You have an array of numbers. Your task is to sort ascending odd numbers but even numbers must be on their places.
        //Zero isn't an odd number and you don't need to move it.If you have an empty array, you need to return it.

        public static int[] SortArr(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 != 0)
                {
                    for (int n = 0; n < array.Length; n++)
                    {
                        if (array[i] < array[n] && array[n] % 2 != 0)
                        {
                            int x = array[n];
                            array[n] = array[i];
                            array[i] = x;
                            
                        }
                    }
                }
               
            }
            return array;
        }
    }
}
