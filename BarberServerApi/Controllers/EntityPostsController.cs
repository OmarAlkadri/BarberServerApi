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
    public class EntityPostsController : ControllerBase
    {
        private readonly My_Graduation_Project_DBContext _context;

        public EntityPostsController(My_Graduation_Project_DBContext context)
        {
            _context = context;
        }

        // GET: api/EntityPosts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EntityPost>>> GetEntityPost()
        {
            return await _context.EntityPost.ToListAsync();
        }

        // GET: api/EntityPosts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EntityPost>> GetEntityPost(int id)
        {
            var entityPost = await _context.EntityPost.FindAsync(id);

            if (entityPost == null)
            {
                return NotFound();
            }

            return entityPost;
        }

        // PUT: api/EntityPosts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEntityPost(int id, EntityPost entityPost)
        {
            if (id != entityPost.EntityPostId)
            {
                return BadRequest();
            }

            _context.Entry(entityPost).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntityPostExists(id))
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

        // POST: api/EntityPosts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EntityPost>> PostEntityPost(EntityPost entityPost)
        {
            _context.EntityPost.Add(entityPost);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEntityPost", new { id = entityPost.EntityPostId }, entityPost);
        }

        // DELETE: api/EntityPosts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEntityPost(int id)
        {
            var entityPost = await _context.EntityPost.FindAsync(id);
            if (entityPost == null)
            {
                return NotFound();
            }

            _context.EntityPost.Remove(entityPost);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EntityPostExists(int id)
        {
            return _context.EntityPost.Any(e => e.EntityPostId == id);
        }
    }
}
