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
    [Route("api/kunde")]
    [ApiController]
    public class KundeController : ControllerBase
    {
        private readonly IDataRepositoryKunde<Kunde> _dataRepository;

        public KundeController(IDataRepositoryKunde<Kunde> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/Sporsmal
        [HttpGet]
        [Route("GetKunde")]
        public IEnumerable<Kunde> Index()
        {
            return _dataRepository.GetAllKunde();
        }

        // GET: api/Sporsmal/5
        [HttpGet]
        //Muligens ID-delen som kræsjer programmet
        [Route("GetKundeById/{ID}")]
        public IActionResult Get(int ID)
        {
            Kunde kunde = _dataRepository.GetKunde(ID);

            if (kunde == null)
            {
                return NotFound("Sporsmal ble ikke funnet.");
            }

            return Ok(kunde);
        }

        // POST: api/Sporsmal
        // Denne kan være feilen
        [HttpPost]
        [Route("CreateKunde")]
        public IActionResult Post([FromBody] Kunde kunde)
        {
            if (kunde == null)
            {
                return BadRequest("Sporsmal is null.");
            }

            _dataRepository.AddKunde(kunde);
            return CreatedAtRoute(

                  "Get",
                  new { Id = kunde.ID },
                  kunde);

        }

        // PUT: api/Sporsmal/5
        [HttpPut]
        [Route("UpdateKunde")]
        public int Put(Kunde kunde)
        {

            Kunde kundeToUpdate = _dataRepository.GetKunde(kunde.KundeNr);


            return _dataRepository.UpdateKunde(kundeToUpdate, kunde);

        }

        // DELETE: api/Sporsmal/5
        [HttpDelete]
        [Route("DeleteKunde")]
        public IActionResult Delete(int id)
        {
            Kunde kunde = _dataRepository.GetKunde(id);
            if (kunde == null)
            {
                return NotFound("Sporsmal ble ikke funnet");
            }

            _dataRepository.DeleteKunde(kunde);
            return NoContent();
        }
    }
}