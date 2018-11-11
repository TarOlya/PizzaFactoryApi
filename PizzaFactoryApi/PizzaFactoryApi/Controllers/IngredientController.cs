using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaData.IOModels;

namespace PizzaFactoryApi.Controllers
{
    [Route("api/[controller]")]
    public class IngredientController : Controller
    {
        [HttpGet("{id}")]
        public async Task<IngredientModel> GetIngredient(int id)
        {
            return new IngredientModel();
        }
    }
}