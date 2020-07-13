using System;

namespace lab_19_datatype_part_two
{
    class Program
    {
        static void Main(string[] args)
        {
            //var tps = TimeSpan.TicksPerSecond;
            //var nowInTicks = DateTime.Now.Ticks;
            //Console.WriteLine(tps); //How many ticks has a second
            //Console.WriteLine(nowInTicks); //Ticks of a day

            ////New date object mapped to midnight, 1 January 0001
            //var d = new DateTime();
            //var d1 = DateTime.Today;

            ////Now
            //var d2 = DateTime.Now;
            //Console.WriteLine(d2);

            //var d3 = new DateTime(2020, 7, 13, 10, 5, 18);

            ////Add one day
            //d = d.AddDays(1);
            ////Add month
            //d = d.AddMonths(1);

            //Calculate age
            //var leoBday = new DateTime(1986, 10, 19);
            //var age = DateTime.Now - leoBday;
            //int age2 = (int)((age.Days) / 365.25); //Implicit cast with int and "/" by 365.25
            //Console.WriteLine(age2);

            //Date formatting
            //var date = DateTime.Now.ToString("dd-MM-yyyy");
            //var date2 = leoBday.ToString("yy/MMM/dd");
            //Console.WriteLine(date);
            //Console.WriteLine(date2);

            //TimeSpan object

            //1 hour time span
            var timespan = new TimeSpan(1, 0, 0);
            //add this time right now
            var date = DateTime.Now + timespan;
            var tick = new TimeSpan(1);
            date += tick;
            Console.WriteLine(date);

            //Suit theSuit = Suit.HEARTS;
            ////int suit = (int)theSuit;
            ////Console.WriteLine(theSuit);
            //theSuit = Suit.SPADES;

            //switch (theSuit)
            //{
            //    case (Suit.HEARTS):
            //        Console.WriteLine("Hearts");
            //        break;
            //    case (Suit.SPADES):
            //        Console.WriteLine("Spades");
            //        break;
            //    case (Suit.DIAMONDS):
            //        Console.WriteLine("Diamonds");
            //        break;
            //    case (Suit.CLUBS):
            //        Console.WriteLine("Clubs");
            //        break;
            //}

            //Suit mySuit = (Suit)2;
            //Console.WriteLine(mySuit);
            //Console.WriteLine($"Sunday as Number is {(int)DayOfWeek.Sunday}"); //C# as built Enum and we can call it from DayOfWeek
            //Console.WriteLine($"Monday as Number is {(int)DayOfWeek.Monday}");
            //Console.WriteLine($"Tuesday as Number is {(int)DayOfWeek.Tuesday}");


            //Nullable
            //int totalCost = 0;
            //int? item = 3;
            //if(item.HasValue)
            //{
            //    totalCost = item.Value * 10;
            //}

            //int? nullableScore = null;
            //int score = nullableScore ?? -9999;


            //Dynamic Type possible to modify data type 
            //dynamic item = 100;
            //Console.WriteLine($"adding 10 to {item} gives {item + 10}");

            //item = "Hello";
            //Console.WriteLine($"adding 10 to {item} gives {item + 10}");


            //Random
            //var rng = new Random();
            //var rngSeeded = new Random(42);  Check seeding what it does
            //Console.WriteLine(rngSeeded);
            //var between1And10 = rngSeeded.Next(1, 11);

            //Console.WriteLine(between1And10);

            //var rnd = new Random(); //Instantiate new random object from the Random class
            //var rollDice = rnd.Next(1, 50); //With next we can set random numbers from  1 to 50
            //Console.WriteLine(rollDice);
        }

        //ENUM
        public enum Suit
        {
            HEARTS = 1, //Assign a default value and the enum after increases by 1
            CLUBS,
            DIAMONDS,
            SPADES
        }

        public enum Days
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday = 8,
            Friday,
            Saturday,
            Sunday

        }

        //#region Random Card

        //var rand = new Random();
        //Suit theSuit = Suit.HEARTS;
       
        //    for (int i = 0; i< 10; i++)
        //    {
        //        int suitNum = rand.Next(1, 5);
        //int cardNum = rand.Next(1, 14);

 

        //        switch (suitNum)
        //        {
        //            case (1):
        //                theSuit = Suit.HEARTS;
        //                break;
        //            case (2):
        //                theSuit = Suit.CLUBS;
        //                break;
        //            case (3):
        //                theSuit = Suit.DIAMONDS;
        //                break;
        //            case (4):
        //                theSuit = Suit.SPADES;
        //                break;
        //        }

 


        //        switch (theSuit)
        //        {
        //            case (Suit.HEARTS):
        //                Console.WriteLine(cardNum + " of Hearts");
        //                break;
        //            case (Suit.CLUBS):
        //                Console.WriteLine(cardNum + " of Clubs");
        //                break;
        //            case (Suit.DIAMONDS):
        //                Console.WriteLine(cardNum + " of Diamonds");
        //                break;
        //            case (Suit.SPADES):
        //                Console.WriteLine(cardNum + " of Spades");
        //                break;
        //        }            
        //    }
            
        //    #endregion
    }
}
