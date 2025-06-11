using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ApiRvMedical2.config;
using ApiRvMedical2.dto.get;
using ApiRvMedical2.dto.post;
using ApiRvMedical2.interfaces;
using ApiRvMedical2.Models;
using Serilog;

namespace ApiRvMedical2.services
{
    public class MedecinService: IMedecin
    {
        // TODO: Add logger 

        private readonly bdRdvMedicalContext _db;

        public MedecinService(bdRdvMedicalContext db)
        {
            _db = db;
        }
        /// <summary>
        /// Ajoute un nouveau médecin dans la base de données.
        /// </summary>
        /// <param name="medecinData">Les données du médecin à ajouter.</param>
        /// <returns>Le médecin ajouté avec ses informations générées (identifiant, mot de passe, etc.).</returns>
        /// <remarks>
        /// Le champ NumeroOrdre doit être un type chaîne ou tableau d'une longueur maximum de '10'
        /// </remarks>
        /// <exception cref="Exception">Lève une exception en cas d'erreur lors de l'enregistrement.</exception>

        public async Task<GetMedecinDto> AddMedecin(PostDtoMedecin medecinData)
        {
            Medecin medecin = new Medecin();
            GetMedecinDto MedecinResponse = new GetMedecinDto();
            Guid myuuid = Guid.NewGuid();
            Guid myuuid2 = Guid.NewGuid();
            string mdpTmp = myuuid.ToString().Substring(0, 8);
            string identfiantTmp = myuuid.ToString().Substring(0, 5);
            var hashedPassword = SaltHash.HashPassword(mdpTmp);
           

            try {

                DateTime.TryParse(medecinData.DateNaissance, out DateTime dateNaissance);
                medecin.NumeroOrdre = medecinData.NumeroOrdre;
                medecin.NomPrenom = medecinData.NomPrenom;
                medecin.Addresse = medecinData.Addresse;
                medecin.Identifiant = identfiantTmp;
                medecin.Status = true;
                medecin.Email = medecinData.Email;
                medecin.MotDePasse = hashedPassword;
                medecin.PremiereConnexion = 0;
                medecin.DateNaissance = dateNaissance;
                medecin.IdSpecialite = medecinData.IdSpecialite;
                medecin.IdRole = this.FindMedRoleId().IdRole;
                medecin.Tel = medecinData.Telephone;
                _db.Medecins.Add(medecin);
                await _db.SaveChangesAsync();

                MedecinResponse.Id = medecin.IdP;
                MedecinResponse.NomPrenom = medecin.NomPrenom;
                MedecinResponse.Addresse = medecin.Addresse;
                MedecinResponse.DateNaissance = medecin.DateNaissance;
                MedecinResponse.NumeroOrdre = medecin.NumeroOrdre;
                MedecinResponse.Email = medecin.Email;
                MedecinResponse.LibelleSpecialite = medecin.Specialite.NomSpecialte;
                MedecinResponse.Status = medecin.Status;
                MedecinResponse.Tel = medecin.Tel;
                return MedecinResponse;

            }
            catch (DbEntityValidationException ex)
            {
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Log.Error($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }
                throw;
            }

            catch (Exception ex) {
               Log.Error(ex.Message);
                throw ;
            
            }



        }

        /// <summary>
        /// Bloque un médecin en désactivant son compte (Status = false) à partir de son numéro d'ordre.
        /// </summary>
        /// <param name="numerOrdre">Le numéro d'ordre du médecin à bloquer.</param>
        /// <returns>
        /// Une tâche asynchrone contenant un booléen :
        /// <c>true</c> si le médecin a été trouvé et bloqué avec succès, 
        /// <c>false</c> s'il n'a pas été trouvé dans la base.
        /// </returns>
        public async Task<bool> BloquerMedecin(string numerOrdre)
        {
            try
            {
                var medecin = await _db.Medecins
               .FirstOrDefaultAsync(m => m.NumeroOrdre == numerOrdre);

                if (medecin == null)
                    return false;

                medecin.Status = false;
                await _db.SaveChangesAsync();

                return true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// cette verifie si les informations qui doivent être unique pour l'ajout d'un médecin 
        /// à savoir le numero d'ordre, le numero de téléphone, l'email le sont bel et bien
        /// </summary>
        /// <param name="numerOrdre">le numero d'ordre à verifier</param>
        /// <param name="telephone">le numero de telephone </param>
        /// <param name="email">l'eamil à verifier </param>
        /// <returns>
        /// si une seul ligne est trouvée avec les informations données la methode renvoie false 
        /// sinon true 
        /// </returns>
        public bool CheckUniqueField(string numerOrdre, string telephone, string email)
        {
            List<Medecin> medecins = _db.Medecins.ToList();
            Medecin medecin  =  medecins.Where(m=> m.NumeroOrdre.Equals(numerOrdre) ||
            m.Tel.Equals(telephone) || m.Email.Equals(email)).FirstOrDefault();
            if (medecin != null)
            {
               return false;
            }
            else
            {
                return true;
            }
        }




        /// <summary>
        /// Débloque un médecin en réactivant son compte (Status = true) à partir de son numéro d'ordre.
        /// </summary>
        /// <param name="numerOrdre">Le numéro d'ordre du médecin à débloquer.</param>
        /// <returns>
        /// Une tâche asynchrone contenant un booléen :
        ///   si le médecin a été trouvé et débloqué avec succès,
        ///  s'il n'a pas été trouvé dans la base.
        /// </returns>
        public async Task<bool> DebloquerMedecin(string numerOrdre)
        {
            try
            {
                var medecin = await _db.Medecins
               .FirstOrDefaultAsync(m => m.NumeroOrdre == numerOrdre);

                if (medecin == null)
                    return false;

                medecin.Status = true;
                await _db.SaveChangesAsync();

                return true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Role FindMedRoleId()
        {
            return _db.Role.Where(r => r.CodeRole.Equals("MED")).FirstOrDefault();
        }

        public Specialite FindSpecialiteById(int IdSpecialite)
        {
           return _db.Specialite.Find(IdSpecialite);
        }

        /// <summary>
        /// Recherche un médecin par son numéro d'ordre de manière asynchrone.
        /// </summary>
        /// <param name="NumerOrdre">Le numéro d'ordre du médecin à rechercher.</param>
        /// <returns>Le médecin correspondant ou null s'il n'existe pas.</returns>
        public async Task<GetMedecinDto> GetMedecinByNumerOrdre(string NumerOrdre)
        {
            try
            {

                            return await _db.Medecins
                      .Include("Specialite") // pour avoir LibelleSpecialite
                      .Where(m => m.NumeroOrdre == NumerOrdre)
                      .Select(m => new GetMedecinDto
                      {
                          NomPrenom = m.NomPrenom,
                          DateNaissance = m.DateNaissance,
                          Addresse = m.Addresse,
                          Email = m.Email,
                          Tel = m.Tel,
                          Status = m.Status,
                          NumeroOrdre = m.NumeroOrdre,
                          LibelleSpecialite = m.Specialite.NomSpecialte,
                      })
                      .FirstOrDefaultAsync();

            }
            catch (Exception ex)
            {
                throw ex;

            }

        }
    }
}