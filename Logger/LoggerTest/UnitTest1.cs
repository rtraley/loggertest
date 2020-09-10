using NUnit.Framework;
using RLog;
using static RLog.Logger;

namespace LoggerTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestLoggingMessage()
        {
            //TODO Need to add test to check if error message was logged
            Logger objLogger = new Logger();
            objLogger.LogMessage(LogLevel.DEBUG, "This is a Debug ERROR");
            Assert.Pass();
       
        }
    }
}