using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketMaster.Components.Models;

namespace TicketMaster.Services
{
    public interface ITicketmasterService
    {
        Task<List<Attraction>> SearchAttractionsAsync(string keyword);
        Task<List<Event>> SearchEventsByAttractionIdAsync(string attractionId);
    }

}
