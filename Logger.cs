using System;
using System.Collections.Generic;
using System.Text;

namespace fininex
{
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
            System.IO.File.AppendAllText(path, $"{DateTime.Now} | {flg} | {comment}\n");
        }

        public void data(string flg, string comment)
        {
            string path = test_logDataPath;
            System.IO.File.AppendAllText(path, $"{DateTime.Now} | {flg} | {comment}\n");
        }
    }
}
