using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaFactoryApi.ViewModels;

namespace PizzaFactoryApi.Controllers
{
    [Route("api/[controller]")]
    public class BasketController : ControllerBase
    {
        [HttpGet("AddPizza/{id}")]
        public async Task AddPizza(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("DeletePizza/{id}")]
        public async Task DeletePizza(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("GetPizzas")]
        public async Task<IEnumerable<PizzaModel>> GetPizzasFromBasket()
        {
            throw new NotImplementedException();
        }

        [HttpGet("Pay")]
        public async Task PayOrder()
        {
            throw new NotImplementedException();
        }

        [HttpPost("AddIngredients")]
        public async Task AddIngredients([FromBody]IEnumerable<Guid> ingredients)
        {
            throw new NotImplementedException();
        }
    }
}