using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using PizzaData.Interfaces;
using PizzaData.Models;
using PizzaFactoryApi.ViewModels;

namespace PizzaFactoryApi.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserRepository _repository;
        private readonly IValidator<User> _validator;

        public UserController(IUserRepository repository, IValidator<User> validator)
        {
            _repository = repository;
            _validator = validator;
        }

        [HttpPost("Register")]
        public async Task<Guid> AddUser([FromBody] LoginParams user)
        {
            var u = Mapper.Map<LoginParams, User>(user);
            await _validator.ValidateAndThrowAsync(u);
            return await _repository.Create(u);
        }

        //I'm not sure in this code
        [HttpPost("Login")]
        public async Task<Guid> Login([FromBody] LoginParams user)
        {
            throw new NotImplementedException();
        }

        //I'm not sure in this code
        [HttpGet("Logout")]
        public async Task Logout()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _repository.GetAll();
        }

        [HttpPut("Update")]
        public async Task UpdateUser([FromBody] User user)
        {
            await _validator.ValidateAndThrowAsync(user);
            await _repository.Update(user);
        }

        [HttpDelete("{id}")]
        public async Task DeleteUser(Guid id)
        {
            await _repository.Delete(id);
        }


    }
}