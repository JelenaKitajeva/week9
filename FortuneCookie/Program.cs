using System;

namespace FortuneCookie
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] cookie = { "Win a Jackpot", "Fall in love", "Get a love letter", "Miss the bus", "See a unicorn un the street"};

            Random rnd = new Random();
            int randomIndex = rnd.Next(0, cookie.Length);


            Console.WriteLine($" Here's your prediction -  {cookie[randomIndex]}.");
        }
    }
}
