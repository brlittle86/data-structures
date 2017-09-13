using System;
using System.Linq;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string that will be reversed:");
            StringReversal(Console.ReadLine());
        }

        //static void StringReversal(string entry)
        //{
        //    Console.WriteLine(new string(entry.ToCharArray().Reverse().ToArray()));
        //    Console.Read();
        //}

        static void StringReversal(string entry)
        {
            string output = "";
            for (int i = (entry.Length - 1); i > -1; i--)
            {
                output += entry[i];
            }
            Console.WriteLine(output);
            Console.Read();
        }


    }
}
