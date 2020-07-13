﻿using System.Collections.Generic;
using System;
namespace CollectionsExercisesLib
{
    public class CollectionsExercises
    {
        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            return "Not implemented";
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            return null;
        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            Dictionary <string, int> digitCounts = new Dictionary<string, int>();
            foreach (char number in input)
            {
                if(Char.IsDigit(number))
                {
                    digitCounts[number]++;
                }
                else
                {
                    string numberToString = number.ToString();
                    digitCounts.Add(numberToString, 1);
                }
            }
            return digitCounts;
        }
    }
}