using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ApiRvMedical2.dto.get;
using ApiRvMedical2.interfaces;
using ApiRvMedical2.Models;

namespace ApiRvMedical2.services
{
    public class SecretaireService : ISecretaire
    {

        private readonly bdRdvMedicalContext _db;

        public SecretaireService(bdRdvMedicalContext db)
        {
            _db = db;
        }
        /// <summary>
        /// Bloque une secretaire en désactivant son compte (Status = false) à partir de son numero  de teléphone fixe ou le matricule
        /// </summary>
        /// <param name="identifiant"> représente le numero  de teléphone fixe ou le matricule de la secretaire  à bloquer.</param>
        /// <returns>
        /// Une tâche asynchrone contenant un booléen :
        /// <c>true</c> si la secretaire a été trouvé et bloqué avec succès, 
        /// <c>false</c> s'elle n'a pas étée trouvé dans la base.
        /// </returns>
        public async Task<bool> BloquerSecretaire(string identifiant)
        {
            try {

                var secretaire = await _db.Secretaires
                  .FirstOrDefaultAsync(s => s.Matricule == identifiant || s.TelephoneFixe == identifiant);

                if (secretaire == null)
                    return false;

                secretaire.Status = false;
                await _db.SaveChangesAsync();

                return true;


            } catch (Exception ex) {
                throw ex;
            
            }
        }

        /// <summary>
        /// Bloque une secretaire en activant son compte (Status = true) à partir de son numero  de teléphone fixe ou le matricule
        /// </summary>
        /// <param name="identifiant"> représente le numero  de teléphone fixe ou le matricule de la secretaire  à bloquer.</param>
        /// <returns>
        /// Une tâche asynchrone contenant un booléen :
        /// <c>true</c> si la secretaire a été trouvé et débloqué avec succès, 
        /// <c>false</c> s'elle n'a pas été trouvé dans la base.
        /// </returns>
        public async Task<bool> DebloquerSecretaire(string identifiant)
        {
            try {
                 var secretaire = await _db.Secretaires
              .FirstOrDefaultAsync(s => s.Matricule == identifiant || s.TelephoneFixe == identifiant);

                if (secretaire == null)
                    return false;

                secretaire.Status = true;
                await _db.SaveChangesAsync();

                return true;


            }
            catch (Exception ex) { throw ex; }
        }

        /// <summary>
        /// cette methode retourne la liste de toutes les secretaires 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<List<GetSecretaireDto>> GetAllSecretaire()
        {
            try {
                var secretaires = await _db.Secretaires
                    .ToListAsync();

                return secretaires.Select(s => new GetSecretaireDto { 
                    Addresse = s.Addresse,
                    DateNaissance = s.DateNaissance,
                    Email = s.Email,
                    Matricule = s.Matricule,
                    NomPrenom = s.NomPrenom,
                    TelephoneFixe = s.TelephoneFixe,
                    Id = s.IdP,
                    Status = s.Status,
                    Tel = s.Tel
                    
                }).ToList();

             
            
            } catch (Exception ex) { throw; }
           
        }

        /// <summary>
        /// Recherche une secretaire  le numero  de teléphone fixe ou le matricule
        /// </summary>
        /// <param name="identifiant"> représente le numero  de teléphone fixe ou le matricule de la secretaire  à rechercher.</param>
        /// <returns>La secretaire correspondante ou null si elle  n'existe pas.</returns>
        public async Task<GetSecretaireDto> GetSecretaireByTelOrMatricule(string identifiant)
        {
            try {
                        return await _db.Secretaires
                  .Where(s => s.Matricule == identifiant || s.Tel == identifiant)
                  .Select(s => new GetSecretaireDto
                  {
                      NomPrenom = s.NomPrenom,
                      DateNaissance = s.DateNaissance,
                      Addresse = s.Addresse,
                      Email = s.Email,
                      Tel = s.Tel,
                      Status = s.Status,
                      TelephoneFixe = s.TelephoneFixe,
                      Matricule = s.Matricule
                  })
                  .FirstOrDefaultAsync();

            }
            catch (Exception ex) {
                
                
                throw ex; 
            
            }   
        }
    }
}