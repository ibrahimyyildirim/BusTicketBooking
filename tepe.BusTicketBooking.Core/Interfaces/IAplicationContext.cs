using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tepe.BusTicketBooking.Core.Entities;

namespace tepe.BusTicketBooking.Core.Interfaces
{
    public interface IAplicationContext
    {
       DbSet<User> Users { get; set; }
       DbSet<UserRoles> UserRoles { get; set; }

    }
}
