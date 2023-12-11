using ExecPetTransportBlazorAPI517.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExecPetTransportBlazor.Services
{
    public interface IQuoteService
    {
        Task<Quote> CreateEmployee(Quote quote);
       
    }
}
