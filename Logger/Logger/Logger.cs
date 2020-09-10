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
            
            if (string.IsNullOrEmpty(logFolderPath))
            {
                logFolderPath = Environment.CurrentDirectory;
            }
            if (!Directory.Exists(logFolderPath))
            {
                DirectoryInfo di = Directory.CreateDirectory(logFolderPath);
            }
            logFilename = logFolderPath + "\\" +  DateTime.Now.ToString("yyyyMMdd") + ".log";
        }


        /// <summary>
        ///  Write message to system file
        ///   <param name="message">The text to be written to the file</param>
        /// </summary>
        private void WriteToFile(string message)
        {
            //Log the Message to the File System and appends text
            using (StreamWriter sw = File.AppendText(logFilename))
            {
                sw.WriteLine(message);
            }

        }

        /// <summary>
        ///  Write message to system file
        ///   <param name="level">Log level that the message belongs to</param>
        ///   <param name="message">String that should be logged</param>
        /// </summary>
        public void LogMessage(LogLevel level, string message)
        {
            string premessage = string.Format("{0} [{1}]", System.DateTime.Now.ToString(dateFormat), level);
            WriteToFile(premessage + message);
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
