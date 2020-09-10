using System;
using RLog;
namespace LoggerUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();

            //Creates a Debug Message
            logger.LogMessage(Logger.LogLevel.DEBUG, "This is a debug message");


            // Creates a Info Messsage
            logger.LogMessage(Logger.LogLevel.INFO, "This is an info message");
        }
    }
}
