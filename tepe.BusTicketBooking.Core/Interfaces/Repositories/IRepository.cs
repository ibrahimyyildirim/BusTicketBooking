using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tepe.BusTicketBooking.Core.Interfaces.Entities;

namespace tepe.BusTicketBooking.Core.Interfaces.Repositories
{
    public interface IRepository <T>where T:class, IEntity, new()
    {
        Task<T> FindAsync(int Id);
        T Find (int Id);
        IQueryable<T> GetQueryable();
    }
}
