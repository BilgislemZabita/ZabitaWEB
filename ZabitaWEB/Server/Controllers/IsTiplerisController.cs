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
    public class IsTiplerisController : ControllerBase
    {
        private readonly ZabitaDatabaseContext _context;

        public IsTiplerisController(ZabitaDatabaseContext context)
        {
            _context = context;
        }

        // GET: api/IsTipleris
        [HttpGet]
        public async Task<ActionResult<List<IsTipleri>>> GetIsTipleris()
        {
            return await _context.IsTipleris.ToListAsync();
        }

        // GET: api/IsTipleris/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IsTipleri>> GetIsTipleri(int id)
        {
            var isTipleri = await _context.IsTipleris.FindAsync(id);

            if (isTipleri == null)
            {
                return NotFound();
            }

            return isTipleri;
        }

        // PUT: api/IsTipleris/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIsTipleri(int id, IsTipleri isTipleri)
        {
            if (id != isTipleri.IstipiID)
            {
                return BadRequest();
            }

            _context.Entry(isTipleri).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IsTipleriExists(id))
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

        // POST: api/IsTipleris
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<IsTipleri>> PostIsTipleri(IsTipleri isTipleri)
        {
            _context.IsTipleris.Add(isTipleri);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIsTipleri", new { id = isTipleri.IstipiID }, isTipleri);
        }

        // DELETE: api/IsTipleris/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIsTipleri(int id)
        {
            var isTipleri = await _context.IsTipleris.FindAsync(id);
            if (isTipleri == null)
            {
                return NotFound();
            }

            _context.IsTipleris.Remove(isTipleri);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IsTipleriExists(int id)
        {
            return _context.IsTipleris.Any(e => e.IstipiID == id);
        }
    }
}
