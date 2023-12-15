using ExecPetTransportBlazorAPI517.Data;
using ExecPetTransportBlazorAPI517.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExecPetTransportBlazorAPI517.Repositories
{
    public class TravelTypeRepository : ITravelTypeRepository
    {
        //private readonly CoyoteQuoteContext _context;

        //public TravelTypeRepository(CoyoteQuoteContext context)
        //{
        //    _context = context;
        //}
        //public async Task<TravelType> GetTravelType(int TravelTypeId)
        //{
        //    return await _context.TravelType.FirstOrDefaultAsync(t => t.TravelTypeId == TravelTypeId);
        //}

        //public async Task<IEnumerable<TravelType>> GetTravelTypes()
        //{
        //    return await _context.TravelType.ToListAsync();
        //}

        public IEnumerable<TravelType> LoadTraveltypes()
        {
            TravelType t1 = new TravelType()
            {
                TravelTypeId = 1,
                Description = "One-way"
            };

            TravelType t2 = new TravelType()
            {
                TravelTypeId = 2,
                Description = "Two-way"
            };

            List<TravelType> result = new List<TravelType>();

            result.Add(t1);
            result.Add(t2);

            IEnumerable<TravelType> ltt = result;
            return ltt;
        }
    }
}
