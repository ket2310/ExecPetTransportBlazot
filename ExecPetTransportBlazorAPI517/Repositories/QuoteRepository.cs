using ExecPetTransportBlazorAPI517.Data;
using ExecPetTransportBlazorAPI517.Models;
using System;
using System.Threading.Tasks;

namespace ExecPetTransportBlazorAPI517.Repositories
{
    public class QuoteRepository : IQuoteRepository
    {
        private readonly CoyoteQuoteContext _qContext;

        public QuoteRepository(CoyoteQuoteContext qContext)
        {
            _qContext= qContext;
        }
        public async Task<Quote> CreateTripQuote(Quote quote)
        {
            var result = await _qContext.Quotes.AddAsync(quote);    
            await _qContext.SaveChangesAsync();
            return result.Entity;
        }
    }
}
