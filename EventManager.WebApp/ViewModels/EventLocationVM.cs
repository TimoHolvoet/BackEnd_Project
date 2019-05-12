using EventManager.Core.Repositories;
using EventManager.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.WebApp.ViewModels
{
    public class EventLocationVM
    {
        public EventLocationVM()
        {

        }
        public EventLocationVM(Event eventobj, Location location )
        {
            this.Eventobj = eventobj;
            this.Location = location;
        }

        private Event Eventobj;
        private Location Location;
    }
}
