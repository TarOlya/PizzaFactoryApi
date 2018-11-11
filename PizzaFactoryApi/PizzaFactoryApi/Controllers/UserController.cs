using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaFactoryApi.ViewModels;

namespace PizzaFactoryApi.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost("Register")]
        public async Task<Guid> AddUser([FromBody] LoginParams user)
        {
            throw new NotImplementedException();
        }

        [HttpPost("Login")]
        public async Task<Guid> Login([FromBody] LoginParams user)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IEnumerable<UserModel>> GetUsers()
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public async Task UpdateUser(Guid id, [FromBody] UserModel user)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }


    }
}