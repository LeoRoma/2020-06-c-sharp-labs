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
            //Person cathy = new Person("Cathy", "French") { Age = 14 }; //{Age= 14} => Object initialiser
            //Person nish = new Person();
            //Person phil = new Person("Phil", "Idk", 35);

            //Point3D pt3d = new Point3D(5, 8, 1);
            //DemoMethod(pt3d, cathy);
            //Console.WriteLine(cathy.Age);
            //Console.WriteLine(pt3d.y);

            //Hunter bryn = new Hunter("Bryn", "Morley", "Sony") { Age = 25 };
            //Console.WriteLine(bryn.Shoot());
            //Console.WriteLine(bryn.Age);

            Hunter jimmy = new Hunter();
            Console.WriteLine(jimmy.Shoot());
        }

        static void DemoMethod(Point3D pt, Person p)
        {
            pt.y = 1000;
            p.Age = 92;
        }
    }
}
