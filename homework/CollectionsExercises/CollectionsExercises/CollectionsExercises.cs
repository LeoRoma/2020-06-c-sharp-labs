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
            {
                string dequeued = "";
                if (num == 0)
                {
                    return dequeued;
                }
                else if (num > queue.Count)
                {
                    if (num > queue.Count)
                    {
                        dequeued = queue.Dequeue();
                        for (int i = 0; i <= queue.Count + 2; i++)
                        {
                            dequeued += $", {queue.Dequeue()}";
                        }
                    }
                }
                else
                {
                    dequeued = queue.Dequeue();
                    for (int i = 0; i < num - 1; i++)
                    {
                        dequeued += $", {queue.Dequeue()}";
                    }
                }
                
                return dequeued;
            }
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            var reversedStack = new Stack<int>();
            Array.Reverse(original);
            foreach (int value in original)
            {
                reversedStack.Push(value);
            }
            int[] reversedArray = reversedStack.ToArray();
            return reversedArray;
        }

        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            var countsDigits = new Dictionary<char, int>();
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