using EventManager.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventManager.Core.Context
{
    public class EventManagerDBContext : DbContext
    {
        public EventManagerDBContext(DbContextOptions<EventManagerDBContext> options)
            : base(options)
        {

        }
        //dummy data toevoegen
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Guid locationId = Guid.NewGuid();

            modelBuilder.Entity<Location>().HasData(
                new Location
                {
                    Id = locationId,
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
                    Date = DateTime.Today,
                    Genre = "EventGenre1",
                    LocationId = locationId

                }
                );


        }
        //        for (var i = 1; i <= 10; i++)
        //                {
        //                    Event Event = new Event();
        //        Event.EventID = i;
        //                    Event.EventName = "EventName" + i;
        //                    Event.EventDescription = "EventDescription" + i;
        //                    Event.EventCapacity = 1000;
        //                    Event.SoldTickets = 400;
        //                    Event.ImageUrl = "fakeLink" + i + ".png";
        //                    Event.Date = DateTime.Today;
        //                    Event.EventGenre = "EventGenre" + 1;
        //                    Event.Location = new Location
        //                    {
        //                        Longitude = 3.257726,
        //                        Latitude = 50.819477
        //                    };
        //}
        //init tabellen
        public DbSet<Event> Events { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}
