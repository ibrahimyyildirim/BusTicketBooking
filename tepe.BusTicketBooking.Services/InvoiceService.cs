using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tepe.BusTicketBooking.Core.Interfaces.Repositories;
using tepe.BusTicketBooking.Core.Interfaces.Services;

namespace tepe.BusTicketBooking.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public InvoiceService(IInvoiceRepository invoiceRepository) {
            _invoiceRepository = invoiceRepository;
        }
    }
}
