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
    public class YerleskeTeknikBilgilersController : ControllerBase
    {
        private readonly ZabitaDatabaseContext _context;

        public YerleskeTeknikBilgilersController(ZabitaDatabaseContext context)
        {
            _context = context;
        }

        // GET: api/YerleskeTeknikBilgilers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<YerleskeTeknikBilgiler>>> GetYerleskeTeknikBilgilers()
        {
            return await _context.YerleskeTeknikBilgilers.ToListAsync();
        }

        // GET: api/YerleskeTeknikBilgilers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<YerleskeTeknikBilgiler>> GetYerleskeTeknikBilgiler(int id)
        {
            var yerleskeTeknikBilgiler = await _context.YerleskeTeknikBilgilers.FindAsync(id);

            if (yerleskeTeknikBilgiler == null)
            {
                return NotFound();
            }

            return yerleskeTeknikBilgiler;
        }

        // PUT: api/YerleskeTeknikBilgilers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutYerleskeTeknikBilgiler(int id, YerleskeTeknikBilgiler yerleskeTeknikBilgiler)
        {
            if (id != yerleskeTeknikBilgiler.YerleskeTeknikBilgilerId)
            {
                return BadRequest();
            }

            _context.Entry(yerleskeTeknikBilgiler).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!YerleskeTeknikBilgilerExists(id))
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

        // POST: api/YerleskeTeknikBilgilers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<YerleskeTeknikBilgiler>> PostYerleskeTeknikBilgiler(YerleskeTeknikBilgiler yerleskeTeknikBilgiler)
        {
            _context.YerleskeTeknikBilgilers.Add(yerleskeTeknikBilgiler);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetYerleskeTeknikBilgiler", new { id = yerleskeTeknikBilgiler.YerleskeTeknikBilgilerId }, yerleskeTeknikBilgiler);
        }

        // DELETE: api/YerleskeTeknikBilgilers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteYerleskeTeknikBilgiler(int id)
        {
            var yerleskeTeknikBilgiler = await _context.YerleskeTeknikBilgilers.FindAsync(id);
            if (yerleskeTeknikBilgiler == null)
            {
                return NotFound();
            }

            _context.YerleskeTeknikBilgilers.Remove(yerleskeTeknikBilgiler);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool YerleskeTeknikBilgilerExists(int id)
        {
            return _context.YerleskeTeknikBilgilers.Any(e => e.YerleskeTeknikBilgilerId == id);
        }
    }
}
