using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tepe.BusTicketBooking.Core.DTO;

namespace tepe.BusTicketBooking.Core.ResponseModels
{
   public class CreateRouteResponseModel
    {
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime Date { get; set; }
    }
}
