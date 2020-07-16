using System;

namespace pyramids_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Select an option to run your pyramid" +
                              "\n1: Creates a pyramid between 1 and 25" +
                              "\n2: Creates a pyramid by using only odd numbers between 1 and 25\n");
            int userInputSelection = Int32.Parse(Console.ReadLine());

            Console.Write("Give a number between 1 and 25\n");
            int userInputLoop = Int32.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine($"You selected: {userInputSelection}");
                UserSelection(userInputSelection, userInputLoop);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void UserSelection(int userInput, int userInputLoop)
        {
            switch (userInput)
            {
                case 1:
                    Pyramid(userInputLoop);
                    break;
                case 2:
                    
                    PyramidOdd(userInputLoop);
                    break;
            }
        }

        static void Pyramid(int number)
        {
            
            if (number > 25)
            {
                throw new ArgumentException("Sorry I can accept only a number between 1 and 25");
            }
            string bricks = "";
            for (int i = 0; i <= number; i++)
            {
                bricks = new String('#', i);
                Console.WriteLine(bricks);
            }
        }

        static void PyramidOdd(int number)
        {
            
            if (number > 25)
            {
                throw new ArgumentException("Sorry I can accept only a number between 1 and 25");
            }
            string bricks = "";
            for (int i = 0; i <= number; i++)
            {
                
                if (i % 2 != 0)
                {
                    bricks = new String('#', i);
                    Console.WriteLine(bricks);
                }    
            }
        }

    }
}
