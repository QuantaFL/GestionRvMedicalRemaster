using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ApiRvMedical2.Models;
using ApiRvMedical2.services;

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
            try {

                var medecin = await _medService.GetMedecinByNumerOrdre(numeroOrdre);

                if (medecin == null)
                    return NotFound();

                return Ok(medecin);

            }
            catch (Exception ex) {
                throw ex;
            
            }
        }
        [HttpGet]
        [Route("api/v1/medecin/bloquer/{numeroOrdre}")]
        public async Task<IHttpActionResult>  BloquerMedecin(string numeroOrdre)
        {
            try {
                var medecin = await _medService.BloquerMedecin(numeroOrdre);
                if(medecin==false)
                    return NotFound();
                return Ok(new
                {
                    message = "Médecin bloqué avec succès.",
                    medecin = medecin
                });


            }
            catch (Exception ex) { 
                
                
                throw ex;
            
            
            }
        }
        [HttpGet]
        [Route("api/v1/medecin/debloquer/{numeroOrdre}")]
        public async Task<IHttpActionResult> debloquer(string numeroOrdre)
        {
            try
            {
                var medecin = await _medService.DebloquerMedecin(numeroOrdre);
                if (medecin == false)
                    return NotFound();
                return Ok(new
                {
                    message = "Médecin debloqué avec succès.",
                    medecin = medecin
                });


            }
            catch (Exception ex)
            {


                throw ex;


            }
        }
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}