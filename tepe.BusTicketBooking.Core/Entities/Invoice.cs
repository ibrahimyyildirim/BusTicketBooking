using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tepe.BusTicketBooking.Core.Entities
{
   public class Invoice : BaseEntity
    {
        public User Customer { get; set; }
        public Route Route { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
    }
}
