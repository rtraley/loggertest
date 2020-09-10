using System;
using RLog;
using static RLog.Logger;

namespace LoggerUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();

            //Creates a Debug Message
            logger.LogMessage(Logger.LogLevel.DEBUG, "This is a debug message");

            // Creates an Info Messsage
            logger.LogMessage(LogLevel.INFO, "This is an info message");

            // Creates an Error Messsage
            logger.LogMessage(LogLevel.ERROR, "This is an error message");

            // Creates a Fatal Messsage
            logger.LogMessage(LogLevel.FATAL, "This is a fatal message");
        }
    }
}
