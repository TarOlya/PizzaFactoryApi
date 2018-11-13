using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PizzaData.Models;

namespace PizzaData.Interfaces
{
    public interface IIngredientRepository : IRepositoryCrud<Ingredient>
    {
        IEnumerable<Ingredient> GetByPage(Page page);
    }
}