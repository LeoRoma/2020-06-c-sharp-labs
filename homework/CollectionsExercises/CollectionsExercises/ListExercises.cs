using System;
using System.Collections.Generic;

using System.Linq;

namespace CollectionsExercisesLib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            var listOfFive = new List<int>();
           
            for (int i = 1; i <= max; i++)
            {
                if (i % 5 == 0)
                {
                    listOfFive.Add(i);
                }
            }
            
           
            return listOfFive;
        }

        // return the average of all the numbers in argList 
        public static double Average(List<double> argList)
        {
            Int32 length = argList.Count;
            double total = 0;
            if (!argList.Any())
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    total += argList[i];
                }
            }
            
            double average = total / length;
            return average;
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            var countedList = new List<string>();
            foreach (string source in sourceList)
            {
                string sourceToLower = source.ToLower();
                char firstLetterA = sourceToLower[0];
                if (firstLetterA == 'a')
                {
                    countedList.Add(source);
                }
            }
            return countedList;
        }
    }
}

