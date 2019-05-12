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
        [Required]
        public string Name { get; set; }

        [MaxLength(1000)]
        [DataType(DataType.Text)]
        [Required]
        public string Description { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy H:mm}")]
        [Required]
        public DateTime StartDate { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy H:mm}")]
        [Required]
        public DateTime EndDate { get; set; }

        [DataType(DataType.Text)]
        public string Genre { get; set; }

        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }
        
        [Required]
        public int Capacity { get; set; }

        [Required]
        public int SoldTickets { get; set; }

        //lookup property
        public Guid LocationId { get; set; }

        //one to many - navigation property
        [Required]
        public Location Location { get; set; }
    }
}
