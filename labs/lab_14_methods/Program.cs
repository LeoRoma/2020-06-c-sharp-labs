using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace lab_14_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //DoThis(); // Runs the method
            //var output = DoThis1();
            //SquareNumber(2); // (b: "Hello", a: 2)can be pass the argument in different position if we declare the name of the variable to the value to associate. Useful with big programs, when they have more parameters.
                             // runs default value "Hello"

            //OrderPizza(true, true, true);
            //OrderPizza(true, true);
            //OrderPizza(banana: true, pepperoni: true, pineapple: false);

            //var hi = DoThis3(3, "Hi", out int z);
            //Console.WriteLine(z);
            //Console.WriteLine(hi);

            var firstTripleCalc = TripleCalc(2, 2, 2, out int sum);
            Console.WriteLine(firstTripleCalc + ' ' + ": From return");
            Console.WriteLine(sum + ' ' + ": From out");

            Console.WriteLine("secondTripleCalc");
            Console.WriteLine(TripleCalc(2, 2, 2));
            //(string a, string b, int c) myTuple = (fName: "Nish", lName: "Mandal", Age: 18); // or use var
            //Console.WriteLine(myTuple.fName); // super dynamic, doesn't have limit of size or memory.
        }
        public static void DoThis() // Static can't be instantiated example Class.StaticMethod(); --> doesn't work
        {
            Console.WriteLine("We are Sparta");
        }

        public static string DoThis1()
        {
            return "We are Sparta";
        }

        public static int SquareNumber(int a, string b = "Hello") // => Default value
        {
            Console.WriteLine(b);
            return a*a;
        }

        static void OrderPizza(bool pepperoni, bool pineapple, bool banana = false)
        {
            if(pepperoni == true && pineapple == true && banana == true)
            {
                Console.WriteLine("Delicious");
            }
            if (pepperoni == true && pineapple == false && banana == true)
            {
                Console.WriteLine("Where is the pineapple");
            }
            if (pepperoni == true && pineapple == true && banana == false)
            {
                Console.WriteLine("Where is my banana!");
            }
        }

        public static int DoThis3(int x, string y, out int z)
        {
            z = x + x;
            return x  *  x;
        }

        public static(int xSquared, bool y_gt_10) DoThat(int x, string y)
        {
            Console.WriteLine(y);
            var z = (x > 10);
            return (x * x, z);
        }
        //In C# it doesn't return more than 1 value in the method

        //public static int Add(int a, int b)
        //{
        //    return a + b;
        //}

        //public static int Add(int a, int b, int c)
        //{
        //    return a + b + c;
        //}

        public static int TripleCalc(int a, int b, int c, out int sum)
        {
            sum = a + b + c;
            return a * b * c;
        }

        public static (int sum, int product) TripleCalc(int a, int b, int c)
        {
            int sum = a + b + c;
            int product = a * b * c;
            return (sum, product);
        }

    }
}
