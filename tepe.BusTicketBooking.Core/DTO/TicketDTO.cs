using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tepe.BusTicketBooking.Core.DTO
{
    public class TicketDTO : BaseDTO
    {
        public bool IsSaled { get; set; }
        public double BasePrice { get; set; }

    }
}
