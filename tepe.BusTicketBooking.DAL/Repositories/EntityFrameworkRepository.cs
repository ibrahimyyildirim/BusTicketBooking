using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tepe.BusTicketBooking.Core.Interfaces.Entities;
using tepe.BusTicketBooking.Core.Interfaces.Repositories;

namespace tepe.BusTicketBooking.DAL.Repositories
{
    public class EntityFrameworkRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : TepeContext
    {
        private readonly TContext _contextdb;
        public EntityFrameworkRepository(TContext context) {
            _contextdb = context;
        }
        public TEntity Find(int Id)
        {
            var queryable = this.GetQueryable();
            return queryable.SingleOrDefault(q => q.Id == Id);
        }

        public async Task<TEntity> FindAsync(int Id)
        {
            var queryable = this.GetQueryable();
            return await queryable.SingleOrDefaultAsync(q => q.Id == Id);
        }

        public IQueryable<TEntity> GetQueryable()
        {
            return this._contextdb.Set<TEntity>().AsQueryable();

        }
    }
}
