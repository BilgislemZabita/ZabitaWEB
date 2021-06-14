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
    public class TalepsController : ControllerBase
    {
        private readonly ZabitaDatabaseContext _context;

        public TalepsController(ZabitaDatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Taleps
        [HttpGet]
        public async Task<ActionResult<List<Talep>>> GetTaleps()
        {
            return await _context.Taleps.ToListAsync();
        }

        // GET: api/Taleps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Talep>> GetTalep(int id)
        {
            var talep = await _context.Taleps.FindAsync(id);

            if (talep == null)
            {
                return NotFound();
            }

            return talep;
        }

        // PUT: api/Taleps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTalep(int id, Talep talep)
        {
            if (id != talep.TalepId)
            {
                return BadRequest();
            }

            _context.Entry(talep).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TalepExists(id))
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

        // POST: api/Taleps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Talep>> PostTalep(Talep talep)
        {
            _context.Taleps.Add(talep);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TalepExists(talep.TalepId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }
            //https://www.tutorialsteacher.com/webapi/implement-post-method-in-web-api
            //https://www.tutorialsteacher.com/webapi/consume-web-api-post-method-in-aspnet-mvc
            return CreatedAtAction("GetTalep", new { id = talep.TalepId }, talep);
        }

        // DELETE: api/Taleps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTalep(int id)
        {
            var talep = await _context.Taleps.FindAsync(id);
            if (talep == null)
            {
                return NotFound();
            }

            _context.Taleps.Remove(talep);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TalepExists(int id)
        {
            return _context.Taleps.Any(e => e.TalepId == id);
        }
    }
}
