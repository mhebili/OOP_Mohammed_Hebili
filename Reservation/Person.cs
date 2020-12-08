using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    public class Person
    {
        public Address Address { get; set; }
        public string FamilyName { get; set; }
        public string FirstName { get; set; }
        public string Name { get; }
        public Person()
        {
            Name = FirstName + " " + FamilyName;
        }
    }
}
