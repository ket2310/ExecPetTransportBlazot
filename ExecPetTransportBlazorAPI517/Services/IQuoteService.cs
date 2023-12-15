using ExecPetTransportBlazorAPI517.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExecPetTransportBlazorAPI517.Services
{
    public interface IQuoteService
    {
        Task CreateQuote(Quote quote);
       
    }
}
