using ExecPetTransportBlazorAPI517.Data;
using ExecPetTransportBlazorAPI517.Models;
using System.Threading.Tasks;

namespace ExecPetTransportBlazorAPI517.Repositories
{
    public interface ITripRepository
    {
        Task<Trip> GetTrip(int tripId);
        

    }
}
