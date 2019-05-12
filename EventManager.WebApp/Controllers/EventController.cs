using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventManager.Core.Repositories;
using EventManager.WebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace EventManager.WebApp.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventRepo eventRepo;

        public EventController(IEventRepo eventRepo)
        {
            this.eventRepo = eventRepo;
        }

        // GET: Event
        public async Task<ActionResult> Index()
        {
            var events = await eventRepo.GetAllAsync();
            return View(events);
        }

        // GET: Event/Details/5
        public async Task<ActionResult> Details(Guid id)
        {
            var eventobj = await eventRepo.GetAsync(id);
            return View(eventobj);
        }

        // GET: Event/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Event/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Event eventobj)
        {
            try
            {
                // TODO: Add insert logic here
                await eventRepo.AddAsync(eventobj);
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Event/Edit/5
        [HttpGet]
        public async Task<ActionResult> Edit(Guid id)
        {
            var eventobj = await eventRepo.GetAsync(id);
            return View(eventobj);
        }

        // POST: Event/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Guid id, Event eventobj)
        {
            try
            {
                // TODO: Add update logic here
                await eventRepo.UpdateAsync(eventobj);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Event/Delete/5
        public async Task<ActionResult> Delete(Guid id)
        {
            var eventobj = await eventRepo.GetAsync(id);
            return View(eventobj);
        }

        // POST: Event/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Guid id, Event eventobj)
        {
            try
            {
                // TODO: Add delete logic here
                await eventRepo.DeleteAsync(eventobj);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}