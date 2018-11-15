using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using PizzaData;
using PizzaData.Interfaces;
using PizzaData.Models;
using PizzaFactoryApi.ViewModels;

namespace PizzaFactoryApi.Controllers
{
    [Route("api/[controller]")]
    public class PizzaController: Controller
    {
        private readonly IValidator<Page> _pageValidator;
        private readonly IValidator<PizzaModel> _pizzaValidator;
        private readonly IPizzaRepository _repository;

        public PizzaController(IPizzaRepository repository, IValidator<PizzaModel> pizzaValidator, IValidator<Page> pageValidator)
        {
            _repository = repository;
            _pizzaValidator = pizzaValidator;
            _pageValidator = pageValidator;
        }

        [HttpDelete("{id}")]
        public async Task DeletePizza(Guid id)
        {
            await _repository.Delete(id);
        }

        [HttpPost]
        public async Task<Guid> AddPizza([FromBody]PizzaModel pizza)
        {
            await _pizzaValidator.ValidateAndThrowAsync(pizza);
            var mPizza = Mapper.Map<PizzaModel, Pizza>(pizza);
            return await _repository.Create(mPizza);
        }

        //todo Change realization
        [HttpPut("{id}")]
        public async Task UpdatePizza([FromBody]Pizza pizza)
        {
            await _repository.Update(pizza);
        }

        [HttpPost("{page}/{pageSize}")]
        public async Task<IEnumerable<Pizza>> GetPizzas(int page, int pageSize, [FromBody]FilterParams filter)
        {
            var paged = new Page()
            {
                PageNumber = page,
                PageSize = pageSize,
            };
            await _pageValidator.ValidateAndThrowAsync(paged);
            return _repository.GetByPage(paged);
        }
    }
}
