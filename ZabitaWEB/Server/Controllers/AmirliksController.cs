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
    public class AmirliksController : ControllerBase
    {
        private readonly ZabitaDatabaseContext _context;

        public AmirliksController(ZabitaDatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Amirliks
        [HttpGet]
        public async Task<ActionResult<List<Amirlik>>> GetAmirliks()
        {
            return await _context.Amirliks.ToListAsync();
        }

        // GET: api/Amirliks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Amirlik>> GetAmirlik(int id)
        {
            var amirlik = await _context.Amirliks.FindAsync(id);

            if (amirlik == null)
            {
                return NotFound();
            }

            return amirlik;
        }

        // PUT: api/Amirliks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAmirlik(int id, Amirlik amirlik)
        {
            if (id != amirlik.AmirlikID)
            {
                return BadRequest();
            }

            _context.Entry(amirlik).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmirlikExists(id))
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

        // POST: api/Amirliks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Amirlik>> PostAmirlik(Amirlik amirlik)
        {
            _context.Amirliks.Add(amirlik);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAmirlik", new { id = amirlik.AmirlikID }, amirlik);
        }

        // DELETE: api/Amirliks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAmirlik(int id)
        {
            var amirlik = await _context.Amirliks.FindAsync(id);
            if (amirlik == null)
            {
                return NotFound();
            }

            _context.Amirliks.Remove(amirlik);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AmirlikExists(int id)
        {
            return _context.Amirliks.Any(e => e.AmirlikID == id);
        }
    }
}