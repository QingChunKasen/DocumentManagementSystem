namespace Utilities
{
    using System;
    using System.IO;

    public class LoggerBootstrap
    {
        public void Setup()
        {
            log4net.Config.XmlConfigurator.Configure(new FileInfo(@"..\..\Config\Log4net.config"));
        }
    }
}
