using System;

namespace ForEachInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apples", "bananas", "oranges", "pears", "plums", "pine-apple" };

            foreach(string items in fruits)
            {
                Console.WriteLine(items);
                if (items =="plums")
                {
                    Console.WriteLine($"Boo, I dont like {items}");

                }
            }
        }
    }
}
