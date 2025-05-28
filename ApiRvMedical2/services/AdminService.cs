using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiRvMedical2.dto;
using ApiRvMedical2.interfaces;
using ApiRvMedical2.Models;
using Microsoft.Ajax.Utilities;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Net;

namespace ApiRvMedical2.services
{
    public class AdminService: IAdmin
    {
        private readonly bdRdvMedicalContext _db;

        public AdminService(bdRdvMedicalContext db)
        {
            _db = db;
        }

       


        /// <summary>
        /// Récupère de manière asynchrone la liste des utilisateurs,
        /// en excluant ceux dont le rôle est "ADMIN".
        ///  Chaque utilisateur est projeté dans un objet <see cref="UserDto"/> contenant
        /// les informations principales telles que nom, date de naissance, adresse, email, rôle, statut et téléphone.
        /// </summary>
        /// <returns>
        /// une liste d'objets <see cref="UserDto"/>
        /// </returns>
        public async Task<List<UserDto>> GetAllUtilisateursAsync()
        {
            try {

                return await _db.Utilisateurs
               .Include("Role")
               .Where(u => u.Role.LibelleRole != "ADMIN")
               .Select(u => new UserDto
               {
                   NomPrenom = u.NomPrenom,
                   DateNaissance = u.DateNaissance,
                   Addresse = u.Addresse,
                   Email = u.Email,
                   LibelleRole = u.Role.LibelleRole,
                   Status = u.Status,
                   Tel = u.Tel
               })
               .ToListAsync();



            } catch (Exception ex) {
                throw ex;
            }
        }
       
    }
}