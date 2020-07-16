using System;

namespace lab_19_loop_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Select an option to run a loop" +
                              "\n1: prints from 1 to 300" +
                              "\n2: for every 100 shows my name" +
                              "\n3: each 5 show with 'th'" +
                              "\n4: countdown from 50 to 0\n");
            int userInput = Int32.Parse(Console.ReadLine());
            
            if(userInput > 4)
            {
                throw new ArgumentException("Invalid input");
            }
            Console.WriteLine($"You selected: {userInput}");
            UserSelection(userInput);
        }

        static void UserSelection(int userInput)
        {
            for (int i = 1; i <= 300; i++)
            {
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine(i);
                        break;
                    case 2:
                        Loop2();
                        break;
                    case 3:
                        Loop3();
                        break;
                    case 4:
                        Loop4();
                        break;
                }
            }
            
        }

        static void Loop1()
        {
            for (int i = 1; i <= 300; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Loop2()
        {
            for (int i = 1; i <= 300; i++)
            {
                if (i % 100 == 0)
                {
                    Console.WriteLine("Hi I am Leo");
                }
                Console.WriteLine(i);
            }
        }

        static void Loop3()
        {
            for (int i = 1; i <= 300; i++)
            {
                if (i == 5 || i == 105 || i == 205)
                {
                    Console.WriteLine($"{i}th");
                }
                Console.WriteLine(i);
            }
        }

        static void Loop4()
        {
            for (int i = 50; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
