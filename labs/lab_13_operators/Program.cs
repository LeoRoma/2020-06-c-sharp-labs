using System;
using System.Xml.XPath;

namespace lab_13_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 1;
            //int y = x++; //int y = x, then increment x

            //int a = 1;
            //int b = ++a; //first increment 'a' then add new value to 'b'

            //double avarage = (2 + 5 + 1 + 8) / 5;

            //var a = 5 / 2;
            //var b = 5.0 / 2;
            //var c = 5 / 3;

            //var totalDays = 26;
            //var days = 26 % 7;
            //var weeks = 26 / 7;

            //bool isWearingAParachute = false;
            //bool jumpOuOfPlane = true;

            //if (isWearingAParachute || jumpOuOfPlane)
            //{
            //    Console.WriteLine("Jump");
            //}
            //else
            //{
            //    Console.WriteLine("Don't jump");
            //}


            //Console.WriteLine(5 ^ 1);
            //^ XOR operator --> checked on internet

            //Bitwise operator use to multiply or divide by powers of 2  0b_ => binary
            //var number01 = 0b_1010;
            //var number02 = 0b_10100; //multiply by 2
            //var number03 = 0b_101; // divide by 2

            //var number04 = 0b_101000;
            //Console.WriteLine(number04);
            //Console.WriteLine(number04 >> 1);
            //Console.WriteLine(number04 << 1);
            //Console.WriteLine(9 << 3);
            //Console.WriteLine(9 >> 2);

            int x = 3;
            int y = 2;
            x = ++y; // --> x get the value of y

            int a = 5, b = 3, c = 4;
            c += +a++ + ++b;
        }
    }
}
