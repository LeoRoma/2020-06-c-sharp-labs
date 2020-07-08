using System;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace lab_09_logging
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("Output.log", $"Printing i\n\n");

            #region loop with stopwatch

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                File.AppendAllText("Output.log", $"The value of i is {i} at {DateTime.Now} \n");
                Thread.Sleep(500);
            }

            stopwatch.Stop();

            Console.WriteLine($"Elapsed: {stopwatch.Elapsed}"); //seconds
            Console.WriteLine($"ElapsedMilliseconds: {stopwatch.ElapsedMilliseconds}"); // ms
            Console.WriteLine($"ElsapsedTicks: {stopwatch.ElapsedTicks}"); // 10 to power -7 seconds
            #endregion

            //Read our log file on console

            //1. Simple way - just all as on string
            Console.WriteLine($"\n\nOutput As String\n\n");
            string text = File.ReadAllText("Output.log");
            string text2 = File.ReadAllText("../../../Output2.log");
            Console.WriteLine(text);
            Console.WriteLine(text2);

            //2. Each line pushed into array
            Console.WriteLine($"\n\nOutput As Array\n\n");
            string[] lines = File.ReadAllLines("Output.log");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }


    }
}
