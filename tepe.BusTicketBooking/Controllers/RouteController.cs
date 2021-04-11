using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tepe.BusTicketBooking.Core.Interfaces.Services;
using tepe.BusTicketBooking.Core.RequestModels;
using tepe.BusTicketBooking.Core.ResponseModels;

namespace tepe.BusTicketBooking.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class RouteController : ControllerBase
    {
        private readonly IRouteService _routeService;
        public RouteController(IRouteService routeService)
        {
            _routeService = routeService;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<CreateRouteResponseModel> CreateRoute(CreateRouteRequestModel createRouteRequest) {
            return await _routeService.CreateRouteAsync(createRouteRequest);
        }

        [AllowAnonymous]
        [HttpGet("Routes")]
        public async Task<GetRoutesResponseModel> GetRoutes()
        {
            var items = await _routeService.GetRoutesAsync();
            return new GetRoutesResponseModel
            {
                Items = items,
                ItemCount = items.Count
            };
        }
    }

}
