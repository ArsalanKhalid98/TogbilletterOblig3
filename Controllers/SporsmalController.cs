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
        [Route("getSporsmal")]
        public IEnumerable<Sporsmal> Index()
        {
            return _dataRepository.GetAll();
        }

        // GET: api/Sporsmal/5
        [HttpGet]
        //Muligens ID-delen som kræsjer programmet
        [Route("getSporsmalById/{ID}")]
        public IActionResult Get(int ID)
        {
            Sporsmal sporsmal = _dataRepository.Get(ID);

            if (sporsmal == null)
            {
                return NotFound("Sporsmal ble ikke funnet.");
            }

            return Ok(sporsmal);
        }

        // POST: api/Sporsmal
        [HttpPost]
        [Route("Create")]
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
        [HttpPut]
        [Route("Update")]
        public int Put(Sporsmal sporsmal)
        {

            Sporsmal sporsmalToUpdate = _dataRepository.Get(sporsmal.sporsmalNr);
            

            return _dataRepository.Update(sporsmalToUpdate, sporsmal);

        }

        // DELETE: api/Sporsmal/5
        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(int id)
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