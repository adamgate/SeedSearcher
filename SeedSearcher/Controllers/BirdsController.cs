using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SeedSearcher.Data;
using SeedSearcher.Models;

namespace SeedSearcher.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BirdsController : ControllerBase
    {
        private readonly SeedSearcherContext _context;

        public BirdsController(SeedSearcherContext context)
        {
            _context = context;
        }

        // GET: api/Birds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bird>>> GetBird()
        {
            return await _context.Bird.ToListAsync();
        }

        // GET: api/Birds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bird>> GetBird(int id)
        {
            var bird = await _context.Bird.FindAsync(id);

            if (bird == null)
            {
                return NotFound();
            }

            return bird;
        }

        // PUT: api/Birds/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBird(int id, Bird bird)
        {
            if (id != bird.BirdId)
            {
                return BadRequest();
            }

            _context.Entry(bird).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BirdExists(id))
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

        // POST: api/Birds
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bird>> PostBird(Bird bird)
        {
            _context.Bird.Add(bird);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBird", new { id = bird.BirdId }, bird);
        }

        // DELETE: api/Birds/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBird(int id)
        {
            var bird = await _context.Bird.FindAsync(id);
            if (bird == null)
            {
                return NotFound();
            }

            _context.Bird.Remove(bird);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BirdExists(int id)
        {
            return _context.Bird.Any(e => e.BirdId == id);
        }
    }
}
