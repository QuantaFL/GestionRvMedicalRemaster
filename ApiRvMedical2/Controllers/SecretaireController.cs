using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ApiRvMedical2.Models;
using ApiRvMedical2.services;
using MySqlX.XDevAPI.Common;

namespace ApiRvMedical2.Controllers
{
    public class SecretaireController : ApiController
    {

        private readonly bdRdvMedicalContext _db;
        private readonly SecretaireService _secretService;
        public SecretaireController()
        {
            _db = new bdRdvMedicalContext();
            _secretService = new SecretaireService(_db);
        }
        /// <summary>
        ///  recupère une secretaire à partir de son numéro de téléphone fixe ou de son matricule.
        /// </summary>
        [HttpGet]
        [Route("api/v1/secretaire/{identifiant}")]
        public async Task<IHttpActionResult> GetSecretaireByIdentifiantAsync(string identifiant)
        {
            try {
                var secretaireDto = await _secretService.GetSecretaireByTelOrMatricule(identifiant);
                if (secretaireDto == null)
                {
                    return NotFound();
                }

                return Ok(new
                {
                    message = "Secrétaire bloquée avec succès.",
                    secretaire = secretaireDto
                });

            }
            catch(Exception ex) { 
                throw ex;
            
            }
        }
        /// <summary>
        /// Débloque une secrétaire à partir de son numéro de téléphone ou de son matricule.
        /// </summary>
        [HttpGet]
        [Route("api/v1/secretaire/bloquer/{identifiant}")]
        public async Task<IHttpActionResult> DebloquerSecretaire(string identifiant)
        {
            try {
                var secretairedto = await  _secretService.DebloquerSecretaire(identifiant);
                if (!secretairedto)
                    return NotFound();

                return Ok(new { secretaire = secretairedto});


            } catch (Exception ex) {


                throw ex;
            }
        }
        /// <summary>
        /// Bloque une secrétaire à partir de son numéro de téléphone ou de son matricule.
        /// </summary>
        [HttpGet]
        [Route("api/v1/secretaire/debloquer/{identifiant}")]
        public async Task<IHttpActionResult> BloquerSecretaire(string identifiant)
        {
            try {

                var secretaire = await _secretService.BloquerSecretaire(identifiant);
                if (!secretaire)
                {
                    return NotFound();
                }

                return Ok(new { message = "Secrétaire débloquée avec succès." });

            } catch (Exception ex) {

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