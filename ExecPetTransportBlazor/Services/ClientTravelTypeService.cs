using ExecPetTransportBlazorAPI517.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ExecPetTransportBlazor.Services
{
    public class ClientTravelTypeService : IClientTravelTypeRepository
    {

        private readonly HttpClient _httpClient;
        private readonly string url = "/api/Traveltypes";

        public ClientTravelTypeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<TravelType>> GetTravelTypes()
        {
            return await _httpClient.GetFromJsonAsync<TravelType[]>(url);
        }

        public async Task<IEnumerable<TravelType>> LoadTraveltypes()
        {
            return await _httpClient.GetFromJsonAsync<TravelType[]>(url);
        }
    }
}
