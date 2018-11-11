using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PizzaData.Models;

namespace PizzaData.Repositories
{
    public class PizzaRepository
    {
        private PizzaContext _db;

        public PizzaRepository(PizzaContext db)
        {
            _db = db;
        }

        public async Task<Pizza> GetPizza(int id)
        {
            return await _db.Pizza.FindAsync(id);
        }

        public IEnumerable<object> GetAllMenu()
        {
            return _db.Pizza
                .Include(pizza => pizza.Recipe)
                .ThenInclude(rElement => rElement.IngredientId).ToList();
        }

        public async Task Add()
        {
            var pizza = new Pizza
            {
                Cost = 20,
                Description = "",
                Name = "Four Cheese",
            };
            var ingredient = new Ingredient
            {
                Cost = 10,
                Description = "",
                Name = "Cheese",
            };
            var pi = new PizzaIngredient
            {
                Ingredient = ingredient,
                Pizza = pizza
            };

            _db.Add(pi);

            await _db.SaveChangesAsync();
        }
    }
}