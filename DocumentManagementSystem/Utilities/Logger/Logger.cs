namespace Utilities
{
    using log4net;
    using log4net.Appender;
    using System;
    public class Logger
    {
        private readonly ILog logger;
        public Logger(Type t)
        {
            logger = LogManager.GetLogger(t.Name);
        }

        private static void WriteLog(string msg, Action<object> action)
        {
            string filename = "FileExplorer.log";
            var repository = LogManager.GetRepository();

            var appenders = repository.GetAppenders();
            if (appenders.Length > 0)
            {
                RollingFileAppender targetApder = null;
                foreach (var Apder in appenders)
                {
                    if (Apder.Name == "LogFileAppender")
                    {
                        targetApder = Apder as RollingFileAppender;
                        break;
                    }
                }
                if (targetApder != null)
                {
                    if (!targetApder.File.Contains(filename))
                    {
                        targetApder.File = @"Logs\" + filename;
                        targetApder.ActivateOptions();
                    }
                }
            }
            action(msg);
        }

        public void Error(string msg)
        {
            WriteLog(msg, this.logger.Error);
        }
        public void Info(string msg)
        {
            WriteLog(msg, this.logger.Info);
        }
        public void Warn(string msg)
        {
            WriteLog(msg, this.logger.Warn);
        }
    }
}
