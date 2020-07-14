using System;
using System.Drawing;

namespace SafariPark
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Having overload constructor we can instantiate 3 differents objects with 3 differents attributes
            // We can set attributes by using the properties if we have a default constructor Eg: Person leo = new Person(){Leo, Xia};
            Person cathy = new Person("Cathy", "French") { Age = 14 };
            //Person nish = new Person();
            //Person phil = new Person("Phil", "Idk", 35);
            
            Point3D pt3d = new Point3D(5, 8, 1);
            DemoMethod(pt3d, cathy);
            Console.WriteLine(cathy.Age);
            Console.WriteLine(pt3d.y);

            //Console.WriteLine(cathy.GetFullName());
            //Person leo = new Person("Leo", "Xia");
            //Console.WriteLine(leo.GetFullName());
            //cathy.Age = 22;
            //Console.WriteLine($"Cathy is {cathy.Age}");
            //Console.WriteLine(cathy.GetFullName);
            
        }

        static void DemoMethod(Point3D pt, Person p)
        {
            pt.y = 1000;
            p.Age = 92;
        }
    }
}
