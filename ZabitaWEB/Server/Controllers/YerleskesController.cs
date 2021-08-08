using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Zabita.Entities.Concrete;
using ZabitaWEB.Server.Concrete.EntityFramework;

namespace ZabitaWEB.Server.Controllers
{
    [Authorize]

    [Route("api/[controller]")]
    [ApiController]
    public class YerleskesController : ControllerBase
    {
        private readonly ZabitaDatabaseContext _context;

        public YerleskesController(ZabitaDatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Yerleskes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Yerleske>>> GetYerleskes()
        {
            return await _context.Yerleskes.ToListAsync();
        }

        // GET: api/Yerleskes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Yerleske>> GetYerleske(int id)
        {
            var yerleske = await _context.Yerleskes.FindAsync(id);

            if (yerleske == null)
            {
                return NotFound();
            }

            return yerleske;
        }

        // PUT: api/Yerleskes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutYerleske(int id, Yerleske yerleske)
        {
            if (id != yerleske.YerleskeId)
            {
                return BadRequest();
            }

            _context.Entry(yerleske).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!YerleskeExists(id))
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

        // POST: api/Yerleskes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Yerleske>> PostYerleske(Yerleske yerleske)
        {
            _context.Yerleskes.Add(yerleske);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetYerleske", new { id = yerleske.YerleskeId }, yerleske);
        }

        // DELETE: api/Yerleskes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteYerleske(int id)
        {
            var yerleske = await _context.Yerleskes.FindAsync(id);
            if (yerleske == null)
            {
                return NotFound();
            }

            _context.Yerleskes.Remove(yerleske);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool YerleskeExists(int id)
        {
            return _context.Yerleskes.Any(e => e.YerleskeId == id);
        }
    }
}