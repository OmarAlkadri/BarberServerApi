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
    public class ReservationBarbersController : ControllerBase
    {
        private readonly My_Graduation_Project_DBContext _context;

        public ReservationBarbersController(My_Graduation_Project_DBContext context)
        {
            _context = context;
        }

        // GET: api/ReservationBarbers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReservationBarber>>> GetReservationBarber()
        {
            return await _context.ReservationBarber.ToListAsync();
        }

        // GET: api/ReservationBarbers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ReservationBarber>> GetReservationBarber(int id)
        {
            var reservationBarber = await _context.ReservationBarber.FindAsync(id);

            if (reservationBarber == null)
            {
                return NotFound();
            }

            return reservationBarber;
        }

        // PUT: api/ReservationBarbers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReservationBarber(int id, ReservationBarber reservationBarber)
        {
            if (id != reservationBarber.ReservationBarberId)
            {
                return BadRequest();
            }

            _context.Entry(reservationBarber).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReservationBarberExists(id))
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

        // POST: api/ReservationBarbers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ReservationBarber>> PostReservationBarber(ReservationBarber reservationBarber)
        {
            _context.ReservationBarber.Add(reservationBarber);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReservationBarber", new { id = reservationBarber.ReservationBarberId }, reservationBarber);
        }

        // DELETE: api/ReservationBarbers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReservationBarber(int id)
        {
            var reservationBarber = await _context.ReservationBarber.FindAsync(id);
            if (reservationBarber == null)
            {
                return NotFound();
            }

            _context.ReservationBarber.Remove(reservationBarber);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReservationBarberExists(int id)
        {
            return _context.ReservationBarber.Any(e => e.ReservationBarberId == id);
        }
    }
}
