using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ApiRvMedical2.config;
using ApiRvMedical2.dto.get;
using ApiRvMedical2.dto.post;
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

        /// <summary>
        /// recupère la liste de tous les medecins incatif
        /// </summary>
        /// <returns>retourne un status code 200 une fois la liste récupérer </returns>
        [HttpGet]
        [Route("api/v1/medecins/inactif")]
        public async Task<List<GetMedecinDto>> GetAllDactiveMedecin()
        {
            try
            {
                return await _medService.GetAllDactiveMedecin();

            }
            catch (Exception ex)
            {
                throw;

            }
        }


        /// <summary>
        /// recupère tous les medecins actifs 
        /// </summary>
        /// <returns>retourne un status code  200 une fois la liste récupérer </returns>
        [HttpGet]
        [Route("api/v1/medecins/actif")]
        public async Task<List<GetMedecinDto>> GetAllActiveMedecin()
        {
            try {
                return await _medService.GetAllActiveMedecin();
            
            }catch (Exception ex) {
                throw;
            
            }
        }
        /// <summary>
        /// recupère la liste de tous les médecins
        /// </summary>
        /// <returns>retoure une status code 200 une fois la liste récupérer</returns>

        [HttpGet]
        [Route("api/v1/medecins")]
        public async Task<List<GetMedecinDto>> GetAllMedecin()
        {
            try {

                return await _medService.GetAllMedecin();

            } catch (Exception ex) { throw; }
        }
        /// <summary>
        /// Ajoute un medecin à partir d'un objet dto medecin contenant les informations telles que nom prenom
        /// date de naissance etc... utilise la méthode AddMedecin du service medecin pour l'ajout
        /// </summary>
        /// <param name="dtoMedecin">L'objet dto a donné en paramètre</param>
        /// <returns>
        /// un 404 si la spécialité donnée n'est pas référencée 
        /// 409 si  une des valeurs uniques ( numero ordre telephone et email ont été trouvés )
        /// 201 si tout se passe bien 
        /// 500 en cas d'erreur serveur 
        /// </returns>
        /// <exception cref="Exception"></exception>

        [HttpPost]
        [Route("api/v1/Addmedecin")]
        public async Task<IHttpActionResult> AddMedecin([FromBody] PostDtoMedecin dtoMedecin)
        {
            try {

                /*
                 * if (_medService.FindRoleById(dtoMedecin.IdRole) == null)
                {
                    return Content(HttpStatusCode.NotFound, new
                    {
                        message ="vous avez renseigné un id erroné pour le role"
                    });
                }
                 
                 */

                if (_medService.FindSpecialiteById(dtoMedecin.IdSpecialite) == null)
                {
                    return Content(HttpStatusCode.NotFound, new
                    {
                        message = "vous avez renseigné un id erroné pour la specialité"
                    });
                }

                if (!_medService.CheckUniqueField(dtoMedecin.NumeroOrdre, dtoMedecin.Telephone, dtoMedecin.Email))
                {
                    return Content(HttpStatusCode.Conflict, new
                    {
                        message = "Données dupliquées",
                        details = "Le numéro d'ordre, le numéro de téléphone et l'email doivent être uniques pour chaque médecin."
                    });
                }
                var Addedmedecin = await  _medService.AddMedecin(dtoMedecin);

                if (Addedmedecin != null)
                {
                    return Content(HttpStatusCode.Created, new
                    {
                        message = "medecin ajouter avec succes ",
                        medecin = Addedmedecin
                    });
                }
                return InternalServerError(new Exception("Impossible d'ajouter le médecin."));

            }
            catch (DbEntityValidationException ex)
            {
                var errorMessages = new List<string>();

                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string errorMsg = $"Propriété: {validationError.PropertyName} Erreur: {validationError.ErrorMessage}";
                        errorMessages.Add(errorMsg);
                        Console.WriteLine(errorMsg);
                        Log.Error(errorMsg); 
                    }
                }

                string fullErrorMessage = string.Join("; ", errorMessages);
                throw new Exception("Échec de la validation EF : " + fullErrorMessage);
            }
            catch (Exception ex) { 
                Log.Error(ex.Message);
                return InternalServerError(ex);



            }
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
        /// <summary>
        ///  Bloque un médecin identifié par son numéro d'ordre.
        /// </summary>
        /// <param name="numeroOrdre"> le numero d'ordre du medecin à bloquer </param>
        /// <returns>
        /// Une réponse HTTP indiquant le résultat de l'opération :
        /// - 200 avec un message de confirmation si le médecin a été bloqué avec succès
        /// -   404  si aucun médecin correspondant n'a été trouvé.
        /// — Une exception est levée en cas d'erreur inattendue.
        /// </returns>

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
        /// <summary>
        ///  débloque un médecin identifié par son numéro d'ordre.
        /// </summary>
        /// <param name="numeroOrdre"> le numero d'ordre du medecin à débloquer </param>
        /// <returns>
        /// Une réponse HTTP indiquant le résultat de l'opération :
        /// - 200 avec un message de confirmation si le médecin a été débloqué avec succès
        /// -   404  si aucun médecin correspondant n'a été trouvé.
        /// — Une exception est levée en cas d'erreur inattendue.
        /// </returns>
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