using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    public abstract class Travel
    {
        private const int dailyRate = 40;
        //PROPERTIES
        public int Days { get; }
        public int Persons { get; set; }
        public DateTime DepurtureDate { get; set; }
        public DateTime ReturnDate { get; set; }
        //CONSTRUCTORS
        public Travel(DateTime DepurtureDate, DateTime ReturnDate)
        {
            if (DepurtureDate.Date < DateTime.Today)
            {
                Console.WriteLine("Departure date can't be on past");
            }

            if (ReturnDate.Date < DepurtureDate.Date)
            {
                Console.WriteLine("Reurn Date must be after Depurture Date");
            }
            if (DepurtureDate.Date > ReturnDate.Date)
            {
                Console.WriteLine("De vertrekdatum moet voor de terugkeerdatum zijn");
            }
            Days = (int)(ReturnDate.Day - DepurtureDate.Day);
        }
        //METHODS
        public virtual double CalculatePrice()
        {
            return dailyRate * Days * Persons;
        }
    }
}
