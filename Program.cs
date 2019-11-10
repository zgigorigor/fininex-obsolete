using System;
using System.Timers;

namespace fininex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Start fininex? ");
            var startApp = Console.ReadLine();
            if (startApp == "no")
            {
                Console.WriteLine("Fininex terminated. Goodbye!");
            }
            else
            {
                Console.WriteLine("Fininex starting...");
            }

            Console.Write("Use today's date? (y/n) ");
            string dateQ = Console.ReadLine();
            if (dateQ == "n")
            {
                Console.WriteLine("Starting fininex history...");
            }
            else
            {

                DateTime now = DateTime.Now;
                Console.WriteLine(now.ToString("d"));
            }
            
        }
    }
}
