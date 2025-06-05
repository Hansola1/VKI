using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MorphpediaAPI.DataAccess;
using MorphpediaAPI.Models;

namespace MorphpediaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MorphsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public MorphsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Morph>>> GetAll()
        {
            return await _context.Morphs.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Morph>> GetById(int id)
        {
            var morph = await _context.Morphs.FindAsync(id);
            if (morph == null) return NotFound();
            return morph;
        }

        [HttpPost]
        public async Task<ActionResult<Morph>> AddMorph([FromBody] Morph morph)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Morphs.Add(morph);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = morph.Id }, morph);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditMorph(int id, [FromBody] Morph morph)
        {
            if (id != morph.Id)
            {
                return BadRequest();
            }

            _context.Entry(morph).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MorphExists(id))
                {
                    return NotFound();
                }
                else { throw; }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMorph(int id)
        {
            var morph = await _context.Morphs.FindAsync(id);
            if (morph == null)
            {
                return NotFound();
            }

            _context.Morphs.Remove(morph);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MorphExists(int id)
        {
            return _context.Morphs.Any(e => e.Id == id);
        }
    }
}
