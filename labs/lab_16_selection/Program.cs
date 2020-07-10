using System;

namespace lab_16_selection
{
    public class Selection
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PassFail(39));

            int x = 5;
            int y = 10;

            var result = x > y ? "x is greater than y" : "x is less than y";
            Console.WriteLine(result);
        }

        public static string PassFail(int mark)
        {
            var grade = "Fail";
            if (mark >= 75 && mark <= 100)
            {
                return grade = "Distinction";
            }
            else if(mark >=60 && mark <= 74)
            {
                return grade = "Pass with merit";
            }
            else if (mark >= 40 && mark <= 59)
            {
                return grade = "Pass";
            }
            else 
            {
                return grade;
            }
 
        }

        public static string AlertLevel(int level)
        {
            string priority = "Code";

            switch(level)
            {
                case 3:
                    priority = priority + "Red";
                    break;
                case 2:
                    priority = priority + "Amber";
                    break;
                case 1:
                    priority = priority + "RedGreen";
                    break;
                default:
                    priority = "Error";
                    break;
            }
            return priority;
        }


    }
}
