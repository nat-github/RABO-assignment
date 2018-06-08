using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace Rabo_assignment
{
    static class Logging
    {
        static string logfile = ConfigurationSettings.AppSettings["logfile"];
        public static void log_message(string message)
        {
            StreamWriter log;
            if(!File.Exists(logfile))
            {
                log = new StreamWriter(logfile);
            }
            else
            {
                log = File.AppendText(logfile);
            }
            log.WriteLine(message);
            log.Close();
        }
    }
}
