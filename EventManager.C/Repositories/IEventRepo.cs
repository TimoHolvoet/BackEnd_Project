using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EventManager.WebApp.Models;

namespace EventManager.Core.Repositories
{
    public interface IEventRepo
    {
        Task<Event> AddAsync(Event eventobj);
        Task<Guid> DeleteAsync(Event eventobj);
        Task<IEnumerable<Event>> GetAllAsync();
        Task<Event> GetAsync(Guid id);
        Task<Event> UpdateAsync(Event eventobj);
    }
}