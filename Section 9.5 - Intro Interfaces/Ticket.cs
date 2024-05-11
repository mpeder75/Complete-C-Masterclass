using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_9._5___Intro_Interfaces
{
    // vil man bruge equals skal man specificiere hvilken type objekt <Ticket>
    // man har tænkt sig at bruge i equals metoden
    class Ticket : IEquatable<Ticket>
    {
        public int DurationInHours { get; set; }

        public Ticket(int durastionInHours)
        {
            DurationInHours = durastionInHours;
        }

        public bool Equals(Ticket? other)
        {
            // sammenligner om 2 tickets this/other har samme durationInHours,
            // returner true/false
            return this.DurationInHours == other.DurationInHours;           
        }
    }
}
