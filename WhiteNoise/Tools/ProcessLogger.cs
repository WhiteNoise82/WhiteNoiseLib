using System;
using System.IO;

namespace WhiteNoise.Tools
{
    public interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }

    }

    public class FileLogger : ILogger
    {
        private StreamWriter writer;
        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }
        public void WriteLog(string message)
        {
            writer.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), message);
        }
    }

    public class ClimateMonitor
    {
        public ILogger logger;
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }

        public void LogStart(string descreption, int index, object value)
        {
            logger.WriteLog(index + descreption + ": " + value);
        }
    }
}
