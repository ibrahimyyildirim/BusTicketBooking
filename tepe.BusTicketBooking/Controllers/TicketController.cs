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
    public class TicketController
    {
        private readonly ITicketService _ticketService;
        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [AllowAnonymous]
        [HttpPost("SellTicket")]
        public async Task<GetTicketResponseModel> GetTickets(SellTicketRequestModel sellTicketRequest)
        {
            var items = await _ticketService.SellTicket(sellTicketRequest);
            return new GetTicketResponseModel
            {

            };
        }

    }


}
