using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tepe.BusTicketBooking.Core.DTO;
using tepe.BusTicketBooking.Core.Interfaces.Repositories;
using tepe.BusTicketBooking.Core.Interfaces.Services;
using tepe.BusTicketBooking.Core.RequestModels;

namespace tepe.BusTicketBooking.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IUserRepository _userRepository;
        public TicketService(ITicketRepository ticketRepository, IInvoiceRepository invoiceRepository, IUserRepository userRepository ) {
            _ticketRepository = ticketRepository;
            _invoiceRepository = invoiceRepository;
            _userRepository = userRepository;
        }

        public Task<TicketDTO> SellTicket(SellTicketRequestModel req)
        {
            // TODO: Https Context ile tokenden user'ı bulma
            // İsteği atan user'ı ve ticket'ı bul (repo)
            var user = _userRepository.getUser(req.UserId);
            var ticket = _ticketRepository.getTicket(req.TicketId);
            // Var mı ve satılmaya uygun mu kontrolleri yapılacak
            // satış yap, ticketi update et. (fiyat artış kuralı çalışacak)
            // incoive kes, (invoice reposuna ihtiyaç olacak)
            // response'u maple
            throw new NotImplementedException();
        }


    }
}
