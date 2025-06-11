using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ApiRvMedical2.config;
using ApiRvMedical2.dto.get;
using ApiRvMedical2.Models;
using ApiRvMedical2.services;
using MySqlX.XDevAPI.Common;
using Serilog;

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
        /// récupre la liste de toues les secretaires actives 
        /// </summary>
        /// <returns>un status code 200 une fois la liste récupérer </returns>
        [HttpGet]
        [Route("api/v1/secretaires/active")]
        public async Task<List<GetSecretaireDto>> GetAllActiveSecretaire()
        {
            try {
                return await  _secretService.GetAllActiveSecretaire();
            
            } catch (Exception ex) { throw; }

        }
        /// <summary>
        /// recupère la liste de toutes les secretaires secretaires 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/v1/secretaires")]
        public async Task<List<GetSecretaireDto>> GetAllSecretaire()
        {
            try { 
            
                return await _secretService.GetAllSecretaire();
            
            } catch (Exception ex) {
                throw;
            
            }
        }
        /// <summary>
        ///  recupère une secretaire à partir de son numéro de téléphone fixe ou de son matricule.
        /// </summary>
        [HttpGet]
        [Route("api/v1/secretaire/{identifiant}")]
        public async Task<IHttpActionResult> GetSecretaireByIdentifiantAsync(string identifiant)
        {
            Log.Information(" GET api/v1/secretaire/{identifiant}  ", identifiant);
            try {
                var secretaireDto = await _secretService.GetSecretaireByTelOrMatricule(identifiant);
                if (secretaireDto == null)
                {
                    Log.Error("cannot find secretaire with {identifiant} ",identifiant);
                    return NotFound();
                }

                Log.Information("find secretaire with {identifiant}",identifiant);

                return Ok(new
                {
                    message = "Secrétaire trouvée avec succès.",
                    secretaire = secretaireDto
                });

            }
            catch(Exception ex) { 
                Log.Error($"{ex.Message}", ex);
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
            Log.Information(" Get api/v1/secretaire/bloquer/{identifiant} called with identifiant", identifiant);
            try {
                var secretairedto = await  _secretService.DebloquerSecretaire(identifiant);
                if (!secretairedto)
                    return NotFound();
                Log.Information("lock secretaire with {identifiant} ", identifiant);

                return Ok(new { secretaire = secretairedto});


            } catch (Exception ex) {

                Log.Error(" Get api/v1/secretaire/bloquer error while searching locked secretaire with {identifiant}", identifiant, ex);
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
            Log.Information(" Get api/v1/secretaire/debloquer/{identifiant} called with {identifiant}", identifiant);

            try {

                var secretaire = await _secretService.BloquerSecretaire(identifiant);
                if (!secretaire)
                {
                    Log.Error("secretaire with {identifiant} not found ",identifiant);
                    return NotFound();
                }
                Log.Information("unlock secretaire with {identifiant} ",identifiant);
                return Ok(new { message = "Secrétaire débloquée avec succès." });

            } catch (Exception ex) {
                Log.Error(" Get api/v1/secretaire/debloquer/ error while unlock secretaire with {identifiant} ", identifiant,ex.Message);
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