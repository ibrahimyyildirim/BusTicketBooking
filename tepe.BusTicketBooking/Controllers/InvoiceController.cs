using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tepe.BusTicketBooking.Core.Interfaces.Services;

namespace tepe.BusTicketBooking.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class InvoiceController
    {
        private readonly IInvoiceService _invoiceService;

        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }
    }
}
