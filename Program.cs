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
            System.IO.File.AppendAllText(testlogPath, $"{DateTime.Now} .. fininex booting...\n");

            // APP START
            Console.Write("Start fininex? (y/n) ");
            var startApp = Console.ReadLine();
            if (startApp == "n")
            {
                System.IO.File.AppendAllText(testlogPath, $"{DateTime.Now} ?? start fininex user choice: no\n");
                Console.WriteLine("Fininex terminated. Goodbye!");
                System.IO.File.AppendAllText(testlogPath, $"{DateTime.Now} !! finninex closed.\n");
            }
            else
            {
                Console.WriteLine("Fininex starting...");
                System.IO.File.AppendAllText(testlogPath, $"{DateTime.Now} !! finninex started.\n");
            }

            // DATE CHECK
            Console.Write("Use today's date? (y/n) ");
            string dateQ = Console.ReadLine();
            if (dateQ == "n")
            {
                System.IO.File.AppendAllText(testlogPath, $"{DateTime.Now} ?? date user choice: no\n");
                Console.WriteLine("Starting fininex history mode...");
                System.IO.File.AppendAllText(testlogPath, $"{DateTime.Now} .. start fininex history mode\n");
                Console.Write("Please enter date: (YY/MM/DD) ");
                var dateHistory = Console.ReadLine();
                System.IO.File.AppendAllText(testlogPath, $"{DateTime.Now} UI {dateHistory}\n");
                Console.WriteLine(dateHistory);
            }
            else
            {
                System.IO.File.AppendAllText(testlogPath, $"{DateTime.Now} ?? date user choice: yes\n");
                DateTime now = DateTime.Now;
                System.IO.File.AppendAllText(testlogPath, $"{DateTime.Now} UI {now.ToString("d")}\n");
                Console.WriteLine(now.ToString("d"));
                                
            }

            // INCOME INPUT
            Earnings zarada = new Earnings();
            Console.WriteLine(zarada);
            

            // EXPENSES INPUT
            // BALANCE CALCULATION
            // EXIT PROGRAM
            System.IO.File.AppendAllText(testlogPath, $"{DateTime.Now} !! fininex terminated.\n");
        }
    }
}


// System.IO.File.AppendAllText(testlogPath, $"{DateTime.Now} \n");
