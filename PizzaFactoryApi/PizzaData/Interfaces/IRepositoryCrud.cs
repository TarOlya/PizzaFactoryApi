using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaData.Models;

namespace PizzaData.Interfaces
{
    public interface IRepositoryCrud<T> where T: BaseEntity
    {
        Task<Guid> Create(T entity);
        Task<T> Read(Guid id);
        Task Update(T entity);
        Task Delete(Guid id);
    }
}