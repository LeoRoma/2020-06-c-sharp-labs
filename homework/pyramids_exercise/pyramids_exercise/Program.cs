using System;

namespace pyramids_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Pyramid(3);
        }

        static void Pyramid(int number)
        {
            string bricks = "";
            for(int i = 0; i <= number + 1; i++)
            {
                bricks = new String('#', i);
                Console.WriteLine(bricks);
            }
            
        }
    }
}
