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
    public class IngredientController : Controller
    {
        private readonly IValidator<IngredientModel> _validator;
        private readonly IIngredientRepository _repository;
        private readonly IValidator<Page> _pageValidator;

        public IngredientController(IIngredientRepository repository, IValidator<IngredientModel> validator, IValidator<Page> pageValidator)
        {
            _repository = repository;
            _validator = validator;
            _pageValidator = pageValidator;
        }

        [HttpPost("{page}/{pageSize}")]
        public async Task<IEnumerable<Ingredient>> GetIngredient(int page, int pageSize, [FromBody]FilterParams filter)
        {
            var paged = new Page
            {
                PageNumber = page,
                PageSize = pageSize
            };
            await _pageValidator.ValidateAndThrowAsync(paged);
            return _repository.GetByPage(paged);
        }

        [HttpPost]
        public async Task<Guid> AddIngredient([FromBody]IngredientModel ingredient)
        {
            await _validator.ValidateAndThrowAsync(ingredient);
            var mIngredient = Mapper.Map<IngredientModel, Ingredient>(ingredient);
            return await _repository.Create(mIngredient);
        }

        //todo Change realization of all methods update
        [HttpPut("{id}")]
        public async Task UpdateIngredient([FromBody]Ingredient ingredient)
        {
            await _repository.Update(ingredient);
        }

        [HttpDelete("{id}")]
        public async Task DeleteIngredient(Guid id)
        {
            await _repository.Delete(id);
        }
    }
}