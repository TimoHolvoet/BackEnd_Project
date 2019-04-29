using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.WebApp.Models
{
    public class Event
    {
        [DataType(DataType.Text)]
        public string EventName { get; set; }

        [MaxLength(300)]
        [DataType(DataType.Text)]
        public string EventDescription { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [DataType(DataType.Text)]
        public string EventGenre { get; set; }

        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }
        
        public int EventCapacity { get; set; }
        public int SoldTickets { get; set; }

        public Location Location { get; set; }
    }
}
