using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Zabita.Entities.Concrete;
using ZabitaWEB.Server.Concrete.EntityFramework;

namespace ZabitaWEB.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OdasController : ControllerBase
    {
        private readonly ZabitaDatabaseContext _context;

        public OdasController(ZabitaDatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Odas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Oda>>> GetOdas()
        {
            return await _context.Odas.ToListAsync();
        }

        // GET: api/Odas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Oda>> GetOda(int id)
        {
            var oda = await _context.Odas.FindAsync(id);

            if (oda == null)
            {
                return NotFound();
            }

            return oda;
        }

        // PUT: api/Odas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOda(int id, Oda oda)
        {
            if (id != oda.OdaId)
            {
                return BadRequest();
            }

            _context.Entry(oda).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OdaExists(id))
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

        // POST: api/Odas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Oda>> PostOda(Oda oda)
        {
            _context.Odas.Add(oda);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOda", new { id = oda.OdaId }, oda);
        }

        // DELETE: api/Odas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOda(int id)
        {
            var oda = await _context.Odas.FindAsync(id);
            if (oda == null)
            {
                return NotFound();
            }

            _context.Odas.Remove(oda);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OdaExists(int id)
        {
            return _context.Odas.Any(e => e.OdaId == id);
        }
    }
}