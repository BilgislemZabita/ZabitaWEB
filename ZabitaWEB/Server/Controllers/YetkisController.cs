using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Zabita.DataAccessLayer.Concrete.EntityFramework;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YetkisController : ControllerBase
    {
        private readonly ZabitaDatabaseContext _context;

        public YetkisController(ZabitaDatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Yetkis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IdentityRole>>> GetYetkis()
        {
            return await _context.Yetkis.ToListAsync();
        }

        // GET: api/Yetkis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IdentityRole>> GetYetki(int id)
        {
            var yetki = await _context.Yetkis.FindAsync(id);

            if (yetki == null)
            {
                return NotFound();
            }

            return yetki;
        }

        // PUT: api/Yetkis/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutYetki(int id, Yetki yetki)
        {
            if (id != yetki.YetkiId)
            {
                return BadRequest();
            }

            _context.Entry(yetki).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!YetkiExists(id.ToString()))
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

        // POST: api/Yetkis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Yetki>> PostYetki(Yetki yetki)
        {
            _context.Yetkis.Add(yetki);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (YetkiExists(yetki.YetkiId.ToString()))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetYetki", new { id = yetki.YetkiId }, yetki);
        }

        // DELETE: api/Yetkis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteYetki(int id)
        {
            var yetki = await _context.Yetkis.FindAsync(id);
            if (yetki == null)
            {
                return NotFound();
            }

            _context.Yetkis.Remove(yetki);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool YetkiExists(string id)
        {
            return _context.Yetkis.Any(e => e.Id == id);
        }
    }
}