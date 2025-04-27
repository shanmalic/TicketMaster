using System.Net.Http.Json;
using System.Text.Json;
using TicketMaster.Components.Models;
using TicketMaster.Services;

public class TicketmasterService : ITicketmasterService
{
    private readonly HttpClient _httpClient;
    private const string ApiKey = "API_KEY";
    private const string BaseUrl = "https://app.ticketmaster.com/discovery/v2/";

    public TicketmasterService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Attraction>> SearchAttractionsAsync(string keyword)
    {
        var url = $"https://app.ticketmaster.com/discovery/v2/attractions.json?apikey={ApiKey}&keyword={keyword}";
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        var json = await response.Content.ReadAsStringAsync();

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        var root = JsonSerializer.Deserialize<AttractionResponse>(json, options);
        return root?._embedded?.attractions ?? new List<Attraction>();
    }


    public async Task<List<Event>> SearchEventsByAttractionIdAsync(string attractionId)
    {
        var url = $"{BaseUrl}events.json?apikey={ApiKey}&attractionId={Uri.EscapeDataString(attractionId)}";
        var result = await _httpClient.GetFromJsonAsync<EventResponse>(url);
        return result?._embedded?.events ?? [];
    }
}
