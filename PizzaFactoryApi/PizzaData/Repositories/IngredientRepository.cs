using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaData.Interfaces;
using PizzaData.Models;

namespace PizzaData.Repositories
{
    public class IngredientRepository: RepositoryCrud<Ingredient>, IIngredientRepository
    {
        private readonly PizzaContext _db;

        public IngredientRepository(PizzaContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<Ingredient> GetByPage(Page page)
        {

            return _db.Ingredients.Skip((page.PageNumber - 1) * page.PageSize).Take(page.PageSize).AsEnumerable();
        }
    }
}
