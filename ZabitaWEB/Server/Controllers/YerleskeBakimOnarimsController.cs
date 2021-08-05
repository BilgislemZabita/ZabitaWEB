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
    public class YerleskeBakimOnarimsController : ControllerBase
    {
        private readonly ZabitaDatabaseContext _context;

        public YerleskeBakimOnarimsController(ZabitaDatabaseContext context)
        {
            _context = context;
        }

        // GET: api/YerleskeBakimOnarims
        [HttpGet]
        public async Task<ActionResult<IEnumerable<YerleskeBakimOnarim>>> GetYerleskeBakimOnarims()
        {
            return await _context.YerleskeBakimOnarims.ToListAsync();
        }

        // GET: api/YerleskeBakimOnarims/5
        [HttpGet("{id}")]
        public async Task<ActionResult<YerleskeBakimOnarim>> GetYerleskeBakimOnarim(int id)
        {
            var yerleskeBakimOnarim = await _context.YerleskeBakimOnarims.FindAsync(id);

            if (yerleskeBakimOnarim == null)
            {
                return NotFound();
            }

            return yerleskeBakimOnarim;
        }

        // PUT: api/YerleskeBakimOnarims/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutYerleskeBakimOnarim(int id, YerleskeBakimOnarim yerleskeBakimOnarim)
        {
            if (id != yerleskeBakimOnarim.YerleskeBakimOnarimId)
            {
                return BadRequest();
            }

            _context.Entry(yerleskeBakimOnarim).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!YerleskeBakimOnarimExists(id))
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

        // POST: api/YerleskeBakimOnarims
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostYerleskeBakimOnarim(YerleskeBakimOnarim yerleskeBakimOnarim)
        {
            if (yerleskeBakimOnarim.YerleskeBakimOnarimOda!= null)
            {
                var oda = _context.Odas.First(a => a.OdaId == yerleskeBakimOnarim.YerleskeBakimOnarimOda.OdaId);
                yerleskeBakimOnarim.YerleskeBakimOnarimOda = oda;
            }
            if (yerleskeBakimOnarim.YerleskeBakimOnarimTalep != null)
            {
                var talep = _context.Taleps.First(a => a.TalepId == yerleskeBakimOnarim.YerleskeBakimOnarimTalep.TalepId);
                yerleskeBakimOnarim.YerleskeBakimOnarimTalep = talep;
            }
           
            _context.YerleskeBakimOnarims.Add(yerleskeBakimOnarim);
            try
            {
                await _context.SaveChangesAsync();

            }
            catch (DbUpdateException)
            {
                if (YerleskeBakimOnarimExists(yerleskeBakimOnarim.YerleskeBakimOnarimId))
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
            return Ok();
        }

        // DELETE: api/YerleskeBakimOnarims/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteYerleskeBakimOnarim(int id)
        {
            var yerleskeBakimOnarim = await _context.YerleskeBakimOnarims.FindAsync(id);
            if (yerleskeBakimOnarim == null)
            {
                return NotFound();
            }

            _context.YerleskeBakimOnarims.Remove(yerleskeBakimOnarim);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool YerleskeBakimOnarimExists(int id)
        {
            return _context.YerleskeBakimOnarims.Any(e => e.YerleskeBakimOnarimId == id);
        }
    }
}
