using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tepe.BusTicketBooking.Core.Entities;
using tepe.BusTicketBooking.Core.Interfaces.Repositories;

namespace tepe.BusTicketBooking.DAL.Repositories
{
    public class UserRepository :  IUserRepository
    {
        private readonly TepeContext _contextdb;
        public UserRepository(TepeContext context)
        {
            _contextdb = context;
        }

        public User getUser(string id) {
            return _contextdb.Users.Find(id);
        }

        public async Task<User> getUserAsync(int id) {
            return await _contextdb.Users.FindAsync(id);
        }
    }
}
