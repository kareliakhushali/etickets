using etickets.Data;
using etickets.Data.Services;
using etickets.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etickets.Controllers
{
    public class ActorsController : Controller
    {
        // private readonly AppDbContext _context;
        private readonly IActorsService _service;

       /* public ActorsController(AppDbContext context)
        {
            _context = context;
        }*/
       public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
           // var allActors = await _context.Actors.ToListAsync();
            //   var data = _service.Actors.ToList();
            var data = await _service.GetAllAsync();
            return View(data);
        }
        //Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        // adding the actor data to the database(creating a new actor)
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)
        {
            // bind 3 of them means adding 3 details that we require 
            if(!ModelState.IsValid)
            {
                // if the validations are met then only the data will be added
                return View(actor);
            }
          await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }
        //Get: Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);

        }
        //Get: Actors/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Id,FullName,ProfilePictureURL,Bio")]Actor actor)
        {
            if(!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.UpdateAsync(id,actor);
            return RedirectToAction(nameof(Index));

        }
        //Get: Actors/Delete/1
        public async Task <IActionResult> Delete(int id)
        {
            var actorsDetails = await _service.GetByIdAsync(id);
            if (actorsDetails == null) return View("NotFound");
            return View(actorsDetails);
        }
        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorsDetails = await _service.GetByIdAsync(id);
            if (actorsDetails == null) return View("NotFound");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
