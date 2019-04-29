using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.WebApp.Models
{
    public class Event
    {
        public string EventName { get; set; }
        [MaxLength(300)]
        public string EventDescription { get; set; }
        public DateTime Date { get; set; }
        public string EventGenre { get; set; }
        public string ImageUrl { get; set; }
        public int EventCapacity { get; set; }

        public int SoldTickets { get; set; }

        public Location Location { get; set; }
    }
}
