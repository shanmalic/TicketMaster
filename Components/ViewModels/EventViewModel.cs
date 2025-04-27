using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketMaster.Components.Models;

namespace TicketMaster.Components.ViewModels
{
    public class EventViewModel
    {
        public string EventName { get; set; } = "";
        public List<Event> Events { get; set; } = [];
        public ExternalLinks? ExternalLinks { get; set; }
    }
}
