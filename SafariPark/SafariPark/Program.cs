using System;
using System.Collections.Generic;
using System.Drawing;

namespace SafariPark
{
    class Program
    {
        static void Main(string[] args)
        {
            // Having overload constructor we can instantiate 3 differents objects with 3 differents attributes
            // We can set attributes by using the properties if we have a default constructor Eg: Person leo = new Person(){Leo, Xia};
            //Person cathy = new Person("Cathy", "French") { Age = 14 }; //{Age= 14} => Object initialiser
            //Person nish = new Person();
            //Person phil = new Person("Phil", "Idk", 35);

            //Point3D pt3d = new Point3D(5, 8, 1);
            //DemoMethod(pt3d, cathy);
            //Console.WriteLine(cathy.Age);
            //Console.WriteLine(pt3d.y);

            //Console.WriteLine(bryn.GetType()); //returns the runtime type of the current instance.
            //Person leo = new Person("Leo", "Xia"); //With abstract cannot be instatiated/ With Sealed cannot be used for intheritance
            Person nish = new Person("Nish", "Mandal");
            Hunter cathy = new Hunter("Cathy", "French");
            MonsterHunter phil = new MonsterHunter("Phil", "Anderson", "Nikon", "Love");
            var safariList = new List<Person>();
            safariList.Add(nish);
            safariList.Add(cathy);
            safariList.Add(phil);

            foreach (var item in safariList)
            {
                Console.WriteLine(item);
            }
        }

        static void DemoMethod(Point3D pt, Person p)
        {
            pt.y = 1000;
            p.Age = 92;
        }
    }
}
