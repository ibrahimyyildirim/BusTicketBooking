using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tepe.BusTicketBooking.Core.DTO;
using tepe.BusTicketBooking.Core.RequestModels;

namespace tepe.BusTicketBooking.Core.Interfaces.Services
{
    public interface ITicketService : IService
    {
        Task<TicketDTO> SellTicket(SellTicketRequestModel req);
    }
}
