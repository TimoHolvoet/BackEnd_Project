using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EventManager.Core.Context;
using EventManager.WebApp.Models;
using EventManager.Core.Repositories;
using AutoMapper;
using EventManager.Core.DTO;

namespace EventManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventRepo _context;
        private readonly IMapper _mapper;

        public EventsController(IEventRepo eventRepo,IMapper mapper)
        {
            _context = eventRepo;
            this._mapper = mapper;
        }

        // GET: api/Events
        [HttpGet]
        public async Task<IActionResult> GetEvents()
        {
            IEnumerable<Event> events = await _context.GetAllAsync();

            return Ok(_mapper.Map<List<Event>,List<EventDTO>>(events.ToList()));
        }

        // GET: api/Events/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEvent(Guid id)
        {
            var eventobj = await _context.GetAsync(id);

            if (eventobj == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<Event, EventDTO>(eventobj));
        }

        // PUT: api/Events/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEvent(Guid id, EventDTO eventDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != eventDTO.Id)
            {
                return BadRequest();
            }

            var eventobj = _mapper.Map<EventDTO, Event>(eventDTO);

            try
            {
                await _context.UpdateAsync(eventobj);
            }
            catch (Exception ex)
            {
                //vraag aan docent welke error bij het mislukken van update
                return BadRequest("Couldn't update your data");
            }

            return NoContent();
        }

        // POST: api/Events
        [HttpPost]
        public async Task<ActionResult> PostEvent(EventDTO eventDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var eventobj = _mapper.Map<EventDTO, Event>(eventDTO);

                await _context.AddAsync(eventobj);
                //welke url meegeven??

                return Created("", eventobj);
            }
            catch (Exception ex)
            {

                return BadRequest("Couldn't save your event");
            }
        }

        // DELETE: api/Events/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Event>> DeleteEvent(Guid id)
        {
            try
            {
                //ophalen object

                var eventobj = await _context.GetAsync(id);

                //indien null == not found
                if (eventobj == null)
                    return NotFound();

                //verwijder object
                await _context.DeleteAsync(eventobj);

                //toon succes melding
                return NoContent();
            }
            catch (Exception)
            {

                return BadRequest("Kon voorlopig data niet verwijderen");
            }
           
        }


    }
}
