using System;

namespace MatterOfTaste
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = new string[]
             {"red","blue","green"};

            Console.Write("Enter your favorite color: ");

            string Coloruser = Console.ReadLine().ToLower();

            if (Array.Exists(colors, color => color.Equals(Coloruser)))
            {
                Console.WriteLine($"We are perfect together. I like {Coloruser} too!");
            }
            else
            {
                Console.WriteLine($"Every man to his taste. I dont like {Coloruser}(((");

            }
        }
    }
}
