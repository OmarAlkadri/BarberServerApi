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
    public class WorkingHoursController : ControllerBase
    {
        private readonly My_Graduation_Project_DBContext _context;

        public WorkingHoursController(My_Graduation_Project_DBContext context)
        {
            _context = context;
        }

        // GET: api/WorkingHours
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkingHours>>> GetWorkingHours()
        {
            return await _context.WorkingHours.ToListAsync();
        }

        // GET: api/WorkingHours/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkingHours>> GetWorkingHours(int id)
        {
            var workingHours = await _context.WorkingHours.SingleOrDefaultAsync(f => f.BarberId == id);

            if (workingHours == null)
            {
                return NotFound();
            }

            return workingHours;
        }

        // PUT: api/WorkingHours/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkingHours(int id, WorkingHours workingHours)
        {
            if (id != workingHours.WorkingHoursId)
            {
                return BadRequest();
            }

            _context.Entry(workingHours).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkingHoursExists(id))
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

        // POST: api/WorkingHours
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WorkingHours>> PostWorkingHours(WorkingHours workingHours)
        {
            /*
            if (_context.WorkingHours.SingleOrDefaultAsync(f=>f.BarberId == workingHours.BarberId) == null)
            {
                return BadRequest();
            }
            _context.WorkingHours.Add(workingHours);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWorkingHours", new { id = workingHours.WorkingHoursId }, workingHours);
             */
            _context.WorkingHours.Add(workingHours);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWorkingHours", new { id = workingHours.WorkingHoursId }, workingHours);
        }

        // DELETE: api/WorkingHours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkingHours(int id)
        {
            var workingHours = await _context.WorkingHours.FindAsync(id);
            if (workingHours == null)
            {
                return NotFound();
            }

            _context.WorkingHours.Remove(workingHours);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WorkingHoursExists(int id)
        {
            return _context.WorkingHours.Any(e => e.WorkingHoursId == id);
        }
    }
}
