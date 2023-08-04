using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace etickets.Data.Base
{
   public interface IEntityBaseRepository<T>where T:class,IEntityBase,new()
    {
        Task<IEnumerable<T>> GetAllAsync();
      //for movies
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);
    }
}
