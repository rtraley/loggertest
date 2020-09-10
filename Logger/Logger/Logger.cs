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

    }
}
