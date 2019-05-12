using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.WebApp.Models
{
    public class Location
    {
        public Guid Id { get; set; }

        [DataType(DataType.Text)]
        [Required]
        public string Venue { get; set; }

        [DataType(DataType.Text)]
        public string Address { get; set; }

        [DataType(DataType.Text)]
        public string City { get; set; }

        [Required]
        public double Longitude { get; set; }
        [Required]
        public double Latitude { get; set; }
    }
}
