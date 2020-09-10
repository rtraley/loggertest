using System;
using System.Configuration;
using System.IO;

namespace RLog
{
    public class Logger
    {
        private readonly string logFilename;
        private readonly string dateFormat;
        /// <summary>
        ///  Logs File  
        /// </summary>
        public Logger()
        {
            dateFormat = "yyyy-MM-dd HH:mm:ss.fff";
            string logFolderPath = ConfigurationManager.AppSettings["LogFilePath"];
            logFilename = logFolderPath + DateTime.Now.ToShortDateString() + ".log";
            if (string.IsNullOrEmpty(logFolderPath))
            {
                logFolderPath = Environment.CurrentDirectory;
            }
            if (!Directory.Exists(logFolderPath))
            {
                DirectoryInfo di = Directory.CreateDirectory(logFolderPath);
            }
        }

        /// <summary>
        ///  Write message to system file
        ///   <param name="level">Log level that the message belongs to</param>
        ///   <param name="message">String that should be logged</param>
        /// </summary>
        public void LogMessage(LogLevel level, string message)
        {
            string pretext = string.Format("{0} [{1}]", System.DateTime.Now.ToString(dateFormat), level);        
        }

        //Loglevel Definitions defined
        public enum LogLevel
        {          
            INFO,
            DEBUG,
            WARNING,
            ERROR,
            FATAL
        }
    }
}
