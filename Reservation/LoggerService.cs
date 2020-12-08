using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    public static class LoggerService
    {
        private static LogMessage[] logs;

        static LoggerService()
        {   
            logs = new LogMessage[10];
        }

        public static void AddLogMessage(LogMessage message)
        {
            Array.Resize(ref logs, logs.Length + 1);
            logs[logs.Length - 1] = message;
        }
    }
}
