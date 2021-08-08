﻿using System;
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
    public class PersonnelsController : ControllerBase
    {
        private readonly My_Graduation_Project_DBContext _context;

        public PersonnelsController(My_Graduation_Project_DBContext context)
        {
            _context = context;
        }

        // GET: api/Personnels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Personnel>>> GetPersonnel()
        {
            return await _context.Personnel.ToListAsync();
        }

        // GET: api/Personnels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Personnel>> GetPersonnel(int id)
        {
            var personnel = await _context.Personnel.FindAsync(id);

            if (personnel == null)
            {
                return NotFound();
            }

            return personnel;
        }

        // PUT: api/Personnels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonnel(int id, Personnel personnel)
        {
            if (id != personnel.PersonnelId)
            {
                return BadRequest();
            }

            _context.Entry(personnel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonnelExists(id))
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

        // POST: api/Personnels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Personnel>> PostPersonnel(Personnel personnel)
        {
            _context.Personnel.Add(personnel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPersonnel", new { id = personnel.PersonnelId }, personnel);
        }

        // DELETE: api/Personnels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonnel(int id)
        {
            var personnel = await _context.Personnel.FindAsync(id);
            if (personnel == null)
            {
                return NotFound();
            }

            _context.Personnel.Remove(personnel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonnelExists(int id)
        {
            return _context.Personnel.Any(e => e.PersonnelId == id);
        }
    }
}
