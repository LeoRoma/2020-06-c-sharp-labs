using System;
using System.Threading;
using System.Threading.Tasks;

namespace lab_28_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Async - Main() thread


            // Sync - sequence in order

            // Process = .exe running application which is able to send commands to CPU for processing

            // Thread ==> set of instructions bundled up and sent to CPU for processing

            // Main()
            //{
            //Sub() ==> execute as different process on computer   
            //}

            // C# Threading ==> manually create thread
            // Tasks ==> hard work removed ==> easy for programmer to work with sub-threads/sub-tasks

            // Key Words

            //Process - running exe
            //Application - run by user and runs in foreground 
            //Service - run by the computer at startup and runs in background (DNS, DHCP, WebSite)
            //Thread - set of instructions sent to CPU for processing
            //Single-Threaded runs on main thread only
            //Multi-Threaded can take advantage of multi-core CPUs which can run multiple threads simultaneously

            // Faster? NO
            // Scale out - More CPUs YES

            var thread = new Thread(
                () => { Console.WriteLine("This is a thread"); }
            );

            thread.Start();

            var task01 = new Task(
                () => { Console.WriteLine("This is a task"); }
            );

            task01.Start();

            // Create and start
            var task02 = Task.Run(
                () => { Console.WriteLine("Creating and running task at same time"); }
            );

            Console.ReadLine();
        }
    }
}
