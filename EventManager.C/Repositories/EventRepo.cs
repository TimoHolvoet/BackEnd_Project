﻿using EventManager.Core.Context;
using EventManager.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Core.Repositories
{
     public class EventRepo
    {
        //fields
        private readonly EventManagerDBContext _context;

        //constructor
        public EventRepo(EventManagerDBContext context)
        {
            this._context = context;
        }

        //methods
        public async Task<IEnumerable<Event>> GetAllAsync()
        {
           return await _context.Events
                .Include(e => e.Location)
                .OrderByDescending( e => e.Date)
                .ToListAsync()                
                ;
        }
       
        public async Task<Event> GetAsync(Guid id)
        {
            return await _context.Events.SingleOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Event> AddAsync(Event eventobj)
        {
            await _context.Locations.AddAsync(eventobj.Location);
            await _context.Events.AddAsync(eventobj);
            await _context.SaveChangesAsync();

            return eventobj;
        }
        public async Task<Event> UpdateAsync(Event eventobj)
        {
            //update kan niet voorafgaan door await!
            _context.Events.Update(eventobj);
            
            await _context.SaveChangesAsync();

            return eventobj;
        }

        public async Task<Guid> DeleteAsync(Event eventobj)
        {
            _context.Events.Remove(eventobj);
            await _context.SaveChangesAsync();

            return eventobj.Id;
        }
    }
}