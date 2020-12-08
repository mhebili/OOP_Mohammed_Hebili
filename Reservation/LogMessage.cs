using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    public class LogMessage
    {
        public LogMessage(string msg)
        {
            Id = GenerateId(Id);
            Message = msg;
        }
        public string Message { get; set; }
        public int Id { get; set; }
        public int GenerateId(int maxId)
        {
            return Id + 1;
        }
    }
}
