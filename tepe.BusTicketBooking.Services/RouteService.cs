using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using tepe.BusTicketBooking.Core.DTO;
using tepe.BusTicketBooking.Core.Interfaces.Repositories;
using tepe.BusTicketBooking.Core.Interfaces.Services;
using tepe.BusTicketBooking.Core.RequestModels;
using tepe.BusTicketBooking.Core.ResponseModels;

namespace tepe.BusTicketBooking.Services
{
    public class RouteService : IRouteService
    {
        private readonly IRouteRepository _routeRepository;
        public RouteService(IRouteRepository routeRepository)
        {
            _routeRepository = routeRepository;
        }

        public async Task<CreateRouteResponseModel> CreateRouteAsync(CreateRouteRequestModel route) {

            var response = await _routeRepository.CreateRouteAsync(new RouteDTO {
                Destination = route.Destination,
                Source = route.Source,
                Date =route.Date
            });
            return new CreateRouteResponseModel { 
                Destination = response.Destination,
                Source = response.Source,
                Date = response.Date
            };
        }

        public async Task<List<RouteDTO>> GetRoutesAsync()
        {
            return await _routeRepository.GetRoutesAsync();
        }
    }
}
