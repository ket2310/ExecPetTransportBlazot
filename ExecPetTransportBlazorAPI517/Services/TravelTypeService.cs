using ExecPetTransportBlazorAPI517.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ExecPetTransportBlazorAPI517.Services
{
    public class TravelTypeService : ITravelTypeService
    {

        private readonly HttpClient _httpClient;
        private readonly string url = "/api/Traveltypes";

        public TravelTypeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<TravelType>> GetTravelTypes()
        {
            return await _httpClient.GetFromJsonAsync<TravelType[]>(url);
        }

    }
}
