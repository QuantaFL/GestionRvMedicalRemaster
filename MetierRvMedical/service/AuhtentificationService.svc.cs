using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MetierRvMedical.interfaces;
using MetierRvMedical.Models;
using MetierRvMedical.utils;
using System.Data.Entity;

namespace MetierRvMedical.service
{
    //TODO : rename to UserService
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class AuhtentificationService : IAuthentification
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        bdRdvMedicalContext db = new bdRdvMedicalContext();

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        /// <summary>
        /// cette fonction retourne un objet utilisateur si l'identifiant correspond  sinon null 
        /// </summary>
        /// <param name="identifiant">identifiant de  l'utilisateur à rechercher</param>
        /// <returns>un objet user ou null</returns>
        public Utilisateur GetUserByIdentifiant(string identifiant)
        {
            Utilisateur user = null;

            try
            {
                InstanceLogger.GetInstance().Information("Recherche de l'utilisateur avec l'identifiant : {Identifiant}", identifiant);

                user = db.Utilisateurs
                         .Where(a => a.Identifiant.Equals(identifiant))
                         .FirstOrDefault();

                if (user != null)
                {
                    InstanceLogger.GetInstance().Information("Utilisateur trouvé : {UserId}", user.IdP);
                }
                else
                {
                    InstanceLogger.GetInstance().Warning("Aucun utilisateur trouvé avec l'identifiant : {Identifiant}", identifiant);
                }

                return user;
            }
            catch (Exception ex)
            {
                InstanceLogger.GetInstance().Error(ex, "Erreur lors de la récupération de l'utilisateur avec l'identifiant : {Identifiant}", identifiant);
                return null;
            }
        }

        /// <summary>
        /// cette fonction retourne un objet role ou null si aucun role n'est trouvé pour l'utilisateur
        /// </summary>
        /// <param name="user">objet utilisateur </param>
        /// <returns> Objet Role ou null </returns>
        public Role GetRoleUser(Utilisateur user)
        {
            Role role = null;
            try {
                InstanceLogger.GetInstance().Information("Recherche  du role de l'utilisateur avec l'identifiant : {Identifiant}", user.Identifiant);

                role = db.Role.Where(r => r.IdRole.Equals(user.IdRole)).FirstOrDefault();
                if (role != null)
                {
                    InstanceLogger.GetInstance().Information(" role trouvé : {LibelleRole}", role.LibelleRole);
                }
                else
                {
                    InstanceLogger.GetInstance().Warning("Aucun role trouvé  pour l'utilisateur avec l'identifiant : {Identifiant}", user.Identifiant);
                }
                return role;


            } catch (Exception ex) {
                InstanceLogger.GetInstance().Error(ex, "Erreur lors de la récupération du role  de l'utilisateur avec l'identifiant : {Identifiant}", user.Identifiant);
                return null;
            }
        }

        /// <summary>
        /// cette fonction ajoute  un utilisateur 
        /// </summary>
        /// <param name="user"> l'utilisateur à ajouter </param>
        /// <returns>true si tout fonctionne correctement false sinon </returns>
        public bool AddUser(Utilisateur user)
        {
            try
            {
                InstanceLogger.GetInstance().Information("Tentative d'ajout d'un utilisateur avec l'identifiant : {identifiant}", user.Identifiant);

                db.Utilisateurs.Add(user);
                db.SaveChanges();

                InstanceLogger.GetInstance().Information("Utilisateur ajouté avec succès. ID : {UserId}", user.IdP);

                return true;
            }
            catch (Exception ex)
            {
                InstanceLogger.GetInstance().Error(ex, "Erreur lors de l'ajout de l'utilisateur : {identifiant}", user.Identifiant);
                return false;
            }
        }

        /// <summary>
        /// cette fonction modifie un utilisateur
        /// </summary>
        /// <param name="user">l'utilisateur à mettre à jour </param>
        /// <returns>retourne true sinon false </returns>
        public bool UpdateUser(Utilisateur user)
        {
            try
            {
                InstanceLogger.GetInstance().Information(" Tentative de mise à jour de l'utilisateur  avec l'identifiant : {identifiant}", user.Identifiant);

                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();

                InstanceLogger.GetInstance().Information("Utilisateur mis à jour avec succès. ID : {UserId}", user.IdP);

                return true;
            }
            catch (Exception ex)
            {
                InstanceLogger.GetInstance().Error(ex, "Erreur lors de la mise à jour de l'utilisateur : {Identifiant}", user?.Identifiant);
                return false;
            }
        }

    }
}
