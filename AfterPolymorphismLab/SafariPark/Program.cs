using ClassesApp;
using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace SafariPark
{
    public class Program
    {
        public static void Main()
        {

            //Hunter bryn = new Hunter("Bryn", "Morley", "Sony") { Age = 25 };
            //Console.WriteLine(bryn);
            //Console.WriteLine(bryn.Age);
            //Console.WriteLine(bryn.Shoot());

            //Person nish = new Person("Nish", "Mandal");
            //Hunter cathy = new Hunter("Cathy", "French", "Nikon");
            //MonsterHunter phil = new MonsterHunter("Phil", "Anderson", "Nikon", "Love");

            //var safariList = new List<Hunter>();

            //safariList.Add(cathy);
            //safariList.Add(phil);

            //foreach (var item in safariList)
            //{
            //    Console.WriteLine(item);
            //}

            //Airplane a = new Airplane(200, 100, "JetsRUs")
            //{ NumPassengers = 150 };
            //a.Ascend(500);
            //Console.WriteLine(a.Move(3));
            //Console.WriteLine(a);
            //a.Descend(200);
            //Console.WriteLine(a.Move());
            //a.Move();
            //Console.WriteLine(a);

            //List<Object> gameObjects = new List<Object>()
            //     {
            //       new Person("Cathy", "French"),
            //       new Airplane(400,200,"Booing"),
            //       new Vehicle(12, 20),
            //       new Hunter("Henry", "Hodgkins", "Pentax")
            //     };
            //foreach (var gameObj in gameObjects)
            //{
            //    Console.WriteLine(gameObj);
            //}

            //var yolanda = new Person("Yolanda", "Young");
            //SpartaWrite(yolanda);


            ////var nish = new Hunter("Nish", "Mandal", "Leica");
            ////SpartaWrite(nish);

            //static void SpartaWrite(Object obj)
            //{
            //    Console.WriteLine(obj.ToString());

            //        var hunterObj = (Hunter)obj;
            //        Console.WriteLine(hunterObj.Shoot());

            //}

            //var cathy = new Person("Cathy", "French");
            //var booing = new Airplane(400, 200, "Booing");
            //var vehicle = new Vehicle(12, 20);
            //var henry = new Hunter("Henry", "Hodgkins", "Pentax");

            //List<IMovable> gameObjects = new List<IMovable>()
            //     {
            //       cathy,
            //       booing,
            //       vehicle,
            //       henry
            //     };

            //foreach (var item in gameObjects)
            //{

            //    Console.WriteLine(item.Move());
            //}

            //var theWeapons = new List<IShootable>();
            //theWeapons.Add(new WaterPistol("ToysRUs"));
            //theWeapons.Add(new LaserGun("Acme"));
            //theWeapons.Add(new Hunter("Cathy", "French", new Camera("Minolta")));
            //theWeapons.Add(new Camera("Pentax"));
            //foreach (var w in theWeapons)
            //{
            //    Console.WriteLine(w.Shoot());
            //}
            Console.WriteLine();
            Console.WriteLine("Polymorphic shootout");
            Camera pentax = new Camera("Pentax");
            WaterPistol pistol = new WaterPistol("Supersoaker");
            LaserGun laserGun = new LaserGun("Acme");
            Hunter nish = new Hunter("Nish", "Mandal", pentax);
            Console.WriteLine(nish.Shoot());
            nish.Shooter = pistol;
            Console.WriteLine(nish.Shoot());
            nish.Shooter = laserGun;
            Console.WriteLine(nish.Shoot());
            nish.Shooter = pistol;
            Console.WriteLine(nish.Shoot());
            Hunter phil = new Hunter("Phil", "Anderson");
            Console.WriteLine(phil.Shoot());

        }
    }

}