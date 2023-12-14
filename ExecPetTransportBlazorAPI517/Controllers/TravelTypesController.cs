using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExecPetTransportBlazorAPI517.Data;
using ExecPetTransportBlazorAPI517.Models;

namespace ExecPetTransportBlazorAPI517.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelTypesController : ControllerBase
    {
        private readonly CoyoteQuoteContext _context;

        public TravelTypesController(CoyoteQuoteContext context)
        {
            _context = context;
        }

        // GET: api/TravelTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TravelType>>> GetTravelType()
        {
            return await _context.TravelType.ToListAsync();
        }

        // GET: api/TravelTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TravelType>> GetTravelType(int id)
        {
            var travelType = await _context.TravelType.FindAsync(id);

            if (travelType == null)
            {
                return NotFound();
            }

            return travelType;
        }

        // PUT: api/TravelTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTravelType(int id, TravelType travelType)
        {
            if (id != travelType.TravelTypeId)
            {
                return BadRequest();
            }

            _context.Entry(travelType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TravelTypeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TravelTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TravelType>> PostTravelType(TravelType travelType)
        {
            _context.TravelType.Add(travelType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTravelType", new { id = travelType.TravelTypeId }, travelType);
        }

        // DELETE: api/TravelTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTravelType(int id)
        {
            var travelType = await _context.TravelType.FindAsync(id);
            if (travelType == null)
            {
                return NotFound();
            }

            _context.TravelType.Remove(travelType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TravelTypeExists(int id)
        {
            return _context.TravelType.Any(e => e.TravelTypeId == id);
        }
    }
}
