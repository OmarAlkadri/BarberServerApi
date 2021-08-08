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
    public class PayingOffsController : ControllerBase
    {
        private readonly My_Graduation_Project_DBContext _context;

        public PayingOffsController(My_Graduation_Project_DBContext context)
        {
            _context = context;
        }

        // GET: api/PayingOffs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PayingOff>>> GetPayingOff()
        {
            return await _context.PayingOff.ToListAsync();
        }

        // GET: api/PayingOffs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PayingOff>> GetPayingOff(int id)
        {
            var payingOff = await _context.PayingOff.FindAsync(id);

            if (payingOff == null)
            {
                return NotFound();
            }

            return payingOff;
        }

        // PUT: api/PayingOffs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPayingOff(int id, PayingOff payingOff)
        {
            if (id != payingOff.PayingOffId)
            {
                return BadRequest();
            }

            _context.Entry(payingOff).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PayingOffExists(id))
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

        // POST: api/PayingOffs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PayingOff>> PostPayingOff(PayingOff payingOff)
        {
            _context.PayingOff.Add(payingOff);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPayingOff", new { id = payingOff.PayingOffId }, payingOff);
        }

        // DELETE: api/PayingOffs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePayingOff(int id)
        {
            var payingOff = await _context.PayingOff.FindAsync(id);
            if (payingOff == null)
            {
                return NotFound();
            }

            _context.PayingOff.Remove(payingOff);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PayingOffExists(int id)
        {
            return _context.PayingOff.Any(e => e.PayingOffId == id);
        }
    }
}
