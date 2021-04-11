using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tepe.BusTicketBooking.Core.Entities
{
    public class Ticket : BaseEntity
    {
        public bool IsSaled { get; set; }
        public double BasePrice { get; set; }
        public User Customer { get; set; }
        public Route Route { get; set; }

    }
}
