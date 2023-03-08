using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionTracker.Logger
{
    public class FileLogger : LogBase
    {
        public FileLogger(string serviceName) : base(serviceName)
        {

        }

        public override void LogInternal(string message)
        {
            string logpath = ConfigurationManager.AppSettings["logPath"];

            if (Directory.Exists(logpath) == false)
            {
                Directory.CreateDirectory(logpath);
            }

            logpath = logpath + "/log.txt";

            using (StreamWriter writer = new StreamWriter(logpath, true))
            {
                writer.WriteLine(message);
            }
        }


    }
}
