namespace PaperlessRestAPI.logging
{
    public interface ILoggerWrapper
    {
        void Debug(string message);
        void Info(string message);
        void Warn(string message);
        void Error(string message);
        void Fatal(string message);
        
        
    }
}

//to use with: private static ILoggerWrapper logger = LoggerFactory.GetLogger();