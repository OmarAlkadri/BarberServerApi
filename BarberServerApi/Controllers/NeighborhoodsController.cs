using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BarberServerApi.Data;
using BarberServerApi.Models;

namespace BarberServerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NeighborhoodsController : ControllerBase
    {
        private readonly My_Graduation_Project_DBContext _context;

        public NeighborhoodsController(My_Graduation_Project_DBContext context)
        {
            _context = context;
        }

        // GET: api/Neighborhoods
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Neighborhood>>> GetNeighborhood()
        {
            return await _context.Neighborhood.ToListAsync();
        }

        // GET: api/Neighborhoods/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Neighborhood>> GetNeighborhood(int id)
        {
            var neighborhood = await _context.Neighborhood.FindAsync(id);

            if (neighborhood == null)
            {
                return NotFound();
            }

            return neighborhood;
        }

        // PUT: api/Neighborhoods/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNeighborhood(int id, Neighborhood neighborhood)
        {
            if (id != neighborhood.NeighborhoodId)
            {
                return BadRequest();
            }

            _context.Entry(neighborhood).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NeighborhoodExists(id))
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

        // POST: api/Neighborhoods
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Neighborhood>> PostNeighborhood(Neighborhood neighborhood)
        {
            _context.Neighborhood.Add(neighborhood);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNeighborhood", new { id = neighborhood.NeighborhoodId }, neighborhood);
        }

        // DELETE: api/Neighborhoods/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNeighborhood(int id)
        {
            var neighborhood = await _context.Neighborhood.FindAsync(id);
            if (neighborhood == null)
            {
                return NotFound();
            }

            _context.Neighborhood.Remove(neighborhood);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NeighborhoodExists(int id)
        {
            return _context.Neighborhood.Any(e => e.NeighborhoodId == id);
        }
    }
}
