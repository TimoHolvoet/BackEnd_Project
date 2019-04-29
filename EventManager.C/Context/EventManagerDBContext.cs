using EventManager.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventManager.Core.Context
{
    class EventManagerDBContext : DbContext
    {
        public EventManagerDBContext(DbContextOptions<EventManagerDBContext> options)
            : base(options)
        {

        }
        //init tabellen
        public DbSet<Event> Events { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}
