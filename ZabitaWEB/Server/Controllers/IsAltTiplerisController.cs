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
    public class IsAltTiplerisController : ControllerBase
    {
        private readonly ZabitaDatabaseContext _context;

        public IsAltTiplerisController(ZabitaDatabaseContext context)
        {
            _context = context;
        }

        // GET: api/IsAltTipleris
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IsAltTipleri>>> GetIsAltTipleris()
        {
            return await _context.IsAltTipleris.ToListAsync();
        }

        // GET: api/IsAltTipleris/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IsAltTipleri>> GetIsAltTipleri(int id)
        {
            var isAltTipleri = await _context.IsAltTipleris.FindAsync(id);

            if (isAltTipleri == null)
            {
                return NotFound();
            }

            return isAltTipleri;
        }

        // PUT: api/IsAltTipleris/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIsAltTipleri(int id, IsAltTipleri isAltTipleri)
        {
            if (id != isAltTipleri.IsAltTipiId)
            {
                return BadRequest();
            }

            _context.Entry(isAltTipleri).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IsAltTipleriExists(id))
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

        // POST: api/IsAltTipleris
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<IsAltTipleri>> PostIsAltTipleri(IsAltTipleri isAltTipleri)
        {
            _context.IsAltTipleris.Add(isAltTipleri);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIsAltTipleri", new { id = isAltTipleri.IsAltTipiId }, isAltTipleri);
        }

        // DELETE: api/IsAltTipleris/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIsAltTipleri(int id)
        {
            var isAltTipleri = await _context.IsAltTipleris.FindAsync(id);
            if (isAltTipleri == null)
            {
                return NotFound();
            }

            _context.IsAltTipleris.Remove(isAltTipleri);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IsAltTipleriExists(int id)
        {
            return _context.IsAltTipleris.Any(e => e.IsAltTipiId == id);
        }
    }
}
