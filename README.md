# Logger Test Application

## Below are examples of usage 
`

            Logger logger = new Logger();

            //Creates a Debug Message
            logger.LogMessage(Logger.LogLevel.DEBUG, "This is a debug message");

            // Creates an Info Messsage
            logger.LogMessage(LogLevel.INFO, "This is an info message");

            // Creates an Error Messsage
            logger.LogMessage(LogLevel.ERROR, "This is an error message");

            // Creates a Fatal Messsage
            logger.LogMessage(LogLevel.FATAL, "This is a fatal message");

`
