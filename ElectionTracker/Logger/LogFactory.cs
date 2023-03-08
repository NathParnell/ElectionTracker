using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ElectionTracker.Logger
{
    public static class LogFactory
    {
        /// <summary>
        /// calling this creates an instance of the File logger
        /// </summary>
        /// <param name="serviceName"></param>
        /// <returns></returns>
        public static ILog SetFileLogger(string serviceName)
        {
            ILog fileLogger = new FileLogger(serviceName);
            return fileLogger;
        }

        /// <summary>
        /// calling this creates an instance of the console logger
        /// </summary>
        /// <param name="serviceName"></param>
        /// <returns></returns>
        public static ILog SetConsoleLogger(string serviceName)
        {
            ILog consoleLogger = new ConsoleLogger(serviceName);
            return consoleLogger;
        }

    }
}
