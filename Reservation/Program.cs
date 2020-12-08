using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    class Program
    {
        static void Main(string[] args)
        { }

            public class LoggerService : ILoggable
        {
            private static LogMessage[] logs;

            static LoggerService()
            {
                logs = new LogMessage[10];
            }

            public void AddLogMessage(LogMessage message)
            {
                message.Id = logs.Length == 0 ? 0 : logs.Max(x => x.Id);
                LogMessage logMessage = new LogMessage(message.Id, message.Message);
                logs[logs.Length + 1] = logMessage;
            }
        }

        public interface ILoggable
        {
            void AddLogMessage(LogMessage logMessage);
        }

        public class LogMessage
        {
            public LogMessage(int maxId, string msg)
            {
                Id = GenerateId(maxId);
                Message = msg;
            }
            public string Message { get; set; }
            public int Id { get; set; }
            public int GenerateId(int maxId)
            {
                return maxId + 1;
            }
        }

        public class AccessorLogger
        {
            private readonly ILoggable _loggable;
            public AccessorLogger()
            {
                _loggable = new LoggerService();
            }

            public ILoggable logService
            {
                get { return _loggable; }
            }
            public void AddLogMessage(LogMessage logMessage)
            {
                _loggable.AddLogMessage(logMessage);
            }
        }
    }

    
}

    