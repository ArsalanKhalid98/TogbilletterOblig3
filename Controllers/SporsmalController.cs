using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TogbilletterOblig3.Models;
using TogbilletterOblig3;
using TogbilletterOblig3.Models.Repository;

namespace TogbilletterOblig3.Controllers
{
    [Route("api/sporsmal")]
    [ApiController]
    public class SporsmalController : ControllerBase
    {
        private readonly IDataRepository<Sporsmal> _dataRepository;

        public SporsmalController(IDataRepository<Sporsmal> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/Sporsmal
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Sporsmal> sporsmaler = _dataRepository.GetAll();
            return Ok(sporsmaler);
        }

        // GET: api/Sporsmal/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(long id)
        {
            Sporsmal sporsmal = _dataRepository.Get(id);

            if (sporsmal == null)
            {
                return NotFound("Sporsmal ble ikke funnet.");
            }

            return Ok(sporsmal);
        }

        // POST: api/Sporsmal
        [HttpPost]
        public IActionResult Post([FromBody] Sporsmal sporsmal)
        {
            if (sporsmal == null)
            {
                return BadRequest("Sporsmal is null.");
            }

            _dataRepository.Add(sporsmal);
            return CreatedAtRoute(
                  "Get",
                  new { Id = sporsmal.ID },
                  sporsmal);
        }

        // PUT: api/Sporsmal/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Sporsmal sporsmal)
        {
            if (sporsmal == null)
            {
                return BadRequest("Sporsmal er null.");
            }

            Sporsmal sporsmalToUpdate = _dataRepository.Get(id);
            if (sporsmalToUpdate == null)
            {
                return NotFound("Sporsmal ble ikke funnet");
            }

            _dataRepository.Update(sporsmalToUpdate, sporsmal);
            return NoContent();
        }

        // DELETE: api/Sporsmal/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Sporsmal sporsmal = _dataRepository.Get(id);
            if (sporsmal == null)
            {
                return NotFound("Sporsmal ble ikke funnet");
            }

            _dataRepository.Delete(sporsmal);
            return NoContent();
        }
    }
}