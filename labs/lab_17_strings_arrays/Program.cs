using System;
using System.Collections.Generic;
using System.Text;

namespace lab_19_string_arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            ////int[] newArray = { 2, 3, 4, 5 };
            ////var result = ArraySum(newArray);
            //int[,] grid2d = { {4, 7, 8, 9 },{6, 1, 7, 10} };
            //// 4 6
            //// 7 1
            //// 8 7
            //// 9 10
            //int val = grid2d[0, 1]; // 7

            //int[,,] grid3d = { { { 4, 7, 8, 9 }, { 6, 1, 7, 10 }, { 4, 4, 4, 4 } } };
            //// 4 6
            //// 7 1
            //// 8 7
            //// 9 10
            //int val1 = grid3d[0, 1, 0]; // 7

            //string[][] animalGrid = new string[2][];
            //animalGrid[0] = new string[4];
            //animalGrid[1] = new string[2];

            //string[][] animalGrid2 = new string[][]
            //{
            //    new string[] {"llama", "puma", "horse", "kitten2"},
            //    new string[] { "haddock", "tuna" }
            //};
            //var animal = animalGrid2[0][1];
            //Console.WriteLine(animal);


            ////no restriction of size
            //List<string> names = new List<string>();
            //names.Add("Nish");
            //names.Add("Bruno");

            //string firstName = "Harry";
            //string lastName = "Derbyshire";
            //double score = 90.131231;

            //var string1 = firstName + " " + lastName + " Age: " + score;
            //var string2 = $"{firstName}, {lastName}, Age: {score:f4}"; // round up 4. p2 --> returns percentage

            //string input = "33";
            //int input2 = Int32.Parse(input);
            //int sum = 1 + input2;

            StringBuilder sb = new StringBuilder("Hello");
            sb.Append("\nHello Engineering 66.\nEspecially Nish");
            Console.WriteLine(sb);
        }

        static int ArraySum(int[] practiceArray)
        {
            int arraySum = practiceArray[0] + practiceArray[1];
            return arraySum;
        }
    }
}

//create array
//char[] nish = new char[4];

//nish[0] = 'n';
//nish[1] = 'i';
//nish[2] = 's';
//nish[3] = 'h';

//char[] sparta = { 's', 'p', 'a', 'r', 't', 'a' };

//multidimensional array
//int[,] grid = new int[2, 4];
