using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tepe.BusTicketBooking.Core.DTO;
using tepe.BusTicketBooking.Core.RequestModels;
using tepe.BusTicketBooking.Core.ResponseModels;

namespace tepe.BusTicketBooking.Core.Interfaces.Services
{
    public interface IRouteService : IService
    {
        Task<CreateRouteResponseModel> CreateRouteAsync(CreateRouteRequestModel route);
        Task<List<RouteDTO>> GetRoutesAsync();
    }
}
