using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EventManager.Core.DTO
{
    public class EventDTO
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
        [Required]
        public DateTime StartDate { get; set; }

        [DataType(DataType.DateTime)]
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


        //one to many - navigation property
        [Required]
        public LocationDTO Location { get; set; }
    }
}
