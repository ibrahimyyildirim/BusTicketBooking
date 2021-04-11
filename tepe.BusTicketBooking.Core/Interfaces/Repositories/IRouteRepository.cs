using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tepe.BusTicketBooking.Core.DTO;
using tepe.BusTicketBooking.Core.Entities;

namespace tepe.BusTicketBooking.Core.Interfaces.Repositories
{
    public interface IRouteRepository : IRepository<Route>
    {
        Task<Route> CreateRouteAsync(RouteDTO route);
        Task<List<RouteDTO>> GetRoutesAsync();
    }
}
