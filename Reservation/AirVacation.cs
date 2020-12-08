using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    public class AirVacation : Travel
    {
        private double AirTicket { get; set; }
        //CONSTRUCTORS
        public AirVacation(double airTicket, DateTime depurtateDate, DateTime returnDate) : base(depurtateDate, returnDate)
        {
            AirTicket = airTicket;
        }
        //METHODS
        public override double CalculatePrice()
        {
            return base.CalculatePrice() + AirTicket;
        }
    }
}
