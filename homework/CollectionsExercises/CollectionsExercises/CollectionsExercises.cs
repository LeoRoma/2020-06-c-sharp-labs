using System.Collections.Generic;
using System;
using System.Linq;
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
            var countsDigits = new Dictionary<char, int>();
            int num;
            foreach (char number in input)
            {
                if (Char.IsNumber(number))
                {
                    if(countsDigits.ContainsKey(number))
                    {
                        countsDigits[number]++;
                    }
                    else
                    {
                        countsDigits.Add(number, 1);
                    }
                    

                }
            }
            string dictionaryToString = "";
            foreach(var digit in countsDigits)
            {
                dictionaryToString += $"[{digit.Key}, {digit.Value}]";
            }
            return dictionaryToString;
        }
    }
}