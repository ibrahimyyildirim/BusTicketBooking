using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tepe.BusTicketBooking.Core.Entities;

namespace tepe.BusTicketBooking.Core.Interfaces.Repositories
{
    public interface ITicketRepository : IRepository<Ticket>
    {
        Ticket getTicket(int ticketId);
    }
}
