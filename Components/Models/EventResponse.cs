using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMaster.Components.Models
{
    public class EventResponse
    {
        public EmbeddedEvents? _embedded { get; set; }
    }

    public class EmbeddedEvents
    {
        public List<Event> events { get; set; } = [];
    }

    public class Event
    {
        public string Name { get; set; } = string.Empty;
        public List<Image> Images { get; set; } = [];
        public Dates Dates { get; set; } = new();
        public EmbeddedVenue? _embedded { get; set; }
    }

    public class Dates
    {
        public Start Start { get; set; } = new();
    }

    public class Start
    {
        public string LocalDate { get; set; } = string.Empty;
    }

    public class EmbeddedVenue
    {
        public List<Venue> Venues { get; set; } = [];
    }

    public class Venue
    {
        public string Name { get; set; } = string.Empty;
        public City City { get; set; } = new();
        public State State { get; set; } = new();
    }

    public class City
    {
        public string Name { get; set; } = string.Empty;
    }

    public class State
    {
        public string StateCode { get; set; } = string.Empty;
    }

}
