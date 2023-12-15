using ExecPetTransportBlazorAPI517.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExecPetTransportBlazorAPI517.Services
{
    public interface ITravelTypeService
    {
        Task<IEnumerable<TravelType>> GetTravelTypes();

    }
}
