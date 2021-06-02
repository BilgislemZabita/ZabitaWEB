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
    public class DemirbasController : ControllerBase
    {
        private readonly ZabitaDatabaseContext _context;

        public DemirbasController(ZabitaDatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Demirbas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Demirbas>>> GetDemirbases()
        {
            return await _context.Demirbases.ToListAsync();
        }

        // GET: api/Demirbas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Demirbas>> GetDemirbas(int id)
        {
            var demirbas = await _context.Demirbases.FindAsync(id);

            if (demirbas == null)
            {
                return NotFound();
            }

            return demirbas;
        }

        // PUT: api/Demirbas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDemirbas(int id, Demirbas demirbas)
        {
            if (id != demirbas.DemirbasId)
            {
                return BadRequest();
            }

            _context.Entry(demirbas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DemirbasExists(id))
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

        // POST: api/Demirbas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Demirbas>> PostDemirbas(Demirbas demirbas)
        {
            _context.Demirbases.Add(demirbas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDemirbas", new { id = demirbas.DemirbasId }, demirbas);
        }

        // DELETE: api/Demirbas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDemirbas(int id)
        {
            var demirbas = await _context.Demirbases.FindAsync(id);
            if (demirbas == null)
            {
                return NotFound();
            }

            _context.Demirbases.Remove(demirbas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DemirbasExists(int id)
        {
            return _context.Demirbases.Any(e => e.DemirbasId == id);
        }
    }
}