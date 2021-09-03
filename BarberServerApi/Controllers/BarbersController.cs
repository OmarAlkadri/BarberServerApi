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
    public class BarbersController : ControllerBase
    {
        private readonly My_Graduation_Project_DBContext _context;

        public BarbersController(My_Graduation_Project_DBContext context)
        {
            _context = context;
        }

        // GET: api/Barbers
        [HttpGet]
        public async Task<ActionResult<List<ShowBarberModel>>> GetBarber()
        {
            var a = await (from data in _context.Barber
                           select new ShowBarberModel
                           {
                               BarberId = data.BarberId,
                               BarberShowName = data.BarberShowName,
                               OpeningTime = data.WorkingHours.OpeningTime,
                               closingTime = data.WorkingHours.closingTime,
                               BarberImg = data.Personnel.PersonnelImageUrl,
                               ContactInfoModel = new ContactInfoModel
                               {
                                   adres = data.ContactInfo.District.Neighborhood.Province.ProvinceName + " " +
                                   data.ContactInfo.District.Neighborhood.NeighborhoodName + " " +
                                   data.ContactInfo.District.DistrictName + " " +
                                   data.ContactInfo.StreetAvenueName
                               },
                           }).ToListAsync();
            return a;
        }

        // GET: api/Barbers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Barber>> GetBarber(int id)
        {
            var barber = await _context.Barber.FindAsync(id);

            if (barber == null)
            {
                return NotFound();
            }

            return barber;
        }

        // PUT: api/Barbers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBarber(int id, Barber barber)
        {
            if (id != barber.BarberId)
            {
                return BadRequest();
            }

            _context.Entry(barber).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BarberExists(id))
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

        // POST: api/Barbers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Barber>> PostBarber(Barber barber)
        {
            _context.Barber.Add(barber);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBarber", new { id = barber.BarberId }, barber);
        }

        // DELETE: api/Barbers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBarber(int id)
        {
            var barber = await _context.Barber.FindAsync(id);
            if (barber == null)
            {
                return NotFound();
            }

            _context.Barber.Remove(barber);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BarberExists(int id)
        {
            return _context.Barber.Any(e => e.BarberId == id);
        }
    }
}
