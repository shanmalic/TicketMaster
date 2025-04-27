using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMaster.Components.Models
{
    public class AttractionResponse
    {
        public EmbeddedAttractions? _embedded { get; set; }
    }

    public class EmbeddedAttractions
    {
        public List<Attraction> attractions { get; set; } = [];
    }

    public class Attraction
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public List<Image> Images { get; set; } = [];
        public ExternalLinks? ExternalLinks { get; set; }
    }

    public class Image
    {
        public string Url { get; set; } = string.Empty;
    }

    public class ExternalLinks
    {
        public List<ExternalLinkItem>? Youtube { get; set; }
        public List<ExternalLinkItem>? Twitter { get; set; }
        public List<ExternalLinkItem>? Spotify { get; set; }
        public List<ExternalLinkItem>? Homepage { get; set; }
        public List<ExternalLinkItem>? Website { get; set; }
    }

    public class ExternalLinkItem
    {
        public string Url { get; set; } = string.Empty;
    }

}
