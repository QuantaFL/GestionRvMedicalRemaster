using MetierRvMedical2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity;

namespace MetierRvMedical2.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AgendaService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AgendaService.svc or AgendaService.svc.cs at the Solution Explorer and start debugging.
    public class AgendaService : IAgendaService
    {
        private bdRdvMedicalContext _db = new bdRdvMedicalContext();

        public void DoWork()
        {
        }

        /// <summary>
        /// Récupère tous les agendas avec leurs médecins associés.
        /// </summary>
        /// <returns>Liste des agendas</returns>
        public IEnumerable<Agenda> GetAllAgendas()
        {
            return _db.Agenda.Include(a => a.Medecin).ToList();
        }

        /// <summary>
        /// Récupère un agenda par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant de l'agenda</param>
        /// <returns>Agenda trouvé ou null</returns>
        public Agenda GetAgendaById(int id)
        {
            return _db.Agenda.Include(a => a.Medecin).FirstOrDefault(a => a.IdAgenda == id);
        }

        /// <summary>
        /// Crée un nouvel agenda.
        /// </summary>
        /// <param name="agenda">Objet agenda à créer</param>
        public void CreateAgenda(Agenda agenda)
        {
            _db.Agenda.Add(agenda);
            _db.SaveChanges();
        }

        /// <summary>
        /// Met à jour un agenda existant.
        /// </summary>
        /// <param name="agenda">Agenda avec les données modifiées</param>
        public void UpdateAgenda(Agenda agenda)
        {
            _db.Entry(agenda).State = EntityState.Modified;
            _db.SaveChanges();
        }

        /// <summary>
        /// Supprime un agenda par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant de l'agenda à supprimer</param>
        public void DeleteAgenda(int id)
        {
            var agenda = _db.Agenda.Find(id);
            if (agenda != null)
            {
                _db.Agenda.Remove(agenda);
                _db.SaveChanges();
            }
        }

        /// <summary>
        /// Récupère tous les agendas d’un médecin spécifique.
        /// </summary>
        /// <param name="medecinId">Identifiant du médecin</param>
        /// <returns>Liste des agendas</returns>
        public IEnumerable<Agenda> GetAgendasByMedecinId(int medecinId)
        {
            return _db.Agenda
                .Include(a => a.Medecin)
                .Where(a => a.IdMedecin == medecinId)
                .ToList();
        }
    }
}
