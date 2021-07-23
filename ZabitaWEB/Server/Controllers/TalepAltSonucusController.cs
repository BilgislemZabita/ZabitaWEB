using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Zabita.DataAccessLayer.Concrete.EntityFramework;
using Zabita.Entities.Concrete;
using ZabitaWEB.Client.Services.Abstract;

namespace ZabitaWEB.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TalepAltSonucusController : ControllerBase, ITalepAltSonucusService
    {
        private readonly ZabitaDatabaseContext _context;

        public TalepAltSonucusController(ZabitaDatabaseContext context)
        {
            _context = context;
        }

        // GET: api/TalepAltSonucus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TalepAltSonucu>>> GetTalepAltSonucus()
        {
            return await _context.TalepAltSonucus.ToListAsync();
        }

        // GET: api/TalepAltSonucus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TalepAltSonucu>> GetTalepAltSonucu(int id)
        {
            var talepAltSonucu = await _context.TalepAltSonucus.FindAsync(id);

            if (talepAltSonucu == null)
            {
                return NotFound();
            }

            return talepAltSonucu;
        }

        // PUT: api/TalepAltSonucus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTalepAltSonucu(int id, TalepAltSonucu talepAltSonucu)
        {
            if (id != talepAltSonucu.TalepAltSonucuId)
            {
                return BadRequest();
            }

            _context.Entry(talepAltSonucu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TalepAltSonucuExists(id))
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

        // POST: api/TalepAltSonucus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TalepAltSonucu>> PostTalepAltSonucu(TalepAltSonucu talepAltSonucu)
        {
            _context.TalepAltSonucus.Add(talepAltSonucu);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTalepAltSonucu", new { id = talepAltSonucu.TalepAltSonucuId }, talepAltSonucu);
        }

        // DELETE: api/TalepAltSonucus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTalepAltSonucu(int id)
        {
            var talepAltSonucu = await _context.TalepAltSonucus.FindAsync(id);
            if (talepAltSonucu == null)
            {
                return NotFound();
            }

            _context.TalepAltSonucus.Remove(talepAltSonucu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TalepAltSonucuExists(int id)
        {
            return _context.TalepAltSonucus.Any(e => e.TalepAltSonucuId == id);
        }
    }
}
