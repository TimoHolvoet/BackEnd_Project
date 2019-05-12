using EventManager.WebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventManager.Core.Context
{
    public class EventManagerDBContext : IdentityDbContext<IdentityUser>
    {
        public EventManagerDBContext(DbContextOptions<EventManagerDBContext> options)
            : base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); //must voor identity

            Guid locationId = Guid.NewGuid();
            modelBuilder.Entity<Location>().HasData(
                new Location
                {
                    Id = locationId,
                    Venue = "EventLocation1",
                    Address = "EventAddress1",
                    City = "EventCity1",
                    Longitude = 3.257726,
                    Latitude = 50.819477
                }
                );
            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    Id = Guid.NewGuid(),
                    Name = "EventName1",
                    Description = "EventDescription1",
                    Capacity = 1000,
                    SoldTickets = 400,
                    ImageUrl = "Fakelink1.png",
                    StartDate = DateTime.Today,
                    EndDate = DateTime.Today,
                    Genre = "EventGenre1",
                    LocationId = locationId

                }
                );


        }
        
        //init tabellen
        public DbSet<Event> Events { get; set; }
        public DbSet<Location> Locations { get; set; }

        //hier later ev. nog relaties leggen
    }
}
