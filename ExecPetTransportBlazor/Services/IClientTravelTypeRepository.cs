using ExecPetTransportBlazorAPI517.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExecPetTransportBlazor.Services
{
    public interface IClientTravelTypeRepository
    {
        //Task<IEnumerable<TravelType>> GetTravelTypes();
        //Task<TravelType> GetTravelType(int TravelTypeId);

        Task<IEnumerable<TravelType>> LoadTraveltypes();
    }
}
