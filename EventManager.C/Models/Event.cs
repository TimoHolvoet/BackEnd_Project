using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.WebApp.Models
{
    public class Event
    {

        public Guid Id { get; set; }

        [DataType(DataType.Text)]
        public string Name { get; set; }

        [MaxLength(300)]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [DataType(DataType.Text)]
        public string Genre { get; set; }

        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }
        
        public int Capacity { get; set; }
        public int SoldTickets { get; set; }

        //lookup property
        public Guid LocationId { get; set; }

        //one to many - navigation property
        public Location Location { get; set; }
    }
}
