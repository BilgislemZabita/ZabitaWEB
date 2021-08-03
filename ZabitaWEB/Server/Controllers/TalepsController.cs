using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;
using Fingers10.ExcelExport.ActionResults;
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
            return await _context.Taleps.Include(s => s.TalepAmirlik).ToListAsync();
        }

        // GET: api/Taleps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Talep>> GetTalep(int id)
        {
            var talep = await _context.Taleps.Include(s => s.TalepAmirlik).Where(s => s.TalepId == id).FirstAsync();

            if (talep == null)
            {
                return NotFound();
            }

            return talep;
        }
        // GET: api/Taleps/durum/5
        [HttpGet("durum/{durum}")]
        public async Task<ActionResult<List<Talep>>> GetDurumTalep(string durum)
        {
            var talep = await _context.Taleps.Where(s => s.TalepDurumu == durum).ToListAsync();

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
        public async Task<IActionResult> PostTalep(Talep talep)
        {
            var amirlik=_context.Amirliks.First(a => a.AmirlikID.ToString() == talep.AmirlikId);
            talep.TalepAmirlik = amirlik;
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
            return Ok();
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
        private async Task<IEnumerable<Talep>> TalepEnum()
        {
            return await _context.Taleps.ToListAsync();
        }
        //IEnumerable<Talep> taleps { get; set; }

        [HttpGet("export")]
        public async Task<IActionResult> GetExcel()
        {

            //var results = await _context.Taleps.Where(s => s.TalepDurumu == "1").Take(100);
            var results =await this.TalepEnum();
            DataTable dt = new DataTable("Gecmis Talep");
            dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Talep Açıklama"),
                                            new DataColumn("Talep Durumu"),
                                            new DataColumn("Talep Konu"),
                                            new DataColumn("Yerleşke Açıklaması") });
            /*IEnumerable<Talep> taleps = new List<Talep> { new Talep { TalepAciklama = "wer" }, new Talep { TalepDurumu = "2" } };
            return new ExcelResult<Talep>(results, "Demo Sheet Name", "Fingers10");*/

            var taleps = from talep in results
                            select talep;

            foreach (var talep in taleps)
            {
                dt.Rows.Add(talep.TalepAciklama, talep.TalepDurumu, talep.TalepKonu, talep.YerleskeAciklamasi);
            }

            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt);
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "GecmisTalepler.xlsx");
                }
            }
        }
    }
}
