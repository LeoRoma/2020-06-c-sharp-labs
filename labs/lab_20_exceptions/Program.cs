using System;

namespace lab_20_exceptions
{
    public class Program
    {
        private static string[] _theBeatles = new string[] { "John", "Paul", "George", "Ringo" };
        static void Main(string[] args)
        {
            //AddBeatle(4, "Brian");

            //int x = 10;
            //int y = 0;

            //try
            //{
            //    int output = x / y;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"An exception occurred {e}");
            //    Console.WriteLine($"An exception occurred {e.ToString()}");
            //    Console.WriteLine($"An exception occurred {e.Data}");
            //    Console.WriteLine($"An exception occurred {e.Message}");

            //}
            //finally
            //{
            //    Console.WriteLine("But life goes on...");
            //}
            checked
            {
                int three = 3;
                int sum = int.MaxValue + three;
                Console.WriteLine(sum);
            }
        }

        public static void AddBeatle(int pos, string name)
        {
            //if(pos < 0 || pos >= _theBeatles.Length)
            //{
            //    throw new ArgumentException($"The Beatles do have a position {pos}");
            //}
            //_theBeatles[pos] = name;
            try
            {
                _theBeatles[pos] = name;
            }
            catch (Exception e)
            {
                Console.WriteLine("Can't add a fifth Beatle");
            }
            finally
            {
                Console.WriteLine("Here comes the sun!");
            }
        }

    }
}
