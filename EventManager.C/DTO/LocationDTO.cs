using System;
using System.Collections.Generic;
using System.Text;

namespace EventManager.Core.DTO
{
    public class LocationDTO
    {
        public Guid Id { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}
