using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tepe.BusTicketBooking.Core.Entities;
using tepe.BusTicketBooking.Core.Interfaces;

namespace tepe.BusTicketBooking.DAL
{
    public class TepeContext : IdentityDbContext<User>
    {
        public TepeContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}


