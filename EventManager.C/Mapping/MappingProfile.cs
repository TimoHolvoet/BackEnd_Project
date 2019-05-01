using AutoMapper;
using EventManager.Core.DTO;
using EventManager.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventManager.Core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domain class --> apiResource
            CreateMap<Event, EventDTO>();
            CreateMap<Location, LocationDTO>();

            //apiResource --> domain class
            CreateMap<EventDTO, Event>();
            CreateMap<LocationDTO, Location>();
        }
    }
}
