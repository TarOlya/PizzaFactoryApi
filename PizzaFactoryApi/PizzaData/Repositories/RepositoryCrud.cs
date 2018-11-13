using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PizzaData.Interfaces;
using PizzaData.Models;

namespace PizzaData.Repositories
{
    public class RepositoryCrud<T>: IRepositoryCrud<T> where T: BaseEntity
    {
        private readonly PizzaContext _db;

        public RepositoryCrud(PizzaContext db)
        {
            _db = db;
        }

        public virtual async Task<Guid> Create(T entity)
        {
            await _db.Set<T>().AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity.Id;
        }

        public virtual async Task<T> Read(Guid id)
        {
            return await _db.Set<T>().FindAsync(id);
        }

        public virtual async Task Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
        }

        public virtual async Task Delete(Guid id)
        {
            var entity = await _db.Set<T>().FindAsync();
            if (entity == null)
            {
                throw new InvalidOperationException("Wrong id");
            }

            _db.Set<T>().Remove(entity);
        }
    }
}