using ExecPetTransportBlazorAPI517.Models;
using System.Threading.Tasks;

namespace ExecPetTransportBlazorAPI517.Models
{
    public interface QuoteRepository
    {
        Task<Quote> CreateTripQuote(Quote quote);
    }
}
