using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tepe.BusTicketBooking.Core.Entities
{
    public class Route : BaseEntity
    {
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime Date { get; set; }
        public List<Ticket> TicketList { get; set; }
    }
}
