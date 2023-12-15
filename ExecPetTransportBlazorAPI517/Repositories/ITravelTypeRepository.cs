using ExecPetTransportBlazorAPI517.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExecPetTransportBlazorAPI517.Repositories
{
    public interface ITravelTypeRepository
    {
        //Task<IEnumerable<TravelType>> GetTravelTypes();
        //Task<TravelType> GetTravelType(int TravelTypeId);

        IEnumerable<TravelType> LoadTraveltypes();
    }
}
