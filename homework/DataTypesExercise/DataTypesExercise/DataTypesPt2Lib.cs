using System;

namespace DataTypesPt2Lib
{
    public enum Suit
    {
        HEARTS, CLUBS, DIAMONDS, SPADES
    }
    public class Methods
    {
        public static int AgeAt(DateTime birthDate, DateTime date)
        {
<<<<<<< HEAD
            return -1;
=======
            var age = DateTime.Now - birthDate;
            int age2 = (int)((age.Days) / 365.25);
            if (date < birthDate)
            {
                throw new ArgumentException("Error - birthDate is in the future");
            }
           
            
            return age2;
>>>>>>> master
        }

        public static string FormatDate(DateTime date)
        {
<<<<<<< HEAD
            return string.Empty;
        }
        public static string GetMonthString(DateTime date)
        {
            return string.Empty;
=======
            var date2 = date.ToString("yy/dd/MMM");
            return date2;
        }
        public static string GetMonthString(DateTime date)
        {
            var date2 = date.ToString("MMMM");
            return date2;
>>>>>>> master
        }

        public static string Fortune(Suit suit)
        {
<<<<<<< HEAD
            return string.Empty;
=======
            switch(suit)
            {
                case (Suit.HEARTS):
                    return "You've broken my heart";
                case (Suit.SPADES):
                    return "Bucket and spade";
                case (Suit.DIAMONDS):
                    return "Diamonds are a girls best friend";
                case (Suit.CLUBS):
                    return "And the seventh rule is if this is your first night at fight club, you have to fight.";
            }

            return "Hello";
        
>>>>>>> master
        }
    }
}