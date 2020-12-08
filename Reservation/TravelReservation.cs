using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    public class TravelReservation : ILoggable
    {
        public LogMessage LogMessage { get; }
        public Person Person { get; set; }
        public Travel Travel { get; set; }
        public TravelOffice TravelOffice { get; set; }
        public TravelReservation(Person person, Travel travel, TravelOffice travelOffice)
        {
            Person = person;
            Travel = travel;
            TravelOffice = travelOffice;
            LogMessage = new LogMessage("Reserved By: '"+ person.Name +"");
            LoggerService.AddLogMessage(LogMessage);
        }
    }
}
