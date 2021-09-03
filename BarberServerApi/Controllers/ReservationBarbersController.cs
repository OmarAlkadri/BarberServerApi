using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BarberServerApi.Data;
using BarberServerApi.Models;
using BarberServerApi.ViewModels;

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
        public async Task<ActionResult<List<ReservationModel>>> GetReservationBarber()
        {
            var a = await (from data in _context.ReservationBarber
                           select new ReservationModel
                           {
                               BarberId = data.Barber.BarberId,
                               BarberShowName = data.Barber.BarberShowName,
                               BarberImg = data.Barber.Personnel.PersonnelImageUrl,
                               times = data.Day+" - "+ data.Hour+":"+ data.Min,
                               PayingOffModel = new PayingOffModel
                               { 
                                   paid = data.PayingOff.paid
                               },
                               ContactInfoModel = new ContactInfoModel
                               {
                                   adres = data.Barber.ContactInfo.District.Neighborhood.Province.ProvinceName+" "+
                                   data.Barber.ContactInfo.District.Neighborhood.NeighborhoodName + " " +
                                   data.Barber.ContactInfo.District.DistrictName+ " " +
                                   data.Barber.ContactInfo.StreetAvenueName
                               },

                           }).ToListAsync();
            return a;
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
