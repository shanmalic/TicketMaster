using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketMaster.Components.Models;

namespace TicketMaster.Components.ViewModels
{
    public class SearchViewModel
    {
        public string Keyword { get; set; } = "";
        public List<Attraction> Attractions { get; set; } = [];
        public Attraction? SelectedAttraction { get; set; }
    }
}
