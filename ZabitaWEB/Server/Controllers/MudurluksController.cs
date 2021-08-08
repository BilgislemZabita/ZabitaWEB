using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Zabita.Entities.Concrete;
using ZabitaWEB.Server.Concrete.EntityFramework;

namespace ZabitaWEB.Server.Controllers
{
    [Authorize]

    [Route("api/[controller]")]
    [ApiController]
    public class MudurluksController : ControllerBase
    {
        private readonly ZabitaDatabaseContext _context;

        public MudurluksController(ZabitaDatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Mudurluks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mudurluk>>> GetMudurluks()
        {
            return await _context.Mudurluks.ToListAsync();
        }

        // GET: api/Mudurluks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mudurluk>> GetMudurluk(int id)
        {
            var mudurluk = await _context.Mudurluks.FindAsync(id);

            if (mudurluk == null)
            {
                return NotFound();
            }

            return mudurluk;
        }

        // PUT: api/Mudurluks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMudurluk(int id, Mudurluk mudurluk)
        {
            if (id != mudurluk.MudurlukId)
            {
                return BadRequest();
            }

            _context.Entry(mudurluk).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MudurlukExists(id))
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

        // POST: api/Mudurluks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Mudurluk>> PostMudurluk(Mudurluk mudurluk)
        {
            _context.Mudurluks.Add(mudurluk);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMudurluk", new { id = mudurluk.MudurlukId }, mudurluk);
        }

        // DELETE: api/Mudurluks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMudurluk(int id)
        {
            var mudurluk = await _context.Mudurluks.FindAsync(id);
            if (mudurluk == null)
            {
                return NotFound();
            }

            _context.Mudurluks.Remove(mudurluk);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MudurlukExists(int id)
        {
            return _context.Mudurluks.Any(e => e.MudurlukId == id);
        }
    }
}