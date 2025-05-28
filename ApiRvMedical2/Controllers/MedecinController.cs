using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ApiRvMedical2.config;
using ApiRvMedical2.Models;
using ApiRvMedical2.services;
using Serilog;

namespace ApiRvMedical2.Controllers
{
    public class MedecinController : ApiController
    {
        private readonly bdRdvMedicalContext _db;
        private readonly MedecinService _medService;
        public MedecinController()
        {
            _db = new bdRdvMedicalContext();
            _medService = new MedecinService(_db);
        }

        [HttpGet]
        [Route("api/v1/medecin/{numeroOrdre}")]
        /// <summary>
        /// Récupère un médecin à partir de son numéro d'ordre.
        /// </summary>
        /// <param name="numeroOrdre">Numéro d'ordre du médecin</param>
        /// <returns>Un objet Medecin ou 404 si introuvable</returns>
        public async Task<IHttpActionResult> GetMedecinByNumeroOrdre(string numeroOrdre)
        {
           Log.Information("GET api/v1/medecin/{NumeroOrdre} called with numeroOrdre={NumeroOrdre}", numeroOrdre);
            try
            {
                var medecin = await _medService.GetMedecinByNumerOrdre(numeroOrdre);

                if (medecin == null)
                {
                    Log.Warning("Medecin not found for numeroOrdre={NumeroOrdre}", numeroOrdre);
                    return NotFound();
                }

                Log.Information("Medecin found for numeroOrdre={NumeroOrdre}", numeroOrdre);
                return Ok(medecin);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Exception in GetMedecinByNumeroOrdre for numeroOrdre={NumeroOrdre}", numeroOrdre);
                throw;
            }
        }

        [HttpGet]
        [Route("api/v1/medecin/bloquer/{numeroOrdre}")]
        public async Task<IHttpActionResult> BloquerMedecin(string numeroOrdre)
        {
            Log.Information("GET api/v1/medecin/bloquer/{NumeroOrdre} called with numeroOrdre={NumeroOrdre}", numeroOrdre);
            try
            {
                var medecin = await _medService.BloquerMedecin(numeroOrdre);
                if (medecin == false)
                {
                    Log.Warning("BloquerMedecin: Medecin not found for numeroOrdre={NumeroOrdre}", numeroOrdre);
                    return NotFound();
                }
                Log.Information("Medecin blocked successfully for numeroOrdre={NumeroOrdre}", numeroOrdre);
                return Ok(new
                {
                    message = "Médecin bloqué avec succès.",
                    medecin = medecin
                });
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Exception in BloquerMedecin for numeroOrdre={NumeroOrdre}", numeroOrdre);
                throw;
            }
        }

        [HttpGet]
        [Route("api/v1/medecin/debloquer/{numeroOrdre}")]
        public async Task<IHttpActionResult> debloquer(string numeroOrdre)
        {
            Log.Information("GET api/v1/medecin/debloquer/{NumeroOrdre} called with numeroOrdre={NumeroOrdre}", numeroOrdre);
            try
            {
                var medecin = await _medService.DebloquerMedecin(numeroOrdre);
                if (medecin == false)
                {
                    Log.Warning("DebloquerMedecin: Medecin not found for numeroOrdre={NumeroOrdre}", numeroOrdre);
                    return NotFound();
                }
                Log.Information("Medecin unblocked successfully for numeroOrdre={NumeroOrdre}", numeroOrdre);
                return Ok(new
                {
                    message = "Médecin debloqué avec succès.",
                    medecin = medecin
                });
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Exception in DebloquerMedecin for numeroOrdre={NumeroOrdre}", numeroOrdre);
                throw;
            }
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            Log.Information("GET api/medecin called");
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            Log.Information("GET api/medecin/{Id} called with id={Id}", id);
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
            Log.Information("POST api/medecin called with value={Value}", value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
            Log.Information("PUT api/medecin/{Id} called with id={Id}, value={Value}", id, value);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            Log.Information("DELETE api/medecin/{Id} called with id={Id}", id);
        }
    }
}