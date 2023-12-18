using ExecPetTransportBlazorAPI517.Data;
using ExecPetTransportBlazorAPI517.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ExecPetTransportBlazorAPI517.Repositories
{
    public class TripRepository : ITripRepository
    {
        private readonly QuoteContext quoteContext;

        public TripRepository(QuoteContext quoteContext)
        {
            this.quoteContext = quoteContext;
        }

        public async Task<Trip> GetTrip(int tripId)
        {
            return await quoteContext.Trips
                .Include(tr => tr.TravelType)
                //.ThenInclude(x => x.xxxx)
                .FirstOrDefaultAsync(t => t.TripId == tripId);
        }
    }
}
