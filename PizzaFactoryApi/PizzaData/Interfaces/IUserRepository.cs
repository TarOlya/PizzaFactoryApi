using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaData.Models;

namespace PizzaData.Interfaces
{
    public interface IUserRepository: IRepositoryCrud<User>
    {
        Task<IEnumerable<User>> GetAll();
    }
}