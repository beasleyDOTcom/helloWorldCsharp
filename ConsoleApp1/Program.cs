using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine} Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine} Press any key to exit...");
            Console.WriteLine("what would you like to me to say?");
            string message = Console.ReadLine();
            Console.WriteLine("How many times would you like me to say that?");
            string times = Console.ReadLine();
            int howManyTimes = int.Parse(times);


            int i = 0;
            while (i < (howManyTimes) )
            {
                Console.WriteLine(message);
                i++;
            }
        }
    }
}
