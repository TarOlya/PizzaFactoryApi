using System.Collections.Generic;
using System.Linq;
using PizzaData.Interfaces;
using PizzaData.Models;

namespace PizzaData.Repositories
{
    public class PizzaRepository: RepositoryCrud<Pizza>, IPizzaRepository
    {
        private readonly PizzaContext _db;

        public PizzaRepository(PizzaContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<Pizza> GetByPage(Page page)
        {
            return _db.Pizza.Skip((page.PageNumber - 1) * page.PageSize).Take(page.PageSize);
        }
    }
}