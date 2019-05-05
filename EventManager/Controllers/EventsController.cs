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
using Microsoft.Extensions.Logging;

namespace EventManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        //fields
        private readonly IEventRepo _context;
        private readonly IMapper _mapper;
        private readonly ILogger<EventsController> _logger;

        //constructor
        public EventsController(IEventRepo eventRepo, IMapper mapper, ILogger<EventsController> logger)
        {
            _context = eventRepo;
            this._mapper = mapper;
            this._logger = logger;
        }

        //Methods
        // GET: api/Events
        [HttpGet]
        public async Task<IActionResult> GetEvents()
        {
            //vanuit repo Lijst (IEnumerable) ophalen alle events
            IEnumerable<Event> events = await _context.GetAllAsync();

            //mapping van Domain class naar DTO object - API resource
            List<EventDTO> eventDTO = _mapper.Map<List<Event>, List<EventDTO>>(events.ToList());

            //geef een ok result met het object terug
            return Ok(eventDTO);
        }

        // GET: api/Events/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEvent(Guid id)
        {
            //vanuit repo één event halen adhv id
            var eventobj = await _context.GetAsync(id);

            if (eventobj == null)
            {
                _logger.LogCritical($"event not found: {id} is not a valid id");
                return NotFound();
            }
            //opgehaalde event mappen naar een EventDTO
            return Ok(_mapper.Map<Event, EventDTO>(eventobj));
        }

        // PUT: api/Events/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEvent(Guid id, EventDTO eventDTO)
        {
            //checken of de state van de eventDTO wel valid is 
            if (!ModelState.IsValid)
            {
                _logger.LogCritical("event not valid");
                return BadRequest(ModelState);
            }


            if (id != eventDTO.Id)
            {
                return BadRequest();
            }

            var eventobj = _mapper.Map<EventDTO, Event>(eventDTO);

            try
            {
                await _context.UpdateAsync(eventobj);
                _logger.LogInformation($"event updated: {eventobj}");
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"Couldn't update event: {eventobj} exeption:  {ex}");

                //vraag aan docent welke error bij het mislukken van update
                return BadRequest("Couldn't update your data");
            }
            //statuscode 204 returnen indien gelukt
            return NoContent();
        }

        // POST: api/Events
        [HttpPost]
        public async Task<ActionResult> PostEvent(SaveEventDTO eventDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                //mapping object
                var eventobj = _mapper.Map<SaveEventDTO, Event>(eventDTO);

                //id aanmaken - gaat automatisch
                //eventobj.Id = Guid.NewGuid();

                //save object
                await _context.AddAsync(eventobj);


                //--------------welke url meegeven??????-----------------------
                return Created("", eventobj);
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"Kon object niet saven: {eventDTO} Warning: {ex}");
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
                _logger.LogCritical($"event not deleted: {id}");
                return BadRequest("Kon voorlopig data niet verwijderen");
            }

        }
    }
}
