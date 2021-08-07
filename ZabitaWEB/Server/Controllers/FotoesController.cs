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
    public class FotoesController : ControllerBase
    {
        private readonly ZabitaDatabaseContext _context;

        public FotoesController(ZabitaDatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Fotoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Foto>>> GetFotolars()
        {
            return await _context.Fotolars.ToListAsync();
        }

        // GET: api/Fotoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Foto>> GetFoto(int id)
        {
            var foto = await _context.Fotolars.FindAsync(id);

            if (foto == null)
            {
                return NotFound();
            }

            return foto;
        }
        // GET: api/Fotoes/talep/5
        [HttpGet("talep/{id:int}")]
        public async Task<ActionResult<List<Foto>>> GetTalepFoto(int id)
        {
            var foto = await _context.Fotolars.Where(s=>s.FotoTalep.TalepId==id).ToListAsync();

            if (foto == null)
            {
                return NotFound();
            }

            return foto;
        }

        // PUT: api/Fotoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFoto(int id, Foto foto)
        {
            if (id != foto.FotoId)
            {
                return BadRequest();
            }

            _context.Entry(foto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FotoExists(id))
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

        // POST: api/Fotoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Foto>> PostFoto(Foto foto)
        {
            _context.Fotolars.Add(foto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFoto", new { id = foto.FotoId }, foto);
        }

        // DELETE: api/Fotoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFoto(int id)
        {
            var foto = await _context.Fotolars.FindAsync(id);
            if (foto == null)
            {
                return NotFound();
            }

            _context.Fotolars.Remove(foto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FotoExists(int id)
        {
            return _context.Fotolars.Any(e => e.FotoId == id);
        }
    }
}