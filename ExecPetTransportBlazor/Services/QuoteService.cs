using ExecPetTransportBlazorAPI517.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExecPetTransportBlazor.Services
{
    public class QuoteService : IQuoteService
    {
        private readonly HttpClient httpClient;

        public QuoteService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task CreateQuote(Quote quote)
        {
           await httpClient.PostAsJsonAsync("api/QuoteInMemory", quote);
        }
    }
}
