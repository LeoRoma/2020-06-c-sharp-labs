using System;
using System.Collections;
using System.Collections.Generic;

namespace lab_21_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue FIFO -> First In First Out
            //var myQueue = new Queue<string>();

            //myQueue.Enqueue("First item");
            //myQueue.Enqueue("Second item");
            //myQueue.Enqueue("Third item");
            //myQueue.Enqueue("Fourth item");
            //Console.WriteLine(myQueue.Peek());
            //myQueue.Dequeue();
            //Console.WriteLine(myQueue.Peek());
            //Console.WriteLine(myQueue.Contains("Third Item"));

            //Stack
            //var myStack = new Stack<string>();
            ////Add item into Stack
            //myStack.Push("item1");
            //myStack.Push("item2");
            //myStack.Push("item3");
            ////Pop() delete last item added
            //myStack.Pop();
            //foreach(var item in myStack)
            //{
            //    Console.WriteLine(item);
            //}

            //Dictionary
            //Initialize an empty dictionary and add items
            //var personDict = new Dictionary<int, string>();
            //personDict.Add(1, "Leo");
            //personDict.Add(2, "Alex");
            //personDict.Add(3, "Bruno");

            //Initialise a dictionary with values
            //var personDict1 = new Dictionary<int, string>()
            //{
            //    {1, "Leo"},
            //    {2, "Alex"},
            //    {3, "Bruno"}
            //};
            ////Check all items in Dictionary
            //foreach(var key in personDict1.Keys)
            //{
            //    Console.WriteLine($"Index/key is {key} and value is {personDict1[key]}");
            //}

            string input = "We are Sparta!";
            input = input.Trim().ToLower();
            var countD = new Dictionary<char, int>();

            foreach(var c in input)
            {
                if(countD.ContainsKey(c))
                {
                    countD[c]++;
                }
                else
                {
                    countD.Add(c, 1);
                }
            }

            foreach(var entry in countD)
            {
                Console.WriteLine(entry);
            }
        }
    }
}
