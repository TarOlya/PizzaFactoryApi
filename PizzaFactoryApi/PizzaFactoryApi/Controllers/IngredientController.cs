using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaFactoryApi.ViewModels;

namespace PizzaFactoryApi.Controllers
{
    [Route("api/[controller]")]
    public class IngredientController : Controller
    {

        [HttpPost("GetIngredients/{page}/{pageSize}")]
        public async Task<IEnumerable<IngredientModel>> GetIngredient(int page, int pageSize, [FromBody]FilterParams filter)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<Guid> AddIngredient([FromBody]IngredientModel ingredient)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public async Task UpdateIngredient(Guid id, [FromBody]IngredientModel ingredient)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task DeleteIngredient(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}