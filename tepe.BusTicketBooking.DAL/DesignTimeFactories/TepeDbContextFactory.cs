using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tepe.BusTicketBooking.DAL.DesignTimeFactories
{
    public class TepeDbContextFactory : IDesignTimeDbContextFactory<TepeContext>
    {
    public TepeContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<TepeContext>();
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-M8TC328\YILDIRIM;Initial Catalog=TepeDB;Integrated Security=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                return new TepeContext(optionsBuilder.Options);
            }
    }
}