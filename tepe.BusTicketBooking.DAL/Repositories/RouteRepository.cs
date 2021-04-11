using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tepe.BusTicketBooking.Core.DTO;
using tepe.BusTicketBooking.Core.Entities;
using tepe.BusTicketBooking.Core.Interfaces.Repositories;

namespace tepe.BusTicketBooking.DAL.Repositories
{
    public class RouteRepository : EntityFrameworkRepository<Route, TepeContext>, IRouteRepository
    {
        private readonly TepeContext _contextdb;
        public RouteRepository(TepeContext context):base(context)
        {
            _contextdb = context;
        }

        public async Task<Route> CreateRouteAsync(RouteDTO route) {
            var tlist = new List<Ticket>();
            var response = await
            _contextdb.Routes.AddAsync(new Route {
                Destination = route.Destination,
                Source = route.Source,
                Date = route.Date,
                TicketList = new List<Ticket>()
            });
            for (int i = 0; i < 20; i++)
            {
                tlist.Add(new Ticket
                {
                    BasePrice = 100,
                    IsSaled = false,
                    Route = response.Entity
                });
            }
            response.Entity.TicketList = tlist;
            _contextdb.SaveChanges();
            return response.Entity;
        }

        public async Task<List<RouteDTO>> GetRoutesAsync()
        {
            var rlist = new List<RouteDTO>();
            var res = await _contextdb.Routes
                .Include(x => x.TicketList)
                    .ThenInclude(t => t.Customer)
                .Where(r => r.Date >= DateTime.UtcNow && !r.IsDeleted)
                .ToListAsync();
            // Map List<Route> to List<RouteDTO>
            res.ForEach(r =>
            {
                var tlist = new List<TicketDTO>();
                // Map List<Ticket> to List<TicketDTO>
                r.TicketList.ForEach(t =>
                {
                    tlist.Add(new TicketDTO
                    {
                        BasePrice = t.BasePrice,
                        Id = t.Id,
                        IsSaled = t.IsSaled
                    });
                });
                rlist.Add(new RouteDTO
                {
                    Date = r.Date,
                    Destination = r.Destination,
                    Id = r.Id,
                    Source = r.Source,
                    TicketList = tlist
                });
            });
            return rlist;
        }
    }
}
