using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tepe.BusTicketBooking.Core.DTO;

namespace tepe.BusTicketBooking.Core.ResponseModels
{
    public class GetRoutesResponseModel
    {
        public List<RouteDTO> Items { get; set; }
        public int  ItemCount { get; set; }
    }
}
