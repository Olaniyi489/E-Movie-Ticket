﻿using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _actorsService;

        public ActorsController(IActorsService actorsService)
        {
            _actorsService = actorsService;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _actorsService.GetAllAsync();
            return View(data);
        }

        //Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        
        public async Task<IActionResult> Create([Bind("FullName, ProfilePictureUrl, Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _actorsService.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        //Get: Actors/Details/id

        public async Task<IActionResult> Details(int id)
        {
            var actorDetails =await _actorsService.GetByIdAsync(id);

            if (actorDetails == null) return View("NotFound");

            return View(actorDetails);
        }

        //Get: Actors/Edit/id
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _actorsService.GetByIdAsync(id);

            if (actorDetails == null) return View("NotFound");

            return View(actorDetails);
            
        }

        [HttpPost]

        public async Task<IActionResult> Edit(int id, [Bind("Id, FullName, ProfilePictureUrl, Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _actorsService.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }

        //Get: Actors/Delete/id
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _actorsService.GetByIdAsync(id);

            if (actorDetails == null) return View("NotFound");

            return View(actorDetails);

        }

        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _actorsService.GetByIdAsync(id);

            if (actorDetails == null) return View("NotFound");

            await _actorsService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
