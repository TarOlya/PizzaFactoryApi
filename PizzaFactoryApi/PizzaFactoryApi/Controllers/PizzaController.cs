using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaData;
using PizzaData.Repositories;
using PizzaFactoryApi.ViewModels;
using PizzaModel = PizzaData.IOModels.PizzaModel;

namespace PizzaFactoryApi.Controllers
{
    [Route("api/[controller]")]
    public class PizzaController: Controller
    {
        [HttpDelete("{id}")]
        public async Task DeletePizza(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<Guid> AddPizza([FromBody]PizzaModel pizza)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public async Task UpdatePizza(Guid id, [FromBody]PizzaModel pizza)
        {
            throw new NotImplementedException();
        }

        [HttpPost("GetPizzas/{page}/{pageSize}")]
        public async Task<IEnumerable<PizzaModel>> GetPizzas(int page, int pageSize, [FromBody]FilterParams filter)
        {
            throw new NotImplementedException();
        }
    }
}
