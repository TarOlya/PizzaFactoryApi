using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PizzaData.Interfaces;
using PizzaData.Models;

namespace PizzaData.Repositories
{
    public class UserRepository: RepositoryCrud<User>, IUserRepository
    {
        private readonly PizzaContext _db;

        public UserRepository(PizzaContext db) : base(db)
        {
            _db = db;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _db.Users.ToListAsync();
        }
    }
}