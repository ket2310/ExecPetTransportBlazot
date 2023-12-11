using ExecPetTransportBlazorAPI517.Models;
using System.Threading.Tasks;

namespace ExecPetTransportBlazorAPI517.Repositories
{
    public interface IQuoteRepository
    {
        Task<Quote> CreateTripQuote(Quote quote);
    }
}
