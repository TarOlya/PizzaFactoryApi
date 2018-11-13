using System.Collections.Generic;
using PizzaData.Models;

namespace PizzaData.Interfaces
{
    public interface IPizzaRepository: IRepositoryCrud<Pizza>
    {
        IEnumerable<Pizza> GetByPage(Page page);
    }
}