﻿using System;

namespace OperatorAndMethodsExercisesLib
{
    public class Methods
    {
        // implement this method so that it returns true if x is greater than or equal to y
        public static bool GreaterEqual(int x, int y)
        {
   
            if (x >= y)
            {
               return true;
            }
            else
            {
               return false;
            }
            
        }

        // implement this method so that it returns the number of dozens of eggs
        public static int Dozens(int numEggs)
        {
            int totalEggs = 0;
            for (int i = 1; i <= numEggs; i++)
            {
                if (i % 12 == 0)
                {
                    totalEggs += 1;
                }
            }
            return totalEggs;
        }

        // Implement this method so that it take a double as an input,
        // squares it, adds 101, divides the result by 7, then subtracts 4.  
        // Return a double rounded to 3 decimal places.
        public static double BODMAS(double inputNumber)
        {
             return Math.Round(((((inputNumber * inputNumber) + 101) / 7) - 4), 3);
        }

        // implement this method so that it returns the sum of x and y
        // and sets the out parameter 'product' to be the product of x and y
        public static int SumProduct(int x, int y, out int product)
        {
            int total = x + y;
            product = x * y;
            return total;
        }

        // implement this method so it returns a tuple (weeks, days) 
        // corresponding to a given number of days
        public static (int weeks, int days) DaysAndWeeks(int totalDays)
        {

            int days = totalDays / 7;
            int weeks = totalDays % 7;
            return (days, weeks);
        }
    }
}