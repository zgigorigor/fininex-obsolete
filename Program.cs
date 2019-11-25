using System;

class Logger
{
    //string logPath = "C:\\Igor\\dev\\Training\\fininex\\fininexlog.txt";
    //string logDataPath = "C:\\Igor\\dev\\Training\\fininex\\fininexdata.txt";
    //string test_logPath = "C:\\Igor\\dev\\Training\\fininex\\test_fininexlog.txt";
    //string test_logDataPath = "C:\\Igor\\dev\\Training\\fininex\\test_fininexdata.txt";

    //string logPath = "D:\\dev\\Biig_dev\\cs\\log\\fininexlog.txt";
    //string logDataPath = "D:\\dev\\Biig_dev\\cs\\log\\fininexdata.txt";
    string test_logPath = "D:\\dev\\Biig_dev\\cs\\log\\test_fininexlog.txt";
    string test_logDataPath = "D:\\dev\\Biig_dev\\cs\\log\\test_fininexdata.txt";

    public void info(string flg, string comment)
    {
        string path = test_logPath; 
        //Console.WriteLine("test logging");
        System.IO.File.AppendAllText(path, $"{DateTime.Now} | {flg} | {comment}\n");
    }

    public void data(string flg, string comment)
    {
        string path = test_logDataPath;
        //Console.WriteLine("test logging");
        System.IO.File.AppendAllText(path, $"{DateTime.Now} | {flg} | {comment}\n");
    }
}

namespace fininex
{
    class Program
    {
        static void Main(string[] args)
        {
            // LOGGER START
            Logger logging = new Logger();
            logging.info("!!!", "fininex booting...");

            // APP START
            Console.Write("Start fininex? (y/n) ");
            var startApp = Console.ReadLine();
            if (startApp == "n")
            {
                logging.info("???", "start fininex? choice: no");
                Console.WriteLine("Fininex terminated. Goodbye!");
                logging.info("!!!", "finninex closed.");
                return;
            }
            else
            {
                logging.info("???", "start fininex? choice: yes");
                Console.WriteLine("Fininex starting...");
                logging.info("!!!", "finninex started.");
            }

            // DATE CHECK
            Console.Write("Use today's date? (y/n) ");
            string dateQ = Console.ReadLine();
            if (dateQ == "n")
            {
                logging.info("???", "today's date? choice: no");
                Console.WriteLine("Starting fininex history mode...");
                logging.info("!!!", "start fininex history mode");
                Console.Write("Please enter date: (YY/MM/DD) ");
                var dateHistory = Console.ReadLine();
                logging.info("INP", $"input for {dateHistory}");
                Console.WriteLine(dateHistory);
            }
            else
            {
                logging.info("???", "today's date? choice: yes");
                DateTime now = DateTime.Now;
                logging.info("INP", $"input for {now.ToString("d")}");
                Console.WriteLine(now.ToString("d"));
                                
            }

        // INCOME INPUT
        //Earnings zarada = new Earnings();
        //Console.WriteLine(zarada);


        // EXPENSES INPUT
        // BALANCE CALCULATION
        // EXIT PROGRAM
        //System.IO.File.AppendAllText(testlogPath, $"{DateTime.Now} !! fininex terminated.\n");
        
         
        }
    }
}


//// System.IO.File.AppendAllText(testlogPath, $"{DateTime.Now} \n");
