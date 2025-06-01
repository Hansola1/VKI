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
    }
}
