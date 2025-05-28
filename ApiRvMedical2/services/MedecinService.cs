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
    public class MedecinService: IMedecin
    {

        private readonly bdRdvMedicalContext _db;

        public MedecinService(bdRdvMedicalContext db)
        {
            _db = db;
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