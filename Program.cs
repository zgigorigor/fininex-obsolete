using System;


namespace fininex
{
    class Program
    {
        static void Main(string[] args)
        {
            var testlogPath = "C:\\Igor\\dev\\Training\\fininex\\fininextest.txt";
            //var logPath = "C:\\Igor\\dev\\Training\\fininex\\fininexlog.txt";
            // LOGGER START
            System.IO.File.AppendAllText(testlogPath, $"{DateTime.Now} Fininex booting...\n");
            // APP START
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

            // DATE CHECK
            Console.Write("Use today's date? (y/n) ");
            string dateQ = Console.ReadLine();
            if (dateQ == "n")
            {
                Console.WriteLine("Starting fininex history...");
                Console.Write("Please enter date: (YY/MM/DD) ");
                var dateHistory = Console.ReadLine();
                Console.WriteLine(dateHistory);
            }
            else
            {

                DateTime now = DateTime.Now;
                Console.WriteLine(now.ToString("d"));
                                
            }
            
            // INCOME INPUT
            // EXPENSES INPUT
            // BALANCE CALCULATION
            // EXIT PROGRAM
        }
    }
}
