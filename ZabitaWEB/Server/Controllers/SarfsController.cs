using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Zabita.DataAccessLayer.Concrete.EntityFramework;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SarfsController : ControllerBase
    {
        private readonly ZabitaDatabaseContext _context;

        public SarfsController(ZabitaDatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Sarfs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sarf>>> GetSarfs()
        {
            return await _context.Sarfs.ToListAsync();
        }

        // GET: api/Sarfs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sarf>> GetSarf(int id)
        {
            var sarf = await _context.Sarfs.FindAsync(id);

            if (sarf == null)
            {
                return NotFound();
            }

            return sarf;
        }

        // PUT: api/Sarfs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSarf(int id, Sarf sarf)
        {
            if (id != sarf.SarfId)
            {
                return BadRequest();
            }

            _context.Entry(sarf).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SarfExists(id))
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

        // POST: api/Sarfs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sarf>> PostSarf(Sarf sarf)
        {
            _context.Sarfs.Add(sarf);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSarf", new { id = sarf.SarfId }, sarf);
        }

        // DELETE: api/Sarfs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSarf(int id)
        {
            var sarf = await _context.Sarfs.FindAsync(id);
            if (sarf == null)
            {
                return NotFound();
            }

            _context.Sarfs.Remove(sarf);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SarfExists(int id)
        {
            return _context.Sarfs.Any(e => e.SarfId == id);
        }
    }
}