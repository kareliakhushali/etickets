using etickets.Data.Base;
using etickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etickets.Data.Services
{
    public interface IActorsService: IEntityBaseRepository<Actor>
    {
        // first we were doing using services but now we will create a repository and inherit from there 
       /* Task<IEnumerable<Actor>> GetAllAsync();
       Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
       Task<Actor> UpdateAsync(int id, Actor newActor);
       Task  DeleteAsync(int id);*/
    }
}
