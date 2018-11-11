using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaData;
using PizzaData.Repositories;

namespace PizzaFactoryApi.Controllers
{
    [Route("api/[controller]")]
    public class PizzaController: Controller
    {
        [HttpGet]
        public async Task GetAll()
        {
            var rep = new PizzaRepository(new PizzaContext());
            var pizza = rep.GetAllMenu();
        }
    }
}
