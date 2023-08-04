using etickets.Data.Base;
using etickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etickets.Data.Services
{
    // first we were just inheriting from IActorsService but now we will inherit from repo also 
    public class ActorsServices :EntityBaseRepository<Actor>, IActorsService
    {
        //to get data from database
       // private readonly AppDbContext _context;
        public ActorsServices(AppDbContext context): base(context) { }
        
        /*public async Task AddAsync(Actor actor)
        {
           await _context.Actors.AddAsync(actor);
           await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            _context.Actors.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public async Task <Actor> GetByIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }
*/
        /*public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
               
        }*/
        /*public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            var existingActor = await _context.Actors.FindAsync(id);
            if (existingActor == null)
                return null;

            // Update the properties of the existing actor with the new values
            existingActor.FullName = newActor.FullName;
            existingActor.ProfilePictureURL = newActor.ProfilePictureURL;
            existingActor.Bio = newActor.Bio;

            await _context.SaveChangesAsync();
            return existingActor;
        }*/

    }
}
