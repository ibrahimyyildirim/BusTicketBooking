using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tepe.BusTicketBooking.Core.RequestModels
{
    public class SellTicketRequestModel
    {
        public int UserId { get; set; }
        public int TicketId { get; set; }
    }
}
