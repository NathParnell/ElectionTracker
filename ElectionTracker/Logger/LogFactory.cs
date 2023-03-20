using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ElectionTracker.Logger
{

    public enum LoggerType
    {
        ConsoleLogger = 0,
        FileLogger = 1
    }

    public static class LogFactory
    {
        public static ILog CreateLogger(string serviceName, LoggerType loggerType)
        {
            if (loggerType == LoggerType.FileLogger)
            {
                ILog fileLogger = new FileLogger(serviceName);
                return fileLogger;
            }
            else
            {
                ILog consoleLogger = new ConsoleLogger(serviceName);
                return consoleLogger;
            }
        }

    }
}
