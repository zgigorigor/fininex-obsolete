using System;
using System.Collections.Generic;
using System.Text;

namespace fininex
{
    class Logger
    {
        public void LoggerControl(String lines)
        {
        
            // Write the string to a file.append mode is enabled so that the log
            // lines get appended to  test.txt than wiping content and writing the log
        
             System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Igor\\dev\\Training\\fininex\\fininextest.txt", true);
             file.WriteLine(lines);
        
             file.Close();
        
        }
    }
}
