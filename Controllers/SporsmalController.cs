using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TogbilletterOblig3.Models;
using TogbilletterOblig3;

namespace TogbilletterOblig3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SporsmalController : Controller
    {
        private readonly DB db;

        public SporsmalController(DB dbContext)
        {
            db = dbContext;
        }

        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var database = new DBFAQ(db);
            var utSpørsmål = database.HentEttSpørsmål(id);

            return Json(utSpørsmål);
        }

        /*
        // GET: api/Sporsmals
        [HttpGet]
        public IEnumerable<Sporsmal> GetSporsmal()
        {
            db.Add(new Sporsmal
            {

            });
            db.SaveChanges();

            return db.Sporsmaler;
        }

        // GET: api/Sporsmals/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSporsmal([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sporsmal = await db.Sporsmaler.SingleOrDefaultAsync(m => m.ID == id);

            if (sporsmal == null)
            {
                return NotFound();
            }

            return Ok(sporsmal);
        }

        // POST: api/Sporsmals
        [HttpPost]
        public async Task<IActionResult> PostSporsmal([FromBody] Sporsmal sporsmal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Sporsmaler.Add(sporsmal);
            await db.SaveChangesAsync();

            return CreatedAtAction("GetSporsmal", new { id = sporsmal.ID }, sporsmal);
        }

        // DELETE: api/Sporsmals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSporsmal([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sporsmal = await db.Sporsmaler.SingleOrDefaultAsync(m => m.ID == id);
            if (sporsmal == null)
            {
                return NotFound();
            }

            db.Sporsmaler.Remove(sporsmal);
            await db.SaveChangesAsync();

            return Ok(sporsmal);
        }

        private bool SporsmalExists(int id)
        {
            return db.Sporsmaler.Any(e => e.ID == id);
        }

    */

    }
}