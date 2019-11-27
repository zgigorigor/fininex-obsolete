﻿using System;

class Logger
{
    //string logPath = "C:\\Igor\\dev\\Training\\fininex\\fininexlog.txt";
    //string logDataPath = "C:\\Igor\\dev\\Training\\fininex\\fininexdata.txt";
    string test_logPath = "C:\\Igor\\dev\\Biig_dev\\fininex\\log\\test_fininexlog.txt";
    string test_logDataPath = "C:\\Igor\\dev\\Biig_dev\\fininex\\log\\test_fininexdata.txt";

    //string logPath = "D:\\dev\\Biig_dev\\cs\\log\\fininexlog.txt";
    //string logDataPath = "D:\\dev\\Biig_dev\\cs\\log\\fininexdata.txt";
    //string test_logPath = "D:\\dev\\Biig_dev\\cs\\log\\test_fininexlog.txt";
    //string test_logDataPath = "D:\\dev\\Biig_dev\\cs\\log\\test_fininexdata.txt";

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

class Income
{
    public void amount(string incomeAmountTemp)
    {
        //int incomeAmount = Int32.Parse(incomeAmountTemp);
        //string incomeAmountFormated = incomeAmount.ToString("0.00");
        Logger logging = new Logger();
        //logging.data(" + ", $"income amount: {incomeAmountFormated}");
        logging.data(" + ", $"income amount: {incomeAmountTemp}");
    }
}

class Expenses
{
    // hendla troskove
    public void amount(int expenseAmountTemp)
    {

        Logger logging = new Logger();
        logging.data(" - ", $" expense amount: {expenseAmountTemp}");
    }
}

class Balance
{
    // hendla konačno stanje računa
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
            if (dateQ != "n")
            {
                logging.info("???", "today's date? choice: yes");
                DateTime now = DateTime.Now;
                logging.info("INP", $"input for {now.ToString("d")}");
                Console.WriteLine(now.ToString("d"));
            }
            else
            {
                logging.info("???", "today's date? choice: no");
                Console.WriteLine("Starting fininex history mode...");
                logging.info("!!!", "start fininex history mode");
                Console.Write("Please enter date: (YY/MM/DD) ");
                var dateHistory = Console.ReadLine();
                logging.info("INP", $"input for {dateHistory}");
                Console.WriteLine($"Entering data for: {dateHistory}");
            }

            // INCOME INPUT
            Income income = new Income();
            bool startInput;
            Console.Write("Would you like to input income amount? (y/n) ");
            var startInp = Console.ReadLine();
            if (startInp == "n")
            {
                startInput = false;
                return;
            }
            else
            {
                startInput = true;
            }
            do
            {
                string subStr = ".";
                Console.Write("Income amount (n.nn): ");
                string tempIncomeInput1 = Console.ReadLine();
                if (tempIncomeInput1.Contains(subStr)) {income.amount(tempIncomeInput1);}
                else
                {
                    int tempIncomeInput2 = Int32.Parse(tempIncomeInput1);
                    string inputFormat = tempIncomeInput2.ToString("0.00");
                    income.amount(inputFormat);
                }
                Console.Write("More income? (y/n) ");
                startInp = Console.ReadLine();
                if (startInp == "n")
                {
                    Console.WriteLine("Income recorded. Proceed to expenses input");
                    logging.info("!!!", "finished income input");
                    startInput = false;
                    break;
                }
            } while (startInput == true);


            // EXPENSES INPUT
            
            // BALANCE CALCULATION

            // EXIT PROGRAM
            //End:
            Console.WriteLine("Fininex closing. Goodbye!");
            logging.info("!!!", "fininex terminated.");
        }
    }
}