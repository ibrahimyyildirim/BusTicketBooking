using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tepe.BusTicketBooking.Core.Entities;
using tepe.BusTicketBooking.Core.Interfaces.Repositories;

namespace tepe.BusTicketBooking.DAL.Repositories
{
    public class TicketRepository : EntityFrameworkRepository<Ticket,TepeContext>, ITicketRepository
    {
        private readonly TepeContext _contextdb;
        public TicketRepository(TepeContext context) : base(context)
        {
            _contextdb = context;
        }
    }
}
